using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SaafiMoney.Data.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class Sender : IdentityUser
    {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public int Zip { get; set; } 
            public string IdImageUrl { get; set; }

            //public virtual IEnumerable<Recipient> Recipients { get; set; }
            public virtual IEnumerable<Remittance> Remittances { get; set; }

    }
} 
