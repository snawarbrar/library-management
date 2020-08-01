using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace librarymgt.Models
{
    public class BookBorrowed
    {
        public string StudentName { get; set; }
        public string BookName { get; set; }
        public DateTime issuedate { get; set; }
        public int BookId { get; set; }
        public int StudentId { get; set; }
        public DateTime ? ReturnDate { get; set; }


    }
}
