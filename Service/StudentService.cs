using E_Learning_Platform.Interfaces;
using E_Learning_Platform.Models;

namespace E_Learning_Platform.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _repository.GetAllStudentsAsync();
        }

        public async Task<Student?> GetStudentByIdAsync(int id)
        {
            return await _repository.GetStudentByIdAsync(id);
        }

        public async Task<Student> AddStudentAsync(Student student)
        {
            return await _repository.AddStudentAsync(student);
        }

        public async Task<Student?> UpdateStudentAsync(Student student)
        {
            return await _repository.UpdateStudentAsync(student);
        }

        public async Task<bool> DeleteStudentAsync(int id)
        {
            return await _repository.DeleteStudentAsync(id);
        }
    }
}