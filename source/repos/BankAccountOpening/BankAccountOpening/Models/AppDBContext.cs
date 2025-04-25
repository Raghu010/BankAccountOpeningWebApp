using Microsoft.EntityFrameworkCore;
using System;

namespace BankAccountOpening.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
                
        }
        
        public DbSet<UserDetails> Users { get; set; }
        public DbSet<States> states { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

    }
}
