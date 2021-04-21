using HRMS_Project.Data.Models;
using HRMS_Project.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignationController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IDepartmentService _departmentService;

        public DesignationController(ApplicationDbContext context, IDepartmentService departmentService)
        {
            _context = context;
            _departmentService = departmentService;
        }
    }
}
