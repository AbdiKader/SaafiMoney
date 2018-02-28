using System.Collections.Generic;

namespace SaafiMoney.Models.SenderViewModels
{
    public class SenderDetailViewModel
    {
        public SenderListingViewModel Sender { get; set; }
        public IEnumerable<RecipientListingViewModel> Recipients { get; set; }
    }
}
