
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly SchoolContext _context;

        public CourseRepository(SchoolContext context)
        {
            _context = context;

            AddCourseData();
        }

        public Task<List<Course>> GetCoursesAsync()
        {
            return _context.Courses.ToListAsync();
        }

        public Task<Course> GetCourseByIdAsync(long id)
        {
            return _context.Courses.SingleOrDefaultAsync(c => c.Id == id);
        }

        private void AddCourseData()
        {
            _context.Courses.AddRange(SeedData());
            _context.SaveChangesAsync();
        }

        private List<Course> SeedData()
        {
            return new List<Course>()
            {
                new Course()
                {
                    Id = 100,
                    Name = "Web Technologies",
                    Description = "All about web technologies."
                },
                new Course()
                {
                    Id = 101,
                    Name = "Basics of Computer",
                    Description = "All about computer basics."
                },
                new Course()
                {
                    Id = 102,
                    Name = "C# Programming",
                    Description = "All about C# Programming."
                },
                new Course()
                {
                    Id = 103,
                    Name = "Java Programming",
                    Description = "All about Java Programming."
                },
                new Course()
                {
                    Id = 104,
                    Name = "Front end Development",
                    Description = "All about front end (UI/UX) development."
                }
            };
        }
    }
}
