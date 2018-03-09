using System;
using System.Collections.Generic;

namespace SaafiMoney.Data.Models
{
    public class Recipient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }

        //public Sender SenderId { get; set }
        //public virtual Sender Sender { get; set; }
        //public static implicit operator List<object>(Recipient v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
