using E_Learning_Platform.Interfaces;
using E_Learning_Platform.Models;

namespace E_Learning_Platform.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _repository;

        public CourseService(ICourseRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Course>> GetAllCoursesAsync()
        {
            return await _repository.GetAllCoursesAsync();
        }

        public async Task<Course?> GetCourseByIdAsync(int id)
        {
            return await _repository.GetCourseByIdAsync(id);
        }

        public async Task<Course> AddCourseAsync(Course course)
        {
            return await _repository.AddCourseAsync(course);
        }

        public async Task<Course?> UpdateCourseAsync(Course course)
        {
            return await _repository.UpdateCourseAsync(course);
        }

        public async Task<bool> DeleteCourseAsync(int id)
        {
            return await _repository.DeleteCourseAsync(id);
        }
    }
}