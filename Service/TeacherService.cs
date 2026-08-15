using E_Learning_Platform.Interfaces;
using E_Learning_Platform.Models;

namespace E_Learning_Platform.Service
{
    
        public class TeacherService : ITeacherService
        {
            private readonly ITeacherRepository _repository;

            public TeacherService(ITeacherRepository repository)
            {
                _repository = repository;
            }

            public async Task<IEnumerable<Teacher>> GetAllTeachersAsync()
            {
                return await _repository.GetAllTeachersAsync();
            }

            public async Task<Teacher?> GetTeacherByIdAsync(int id)
            {
                return await _repository.GetTeacherByIdAsync(id);
            }

            public async Task<Teacher> AddTeacherAsync(Teacher teacher)
            {
                return await _repository.AddTeacherAsync(teacher);
            }

            public async Task<Teacher?> UpdateTeacherAsync(Teacher teacher)
            {
                return await _repository.UpdateTeacherAsync(teacher);
            }

            public async Task<bool> DeleteTeacherAsync(int id)
            {
                return await _repository.DeleteTeacherAsync(id);
            }
        }
    }

