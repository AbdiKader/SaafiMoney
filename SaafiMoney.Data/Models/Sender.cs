using System.Collections.Generic;

namespace SaafiMoney.Data.Models
{
    public class Sender
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string IdImageUrl { get; set; }

        public virtual IEnumerable<Recipient> Recipients { get; set; }
    }
}
