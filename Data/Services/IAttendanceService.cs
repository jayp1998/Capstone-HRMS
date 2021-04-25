using System.Collections.Generic;
using Capstone_HRMS.Data.Models;

namespace Capstone_HRMS.Data.Services
{
    public interface IAttendanceService
    {
         long AddAttendance(Attendance d);

        Attendance UpdateAttendance(Attendance d);

        bool DeleteAttendance(long id);

        List<Attendance> GetAllAttendance();

        Attendance GetAttendanceById(long Id);

         List<Attendance> GetAttendanceByEmpId(long Id);

    }
}