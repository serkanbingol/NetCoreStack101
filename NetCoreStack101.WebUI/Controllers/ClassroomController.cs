using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreStack101.WebUI.Controllers
{
    public class ClassroomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update()
        {
            return View();
        }


    }
}