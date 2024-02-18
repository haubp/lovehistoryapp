using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Constants;

namespace Controllers
{
    public class LoveInfoController : Controller
    {
        private IWebHostEnvironment _env;
        public LoveInfoController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpGet]
        [Route("/loveinfo")]
        public IActionResult Index()
        {
            LoveInfo info = new (Path.Combine(_env.WebRootPath, Constant.LoveInfoFileName));
            return View(info);
        }

        [HttpPost]
        [Route("/loveinfo")]
        public IActionResult UpdateLoveInfo([FromBody] LoveInfo info)
        {
            info.SaveToFile(Path.Combine(_env.WebRootPath, Constant.LoveInfoFileName));
            return Content(string.Empty);
        }
    }
}

