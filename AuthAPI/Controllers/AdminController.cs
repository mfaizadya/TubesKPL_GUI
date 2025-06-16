using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BCrypt.Net;

namespace AuthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private static List<Admin> daftarAdmin = new List<Admin>
        {
            new Admin("Admin1", "admin", BCrypt.Net.BCrypt.HashPassword("password")),
            new Admin { Nama = "Admin2", Username = "admin2", Password = BCrypt.Net.BCrypt.HashPassword("password") }

        };

        [HttpGet]
        public ActionResult<IEnumerable<Admin>> GetAllAdmin()
        {
            return daftarAdmin;
        }

        [HttpPost("register")]
        public ActionResult<Admin> Register([FromBody] Admin newAdmin)
        {
            if (newAdmin == null || string.IsNullOrWhiteSpace(newAdmin.Username) || string.IsNullOrWhiteSpace(newAdmin.Password) || string.IsNullOrWhiteSpace(newAdmin.Nama))
            {
                return BadRequest("Semua data (Nama, Username, dan Password) harus diisi.");
            }

            var existing = daftarAdmin.FirstOrDefault(a => a.Username == newAdmin.Username);
            if (existing != null)
            {
                return Conflict("Username sudah digunakan.");
            }

            newAdmin.Password = BCrypt.Net.BCrypt.HashPassword(newAdmin.Password);
            daftarAdmin.Add(newAdmin);
            return CreatedAtAction(nameof(GetAllAdmin), new { username = newAdmin.Username }, newAdmin);
        }


        [HttpPost("login")]
        public ActionResult<Admin> Login([FromBody] LoginReq req)
        {
            int i;

            if (req == null || string.IsNullOrWhiteSpace(req.Username) || string.IsNullOrWhiteSpace(req.Password))
            {
                return BadRequest("Username dan password harus diisi.");
            }

            var admin = daftarAdmin.FirstOrDefault(a => a.Username == req.Username);

            if (admin == null || !BCrypt.Net.BCrypt.Verify(req.Password, admin.Password))
            {
                return Unauthorized("Username atau password salah");
            }

            return Ok(admin);
        }
    }
}
