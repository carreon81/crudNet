using System;
using crudNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace crudNetCore
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }
    }
}
