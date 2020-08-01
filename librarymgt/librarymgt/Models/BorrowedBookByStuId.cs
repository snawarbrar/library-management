using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace librarymgt.Models
{
    public class BorrowedBookByStuId
    {
        [Required]
        public int StudentId{ get; set; }
    }
}
