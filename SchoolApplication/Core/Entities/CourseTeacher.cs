using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class CourseTeacher
    {
        public Guid CourseId { get; set; }
        public Guid TeacherId { get; set; }
    }
}
