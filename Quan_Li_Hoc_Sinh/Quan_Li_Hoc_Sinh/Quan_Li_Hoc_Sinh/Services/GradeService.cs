using Microsoft.EntityFrameworkCore;
using Quan_Li_Hoc_Sinh.DBContexts;
using Quan_Li_Hoc_Sinh.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quan_Li_Hoc_Sinh.Services
{
    public class GradeService : IGradeService
    {
        private readonly SchoolDBContext context;
        public GradeService(SchoolDBContext context)
        {
            this.context = context;
        }

        public async Task<Grade> Create(Grade createGrade)
        {
            try
            {
                context.Add(createGrade);
                var gradid = await context.SaveChangesAsync();
                createGrade.GradeId = gradid;
                return createGrade;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Grade> GetGradeById(int gradeId)
        {
            return await context.grades.Include(b => b.Students).FirstOrDefaultAsync(c => c.GradeId == gradeId);
        }

        public async Task<List<Grade>> GetListGrade()
        {
            return await context.grades.Include(b => b.Students).Where(c => c.IsDeleted == true).ToListAsync();
        }
    }
}
