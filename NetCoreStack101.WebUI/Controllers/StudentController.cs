using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreStack101.Domain.Managers;
using NetCoreStack.Data.Interfaces;
using NetCoreStack101.WebUI.Extensions;
using NetCoreStack101.SharedLibrary.ApiContracts;
using NetCoreStack.Contracts;
using NetCoreStack101.SharedLibrary.ViewModels;

namespace NetCoreStack101.WebUI.Controllers
{
    public class StudentController : ClientBaseController
    {

        private readonly IStudentApi _studentApi;

        public StudentController (IStudentApi studentApi)
	{
            _studentApi = studentApi;
	}
        public IActionResult Index()
        {
             
            return View();
        }

       public async Task<IActionResult> GetStudents(CollectionRequest request)
        {
            CollectionResult<StudentViewModel> collection =await _studentApi.GetAllStudentViewModelAsync(request);
            return Json(collection);
        }

      
    }
}