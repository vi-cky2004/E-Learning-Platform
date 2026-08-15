using E_Learning_Platform.Data;
using E_Learning_Platform.Interfaces;
using E_Learning_Platform.Models;
using Microsoft.EntityFrameworkCore;
namespace E_Learning_Platform.Repository
{
    public class DepartmentRepository:IDepartmentRepository
    {
        private readonly AppDbContext _context;

        public DepartmentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Department>> GetAllDepartmentsAsync()
        {
            return await _context.Departments.ToListAsync();
        }

        public async Task<Department?> GetDepartmentByIdAsync(int id)
        {
            return await _context.Departments.FindAsync(id);
        }

        public async Task<Department> AddDepartmentAsync(Department department)
        {
            _context.Departments.Add(department);
            await _context.SaveChangesAsync();
            return department;
        }

        public async Task<Department?> UpdateDepartmentAsync(Department department)
        {
            var existingDepartment = await _context.Departments.FindAsync(department.DepartmentId);

            if (existingDepartment == null)
                return null;

            existingDepartment.DepartmentName = department.DepartmentName;

            await _context.SaveChangesAsync();

            return existingDepartment;
        }

        public async Task<bool> DeleteDepartmentAsync(int id)
        {
            var department = await _context.Departments.FindAsync(id);

            if (department == null)
                return false;

            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
