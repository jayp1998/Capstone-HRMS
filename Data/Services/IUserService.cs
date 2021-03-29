using HRMS_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Project.Data.Services
{
    public interface IUserService
    {
        Task<string> RegisterAsync(RegisterModel model);

        Task<AuthenticationModel> GetTokenAsync(TokenRequestModel model);

        Task<string> AddRoleAsync(AddRoleModel model);
    }
}
