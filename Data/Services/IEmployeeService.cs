using HRMS_Project.Data.Models;
using System;
using System.Collections.Generic;

namespace Capstone_HRMS.Data.Services
{
    public interface IEmployeeService
    {
        long AddEmployee(Employee d);

        Employee UpdateEmployee(Employee d);

        bool DeleteEmployee(long id);

        List<Employee> GetAllEmployees();

        Employee GetEmployeeById(long id);

        bool EmployeeExists(string EmployeeName);

        Employee GetEmployeeByName(string name);
    }
}