using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Task.Models;

namespace Task
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<MouseMovement> MouseMovements { get; set; }
    }
}
