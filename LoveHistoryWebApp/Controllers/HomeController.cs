using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("/home")]
        public IActionResult Index()
        {
            return RedirectToAction("Index", "LoveInfo");
        }
    }
}
