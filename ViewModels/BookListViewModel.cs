using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAD.WebApp._7986.BookRent.Models;

namespace WAD.WebApp._7986.BookRent.ViewModels
{
    public class BookListViewModel
    {
        public List<Book> Books { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
