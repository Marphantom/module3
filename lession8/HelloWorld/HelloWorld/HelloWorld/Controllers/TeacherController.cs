using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Controllers
{
    public class TeacherController : Controller
    {
        List<Teacher> teachers = new List<Teacher>();
       
        public IActionResult Index()
        {
            var teach1 = new Teacher()
            {
                TeacherId = 1,
                TeacherName = "Thi",
                Gender = "Nữ",
                Adress = "Huế"
            };

            var teach2 = new Teacher()
            {
                TeacherId = 2,
                TeacherName = "Nguyên",
                Gender = "Nam",
                Adress = "Huế"
            };
            teachers.Add(teach1);
            teachers.Add(teach2);
            return View(teachers);
        }

    }
}
