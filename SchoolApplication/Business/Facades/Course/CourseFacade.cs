using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Repositories;

namespace Business.Facades.Course
{
    public class CourseFacade : ICourseFacade
    {
        private readonly ICourseRepository _courseRepository;

        public CourseFacade(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public Task<List<Core.Entities.Course>> GetCourseManyAsync()
        {
            return _courseRepository.GetCoursesManyAsync();
        }

        public Task<Core.Entities.Course> GetCourseByIdAsync(Guid id)
        {
            return _courseRepository.GetCourseByIdAsync(id);
        }
    }
}
