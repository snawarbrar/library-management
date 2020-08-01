using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using librarymgt.Models;
using librarymgt.Repository;
using Microsoft.AspNetCore.Mvc;

namespace librarymgt.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent studentRepository;
        public StudentController(IStudent _student)
        {
            studentRepository = _student;
        }
        public IActionResult Index()
        {
           var results= studentRepository.GetAllStudents();
            return View(results);
        }

        [HttpGet]
        public IActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                studentRepository.AddStudent(student);   
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
           var stu= studentRepository.GetStudentById(id);
            return View(stu);
        }

        [HttpPost]

        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                studentRepository.UpdateStudent(student);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Delete(int id)
        {
          var result=studentRepository.DeleteStudent(id);
            if (result == true)
            {
                return RedirectToAction("Index");

            }
            else {
                return RedirectToAction("BookBorrowed", new { id = id });
            }
            
        }
        /// <summary>
        /// return list of book borrowed by student
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult BookBorrowed(int id)
        {
            
                var Ressult = studentRepository.booksBorrowedByStudent(id);
                ViewBag.borrow = "";
            if (Ressult.Count == 0)
            {
                ViewBag.info = "No book is borrwed By student Yet";
                return View();
            }
            else
            {
                var data = Ressult.FirstOrDefault(x => x.StudentId == id);
                ViewBag.name = data.StudentName;
                if (Ressult != null)
                {
                    return View(Ressult);
                }
                else
                {
                    ViewBag.borrow = "No Books Borrowed Yet...";
                }
            }
            return View();
        }

        /// <summary>
        /// show a form to return a book
        /// </summary>
        /// <param name="StuId"></param>
        /// <param name="bookId"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ReturnBook(int StuId, int bookId)
        {
            var data = studentRepository.GetReturnBook(StuId, bookId);
            return View(data);

        }
        /// <summary>
        /// update datbase with return date
        /// </summary>
        /// <param name="bookBorrowed"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ReturnBook(BookBorrowed bookBorrowed)
        {
           var result= studentRepository.ReturnBook(bookBorrowed);
            if (result == true)
            {
                return RedirectToAction("BookBorrowed", new { id = bookBorrowed.StudentId });
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Unable To Return Try Next Time...");
            }
            return View();
        }
        /// <summary>
        /// after getting id call the "BookBorrowed" action method to show list
        /// </summary>
        /// <param name="byStuId"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetStudentIdToReturnBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetStudentIdToReturnBook(BorrowedBookByStuId byStuId)
        {
            
            return RedirectToAction("BookBorrowed", new { id=byStuId.StudentId });
        }

        public IActionResult GetStudentIdToReturnBookByRollNo(BorowedBookByRollNo byRollNo)
        {
           var Stuid= studentRepository.GetBookBorrowedByStudentRollNO(byRollNo.RollNumber);
            if (Stuid != 0)
            {
                return RedirectToAction("BookBorrowed", new { id = Stuid });
            }
            else
            {
                return RedirectToAction("GetStudentIdToReturnBook");
            }
        }
    }

    
}