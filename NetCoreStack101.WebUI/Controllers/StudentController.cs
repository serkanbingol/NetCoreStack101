using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreStack101.Domain.Managers;
using NetCoreStack.Data.Interfaces;

namespace NetCoreStack101.WebUI.Controllers
{
    public class StudentController : Controller
    {

        private readonly ISqlUnitOfWork _unitOfWork;

        public StudentController (ISqlUnitOfWork unitOfWork):base()
	{
            _unitOfWork = unitOfWork;
	}
        public IActionResult Index()
        {

            StudentManager manager=new StudentManager(_unitOfWork);
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