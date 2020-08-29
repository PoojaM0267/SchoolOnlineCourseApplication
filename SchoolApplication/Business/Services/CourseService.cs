using Business.IServices;
using Business.Repositories;
using Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Services
{
    public class CourseService: ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<List<Course>> GetAllCourses()
        {
            return await _courseRepository.GetCoursesAsync();
        }

        public async Task<Course> GetCourseById(long id)
        {
            return await _courseRepository.GetCourseByIdAsync(id);
        }


    }
}
