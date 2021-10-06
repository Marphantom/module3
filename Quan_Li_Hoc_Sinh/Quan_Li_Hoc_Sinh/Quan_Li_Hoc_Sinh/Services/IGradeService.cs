using Quan_Li_Hoc_Sinh.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quan_Li_Hoc_Sinh.Services
{
    public interface IGradeService
    {
        Task<List<Grade>> GetListGrade();
        Task<Grade> GetGradeById(int gradeId);
        Task<Grade> Create(Grade createGrade);
    }
}
