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
        private readonly IDesignationService _designationService;

        public DesignationController(ApplicationDbContext context, IDesignationService designationService)
        {
            _context = context;
            _designationService = designationService;
        }

        [HttpGet("[action]")]
        public ActionResult<IEnumerable<Designation>> GetAllDesignations()
        {
            return _designationService.GetAllDesignations();
        }

        //api/Designation/GetDesignationById/1
        [HttpGet("[action]/{id}")]
        public ActionResult<Designation> GetDesignationById(int id)
        {
            return _designationService.GetDesignationById(id);
        }

        //api/Designation/GetDesignationByName/Web devloper
        [HttpGet("[action]/{name}")]
        public ActionResult<IEnumerable<Designation>> GetDesignationByName(string name)
        {
            return _designationService.GetDesignationByName(name);
        }

        [HttpPost("add")]
        public ActionResult<Designation> AddDesignation(Designation Designation)
        {
            int temp = _designationService.AddDesignation(Designation);
            if (temp > 0)
            {
                return CreatedAtAction(nameof(Designation), new { id = temp }, Designation);
            }
            else
            {
                return UnprocessableEntity("Designation already exist");
            }
        }

        [HttpPut("update")]
        public ActionResult<Designation> UpdateDesignation(Designation Designation)
        {
            var d = _designationService.UpdateDesignation(Designation);
            if (d != null)
            {
                return d;
            }
            else
            {
                return UnprocessableEntity("Designation does not exist");
            }
        }

        [HttpDelete("delete")]
        public bool DeleteDesignation(int id)
        {
            return _designationService.DeleteDesignation(id);
        }
    }
}
