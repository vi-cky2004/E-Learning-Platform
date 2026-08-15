using E_Learning_Platform.Data;
using E_Learning_Platform.Interfaces;
using E_Learning_Platform.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Learning_Platform.Repository
{
   
        public class CourseRepository : ICourseRepository
        {
            private readonly AppDbContext _context;

            public CourseRepository(AppDbContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<Course>> GetAllCoursesAsync()
            {
                return await _context.Courses.ToListAsync();
            }

            public async Task<Course?> GetCourseByIdAsync(int id)
            {
                return await _context.Courses.FindAsync(id);
            }

            public async Task<Course> AddCourseAsync(Course course)
            {
                _context.Courses.Add(course);
                await _context.SaveChangesAsync();
                return course;
            }

            public async Task<Course?> UpdateCourseAsync(Course course)
            {
            var existingCourse = await _context.Courses.FindAsync(course.CourseId);

            if (existingCourse == null)
                return null;

            _context.Courses.Update(course);
            await _context.SaveChangesAsync();

            return course;
        }

            public async Task<bool> DeleteCourseAsync(int id)
            {
                var course = await _context.Courses.FindAsync(id);

                if (course == null)
                    return false;

                _context.Courses.Remove(course);
                await _context.SaveChangesAsync();

                return true;
            }
        }
}
