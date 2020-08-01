using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace librarymgt.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required,MinLength(4)]
        public string  BookName {  get; set; }
        [Required,MinLength(4)]
        public string AuthorName { get; set; }
        [Required]
       
        public long ISBN { get; set; }

        public int bookCategoryId { get; set; }
        public BookCategory bookCategory { get; set; }

        
    }
}
