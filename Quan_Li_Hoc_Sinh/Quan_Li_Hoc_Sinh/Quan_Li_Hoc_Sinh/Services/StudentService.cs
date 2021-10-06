using Microsoft.EntityFrameworkCore;
using Quan_Li_Hoc_Sinh.DBContexts;
using Quan_Li_Hoc_Sinh.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quan_Li_Hoc_Sinh.Services
{
    public class StudentService : IStudentService
    {
        private readonly SchoolDBContext context;
        public StudentService(SchoolDBContext context)
        {
            this.context = context;
        }

        public async Task<List<Student>> GetListStudent()
        {
            return await context.students.Include(b => b.grade).ToListAsync();
        }

        public async Task<Student> GetStudentById(int studentId)
        {
            return await context.students.Include(c => c.grade).FirstOrDefaultAsync(b => b.StudentId == studentId);
        }
        //Create
        public async Task<Student> Create(Student createStudent)
        {
            try
            {
                context.Add(createStudent);
                var studentId = await context.SaveChangesAsync();
                createStudent.StudentId = studentId;
                return createStudent;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task Create(Models.Student newStudent)
        {
            throw new NotImplementedException();
        }
    }
}
