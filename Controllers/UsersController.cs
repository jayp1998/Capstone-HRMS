using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HRMS_Project.Data.Models;
using Newtonsoft.Json;

namespace HRMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly HRMSContext _context;

        public UsersController(HRMSContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public IActionResult GetUsers()
        {
            return Ok(_context.TblUsers.ToList());
        }

        [HttpPost("Login")]
        public ActionResult Login([FromBody] TblUser user)
        {
            if (user != null)
            {
                var u = _context.TblUsers.Where(m => m.Username == user.Username && m.Password == user.Password).FirstOrDefault();
                if (u != null)
                {
                    HttpContext.Session.SetString("LoggedInUser", JsonConvert.SerializeObject(u));
                    return Ok(u);
                }
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


        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblUser>> GetTblUser(int id)
        {
            var tblUser = await _context.TblUsers.FindAsync(id);

            if (tblUser == null)
            {
                return NotFound();
            }

            return tblUser;
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblUser(int id, TblUser tblUser)
        {
            if (id != tblUser.UserId)
            {
                return BadRequest();
            }

            _context.Entry(tblUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblUserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<TblUser>> PostTblUser(TblUser tblUser)
        {
            _context.TblUsers.Add(tblUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblUser", new { id = tblUser.UserId }, tblUser);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblUser(int id)
        {
            var tblUser = await _context.TblUsers.FindAsync(id);
            if (tblUser == null)
            {
                return NotFound();
            }

            _context.TblUsers.Remove(tblUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblUserExists(int id)
        {
            return _context.TblUsers.Any(e => e.UserId == id);
        }
    }
}
