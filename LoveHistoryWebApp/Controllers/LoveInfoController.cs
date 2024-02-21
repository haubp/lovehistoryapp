using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using DTO;

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
            LoveInfo info = LoveInfoModel.Query(_env);
            return View(info);
        }

        [HttpPost]
        [Route("/loveinfo")]
        public IActionResult UpdateLoveInfo([FromBody] LoveInfo info)
        {
            LoveInfoModel.Save(_env, info);
            return Content(string.Empty);
        }
    }
}

