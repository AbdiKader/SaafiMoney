using Microsoft.AspNetCore.Mvc.Rendering;
using SaafiMoney.Data.Models;
using System.Collections.Generic;

namespace SaafiMoney.Models.RecipientViewModel
{
    public class NewRecipientViewModel
    {
        public string senderID { get; set; }    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        
    }
}
