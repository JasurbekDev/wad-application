using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WAD.WebApp._7986.BookRent.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        public string GenreName { get; set; }
    }
}
