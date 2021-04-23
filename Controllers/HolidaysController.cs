using Capstone_HRMS.Data.Services;
using HRMS_Project.Data.Models;
using HRMS_Project.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Capstone_HRMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HolidaysController : ControllerBase
    {
        
        private readonly ApplicationDbContext _context;
        private readonly IHolidaysService _HolidaysService;

        public HolidaysController(ApplicationDbContext context, IHolidaysService HolidaysService)
        {
            _context = context;
            _HolidaysService = HolidaysService;
        }

        //api/Holidays/GetAllHolidays
        [HttpGet("[action]")]
        public ActionResult<IEnumerable<Holidays>> GetAllHolidays()
        {
            return _HolidaysService.GetAllHolidays();
        }

        //api/Holidays/GetHolidaysById/1
        [HttpGet("[action]/{id}")]
        public ActionResult<Holidays> GetHolidaysById(int id)
        {
            return _HolidaysService.GetHolidaysById(id);
        }

        //api/Holidays/GetHolidaysByTitle/PL
        [HttpGet("[action]/{status}")]
        public ActionResult<Holidays> GetHolidaysByTitle(string status)
        {
            return _HolidaysService.GetHolidaysByTitle(status);
        }

        ///api/Holidays/add
        [HttpPost("add")]
        public ActionResult<Holidays> AddHolidays(Holidays Holidays)
        {
            int temp = _HolidaysService.AddHolidays(Holidays);
            if (temp > 0)
            {
                return CreatedAtAction(nameof(Holidays), new { id = temp }, Holidays);
            }
            else
            {
                return UnprocessableEntity("Holiday already exist");
            }
        }

        //api/Holidays/update
        [HttpPut("update")]
        public ActionResult<Holidays> UpdateHolidays(Holidays Holidays)
        {
            var d = _HolidaysService.UpdateHolidays(Holidays);
            if (d != null)
            {
                return d;
            }
            else
            {
                return UnprocessableEntity("Holiday does not exist");
            }
        }

        //api/Holidays/delete/5
        [HttpDelete("delete/{id}")]
        public bool DeleteHolidays(int id)
        {
            return _HolidaysService.DeleteHolidays(id);
        }
    }
}