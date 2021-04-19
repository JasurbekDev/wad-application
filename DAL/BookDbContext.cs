using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WAD.WebApp._7986.BookRent.Models
{
    public class BookDbContext : DbContext
    {
        public BookDbContext()
        {

        }
        public DbSet<Book> Book { get; set; }
    }
}
