using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Starmovies.Controllers
{
    public class EstrenosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DirtyDancing()
        {
            return View();
        }

        public IActionResult Grease()
        {
            return View();
        }

        public IActionResult FlashDance()
        {
            return View();
        }

        public IActionResult Saturday()
        {
            return View();
        }
    }
}