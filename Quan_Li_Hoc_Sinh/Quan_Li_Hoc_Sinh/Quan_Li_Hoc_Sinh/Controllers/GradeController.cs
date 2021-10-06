using Microsoft.AspNetCore.Mvc;
using Quan_Li_Hoc_Sinh.Models;
using Quan_Li_Hoc_Sinh.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quan_Li_Hoc_Sinh.Controllers
{
    public class GradeController : Controller
    {
        private readonly IGradeService gradeService;

        public GradeController(IGradeService gradeService)
        {
            this.gradeService = gradeService;
        }
        public async Task<IActionResult> Index()
        {
            List<Entities.Grade> list = await gradeService.GetListGrade();

            return View(list);
        }

        public async Task<IActionResult> Create(Grade createGrade)
        {
            if (ModelState.IsValid)
            {
                var newGrade = new Grade()
                {
                    GradeName = createGrade.GradeName,
                    IsDeleted = true
                };
                await gradeService.Create(newGrade);
                return RedirectToAction("Index", "Category");
            }
            return View();
        }
    }
}
