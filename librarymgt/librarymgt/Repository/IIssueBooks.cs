using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using librarymgt.Models;

namespace librarymgt.Repository
{
    public interface IIssueBooks
    {
        List<BookIssued> getAllIssueBooks();

        bool issueBook(BookIssued bookIssued);

        List<BookCategory> GetBookCategories();
        bool returnBook();
        List<Book> getBooksByCategory(int catId);
    }
}
