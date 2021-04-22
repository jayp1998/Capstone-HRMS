using System.Collections.Generic;
using System.Linq;
using HRMS_Project.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Capstone_HRMS.Data.Services
{
    public class EmployeeService : IEmployeeService
    {       
        private readonly ApplicationDbContext _context;

        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public int AddEmployee(Employee emp)
        {
            if (!EmployeeExists(emp.Sin))
            {
                _context.Employee.Add(emp);
                _context.SaveChanges();

                return emp.EmployeeId;
            }
            else
            {
                return 0;
            }
        }

        public bool DeleteEmployee(int id)
        {
            var result = GetEmployeeById(id);
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

        public bool EmployeeExists(string sin)
        {
             return _context.Employee.Any(e => e.Sin == sin);
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employee.ToList();
        }

        public Employee GetEmployeeById(int Id)
        {
            return  _context.Employee.Where(e => e.EmployeeId == Id).FirstOrDefault();
        }

        public Employee GetEmployeeByName(string name)
        {
           return _context.Employee.Where(e => e.FirstName.Contains(name)).FirstOrDefault();
        }

        public Employee UpdateEmployee(Employee emp)
        {
           var result = GetEmployeeById(emp.EmployeeId);
            if (result != null)
            {
                 result.FirstName = emp.FirstName;
                 result.LastName = emp.LastName;
                 result.BirthDate = emp.BirthDate;
                 result.Gender = emp.Gender;
                 result.DesignationId = emp.DesignationId;
                 result.Sin = emp.Sin;
                 result.StreetAddress = emp.StreetAddress;
                 result.City = emp.City;
                 result.Province = emp.Province;
                 result.PostalCode = emp.PostalCode;
                 result.Country = emp.Country;
                 result.PhoneNumber = emp.PhoneNumber;
                 result.Email = emp.Email;
                 result.LinkedIn = emp.LinkedIn;
                 result.Twitter = emp.Twitter;
                 result.Facebook = emp.Facebook;
                 result.UserId = emp.UserId;

                _context.Entry(result).State = EntityState.Modified;
                _context.SaveChanges();

                return result;
            }
            else
            {
                return null;
            }
        }
    }
}