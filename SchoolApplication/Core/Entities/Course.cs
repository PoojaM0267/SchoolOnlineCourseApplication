using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
