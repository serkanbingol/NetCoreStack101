using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreStack101.SharedLibrary.ApiContracts;
using NetCoreStack101.WebUI.Extensions;

namespace NetCoreStack101.WebUI.Controllers
{
    public class ClassroomController : ClientBaseController
    {
        private readonly IClassroomApi _classroomApi;
        public ClassroomController(IClassroomApi classroomApi)
        {
            _classroomApi = classroomApi;
        }
        public IActionResult Index()
        {
            return View();
        }

       


    }
}