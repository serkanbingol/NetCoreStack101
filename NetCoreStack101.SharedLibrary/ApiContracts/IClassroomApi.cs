using NetCoreStack.Contracts;
using NetCoreStack101.SharedLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreStack101.SharedLibrary.ApiContracts
{
    public interface IClassroomApi:IApiContract
    {

        Task<ClassroomViewModel> GetClassroomViewModelAsync(int studentId);
        Task<CollectionResult<ClassroomViewModel>> GetAllClassroomViewModelAsync(CollectionRequest request);
        Task SaveClassroomAsync(ClassroomViewModel viewModel);
    }
}
