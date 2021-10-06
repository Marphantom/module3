using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeZone.Models;

namespace TimeZone.Services
{
    
    public class EmployeeServices : IEmployeeServices
    {
        private static List<Employee> employees = new List<Employee>();
        public bool Create(Employee employee)
        {
            try
            {
                employee.EmployeeID = employees.Count > 0 ? employees.Max(s => s.EmployeeID) + 1 : 1;
                employees.Add(employee);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Employee> Gets()
        {
            return employees;
        }
    }
}
