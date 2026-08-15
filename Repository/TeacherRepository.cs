using E_Learning_Platform.Data;
using E_Learning_Platform.Interfaces;
using Microsoft.EntityFrameworkCore;
using E_Learning_Platform.Models;

namespace E_Learning_Platform.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly AppDbContext _context;

        public TeacherRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Teacher>> GetAllTeachersAsync()
        {
            return await _context.Teachers.ToListAsync();
        }

        public async Task<Teacher?> GetTeacherByIdAsync(int id)
        {
            return await _context.Teachers.FindAsync(id);
        }

        public async Task<Teacher> AddTeacherAsync(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            await _context.SaveChangesAsync();
            return teacher;
        }

        public async Task<Teacher?> UpdateTeacherAsync(Teacher teacher)
        {
            var existingTeacher = await _context.Teachers.FindAsync(teacher.TeacherId);

            if (existingTeacher == null)
                return null;

            _context.Teachers.Update(teacher);
            await _context.SaveChangesAsync();

            return teacher;
        }

        public async Task<bool> DeleteTeacherAsync(int id)
        {
            var teacher = await _context.Teachers.FindAsync(id);

            if (teacher == null)
                return false;

            _context.Teachers.Remove(teacher);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
