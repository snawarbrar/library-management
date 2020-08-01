using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using librarymgt.Models;

namespace librarymgt.Repository
{
    public class IssueBookRepository : IIssueBooks
    {
        private readonly identityModel context;
        public IssueBookRepository(identityModel _context)
        {
            context = _context;
        }
        public List<BookIssued> getAllIssueBooks()
        {
            return context.BookIssueds.ToList();
        }

        public List<BookCategory> GetBookCategories()
        {
            return context.BookCategories.ToList();
        }

        public List<Book> getBooksByCategory(int catId)
        {
          return  context.Books.Where(book => book.bookCategoryId == catId).ToList();
        }

        public bool issueBook(BookIssued bookIssued)
        {
            var chk = context.BookIssueds.Count(x=>x.BookId==bookIssued.BookId && x.StudentId==bookIssued.StudentId);
            if (chk == 0)
            {
                context.BookIssueds.Add(bookIssued);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        

        public bool returnBook()
        {
            throw new NotImplementedException();
        }
    }
}
