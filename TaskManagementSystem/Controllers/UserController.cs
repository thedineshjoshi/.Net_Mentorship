using Microsoft.AspNetCore.Mvc;
using TaskManagementSystem.Data;
using TaskManagementSystem.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        public UserController( ApplicationDbContext db)
        {
            this.db = db;
        }
        // GET: api/<UserController>
        [HttpGet("GetUser")]
        public IEnumerable<User> Get()
        {
            var result = db.Users;
            return result;
        }

        // GET api/<UserController>/5
        [HttpGet("GetUserById/{id}")]
        public IActionResult Get(Guid id)
        {
            var result = db.Users.Where(a => a.Id == id).FirstOrDefault();
            return Ok(result);
        }

        // POST api/<UserController>
        [HttpPost("AddUser")]
        public IActionResult Post([FromBody] User user)
        {
            var users = new User
            {
                Id = new Guid(),
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.LastName,
                Username = user.Username,
                PasswordHash = user.PasswordHash,
                Role = user.Role,
                CreatedAt = DateTime.UtcNow,
                LastLogin = DateTime.UtcNow
                
            };
            db.Users.Add(users);
            db.SaveChanges();
            return Ok();
        }
        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] User user)
        {
            var result = db.Users.Where(a => a.Id == id).FirstOrDefault();
            result.FirstName = user.FirstName;
            result.LastName = user.LastName;
            result.Email = user.Email;
            db.SaveChanges();
            return Ok(result);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var result = db.Users.Where(a => a.Id == id).FirstOrDefault();
            db.Users.Remove(result);
            db.SaveChanges();
            return Ok(result);
        }
    }
}
