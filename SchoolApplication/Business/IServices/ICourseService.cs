using Core.Entities;
using System.Collections.Generic;

namespace Business.IServices
{
    public interface ICourseService
    {
        List<Course> GetAllCourses();
    }
}
