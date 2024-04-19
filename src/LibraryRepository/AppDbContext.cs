using LibraryRepository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Copy> Copies { get; set; }
        public DbSet<Fine> Fines { get; set; }
        public DbSet<Loan> Loans { get; set; }

        public string DbPath { get; }
        public AppDbContext()
        {
            var projectDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString();

            DbPath = System.IO.Path.Combine(projectDirectory, "library.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fine>()
                        .HasOne(f => f.Loan)
                        .WithOne(l => l.Fine)
                        .HasForeignKey<Loan>(l => l.FineId);

            modelBuilder.Entity<Loan>()
                .Property(l => l.FineId)
                .IsRequired(false);
        }

    }
}
