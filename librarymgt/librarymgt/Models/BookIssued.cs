using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace librarymgt.Models
{
    public class BookIssued
    {
        public int BookIssuedId { get; set; }
        
        [Required]
        public int BookId { get; set; }
        public Book book { get; set; }
        [Required]
        public int StudentId { get; set; }
        public Student student { get; set; }
        
        public DateTime issueDate { get; set; }
       
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ? ReturnDate { get; set; }
    }
}
