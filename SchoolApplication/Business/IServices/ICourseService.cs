using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.IServices
{
    public interface ICourseService
    {
        Task<List<Course>> GetAllCourses();

        Task<Course> GetCourseById(long id);
    }
}
