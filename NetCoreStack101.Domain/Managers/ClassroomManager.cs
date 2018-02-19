using NetCoreStack.Contracts;
using NetCoreStack.Data.Interfaces;
using NetCoreStack.Mvc.Extensions;
using NetCoreStack101.SharedLibrary.ApiContracts;
using NetCoreStack101.SharedLibrary.DbModels;
using NetCoreStack101.SharedLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreStack101.Domain.Managers
{
    public class ClassroomManager : IClassroomApi
    {
        private readonly ISqlUnitOfWork _unitOfWork;
        public ClassroomManager(ISqlUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<CollectionResult<ClassroomViewModel>> GetAllClassroomViewModelAsync(CollectionRequest request)
        {
            await Task.CompletedTask;
            var classroomRepository = _unitOfWork.Repository<Classroom>();
            var query = classroomRepository.Select(x => new ClassroomViewModel
            {
                Id = x.Id,
                ClassroomName = x.ClassroomName,
                StudentCount = x.StudentCount
            });
            return query.ToCollectionResult(request);

        }

        public async Task<ClassroomViewModel> GetClassroomViewModelAsync(int classroomId)
        {
            await Task.CompletedTask;
            var classroomRepository = _unitOfWork.Repository<Classroom>();
            var viewModel = classroomRepository
                .Where(x => x.Id == classroomId)
                .Select(x => new ClassroomViewModel
                {
                    Id = x.Id,
                    ClassroomName = x.ClassroomName,
                    StudentCount = x.StudentCount
                }
            );
            return (ClassroomViewModel)viewModel;
        }

        public async Task SaveClassroomAsync(ClassroomViewModel viewModel)
        {
            await Task.CompletedTask;
            var classroomRepository = _unitOfWork.Repository<Classroom>();
            if (viewModel.IsNew)
            {
                var model = new Classroom
                {
                    ClassroomName = viewModel.ClassroomName,
                    ObjectState = ObjectState.Added

                };
                classroomRepository.SaveAllChanges(model);
            }
            else
            {
                var model = classroomRepository.Single(x => x.Id == viewModel.Id);

                model.ClassroomName = viewModel.ClassroomName;
                model.ObjectState = ObjectState.Modified;

                classroomRepository.SaveAllChanges(model);
            }


        }
    }
}
