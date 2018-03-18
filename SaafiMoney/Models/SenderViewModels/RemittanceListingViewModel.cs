using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaafiMoney.Models.SenderViewModels
{
    public class RemittanceListingViewModel
    {
        public int ID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Created { get; set; }

        public SenderListingViewModel Sender { get; set; }
    }
}
