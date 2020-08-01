using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace librarymgt.Models
{
    public class BorowedBookByRollNo
    {
        [Required, MaxLength(5), MinLength(5)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "roll no must conatin 5 digits")]
        public string RollNumber { get; set; }
    }
}
