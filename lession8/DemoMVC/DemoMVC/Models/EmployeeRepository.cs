using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employees = new List<Employee>();

        public EmployeeRepository()
        {
            Employee employee = new Employee();
            employee.ID = 1;
            employee.FullName = "Nguyen";
            employee.Email = "jstrongnguyen@gmail.com";
            employee.Derpartment = "admin";
            employee.AvatarPath = "~/images/computer.jpg";
            employees.Add(employee);

            Employee employee1 = new Employee();
            employee1.ID = 2;
            employee1.FullName = "Huy";
            employee1.Email = "trandiephuy@gmail.com";
            employee1.Derpartment = "staff";
            employee1.AvatarPath = "~/images/computer.jpg";
            employees.Add(employee1);
        }

        public IEnumerable<Employee> Gets()
        {
            return employees;
        }
    }
}
