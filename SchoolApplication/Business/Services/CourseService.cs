using Business.IServices;
using Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class CourseService: ICourseService
    {
        private SchoolContext _schoolContext;

        public CourseService(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }

        public List<Course> GetAllCourses()
        {
            return AddCourseData();
        }

        private List<Course> AddCourseData()
        {
           _schoolContext.Courses.AddRange(
                new Course()
                {
                    Id = new System.Guid(),
                    Name = "Web Technologies",
                    Description = "All about web technologies."
                },
                new Course()
                {
                    Id = new System.Guid(),
                    Name = "Basics of Computer",
                    Description = "All about computer basics."
                },
                new Course()
                {
                    Id = new System.Guid(),
                    Name = "C# Programming",
                    Description = "All about C# Programming."
                },
                new Course()
                {
                    Id = new System.Guid(),
                    Name = "Java Programming",
                    Description = "All about Java Programming."
                },
                new Course()
                {
                    Id = new System.Guid(),
                    Name = "Front end Development",
                    Description = "All about front end (UI/UX) development."
                }
            );

            _schoolContext.SaveChanges();

            return _schoolContext.Courses.ToList();
        }
    }
}
