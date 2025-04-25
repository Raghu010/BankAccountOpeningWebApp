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
    }
}
