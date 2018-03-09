using SaafiMoney.Models.SenderViewModels;
using System;
using System.Collections.Generic;

namespace SaafiMoney.Models.RecipientViewModel
{
    public class RecipientIndexViewModel
    {
        public IEnumerable<RecipientListingViewModel> RecipientList { get; set; }

    }
}
