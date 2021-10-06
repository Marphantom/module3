
using Quan_Li_Hoc_Sinh.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quan_Li_Hoc_Sinh.Services
{
    public interface IStudentService
    {

        Task<List<Student>> GetListStudent();
        Task<Student> GetStudentById(int studentId);

        //Create
        Task<Student> Create(Student createStudent);
        Task Create(Models.Student newStudent);
    }
}
