using SaafiMoney.Data.Models;
using System;

namespace SaafiMoney.Models.RemittanceViewModel
{
    public class RemittanceIndexViewModel
    {
        public int ID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Created { get; set; }

        public Sender Sender { get; set; }
    }
}
