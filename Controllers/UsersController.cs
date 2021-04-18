using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HRMS_Project.Data.Models;
using HRMS_Project.Data.Services;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Mvc.Routing;
using Newtonsoft.Json;

namespace HRMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserService _userService;
        private readonly IMailService _mailService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UsersController(ApplicationDbContext context, IUserService userService, IMailService mailService, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userService = userService;
            _mailService = mailService;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost("login")]
        public async Task<IActionResult> GetTokenAsync(TokenRequestModel model)
        {
            var result = await _userService.GetTokenAsync(model);
            return Ok(result);
        }

        [HttpPost("register")]
        public async Task<ActionResult> RegisterAsync(RegisterModel model)
        {
            var result = await _userService.RegisterAsync(model);
            return Ok(result);
        }

        [HttpPost("addrole")]
        public async Task<IActionResult> AddRoleAsync(AddRoleModel model)
        {
            var result = await _userService.AddRoleAsync(model);
            return Ok(result);
        }

        [HttpPost("resetemail")]
        public async Task<IActionResult> SendForgotPasswordMail(ForgotPasswordModel forgotPasswordModel)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            dynamic result;
            string url = AbsoluteUrl(_httpContextAccessor, "/resetpassword/");

            var user = await _userService.FindByEmailAsync(forgotPasswordModel.Email);
            if (user != null)
            {
                var token = await _userService.GeneratePasswordResetTokenAsync(user);
                if (token != null && url != null)
                {
                    string sent = await _mailService.SendResetEmailAsync(user.Email, token, url);
                    result = new
                    {
                        data = "sent"
                    };
                }
                else
                {
                    result = new
                    {
                        data = "token generation failed!"
                    };
                }
            }
            else
            {
                result = new
                {
                    data = "User not found!"
                };
            }
            return Ok(result);
        }

        [HttpPost("resetpassword")]
        public async Task<dynamic> ResetPasswordAsync(string token, string email, string newPassword) 
        {
            var user = await _userService.FindByEmailAsync(email);
            if (user != null) 
            {
                var result = await _userService.UpdatePasswordByEmailAsync(token, user, newPassword);
                return result;
            }
            return new { 
                data = "email not found",
            };
        }

        private string AbsoluteUrl(IHttpContextAccessor httpContextAccessor, string relativeUrl, object parameters = null)
        {
            var request = httpContextAccessor.HttpContext.Request;
            var url = new Uri(new Uri($"{request.Scheme}://{request.Host.Value}"), relativeUrl).ToString();
            if (parameters != null)
            {
                url = Microsoft.AspNetCore.WebUtilities.QueryHelpers.AddQueryString(url, ToDictionary(parameters));
            }
            return url;
        }

        private Dictionary<string, string> ToDictionary(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }
    }
}
