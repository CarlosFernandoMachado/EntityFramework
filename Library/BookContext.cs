using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Library
{
    public class BookContext : DbContext
    {
        public BookContext() : base("BookContext")
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
