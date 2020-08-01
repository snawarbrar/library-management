using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace librarymgt.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required,MaxLength(5),MinLength(5)]
        [RegularExpression("^[0-9]*$", ErrorMessage ="roll no must conatin 5 digits")]
        public string RollNumber { get; set; }
        [Required]
        public string StuName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string StuEmail { get; set; }
        [Required]
        public string Course { get; set; } 
    }
}
