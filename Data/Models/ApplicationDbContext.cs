using Capstone_HRMS.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Project.Data.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Tokens> Tokens { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EducationDetail> EducationDetail { get; set; }
        public DbSet<JobDetail> JobDetail { get; set; }
        public DbSet<LeaveApplication> LeaveApplication { get; set; }
        public DbSet<LeaveStatus> LeaveStatus { get; set; }
        public DbSet<LeaveType> LeaveType { get; set; }
        public DbSet<Holidays> Holidays { get; set; }
        public DbSet<Attendance> Attendance { get; set; }

    }
}
