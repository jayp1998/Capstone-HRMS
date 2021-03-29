using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HRMS_Project.Data.Models;
using HRMS_Project.Data.Services;

namespace HRMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserService _userService;

        public UsersController(ApplicationDbContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        [HttpGet("[action]")]
        public IActionResult GetUsers()
        {
            return Ok();
        }

        [HttpPost("Login")]
        public ActionResult Login([FromBody] TblUser user)
        {
            if (user != null)
            {
                //var u = _context.TblUsers.Where(m => m.Username == user.Username && m.Password == user.Password).FirstOrDefault();
                //if (u != null)
                //{
                //    //HttpContext.Session.SetString("LoggedInUser", JsonConvert.SerializeObject(u));
                //    return Ok(u);
                //}
            }
            return Ok();
        }

        [HttpPost("Logout")]
        public ActionResult Logout([FromBody] TblUser user)
        {
            if (user != null)
            {
                HttpContext.Session.Remove("LoggedInUser");
                return Ok();
            }
            return NotFound();
        }

        [HttpPost("register")]
        public async Task<ActionResult> RegisterAsync(RegisterModel model)
        {

            var result = await _userService.RegisterAsync(model);
            return Ok(result);
        }

        [HttpPost("token")]
        public async Task<IActionResult> GetTokenAsync(TokenRequestModel model)
        {
            var result = await _userService.GetTokenAsync(model);
            return Ok(result);
        }

        [HttpPost("addrole")]
        public async Task<IActionResult> AddRoleAsync(AddRoleModel model)
        {
            var result = await _userService.AddRoleAsync(model);
            return Ok(result);
        }
    }
}
