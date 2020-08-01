using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace librarymgt.Models
{
    public class identityModel:IdentityDbContext
    {
        public identityModel(DbContextOptions<identityModel> options)
       : base(options)
        {
        }
        public DbSet<BookCategory> BookCategories { get; set; }
        
        public DbSet<Book> Books { get; set; }

        public DbSet<Student> Students { get; set; }
        
        public DbSet<BookIssued> BookIssueds { get; set; }

    }
}
