using Microsoft.AspNetCore.Mvc;
using SaafiMoney.Data;
using SaafiMoney.Models.SenderViewModels;
using System.Linq;
using SaafiMoney.Data.Models;
using System;
using System.Collections.Generic;
using SaafiMoney.Models.RecipientViewModel;
using Microsoft.AspNetCore.Identity;

namespace SaafiMoney.Controllers
{
    public class SenderController : Controller
    {
        private readonly ISender _senderService;

        private static UserManager<Sender> _userManager;


        public SenderController(ISender senderService, UserManager<Sender> userManager)
        {
            _senderService = senderService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var id = _userManager.GetUserId(User);
            var sender = _senderService.GetById(id);
            var model = BuildSenderHome(sender);

            return View(model);
        }

        private SenderHomeIndexViewModel BuildSenderHome(Sender sender)
        {
            var recipients = BuildRecipients(sender.Recipients);

            return new SenderHomeIndexViewModel
            {
                ID = sender.Id,
                FirstName = sender.FirstName,
                LastName = sender.LastName,
                Address = sender.Address,
                City = sender.City,
                State = sender.State,
                Zip = sender.Zip,
                Phone = sender.Phone,
                ImageUrl = sender.IdImageUrl,
                Recipients = recipients
            };
        }

        private IEnumerable<RecipientIndexViewModel> BuildRecipients(IEnumerable<Recipient> recipients)
        {

            var recipient = recipients.Select(rec => new RecipientIndexViewModel
            {
                ID = rec.ID,
                FirstName = rec.FirstName,
                LastName = rec.LastName,
                Country = rec.Country,
                Phone = rec.Phone,

            });

            return recipient;
        }

        public IActionResult Detail(string id)
        {
            var sender = _senderService.GetById(id);
            var recipients = sender.Recipients;

            var recipientList = recipients.Select(recipient => new RecipientListingViewModel
            {
                ID = recipient.ID,
                FirstName = recipient.FirstName,
                LastName = recipient.LastName,
                Country = recipient.Country,
                Phone = recipient.Phone,
                Sender = BuildSender(recipient)

            });

            var model = new SenderDetailViewModel
            {
                Recipients = recipientList,
                Sender = BuildSender(sender)
            };
           
            return View(model);
        }

        private SenderListingViewModel BuildSender(Recipient recipient)
        {
            var sender = recipient.Sender;
            return BuildSender(sender);
        }

        private SenderListingViewModel BuildSender(Sender sender)
        {
            return new SenderListingViewModel
            {
                ID = sender.Id,
                FirstName = sender.FirstName,
                LastName = sender.LastName,
                Address = sender.Address,
                City = sender.City,
                Zip = sender.Zip,
                State = sender.State,
                Phone = sender.Phone


            };
        }
    }
}