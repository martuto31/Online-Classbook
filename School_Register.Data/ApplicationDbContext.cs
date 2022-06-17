using Microsoft.EntityFrameworkCore;
using School_Register.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School_Register.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // One to many relation - 1 Student account has many grades
            builder.Entity<StudentAccount>()
                .HasMany(c => c.Marks)
                .WithOne(e => e.StudentAccount);
        }

        public DbSet<StudentAccount> studentAccounts { get; set; }

        public DbSet<Mark> marks { get; set; }
    }
}
