
namespace SaafiMoney.Models.SenderViewModels
{
    public class RecipientListingViewModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }

        public SenderListingViewModel Sender { get; set; }
    }
}
