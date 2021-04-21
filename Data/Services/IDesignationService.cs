using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRMS_Project.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRMS_Project.Data.Services
{
    public interface IDesignationService
    {
        int AddDesignation(Designation d);

        Designation UpdateDesignation(Designation d);

        bool DeleteDesignation(int id);

        List<Designation> GetAllDesignations();

        Designation GetDesignationById(int Id);

        bool DesignationExists(string DesignationName);

        List<Designation> GetDesignationByName(string name);
    }
}
