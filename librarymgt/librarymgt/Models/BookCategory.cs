using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace librarymgt.Models
{
    public class BookCategory
    {
        public int BookCategoryId { get; set; }
        [Required(ErrorMessage ="Enter Category name"),MinLength(3)]
       
        public string CategoryName { get; set; }
    }
}
