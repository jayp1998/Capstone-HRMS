using System.Collections.Generic;
using System.Linq;
using Capstone_HRMS.Data.Models;
using HRMS_Project.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Capstone_HRMS.Data.Services
{
    public class EmployeeSalaryService: IEmployeeSalaryService
    {       
        private readonly ApplicationDbContext _context;

        public EmployeeSalaryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public long AddEmployeeSalary(EmployeeSalary emp)
        {
            if (!EmployeeSalaryExists(emp))
            {
                _context.EmployeeSalary.Add(emp);
                _context.SaveChanges();

                return emp.EmployeeSalaryId;
            }
            else
            {
                return 0;
            }
        }

        public bool DeleteEmployeeSalary(long id)
        {
            var result = GetEmployeeSalaryById(id);
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

        public bool EmployeeSalaryExists(EmployeeSalary emp)
        {
             return _context.EmployeeSalary.Any(e => e.EmployeeId == emp.EmployeeId && e.Period.Month ==  emp.Period.Month && e.Period.Year ==  emp.Period.Year);
        }

        public List<EmployeeSalary> GetAllEmployeeSalary()
        {
            return _context.EmployeeSalary.ToList();
        }

        public EmployeeSalary GetEmployeeSalaryById(long id)
        {
            return  _context.EmployeeSalary.Where(e => e.EmployeeSalaryId == id).FirstOrDefault();
        }

        public EmployeeSalary UpdateEmployeeSalary(EmployeeSalary emp)
        {
           var result = GetEmployeeSalaryById(emp.EmployeeSalaryId);
            if (result != null)
            {
                if ((result.EmployeeId != emp.EmployeeId ||  result.Period.Month != emp.Period.Month || result.Period.Year != emp.Period.Year ) && EmployeeSalaryExists(emp))
                {
                    return null;
                }
                 result.EmployeeId = emp.EmployeeId;
                 result.NetSalary = emp.NetSalary;
                 result.Basic = emp.Basic;
                 result.DA = emp.DA;
                 result.HRA = emp.HRA;
                 result.Conveyance = emp.Conveyance;
                 result.Allowance = emp.Allowance;
                 result.MedicalAllowance = emp.MedicalAllowance;
                 result.OthersEarnings = emp.OthersEarnings;
                 result.TDS = emp.TDS;
                 result.ESI = emp.ESI;
                 result.PF = emp.PF;
                 result.Leave = emp.Leave;
                 result.ProfTax = emp.ProfTax;
                 result.LabourWelfare = emp.LabourWelfare;
                 result.Fund = emp.Fund;
                 result.OthersDeductions = emp.OthersDeductions;
                 result.Period = emp.Period;

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