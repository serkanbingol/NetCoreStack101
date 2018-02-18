using NetCoreStack.Contracts;
using NetCoreStack101.SharedLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreStack101.SharedLibrary.ApiContracts
{
    public interface ITeacherApi : IApiContract
    {
        Task<TeacherViewModel> GetTeacherViewModelAsync(int studentId);
        Task<CollectionResult<TeacherViewModel>> GetAllTeacherViewModelAsync(CollectionRequest request);
        Task SaveTeacherAsync(TeacherViewModel viewModel);
    }
}
