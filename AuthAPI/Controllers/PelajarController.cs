    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using BCrypt.Net;

    namespace AuthAPI.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class PelajarController : ControllerBase
        {
            // Mock database
            private static readonly List<Pelajar> pelajarList = new()
            {
                new Pelajar("Pelajar1", "pela1", BCrypt.Net.BCrypt.HashPassword("pass")),
                new Pelajar("Pelajar2", "pela2", BCrypt.Net.BCrypt.HashPassword("pass2"))
            };

            /// <summary>
            /// Mengambil semua data pelajar (hanya nama dan username).
            /// </summary>
            [HttpGet]
            public ActionResult<IEnumerable<object>> GetAllPelajar()
            {
                return Ok(pelajarList.Select(p => new { p.Nama, p.Username, p.Password}));
            }

            /// <summary>
            /// Endpoint untuk registrasi pelajar baru.
            /// </summary>
            [HttpPost("register")]
            public ActionResult Register([FromBody] Pelajar newPelajar)
            {
                if (newPelajar == null ||
                    string.IsNullOrWhiteSpace(newPelajar.Nama) ||
                    string.IsNullOrWhiteSpace(newPelajar.Username) ||
                    string.IsNullOrWhiteSpace(newPelajar.Password))
                {
                    return BadRequest("Semua data (Nama, Username, dan Password) harus diisi.");
                }

                if (pelajarList.Any(p => p.Username == newPelajar.Username))
                {
                    return Conflict("Username sudah digunakan.");
                }

                newPelajar.Password = BCrypt.Net.BCrypt.HashPassword(newPelajar.Password);
                pelajarList.Add(newPelajar);

                var response = new { newPelajar.Nama, newPelajar.Username };
                return CreatedAtAction(nameof(GetAllPelajar), new { newPelajar.Username }, response);
            }

            /// <summary>
            /// Endpoint untuk login pelajar.
            /// </summary>
            [HttpPost("login")]
            public ActionResult Login([FromBody] LoginReq loginRequest)
            {
                if (loginRequest == null ||
                    string.IsNullOrWhiteSpace(loginRequest.Username) ||
                    string.IsNullOrWhiteSpace(loginRequest.Password))
                {
                    return BadRequest("Username dan password harus diisi.");
                }

                var matchedPelajar = pelajarList.FirstOrDefault(p =>
                    p.Username == loginRequest.Username &&
                    BCrypt.Net.BCrypt.Verify(loginRequest.Password, p.Password));

                if (matchedPelajar == null)
                {
                    return Unauthorized("Username atau password salah.");
                }

                var response = new { matchedPelajar.Nama, matchedPelajar.Username };
                return Ok(response);
            }
        }
    }
