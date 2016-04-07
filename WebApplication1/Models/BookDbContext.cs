using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class BookDbContext : DbContext
    {
        public BookDbContext()
            : base("myConnection")
        { }
        public DbSet<Book> Books { get; set; }

    }
}