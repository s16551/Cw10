using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw10.Models;
using Cw10.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cw10.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentDbService _context;

        public StudentsController(IStudentDbService context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_context.GetStudents());
        }

        [HttpPut("{id}")]
        public void Put(string index, [FromBody] Student student)
        {
            _context.Put(index, student);

        }
        [HttpDelete("{id}")]
        public void Delete(string index)
        {
            _context.Delete(index);
        }
            


    }
}
