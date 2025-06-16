using Microsoft.AspNetCore.Mvc;
using BCrypt.Net;

namespace AuthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        // list Admin yang sudah terdaftar
        private static List<Admin> adminList = new List<Admin>
        {
            new Admin("Admin1", "admin", BCrypt.Net.BCrypt.HashPassword("password")),
            new Admin { Nama = "Admin2", Username = "admin2", Password = BCrypt.Net.BCrypt.HashPassword("password") }
        };

        /// <summary>
        /// Mengembalikan semua data admin.
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<Admin>> GetAllAdmins()
        {
            return adminList;
        }

        /// <summary>
        /// Endpoint untuk registrasi admin baru.
        /// </summary>
        [HttpPost("register")]
        public ActionResult<Admin> Register([FromBody] Admin newAdmin)
        {
            if (newAdmin == null ||
                string.IsNullOrWhiteSpace(newAdmin.Username) ||
                string.IsNullOrWhiteSpace(newAdmin.Password) ||
                string.IsNullOrWhiteSpace(newAdmin.Nama))
            {
                return BadRequest("Semua data (Nama, Username, dan Password) harus diisi.");
            }

            var existingAdmin = adminList.FirstOrDefault(a => a.Username == newAdmin.Username);
            if (existingAdmin != null)
            {
                return Conflict("Username sudah digunakan.");
            }

            newAdmin.Password = BCrypt.Net.BCrypt.HashPassword(newAdmin.Password);
            adminList.Add(newAdmin);

            return CreatedAtAction(nameof(GetAllAdmins), new { username = newAdmin.Username }, newAdmin);
        }

        /// <summary>
        /// Endpoint login admin berdasarkan username dan password.
        /// </summary>
        [HttpPost("login")]
        public ActionResult<Admin> Login([FromBody] LoginReq loginRequest)
        {
            if (loginRequest == null ||
                string.IsNullOrWhiteSpace(loginRequest.Username) ||
                string.IsNullOrWhiteSpace(loginRequest.Password))
            {
                return BadRequest("Username dan password harus diisi.");
            }

            var admin = adminList.FirstOrDefault(a => a.Username == loginRequest.Username);
            bool isValidPassword = admin != null && BCrypt.Net.BCrypt.Verify(loginRequest.Password, admin.Password);

            if (!isValidPassword)
            {
                return Unauthorized("Username atau password salah.");
            }

            return Ok(admin);
        }
    }
}
