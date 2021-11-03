using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookShelf.Models;

namespace BookShelf.Data
{
    public class BookShelfContext : DbContext
    {
        public BookShelfContext (DbContextOptions<BookShelfContext> options)
            : base(options)
        {
        }

        public DbSet<BookShelf.Models.Book> Book { get; set; }
    }
}
