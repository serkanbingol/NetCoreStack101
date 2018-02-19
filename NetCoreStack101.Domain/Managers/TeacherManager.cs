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
    public class TeacherManager : ITeacherApi
    {

        private readonly ISqlUnitOfWork _unitOfWork;
        public TeacherManager(ISqlUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<CollectionResult<TeacherViewModel>> GetAllTeacherViewModelAsync(CollectionRequest request)
        {
            await Task.CompletedTask;
            var teacherRepository = _unitOfWork.Repository<Teacher>();
            var query = teacherRepository.Select(x => new TeacherViewModel
            {
                Id = x.Id,
                TeacherName = x.TeacherName,
                TeacherSurname = x.TeacherSurname,
                Age = x.Age,
                DateOfBirth = x.DateOfBirth,
         
            });
            return query.ToCollectionResult(request);
        }

        public async Task<TeacherViewModel> GetTeacherViewModelAsync(int teacherId)
        {
            await Task.CompletedTask;
            var teacherRepository = _unitOfWork.Repository<Teacher>();
            var viewModel = teacherRepository
                .Where(x => x.Id == teacherId)
                .Select(x => new TeacherViewModel
                {

                    Id = x.Id,
                    TeacherName = x.TeacherName,
                    TeacherSurname = x.TeacherSurname,
                    Age = x.Age,
                    DateOfBirth = x.DateOfBirth,
                }
            );
            return (TeacherViewModel)viewModel;
        }

        public async Task SaveTeacherAsync(TeacherViewModel viewModel)
        {
            await Task.CompletedTask;
            var teacherRepository = _unitOfWork.Repository<Teacher>();
            if (viewModel.IsNew)
            {
                var model = new Teacher
                {
                    TeacherName = viewModel.TeacherName,
                    TeacherSurname = viewModel.TeacherSurname,
                    Email = viewModel.Email,
                    Age = DateTime.Now.Year - viewModel.DateOfBirth.Year,
                    DateOfBirth = viewModel.DateOfBirth,
                    ObjectState = ObjectState.Added

                };
                teacherRepository.SaveAllChanges(model);
            }
            else
            {
                var model = teacherRepository.Single(x => x.Id == viewModel.Id);

                model.TeacherName = viewModel.TeacherName;
                model.TeacherSurname = viewModel.TeacherSurname;
                model.Email = viewModel.Email;
                model.Age = DateTime.Now.Year - viewModel.DateOfBirth.Year;
                model.DateOfBirth = viewModel.DateOfBirth;
                model.ObjectState = ObjectState.Modified;

                teacherRepository.SaveAllChanges(model);
            }
        }
    }
}
