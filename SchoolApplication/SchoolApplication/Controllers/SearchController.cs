using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {

        public string Get(string text)
        {
            //Full Text search on course module 
            return string.Empty;
        }

        public string ByTeacher(string text)
        {
            //Full text search on teacher name
            //By teacher
            return string.Empty;
        }

        public string BySkills(string skills)
        {
            //Full text search on Skills for all courses
            //Skills
            return string.Empty;
        }

    }
}
