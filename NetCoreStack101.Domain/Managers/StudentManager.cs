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
    public class StudentManager:IStudentApi
    {

        private readonly ISqlUnitOfWork _unitOfWork;
        public StudentManager(ISqlUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<CollectionResult<StudentViewModel>> GetAllStudentViewModelAsync(CollectionRequest request)
        {
            await Task.CompletedTask;
            var studentRepository = _unitOfWork.Repository<Student>();
            var query = studentRepository.Select(x => new StudentViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                Age = x.Age,
                Email=x.Email,
                DateOfBirth=x.DateOfBirth,
      

            });
            return query.ToCollectionResult(request);

        }

        public async Task<StudentViewModel> GetStudentViewModelAsync(int studentId)
        {
            await Task.CompletedTask;
            var studentRepository = _unitOfWork.Repository<Student>();     
            var viewModel = studentRepository
                .Where(x=>x.Id==studentId)
                .Select(x => new StudentViewModel {

                    Id = x.Id,
                    Name = x.Name,
                    Surname = x.Surname,
                    Age = x.Age,
                    Email = x.Email,
                    DateOfBirth = x.DateOfBirth,
                }
            );
            return (StudentViewModel)viewModel;
        }

        public async Task SaveStudentAsync(StudentViewModel viewModel)
        {
            await Task.CompletedTask;
            var studentRepository = _unitOfWork.Repository<Student>();
            var classroomRepository=_unitOfWork.Repository<Classroom>();
            if (viewModel.IsNew)
            {
                var model = new Student
                {
                    Name = viewModel.Name,
                    Surname = viewModel.Surname,
                    Email = viewModel.Email,
                    Age = DateTime.Now.Year - viewModel.DateOfBirth.Year,
                    DateOfBirth = viewModel.DateOfBirth,                
                    ObjectState = ObjectState.Added

                };
                studentRepository.SaveAllChanges(model);
            }
            else
            {
                var model = studentRepository.Single(x => x.Id == viewModel.Id);
                model.Name = viewModel.Name;
                model.Surname = viewModel.Surname;
                model.Email = viewModel.Email;
                model.Age = DateTime.Now.Year - viewModel.DateOfBirth.Year;
                model.DateOfBirth = viewModel.DateOfBirth;
                model.ObjectState = ObjectState.Modified;

                studentRepository.SaveAllChanges(model);
            }


        }
    }
}
