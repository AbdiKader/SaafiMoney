using Microsoft.AspNetCore.Mvc;
using SaafiMoney.Data;
using SaafiMoney.Models.SenderViewModels;
using System.Linq;
using SaafiMoney.Data.Models;
using System;
using System.Collections.Generic;
using SaafiMoney.Models.RecipientViewModel;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using SaafiMoney.Models.RemittanceViewModel;

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

            return RedirectToAction("Transactions");
        }
        public IActionResult Recipients()
        {
            var id = _userManager.GetUserId(User);
            var sender = _senderService.GetById(id);
            var model = BuildSenderHome(sender);

            return View(model);
        }
        public IActionResult Transactions()
        {
            var id = _userManager.GetUserId(User);
            var sender = _senderService.GetRemittanceById(id);
            var model = BuildSenderTransactions(sender);

            return View(model);
        }
        public IActionResult Add()
        {


            var model = new NewRecipientViewModel();
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(NewRecipientViewModel model)
        {
            var id = _userManager.GetUserId(User);
            var sender = _userManager.FindByIdAsync(id).Result;

            var recipient = BuildNewRecipient(model, sender);
            await _senderService.Add(recipient);
            return RedirectToAction("Index");
        }

        private Recipient BuildNewRecipient(NewRecipientViewModel model, Sender sender)
        {
            return new Recipient
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Country = model.Country,
                Phone = model.Phone,
                Sender = sender
            };
        }

        public IActionResult Send()
        {


            var model = new NewRemittanceViewModel(_senderService.GetAll((string)_userManager.GetUserId(User)).ToList());

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Send(NewRemittanceViewModel model)
        {
            var id = _userManager.GetUserId(User);
            var sender = _userManager.FindByIdAsync(id).Result;

            var remittance = BuildNewRemittance(model, sender);
            await _senderService.Send(remittance);
            return RedirectToAction("Transactions");
        }

        private Remittance BuildNewRemittance(NewRemittanceViewModel model, Sender sender)
        {
            return new Remittance
            {
                Amount = model.Amount,
                Created = model.Created,
                RecipientId = model.RecipientId,
                Sender = sender
            };
        }
        private SenderHomeIndexViewModel BuildSenderHome(Sender sender)
        {
            var recipients = BuildRecipients(sender.Recipients);
            //var remittances = BuildRemittances(sender.Remittances);

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
                Recipients = recipients,
               // Remittances = remittances
            };
        }

        private SenderTransactionsIndexViewModel BuildSenderTransactions(Sender sender)
        {
           var remittances = BuildRemittances(sender.Remittances);

            return new SenderTransactionsIndexViewModel
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
                Remittances = remittances
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

        private IEnumerable<RemittanceIndexViewModel> BuildRemittances(IEnumerable<Remittance> remittances)
        {

            var remittance = remittances.Select(rem => new RemittanceIndexViewModel
            {
                ID = rem.ID,
                Amount = rem.Amount,
                Created = rem.Created,
            });

            return remittance;
        }

        //public IActionResult Detail(string id)
        //{
        //    var sender = _senderService.GetById(id);
        //    var recipients = sender.Recipients;

        //    var recipientList = recipients.Select(recipient => new RecipientListingViewModel
        //    {
        //        ID = recipient.ID,
        //        FirstName = recipient.FirstName,
        //        LastName = recipient.LastName,
        //        Country = recipient.Country,
        //        Phone = recipient.Phone,
        //        Sender = BuildSender(recipient)

        //    });

        //    var model = new SenderDetailViewModel
        //    {
        //        Recipients = recipientList,
        //        Sender = BuildSender(sender)
        //    };

        //    return View(model);
        //}

        private SenderListingViewModel BuildSender(Recipient recipient)
        {
            var sender = recipient.Sender;
            return BuildSender(sender);
        }
        private SenderListingViewModel BuildSender(Remittance remittance)
        {
            var sender = remittance.Sender;
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