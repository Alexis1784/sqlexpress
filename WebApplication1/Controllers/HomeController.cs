using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        protected BookDbContext db = new BookDbContext();
        
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Add()
        {
            IEnumerable<Book> books = db.Books;
            ViewBag.books = books;
            return View();
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Buy(string first_arg1)
        {
            return first_arg1;
        }
        [HttpPost]
        public string Buy2(string first_arg2)
        {
            return first_arg2;
        }
        [HttpPost]
        public string Buy3(string [] first_arg)
        {
            return first_arg[0] + first_arg[1] + first_arg[2];
        }

        public ActionResult Delete()
        {
            Book b = db.Books.Find(1);
            return View(b);
        }
        [HttpPost]
        public string Delete(Book b)
        {
             
            return b.BookId.ToString() + b.Name;
        }
        [HttpGet]
        public string Delete2(int id)
        {

            return id.ToString();
        }

        [HttpGet]
        public ActionResult EditBook(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Book book = db.Books.Find(id);
            if (book != null)
            {
                return View(book);
            }
            return HttpNotFound();
        }

        [HttpPost]
        public string EditBook(Book book)
        {
             
            return book.Name;
        }

        [HttpGet]
        public ActionResult Some()
        {
            int id = 2;
            Book b = db.Books.Find(id);
            return View(b);
        }
        [HttpPost]
        public string Some(string Name2, string act, string inp, string inp3, string Name3, string Name4, string Name5, string[] Name6)
        {

            return inp3 + inp + act + Name2 + Name3 + Name4 + Name5 + Name6[0] + Name6[1] + Name6[2];
        }

        [HttpGet]
        public ActionResult Add2()
        {
            return View(db.Books.ToList());
        }
        [HttpPost]
        public string Add2(List<Book> books)
        {
            if (books != null)
            {
                return books[0].BookId.ToString() + books[1].BookId.ToString() + books[2].BookId.ToString();
            }
            else
                return "It's null!";
        }

        [HttpGet]
        public ActionResult Add3()
        {
            Book firstBook = db.Books.FirstOrDefault();
            return View(firstBook);
        }
        [HttpPost]
        public string Add3(Book book, Book myBook)
        {
            if (book != null)
            {
                
                return book.BookId.ToString() + myBook.BookId.ToString();
            }
            else
                return "It's null!";
        }

        
        public ActionResult GetAuthor()
        {
            return View();
        }

        [HttpPost]
        public string GetAuthor(Author author)
        {
            return author.Name+author.Book.Name;
        }
    }
}