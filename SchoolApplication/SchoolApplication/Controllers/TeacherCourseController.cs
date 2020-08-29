using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Facades.Course;
using Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherCourseController : ControllerBase
    {
        private readonly ICourseFacade _courseFacade;
        public TeacherCourseController(ICourseFacade courseFacade)
        {
            _courseFacade = courseFacade;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _courseFacade.GetCourseManyAsync();
            var apiResponse = new ApiResponse()
            {
                Courses = result
            };

            return Ok(apiResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne(Guid id)
        {
            var result = await _courseFacade.GetCourseByIdAsync(id);
            

            return Ok(result);
        }
    }
}
