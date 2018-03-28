using System;
using System.Collections.Generic;
using System.Text;

namespace SaafiMoney.Data.Models
{
   public class SenderRemittance
   {
        public string SenderId { get; set; }
        public Sender Sennder { get; set; }


        public int RemittanceId { get; set; }
        public Remittance Remittance { get; set; }
    }
}
