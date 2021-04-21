using HRMS_Project.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static HRMS_Project.Data.Constants.enums;

namespace HRMS_Project.Data.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly ApplicationDbContext _context;

        public DepartmentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public int AddDepartment(string name)
        {
            if (!DepartmentExists(name))
            {
                var d = new Department()
                {
                    DepartmentName = name
                };
                _context.Department.Add(d);
                _context.SaveChanges();

                return d.DepartmentId;
            }
            else
            {
                return 0;
            }
        }

        public Department UpdateDepartment(Department d)
        {
            var result = GetDepartmentById(d.DepartmentId);
            if (result != null)
            {
                result.DepartmentName = d.DepartmentName;

                _context.Entry(result).State = EntityState.Modified;
                _context.SaveChanges();

                return result;
            }
            else
            {
                return null;
            }
        }

        public bool DeleteDepartment(int id)
        {
            var result = GetDepartmentById(id);
            if (result != null)
            {
                _context.Entry(result).State = EntityState.Deleted;
                _context.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Department> GetAllDepartments()
        {
            return _context.Department.ToList();
        }

        public bool DepartmentExists(string DepartmentName)
        {
            return _context.Department.Any(e => e.DepartmentName == DepartmentName);
        }

        public Department GetDepartmentById(int Id)
        {
            Department result = _context.Department.Where(e => e.DepartmentId == Id).FirstOrDefault();
            return result;
        }

        public Department GetDepartmentByName(string name)
        {
            Department result = _context.Department.Where(e => e.DepartmentName.Contains(name)).FirstOrDefault();

            return result;
        }
    }
}
