using E_Learning_Platform.Interfaces;
using E_Learning_Platform.Models;

namespace E_Learning_Platform.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _repository;

        public DepartmentService(IDepartmentRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Department>> GetAllDepartmentsAsync()
        {
            return await _repository.GetAllDepartmentsAsync();
        }

        public async Task<Department?> GetDepartmentByIdAsync(int id)
        {
            return await _repository.GetDepartmentByIdAsync(id);
        }

        public async Task<Department> AddDepartmentAsync(Department department)
        {
            return await _repository.AddDepartmentAsync(department);
        }

        public async Task<Department?> UpdateDepartmentAsync(Department department)
        {
            return await _repository.UpdateDepartmentAsync(department);
        }

        public async Task<bool> DeleteDepartmentAsync(int id)
        {
            return await _repository.DeleteDepartmentAsync(id);
        }
    }
}
