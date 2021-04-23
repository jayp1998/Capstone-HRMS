using System.Collections.Generic;
using HRMS_Project.Data.Models;

namespace Capstone_HRMS.Data.Services
{
    public interface IHolidaysService
    {
        int AddHolidays(Holidays d);

        Holidays UpdateHolidays(Holidays d);

        bool DeleteHolidays(int id);

        List<Holidays> GetAllHolidays();

        Holidays GetHolidaysById(int Id);

        Holidays GetHolidaysByTitle(string title);

        bool HolidaysExists(string title);
        
    }
}