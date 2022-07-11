using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BooksApp.Models;

namespace BooksApp.Data
{
    public class BooksAppContext : DbContext
    {
        public BooksAppContext (DbContextOptions<BooksAppContext> options)
            : base(options)
        {
        }

        public DbSet<BooksApp.Models.Book> Book { get; set; }
    }
}
