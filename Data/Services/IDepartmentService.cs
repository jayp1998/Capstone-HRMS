using HRMS_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Project.Data.Services
{
    public interface IDepartmentService
    {
        int AddDepartment(string name);

        Department UpdateDepartment(Department d);

        bool DeleteDepartment(int id);

        List<Department> GetAllDepartments();

        Department GetDepartmentById(int Id);

        bool DepartmentExists(string DepartmentName);

        Department GetDepartmentByName(string name);
    }
}
