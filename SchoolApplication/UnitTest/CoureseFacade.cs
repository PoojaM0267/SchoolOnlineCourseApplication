using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Facades.Course;
using Business.Repositories;
using Core.Entities;
using FluentAssertions;
using Moq;
using Xunit;

namespace UnitTest
{
    public class CourseFacade
    {
        private ICourseFacade _courseFacade;
        private Mock<ICourseRepository> _mockRepo;
        public CourseFacade()
        {
            _mockRepo = new Mock<ICourseRepository>();
            _courseFacade = new Business.Facades.Course.CourseFacade(_mockRepo.Object);
        }

        [Fact]
        public async Task ShouldGetAllCourses()
        {
            _mockRepo.Setup(r => r.GetCoursesManyAsync()).ReturnsAsync(SeedData());

            var response = await _courseFacade.GetCourseManyAsync();

            response.Count.Should().Be(3);
        }

        [Fact]
        public async Task ShouldGetOneWithProperId()
        {
            _mockRepo.Setup(r => r.GetCourseByIdAsync(It.IsAny<Guid>()))
                .ReturnsAsync(SeedData().SingleOrDefault(c=>c.Id==Guid.Parse("333CC06D-AC0F-4DCE-A93B-2D556A295641")));

            var response = await _courseFacade.GetCourseByIdAsync(Guid.Parse("333CC06D-AC0F-4DCE-A93B-2D556A295641"));

            response.Id.Should().Be(Guid.Parse("333CC06D-AC0F-4DCE-A93B-2D556A295641"));
            response.Name.Should().Be("Maths");
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
