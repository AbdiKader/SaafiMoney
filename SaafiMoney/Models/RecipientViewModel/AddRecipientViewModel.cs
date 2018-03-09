using SaafiMoney.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaafiMoney.Models.RecipientViewModel
{
    public class AddRecipientViewModel
    {
        [Display(Name = "Recipient Name")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide a recipient name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please provide a recipient name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please provide a phone name")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter a destination country")]

        public string Country { get; set; }


        //public virtual Sender Sender { get; set; }
    }
}
