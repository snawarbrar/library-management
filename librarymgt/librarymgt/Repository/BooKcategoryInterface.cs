using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using librarymgt.Models;
namespace librarymgt.Repository
{
   public interface BooKcategoryInterface
    {
        bool AddBookCategroy(BookCategory category);

        bool AddBook(Book book);

        List<Book> ListOfBooks();

        List<BookCategory> ListBookCategories();
        List<Book> ViewBooksByCategories(int categoryId);
        bool Edit(Book book);
        Book GetBookById(int id);


    }
}
