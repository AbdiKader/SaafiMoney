using SaafiMoney.Data.Models;
using System;
using System.Collections.Generic;

namespace SaafiMoney.Models.RemittanceViewModel
{
    public class RemittanceIndexViewModel
    {
        public int ID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Created { get; set; }
        public int RecipientId { get; set; }
        public virtual IEnumerable<Recipient> Recipients { get; set; }
        public Sender Sender { get; set; }
    }
}
