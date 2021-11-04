using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AAO_adminstrationspanel.Controllers
{
    public class AAOController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OpretTur()
        {
            return View();
        }

        public IActionResult AlleTure()
        {
            return View();
        }

        public IActionResult TildelteTure()
        {
            return View();
        }

        public IActionResult AfloserOversigt()
        {
            return View();
        }
    }
}
