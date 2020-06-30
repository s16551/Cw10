using Cw10.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw10.Services
{
    public interface IStudentDbService
    {
        public IEnumerable<Student> GetStudents();

        public IActionResult Delete(int id);

        public IActionResult Put(int id);
    }
}
