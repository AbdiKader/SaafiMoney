using Microsoft.AspNetCore.Mvc.Rendering;
using SaafiMoney.Data.Models;
using SaafiMoney.Models.RecipientViewModel;
using SaafiMoney.Models.SenderViewModels;
using System;
using System.Collections.Generic;

namespace SaafiMoney.Models.RemittanceViewModel
{
    public class NewRemittanceViewModel
    {
        public string senderID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Created { get; set; }
        //public IEnumerable<RecipientIndexViewModel> RecipientsList { get; set; }

        public int RecipientId { get; set; }
        public RecipientListingViewModel Recipient { get; set; }

        public List<SelectListItem> Recipients { get; set; }
        public NewRemittanceViewModel() { }

        public NewRemittanceViewModel(IEnumerable<Recipient> recipients)
        {
            Recipients = new List<SelectListItem>();

            foreach (Recipient recipient in recipients)
            {
                Recipients.Add(new SelectListItem
                {
                    Value = (recipient.ID).ToString(),
                    Text = recipient.FirstName.ToString()
                });
            }
        }
    }
}
