using System.Collections.Generic;
using System.Linq;
using HRMS_Project.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Capstone_HRMS.Data.Services
{
    public class JobProfileDetailService : IJobProfileDetailService
    {
          private readonly ApplicationDbContext _context;

        public JobProfileDetailService(ApplicationDbContext context)
        {
            _context = context;
        }
        public long AddJobProfileDetail(JobProfileDetail d)
        {
            if (!JobProfileDetailExists(d.EmployeeId))
            {
                _context.JobProfileDetail.Add(d);
                _context.SaveChanges();

                return d.JobProfileDetailId;
            }
            else
            {
                return 0;
            }
        }

        public bool DeleteJobProfileDetail(long id)
        {
            var result = GetJobProfileDetailById(id);
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

         public bool JobProfileDetailExists(long id) 
        {
             return _context.JobProfileDetail.Any(j => j.EmployeeId == id);
        }

        public List<JobProfileDetail> GetAllJobProfileDetail()
        {
            return _context.JobProfileDetail.ToList();
        }

        public JobProfileDetail GetJobProfileDetailById(long id)
        {
            return  _context.JobProfileDetail.Where(e => e.JobProfileDetailId == id).FirstOrDefault();
        }

        public JobProfileDetail UpdateJobProfileDetail(JobProfileDetail jobp)
        {
           var result = GetJobProfileDetailById(jobp.JobProfileDetailId);
            if (result != null )
            {
                if (result.EmployeeId != jobp.EmployeeId && JobProfileDetailExists(jobp.EmployeeId) )
                {
                    return null;
                }
                else
                {
                    result.EmployeeId = jobp.EmployeeId;
                    result.HireDate = jobp.HireDate;
                    result.ProbationaryPeriodEndDate = jobp.ProbationaryPeriodEndDate;
                    result.ProbationaryPeriodStartDate = jobp.ProbationaryPeriodStartDate;
                    result.ReportsTo = jobp.ReportsTo;

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

        public List<JobProfileDetail> GetJobProfileDetailByEmpID(long id)
        {
            return  _context.JobProfileDetail.Where(e => e.EmployeeId == id).ToList();
        }

    }
}