using System.Collections.Generic;
using Capstone_HRMS.Data.Models;
using HRMS_Project.Data.Models;

namespace Capstone_HRMS.Data.Services
{
    public interface IEmployeeSalaryService
    {
         long AddEmployeeSalary(EmployeeSalary e);

        EmployeeSalary UpdateEmployeeSalary(EmployeeSalary e);

        bool DeleteEmployeeSalary(long id);

        List<EmployeeSalary> GetAllEmployeeSalary();

        EmployeeSalary GetEmployeeSalaryById(long id);

        bool EmployeeSalaryExists(EmployeeSalary e);

    }
}