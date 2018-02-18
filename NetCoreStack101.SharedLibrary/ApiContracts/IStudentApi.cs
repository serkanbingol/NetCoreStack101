using NetCoreStack.Contracts;
using NetCoreStack101.SharedLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreStack101.SharedLibrary.ApiContracts
{
   public  interface IStudentApi : IApiContract
    {
        Task<StudentViewModel> GetStudentViewModelAsync(int studentId);
        Task<CollectionResult<StudentViewModel>> GetAllStudentViewModelAsync(CollectionRequest request);
        Task SaveStudentAsync(StudentViewModel viewModel);
    }
}
