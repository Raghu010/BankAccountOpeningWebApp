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
        public DbSet<Cities> cities { get; set; }
        public DbSet<Branch> branches { get; set; }
        public DbSet<Languages> languages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

    }
}
