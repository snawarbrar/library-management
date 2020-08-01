using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using librarymgt.Repository;
using librarymgt.Models;

namespace librarymgt.Controllers
{
    public class BookController : Controller
    {
        private readonly BooKcategoryInterface Ibook;
        public BookController(BooKcategoryInterface _IBook)
        {
            Ibook = _IBook;
        }
        public IActionResult Index()
        {
            var bookCategories = Ibook.ListBookCategories();
            return View(bookCategories);
        }
        public IActionResult addCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(BookCategory category)
        {
            Ibook.AddBookCategroy(category);
            return RedirectToAction("index");
        }

        public IActionResult AddBook(int id)
        {
            ViewBag.id = id;
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            Ibook.AddBook(book);
            return RedirectToAction("Index");
        }

        //
        // List Of Books
        //
        public IActionResult ListOfBooks()
        {
            var list = Ibook.ListOfBooks();
            return View(list);
        }

        //
        //View Books By categories
        //
       [HttpGet("ViewBooksByCategories")]
        //[Route("book/ViewBooksByCategories/{id}/{category}")]
        public IActionResult ViewBooksByCategories(int id)
        {
              var books=Ibook.ViewBooksByCategories(id);
           //   ViewBag.category= category;
              return View(books);
           
        }
        [HttpGet]
        public IActionResult Edit(int BookId)
        {
          var book = Ibook.GetBookById(BookId);
            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(Book book)
        {
           var result= Ibook.Edit(book);
            if (result == true)
            {
                return RedirectToAction("ListOfBooks");
            }
            else
            {
                return View();
            }
        }
    }
}