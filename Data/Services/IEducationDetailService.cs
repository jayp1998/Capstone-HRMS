using System.Collections.Generic;
using HRMS_Project.Data.Models;

namespace Capstone_HRMS.Data.Services
{
    public interface IEducationDetailService
    {
        int AddEducationDetail(EducationDetail d);

        EducationDetail UpdateEducationDetail(EducationDetail d);

        bool DeleteEducationDetail(int id);

        List<EducationDetail> GetAllEducationDetail();

        EducationDetail GetEducationDetailById(int id);

        List<EducationDetail> GetEducationDetailByEmpID(int id);

        bool EducationDetailExists(int id);
        
    }
}