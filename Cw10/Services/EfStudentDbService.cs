using Cw10.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw10.Services
{
    public class EfStudentDbService : IStudentDbService
    {
        private readonly SampleDbContext _context;

        public EfStudentDbService(SampleDbContext context)
        {
            _context = context;
        }
        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudents()
        {
            return _context.Student.ToList();
        }

        public IActionResult Put(int id)
        {
            throw new NotImplementedException();
        }
    }
}
