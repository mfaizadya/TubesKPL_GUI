using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private static List<Admin> daftarAdmin = new List<Admin>
        {
            new Admin("Admin1", "admin", "password"),
            new Admin{Nama="Admin2", Username="admin2", Password="password"}
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
            for (i = 0; i < daftarAdmin.Count; i++)
            {
                if (daftarAdmin[i].Username == req.Username && daftarAdmin[i].Password == req.Password)
                {
                    return Ok(daftarAdmin[i]);
                }
            }
            return Unauthorized("Username atau password salah");
        }
    }
}
