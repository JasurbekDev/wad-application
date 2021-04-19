using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WAD.WebApp._7986.BookRent.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Display(Name = "Author")]
        public string Author { get; set; }

        [Display(Name = "Published Date")]
        public DateTime? PublishedDate { get; set; }

    }
}
