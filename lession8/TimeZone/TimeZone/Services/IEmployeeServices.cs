using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeZone.Models;

namespace TimeZone.Services
{
    public interface IEmployeeServices
    {
        List<Employee> Gets();
        bool Create(Employee employee);
    }
}
