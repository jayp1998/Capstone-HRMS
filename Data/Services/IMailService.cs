using HRMS_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Project.Data.Services
{
    public interface IMailService
    {
        Task<string> SendResetEmailAsync(string email, string resetToken, string url);
    }
}
