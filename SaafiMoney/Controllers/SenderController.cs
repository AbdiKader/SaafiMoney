using Microsoft.AspNetCore.Mvc;
using SaafiMoney.Data;
using SaafiMoney.Models.SenderViewModels;
using SaafiMoney.Models.RecipientViewModel;

using System.Linq;
using SaafiMoney.Data.Models;
using System;

namespace SaafiMoney.Controllers
{
    public class SenderController : Controller
    {
        private readonly ISender _senderService;
        public SenderController(ISender senderService)
        {
            _senderService = senderService;
        }

        public IActionResult Index()
        {
            var senders = _senderService.GetAll().Select(sender => new SenderListingViewModel
            {
                ID = sender.Id,
                FirstName = sender.FirstName,
                LastName = sender.LastName
            });

            var model = new SenderIndexViewModel
            {
                SenderList = senders
            };

            return View(model);
        }

        public IActionResult Detail(string id)
        {
            var sender = _senderService.GetById(id);
            var recipients = sender.Recipients;

            var recipientList = recipients.Select(recipient => new RecipientListingViewModel
            {
                Id = recipient.Id,
                FirstName = recipient.FirstName,
                LastName = recipient.LastName,
                Country = recipient.Country,
                Phone = recipient.Phone,
                //Sender = BuildSender(recipient)

            });

            var model = new SenderDetailViewModel
            {
                Recipients = recipientList,
                Sender = BuildSender(sender)
            };
           
            return View(model);
        }

        //private SenderListingViewModel BuildSender(Recipient recipient)
        //{
        //    var sender = recipient.Sender;
        //    return BuildSender(sender);
        //}

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