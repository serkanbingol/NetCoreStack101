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

        public async Task<IActionResult> GetClassrooms(CollectionRequest request)
        {
            var collection = await _classroomApi.GetAllClassroomViewModelAsync(request);
            return Json(collection);
        }

        [HttpPost]
        public async Task<IActionResult> SaveTeacher([FromBody]ClassroomViewModel viewModel)
        {
            await _classroomApi.SaveClassroomAsync(viewModel);
            return CreateSuccessWebResult(viewModel.IsNew ? "Classroom Record Created." : "Classroom Record Updated.");
        }





    }
}