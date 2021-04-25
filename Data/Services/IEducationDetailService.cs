using System.Collections.Generic;
using HRMS_Project.Data.Models;

namespace Capstone_HRMS.Data.Services
{
    public interface IEducationDetailService
    {
        long AddEducationDetail(EducationDetail d);

        EducationDetail UpdateEducationDetail(EducationDetail d);

        bool DeleteEducationDetail(long id);

        List<EducationDetail> GetAllEducationDetail();

        EducationDetail GetEducationDetailById(long id);

        List<EducationDetail> GetEducationDetailByEmpID(long id);

        bool EducationDetailExists(long id);
        
    }
}