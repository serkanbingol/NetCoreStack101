using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreStack.Contracts;
using NetCoreStack101.SharedLibrary.ApiContracts;
using NetCoreStack101.SharedLibrary.ViewModels;
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

        public async Task<IActionResult> GetTeachers(CollectionRequest request)
        {
            var collection = await _teacherApi.GetAllTeacherViewModelAsync(request);
            return Json(collection);
        }

        [HttpPost]
        public async Task<IActionResult> SaveTeacher([FromBody]TeacherViewModel viewModel)
        {
            await _teacherApi.SaveTeacherAsync(viewModel);
            return CreateSuccessWebResult(viewModel.IsNew ? "Teacher Record Created." : "Teacher Record Updated.");
        }



    }
}