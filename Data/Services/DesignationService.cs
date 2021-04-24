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
    public class DesignationService : IDesignationService
    {
        private readonly ApplicationDbContext _context;

        public DesignationService(ApplicationDbContext context)
        {
            _context = context;
        }

        public int AddDesignation(Designation d)
        {
            if (!DesignationExists(d))
            {
                _context.Designation.Add(d);
                _context.SaveChanges();

                return d.DesignationId;
            }
            else
            {
                return 0;
            }
        }

        public Designation UpdateDesignation(Designation d)
        {
            var result = GetDesignationById(d.DesignationId);
            if (result != null)
            {
                 if (result.DesignationName != d.DesignationName || result.DepartmentId != d.DepartmentId  && DesignationExists(d))
                {
                    return null;
                }
                result.DesignationName = d.DesignationName;

                _context.Entry(result).State = EntityState.Modified;
                _context.SaveChanges();

                return result;
            }
            else
            {
                return null;
            }
        }

        public bool DeleteDesignation(int id)
        {
            var result = GetDesignationById(id);
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

        public List<Designation> GetAllDesignations()
        {
            return _context.Designation.ToList();
        }

        public bool DesignationExists(Designation d)
        {
            return _context.Designation.Any(p => p.DesignationName == d.DesignationName && p.DepartmentId == d.DepartmentId);
        }

        public Designation GetDesignationById(int Id)
        {
            Designation result = _context.Designation.Where(d => d.DesignationId == Id).FirstOrDefault();
            return result;
        }

        public List<Designation> GetDesignationByName(string name)
        {
            return _context.Designation.Where(d => d.DesignationName.Contains(name)).ToList();
        }
    }
}
