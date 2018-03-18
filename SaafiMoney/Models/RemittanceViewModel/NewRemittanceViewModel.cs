using System;

namespace SaafiMoney.Models.RemittanceViewModel
{
    public class NewRemittanceViewModel
    {
        public string senderID { get; set; }    
        public decimal Amount { get; set; }
        public DateTime Created { get; set; }
    }
}
