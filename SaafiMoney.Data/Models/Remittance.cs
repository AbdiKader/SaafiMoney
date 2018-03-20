using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaafiMoney.Data.Models
{
    public class Remittance
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Created { get; set; }
        public virtual Sender Sender { get; set; }

        public int RecipientId { get; set; }
        public virtual IEnumerable<Recipient> Recipients { get; set; }


    }
}