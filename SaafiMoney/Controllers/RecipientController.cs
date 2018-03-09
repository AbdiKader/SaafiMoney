using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaafiMoney.Data.Models;
using SaafiMoney.Models.RecipientViewModel;
using SaafiMoney.Data;
using SaafiMoney.Models.SenderViewModels;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace SaafiMoney.Controllers
{
    public class RecipientController : Controller
    {

        private readonly IRecipient _recipientService;
        public RecipientController(IRecipient recipientService)
        {
            _recipientService = recipientService;
        }

        public IActionResult Index()
        {
            var recipients = _recipientService.GetAll().Select(recipient => new RecipientListingViewModel
            {
                Id = recipient.Id,
                FirstName = recipient.FirstName,
                LastName = recipient.LastName,
                Phone = recipient.Phone,
                Country = recipient.Country,
                //SenderId = Sender.ID
            });

            var model = new RecipientIndexViewModel
            {
                RecipientList = /*(IEnumerable<RecipientIndexViewModel>)*/ recipients
            };

            return View(model);
        }



        public IActionResult Add()
        {
            AddRecipientViewModel addRecipientViewModel =
                new AddRecipientViewModel();
            return View(addRecipientViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddRecipientViewModel addRecipientViewModel)
        {
            if (ModelState.IsValid)
            {
                Recipient newRecipient = new Recipient
                {
                    Id = addRecipientViewModel.Id,
                    FirstName = addRecipientViewModel.FirstName,
                    LastName = addRecipientViewModel.LastName,
                    Phone = addRecipientViewModel.Phone,
                    Country = addRecipientViewModel.Country,
                };

                var recipients = _recipientService.Add(newRecipient);
                //recipients = recipients.Wait();
                return View(recipients); //Redirect("/Recipient");
            }

            return View(addRecipientViewModel);
        }

        private RecipientListingViewModel BuildRecipient(Recipient recipient)
        {
            return new RecipientListingViewModel
            {
                Id = recipient.Id,
                FirstName = recipient.FirstName,
                LastName = recipient.LastName,
                Phone = recipient.Phone
            };
        }
    }
}