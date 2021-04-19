using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAD.WebApp._7986.BookRent.Models;
using WAD.WebApp._7986.BookRent.ViewModels;

namespace WAD.WebApp._7986.BookRent.Controllers
{
    public class BookController : Controller
    {
        private readonly BookDbContext _dbContext;
        public BookController()
        {
            this._dbContext = new BookDbContext();
        }
        public IActionResult Index()
        {
            var bookList = this._dbContext.Book.ToList();
            return View(bookList);
        }

        public ActionResult AddBook()
        {
            var bookViewModel = new BookFormViewModel()
            {
                Book = new Book()
            };
            return View("BookForm", bookViewModel);
        }

        public ActionResult Edit(int id)
        {
            var book = this._dbContext.Book.FirstOrDefault(x => x.BookId == id);

            var viewModel = new BookFormViewModel()
            {
                Book = book
            };

            return View("BookForm", viewModel);
        }

        public ActionResult AddBooks(int id)
        {
            var book = this._dbContext.Book.FirstOrDefault(x => x.BookId == id);

            var viewModel = new BookFormViewModel()
            {
                Book = book
            };

            return View("BookForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Book book)
        {
            if (!ModelState.IsValid)
            {
                //return RedirectToAction("AddBooks", "Book");
            }

            if (book.BookId == 0)
                this._dbContext.Book.Add(book);

            else
            {
                var booksDb = this._dbContext.Book.FirstOrDefault(x => x.BookId == book.BookId);
                booksDb.Title = book.Title;
                booksDb.Author = book.Author;
                booksDb.PublishedDate = book.PublishedDate;
            }

            this._dbContext.SaveChanges();
            return RedirectToAction("Index", "Book");
        }

        public ActionResult Delete(int id)
        {
            var bookDb = this._dbContext.Book.FirstOrDefault(x => x.BookId == id);
            this._dbContext.Book.Remove(bookDb);
            this._dbContext.SaveChanges();

            return RedirectToAction("Index", "Book");
        }

    }
}
