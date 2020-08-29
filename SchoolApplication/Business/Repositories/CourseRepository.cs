using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly SchoolContext _context;

        public CourseRepository(SchoolContext context)
        {
            _context = context;
            _context.Courses.AddRange(SeedData());
        }

        public Task<List<Course>> GetCoursesManyAsync()
        {
            return _context.Courses.ToListAsync();
        }

        public Task<Course> GetCourseByIdAsync(Guid id)
        {
            return _context.Courses.SingleOrDefaultAsync(c => c.Id == id);
        }

        private List<Course> SeedData()
        {
            return new List<Course>()
            {
                new Course()
                {
                    Id = Guid.Parse("333CC06D-AC0F-4DCE-A93B-2D556A295640"),
                    Name = "Science",
                    Description = "Some Description"
                },
                new Course()
                {
                    Id = Guid.Parse("333CC06D-AC0F-4DCE-A93B-2D556A295641"),
                    Name = "Maths",
                    Description = "Some Description"
                },
                new Course()
                {
                    Id = Guid.Parse("333CC06D-AC0F-4DCE-A93B-2D556A295642"),
                    Name = "Physics",
                    Description = "Some Description"
                }
            };
        }
    }
}
