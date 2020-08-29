using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;

namespace SchoolApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentsController : ControllerBase
    {
        [HttpGet]
        public HttpResponseMessage Assignments(Guid CourseId)
        {
            //Returns the pre stored assignment provided by teacher for a particular course 

            return  new HttpResponseMessage();
        }

        [HttpPost("/{courseId}/{studentId}")]
        public Guid Assignments(Guid courseId , Guid studentId ,[FromBody] object assignmentFile)
        {
            //Uploaded Assignment can be store in Block storage with Id path of that in DB 
            // which will be used for evaluating the assignment
            
            return Guid.NewGuid(); // New Assignment GUID 
            //TODO: IT can be refined to send complete url and assignment ID in object so student can 
            //latter check its assignment details
        }
    }
}
