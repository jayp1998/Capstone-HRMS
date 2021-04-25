using System.Collections.Generic;
using System.Linq;
using HRMS_Project.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Capstone_HRMS.Data.Services
{
    public class EducationDetailService : IEducationDetailService
    {
          private readonly ApplicationDbContext _context;

        public EducationDetailService(ApplicationDbContext context)
        {
            _context = context;
        }
        public int AddEducationDetail(EducationDetail d)
        {
            if (!EducationDetailExists(d.EmployeeId))
            {
                _context.EducationDetail.Add(d);
                _context.SaveChanges();

                return d.EducationDetailId;
            }
            else
            {
                return 0;
            }
        }

        public bool DeleteEducationDetail(int id)
        {
            var result = GetEducationDetailById(id);
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

         public bool EducationDetailExists(long id) 
        {
             return _context.EducationDetail.Any(e => e.EmployeeId == id);
        }

        public List<EducationDetail> GetAllEducationDetail()
        {
            return _context.EducationDetail.ToList();
        }

        public EducationDetail GetEducationDetailById(int id)
        {
            return  _context.EducationDetail.Where(e => e.EducationDetailId == id).FirstOrDefault();
        }


        public EducationDetail UpdateEducationDetail(EducationDetail edu)
        {
           var result = GetEducationDetailById(edu.EducationDetailId);
            if (result != null )
            {
                if (result.EmployeeId != edu.EmployeeId && EducationDetailExists(edu.EmployeeId) )
                {
                    return null;
                }
                else
                {
                    result.EmployeeId = edu.EmployeeId;
                    result.DegreeName = edu.DegreeName;
                    result.StartDate = edu.StartDate;
                    result.EndDate = edu.EndDate;
                    result.Gpa = edu.Gpa;
                    result.UniversityName = edu.UniversityName;
                    result.Specialization  = edu.Specialization;

                    _context.Entry(result).State = EntityState.Modified;
                    _context.SaveChanges();

                    return result;
                }
            }
            else
            {
                return null;
            }
        }

        public List<EducationDetail> GetEducationDetailByEmpID(long id)
        {
            return  _context.EducationDetail.Where(e => e.EmployeeId == id).ToList();
        }

    }
}