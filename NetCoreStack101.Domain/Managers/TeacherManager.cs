using NetCoreStack.Contracts;
using NetCoreStack101.SharedLibrary.ApiContracts;
using NetCoreStack101.SharedLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreStack101.Domain.Managers
{
    public class TeacherManager : ITeacherApi
    {
        public Task<CollectionResult<TeacherViewModel>> GetAllTeacherViewModelAsync(CollectionRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<TeacherViewModel> GetTeacherViewModelAsync(int studentId)
        {
            throw new NotImplementedException();
        }

        public Task SaveTeacherAsync(TeacherViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
