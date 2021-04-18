using HRMS_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Project.Data.Services
{
    public interface IUserService
    {
        Task<string> RegisterAsync(RegisterModel model);

        Task<AuthenticationModel> GetTokenAsync(TokenRequestModel model);

        Task<string> AddRoleAsync(AddRoleModel model);

        Task<ApplicationUser> FindByEmailAsync(string email);

        Task<string> GeneratePasswordResetTokenAsync(ApplicationUser user);

        string GetToken(string id, string token);

        Task<bool> UpdatePasswordByEmailAsync(string token, ApplicationUser user, string newPassword);
    }
}
