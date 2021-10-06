using Microsoft.AspNetCore.Mvc;
using Quan_Li_Hoc_Sinh.Models;
using Quan_Li_Hoc_Sinh.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quan_Li_Hoc_Sinh.Controllers
{
    public class StudentController : Controller
    {
        private static int gradeId;
        private static string gradeName;
        private IStudentService studentService { get; set; }

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }
        public async Task<IActionResult> Index()
        {
            List<Entities.Student> list = await studentService.GetListStudent();

            return View(list);
        }
        //Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.GradeName = gradeName;
            ViewBag.CategoryId = gradeId;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student createStudent)
        {
            if (ModelState.IsValid)
            {
                var newStudent = new Student()
                {
                    BookName = createStudent.BookName,
                    Dob = createStudent.Dob,
                    PublishYear = createStudent.PublishYear,
                    IsDeleted = true,
                    Gender = true,
                    CategoryId = gradeId


                };
                await studentService.Create(newStudent);
                return RedirectToAction("Index", "Student", new { graid = gradeId });
            }
            ViewBag.GradeName = gradeName;
            ViewBag.CategoryId = gradeId;
            return View();
        }
    }
}
