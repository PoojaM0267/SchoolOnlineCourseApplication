using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetCoursesAsync();

        Task<Course> GetCourseByIdAsync(long id);
    }
}
