using NetCoreStack.Contracts;
using NetCoreStack.Data.Interfaces;
using NetCoreStack.Mvc.Extensions;
using NetCoreStack101.SharedLibrary.DbModels;
using NetCoreStack101.SharedLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreStack101.Domain.Managers
{
    public class StudentManager
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
                DateOfBirth=x.DateOfBirth,
                ClassroomId = x.ClassroomId,
                ClassroomName =x.ClassOfStudent.ClassroomName,
      

            });
            return query.ToCollectionResult(request);

        }

        public async Task<StudentViewModel> GetStudentViewModelAsync(int studentId)
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
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
                    Age = viewModel.Age,
                    DateOfBirth = viewModel.DateOfBirth,
                    ClassroomId = viewModel.ClassroomId,
                   // ClassOfStudent = classroomRepository.Select(x => x.Id == viewModel.ClassroomId).FirstOrDefault(),
                    ObjectState = ObjectState.Added

                };
                studentRepository.SaveAllChanges(model);
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
