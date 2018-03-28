using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SaafiMoney.Data.Models;

namespace SaafiMoney.Data
{
    public class ApplicationDbContext : IdentityDbContext<Sender>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

         public DbSet<Remittance> Remittances { get; set; }
         public DbSet<Recipient> Recipients { get; set; }
         public DbSet<Sender> Senders { get; set; }

        //public DbSet<SenderRemittance> SenderRemittance { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<SenderRemittance>()
        //        .HasKey(c => new { c.LoadID, c.OwnerID });
           
        //}
    }
}
