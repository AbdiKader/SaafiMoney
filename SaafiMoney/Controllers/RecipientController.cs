using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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