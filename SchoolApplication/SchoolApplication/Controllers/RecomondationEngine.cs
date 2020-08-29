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
    public class RecomondationService : ControllerBase
    {
        public string Get(Guid studentId)
        {
            //Will be taking input as student id and based on his past search/ behaviour
            // and behaviour of other students browsing history and enrollment of course 
            // results will be recomonded

            return string.Empty;
        }
    }
}
