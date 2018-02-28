using Microsoft.AspNetCore.Mvc;
using SaafiMoney.Data;
using SaafiMoney.Models.SenderViewModels;
using System.Linq;

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
                ID = sender.ID,
                FirstName = sender.FirstName,
                LastName = sender.LastName
            });

            var model = new SenderIndexViewModel
            {
                SenderList = senders
            };

            return View(model);
        }
    }
}