using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Business.Repositories
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetCoursesManyAsync();

        Task<Course> GetCourseByIdAsync(Guid id);

    }
}
