using E_Learning_Platform.Interfaces;
using E_Learning_Platform.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _service;

        public TeacherController(ITeacherService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTeachers()
        {
            return Ok(await _service.GetAllTeachersAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeacherById(int id)
        {
            var teacher = await _service.GetTeacherByIdAsync(id);

            if (teacher == null)
                return NotFound();

            return Ok(teacher);
        }

        [HttpPost]
        public async Task<IActionResult> AddTeacher(Teacher teacher)
        {
            return Ok(await _service.AddTeacherAsync(teacher));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTeacher(Teacher teacher)
        {
            var result = await _service.UpdateTeacherAsync(teacher);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeacher(int id)
        {
            var result = await _service.DeleteTeacherAsync(id);

            if (!result)
                return NotFound();

            return Ok("Teacher Deleted Successfully");
        }
    }
}
