using System.Collections.Generic;
using System.Threading.Tasks;
using Business.IServices;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace SchoolApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        // GET: api/Course
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> Get()
        {
            return await _courseService.GetAllCourses();
        }

        // GET: api/Course/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<Course>> Get(int id)
        {
            return await _courseService.GetCourseById(id);
        }

        // POST: api/Course
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
