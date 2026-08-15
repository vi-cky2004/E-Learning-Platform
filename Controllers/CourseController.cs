using E_Learning_Platform.Interfaces;
using E_Learning_Platform.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _service;

        public CourseController(ICourseService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCourses()
        {
            var courses = await _service.GetAllCoursesAsync();
            return Ok(courses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourseById(int id)
        {
            var course = await _service.GetCourseByIdAsync(id);

            if (course == null)
                return NotFound();

            return Ok(course);
        }

        [HttpPost]
        public async Task<IActionResult> AddCourse(Course course)
        {
            var result = await _service.AddCourseAsync(course);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCourse(Course course)
        {
            var result = await _service.UpdateCourseAsync(course);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            var result = await _service.DeleteCourseAsync(id);

            if (!result)
                return NotFound();

            return Ok("Course Deleted Successfully");
        }
    }
}
