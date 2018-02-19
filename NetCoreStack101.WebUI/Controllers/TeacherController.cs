using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreStack101.SharedLibrary.ApiContracts;
using NetCoreStack101.WebUI.Extensions;

namespace NetCoreStack101.WebUI.Controllers
{
    public class TeacherController : ClientBaseController
    {
        private readonly ITeacherApi _teacherApi;
        public TeacherController(ITeacherApi teacherApi )
        {
            _teacherApi = teacherApi;
        }
        public IActionResult Index()
        {
            return View();
        }


    }
}