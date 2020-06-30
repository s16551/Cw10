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

        public void Delete(string index);

        public void Put(string index, Student student);
    }
}
