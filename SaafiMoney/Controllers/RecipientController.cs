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


        public IActionResult Index()
        {

            return View();
        }

    }
}