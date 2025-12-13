using FileShareApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FileShareApp.Data
{
    public partial class FileShareDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        public FileShareDbContext()
        {
        }

        public FileShareDbContext(DbContextOptions<FileShareDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder
                .UseCollation("utf8mb4_unicode_ci")
                .HasCharSet("utf8mb4");
        }
    }
}