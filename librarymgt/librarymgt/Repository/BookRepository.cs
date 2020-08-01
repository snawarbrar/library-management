using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using librarymgt.Models;


namespace librarymgt.Repository
{
    public class BookRepository:BooKcategoryInterface
    {
        private readonly identityModel context;
        public BookRepository(identityModel _context)
        {
            context = _context;
        }

        public bool AddBook(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
            return true;
        }

        public bool AddBookCategroy(BookCategory category)
        {
            context.BookCategories.Add(category);
            context.SaveChanges();
            return true;
        }

        public List<Book> ListOfBooks()
        {
            var books = context.Books.ToList();
            return books;
        }

        public List<BookCategory> ListBookCategories()
        {
           return context.BookCategories.ToList();
        }

        public List<Book> ViewBooksByCategories(int categoryId)
        {
            var books = (from book in context.Books
                        join categories in context.BookCategories
                        on book.bookCategory.BookCategoryId equals categories.BookCategoryId
                        select book).ToList();
            return books;
        }

        public bool Edit(Book books)
        {

        var result=context.Books.FirstOrDefault(x=>x.BookId==books.BookId);
            result.BookName = books.BookName;
            result.AuthorName = books.AuthorName;
            result.ISBN = books.ISBN;
            result.bookCategoryId = books.bookCategoryId;
            context.SaveChanges();
            return true;
        }

        

        public Book GetBookById(int id)
        {
            return context.Books.FirstOrDefault(x => x.BookId == id);
        }
    }
}
