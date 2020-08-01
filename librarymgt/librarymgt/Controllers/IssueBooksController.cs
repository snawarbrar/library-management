using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using librarymgt.Repository;
using librarymgt.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace librarymgt.Controllers
{ 
    
    public class IssueBooksController : Controller
    {
        // GET: /<controller>/
        private readonly IIssueBooks issueBooksRepository;
        public IssueBooksController(IIssueBooks _issueBooksRepository)
        {
            issueBooksRepository = _issueBooksRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// create a select list to select book category then call action mrthod to diaplay aform with
        /// category of selected books
        /// </summary>
        /// <returns></returns>
        public IActionResult issueNewBook()
        {
            List<BookCategory> bookCategory = issueBooksRepository.GetBookCategories();
            ViewBag.categories = bookCategory;
            return View();
        }
        [HttpGet("IssueBookWithId")]
        [Route("IssueBooks/IssueBookWithId/{categoryId}")]
        public IActionResult IssueBookWithId(int BookCategoryId)
        {
            ViewBag.booksInfo = "";
            ViewBag.Info = "";
            if (!String.IsNullOrEmpty(HttpContext.Request.Query["BookCategoryId"]))
            {
                var catId = HttpContext.Request.Query["BookCategoryId"];
                var id=Int32.Parse(catId);
                var books = issueBooksRepository.getBooksByCategory(id);
                if (books.Count == 0)
                {
                    ViewBag.booksInfo = "There is No books In This cateGory Right Now";
                }
                else
                {
                    ViewBag.books = books;
                }
            }
           
            return View();
        }
        [HttpPost("IssueBookWithId")]
        public IActionResult IssueBookWithId(BookIssued bookIssued)
        {

            ViewBag.Info = "";
            ViewBag.booksInfo = "";
            if (ModelState.IsValid)
            {

               var result= issueBooksRepository.issueBook(bookIssued);
                if (result == true)
                {
                    return RedirectToAction("BookBorrowed", "Student", new { id = bookIssued.StudentId });
                }
                else
                {
                    ViewBag.Info = "Book is already Borrowed by student";
                }
            }
            return View();
        }
    }
}
