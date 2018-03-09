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

         public DbSet<Record> Records { get; set; }
         public DbSet<Recipient> Recipients { get; set; }
         public DbSet<Sender> Senders { get; set; }
    }
}
