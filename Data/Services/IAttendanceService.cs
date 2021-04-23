using System.Collections.Generic;
using Capstone_HRMS.Data.Models;

namespace Capstone_HRMS.Data.Services
{
    public interface IAttendanceService
    {
         int AddAttendance(Attendance d);

        Attendance UpdateAttendance(Attendance d);

        bool DeleteAttendance(int id);

        List<Attendance> GetAllAttendance();

        Attendance GetAttendanceById(int Id);

         List<Attendance> GetAttendanceByEmpId(int Id);

    }
}