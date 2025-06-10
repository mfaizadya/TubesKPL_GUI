using Microsoft.AspNetCore.Mvc;

namespace AuthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PelajarController : ControllerBase
    {
        // List statis untuk menyimpan data pelajar sementara (mock database)
        private static List<Pelajar> daftarPelajar = new List<Pelajar>
        {
            new Pelajar("Pelajar1", "pela1", "pass"),
            new Pelajar("Pelajar2", "pela2", "pass2")
        };

        /// <summary>
        /// Mengambil semua data pelajar yang terdaftar.
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<Pelajar>> GetAllPelajar()
        {
            return Ok(daftarPelajar);
        }

        /// <summary>
        /// Endpoint untuk registrasi pelajar baru.
        /// </summary>
        [HttpPost("register")]
        public ActionResult Register([FromBody] Pelajar newPelajar)
        {
            // Validasi input tidak boleh kosong
            if (newPelajar == null ||
                string.IsNullOrWhiteSpace(newPelajar.Nama) ||
                string.IsNullOrWhiteSpace(newPelajar.Username) ||
                string.IsNullOrWhiteSpace(newPelajar.Password))
            {
                return BadRequest("Semua data (Nama, Username, dan Password) harus diisi.");
            }

            // Cek apakah username sudah digunakan
            var existing = daftarPelajar.FirstOrDefault(p => p.Username == newPelajar.Username);
            if (existing != null)
            {
                return Conflict("Username sudah digunakan.");
            }

            // Tambahkan ke daftar pelajar
            daftarPelajar.Add(newPelajar);

            // Jangan kembalikan password (praktik aman)
            var response = new
            {
                newPelajar.Nama,
                newPelajar.Username
            };

            return CreatedAtAction(nameof(GetAllPelajar), new { username = newPelajar.Username }, response);
        }

        /// <summary>
        /// Endpoint untuk login pelajar.
        /// </summary>
        [HttpPost("login")]
        public ActionResult Login([FromBody] LoginReq req)
        {
            // Validasi input login
            if (req == null ||
                string.IsNullOrWhiteSpace(req.Username) ||
                string.IsNullOrWhiteSpace(req.Password))
            {
                return BadRequest("Username dan password harus diisi.");
            }

            // Autentikasi sederhana (tanpa hash)
            var pelajar = daftarPelajar.FirstOrDefault(p =>
                p.Username == req.Username && p.Password == req.Password);

            if (pelajar != null)
            {
                // Jangan kembalikan password
                var response = new
                {
                    pelajar.Nama,
                    pelajar.Username
                };

                return Ok(response);
            }

            return Unauthorized("Username atau password salah.");
        }
    }
}
