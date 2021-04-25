using System.Collections.Generic;
using System.Linq;
using HRMS_Project.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Capstone_HRMS.Data.Services
{
    public class HolidaysService : IHolidaysService
    {
      private readonly ApplicationDbContext _context;
         public HolidaysService(ApplicationDbContext context)
        {
            _context = context;
        }
        public int AddHolidays(Holidays d)
        {
             if (!HolidaysExists(d.Title))
            {
                 _context.Holidays.Add(d);
                _context.SaveChanges();

                return d.HolidaysId;
            }
            else
            {
                return 0;
            }
        }

        public bool DeleteHolidays(int id)
        {
            var result = GetHolidaysById(id);
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

        public List<Holidays> GetAllHolidays()
        {
            return _context.Holidays.ToList();
        }

        public Holidays GetHolidaysById(int Id)
        {
            Holidays result = _context.Holidays.Where(e => e.HolidaysId == Id).FirstOrDefault();
            return result;
        }

        public Holidays GetHolidaysByTitle(string title)
        {
            Holidays result = _context.Holidays.Where(e => e.Title.Contains(title)).FirstOrDefault();

            return result;
        }

        public bool HolidaysExists(string title)
        {
            return _context.Holidays.Any(e => e.Title == title);
        }

        public Holidays UpdateHolidays(Holidays d)
        {
             var result = GetHolidaysById(d.HolidaysId);
            if (result != null)
            {
                 if (result.Title != d.Title && HolidaysExists(d.Title))
                {
                    return null;
                }
                result.Title = d.Title;
                result.HolidayDate = d.HolidayDate;
                result.Day = d.Day;
                
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