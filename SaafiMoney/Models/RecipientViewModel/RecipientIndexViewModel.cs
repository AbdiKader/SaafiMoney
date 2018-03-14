using SaafiMoney.Data.Models;

namespace SaafiMoney.Models.RecipientViewModel
{
    public class RecipientIndexViewModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

        public Sender Sender { get; set; }
    }
}
