using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookShelf.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BookShelf.Data
{
    public class BookShelfContext : IdentityDbContext<ApplicationUser>
    {
        public BookShelfContext (DbContextOptions<BookShelfContext> options)
            : base(options)
        {
        }

        public DbSet<BookShelf.Models.Book> Book { get; set; }
    }
}
