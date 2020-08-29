using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {

        [HttpGet]
        public decimal Course(Guid CourseId)
        {
            return 0;
        }

        [HttpPost]
        public HttpStatusCode Course(object CourseObject)
        {
            return HttpStatusCode.Accepted;
        }
    }
}
