using Cw10.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public void Delete(string index)
        {
            var student = _context.Student.ToList().Find(x => x.IndexNumber == index);

            _context.Student.ToList().Remove(student);
        }

        public IEnumerable<Student> GetStudents()
        {
            return _context.Student.ToList();
        }

        public void Put(string index, Student student)
        {
            var studentToUpdate = _context.Student.ToList().Select(x => x.IndexNumber == index);

         

        }
    }
}
