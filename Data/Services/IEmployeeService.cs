using HRMS_Project.Data.Models;
using System;
using System.Collections.Generic;

namespace Capstone_HRMS.Data.Services
{
    public interface IEmployeeService
    {
        int AddEmployee(Employee d);

        Employee UpdateEmployee(Employee d);

        bool DeleteEmployee(int id);

        List<Employee> GetAllEmployees();

        Employee GetEmployeeById(int Id);

        bool EmployeeExists(string EmployeeName);

        Employee GetEmployeeByName(string name);
    }
}