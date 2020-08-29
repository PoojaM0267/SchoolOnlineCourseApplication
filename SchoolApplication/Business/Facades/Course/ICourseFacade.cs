using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Facades.Course
{
    public interface ICourseFacade
    {
        Task<List<Core.Entities.Course>> GetCourseManyAsync();
        Task<Core.Entities.Course> GetCourseByIdAsync(Guid id);
    }
}
