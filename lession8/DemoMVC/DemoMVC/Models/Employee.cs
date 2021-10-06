using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Derpartment { get; set; }
        public string AvatarPath { get; set; }
    }
}
