using LibraryCollege.Interfaces;
using LibraryCollege.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCollege.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentService _studentService;
        public StudentService(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void Insert(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
