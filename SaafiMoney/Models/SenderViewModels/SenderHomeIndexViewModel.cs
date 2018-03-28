using SaafiMoney.Models.RecipientViewModel;
using SaafiMoney.Models.RemittanceViewModel;
using System.Collections.Generic;

namespace SaafiMoney.Models.SenderViewModels
{
    public class SenderHomeIndexViewModel
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Phone { get; set; }
        public string ImageUrl { get; set; }

        public IEnumerable<RecipientIndexViewModel> Recipients { get; set; }
        public IEnumerable<RemittanceIndexViewModel> Remittances { get; set; }

    }
}
