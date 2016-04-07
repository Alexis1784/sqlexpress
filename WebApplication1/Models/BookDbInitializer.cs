using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookDbContext>
    {
        protected override void Seed(BookDbContext context)
        {
            base.Seed(context);

            Book book1 = new Book { Price = 12, Author = "Quian1", Name = "Phantasy1" };
            Book book2 = new Book { Price = 13, Author = "Quian2", Name = "Phantasy2" };
            Book book3 = new Book { Price = 14, Author = "Quian3", Name = "Phantasy3" };

            context.Books.AddRange(new List<Book>() { book1, book2, book3 });

        }
    }
}