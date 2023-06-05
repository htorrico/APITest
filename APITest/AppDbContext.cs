using APITest.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace APITest
{
    public class AppDbContext : DbContext
    {        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
