﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PelajarController : ControllerBase
    {
        private static List<Pelajar> daftarPelajar = new List<Pelajar>
        {
            new Pelajar("Pelajar1","pela1","pass"),
            new Pelajar("Pelajar2","pela2","pass2")
        };

        [HttpGet]
        public ActionResult<IEnumerable<Pelajar>> GetAllPelajar()
        {
            return daftarPelajar;
        }

        [HttpPost("register")]
        public ActionResult<Pelajar> Register([FromBody] Pelajar newPelajar)
        {
            if (newPelajar == null || string.IsNullOrWhiteSpace(newPelajar.Username) || string.IsNullOrWhiteSpace(newPelajar.Password) || string.IsNullOrWhiteSpace(newPelajar.Nama))
            {
                return BadRequest("Semua data (Nama, Username, dan Password) harus diisi.");
            }

            var existing = daftarPelajar.FirstOrDefault(p => p.Username == newPelajar.Username);
            if (existing != null)
            {
                return Conflict("Username sudah digunakan.");
            }

            daftarPelajar.Add(newPelajar);
            return CreatedAtAction(nameof(GetAllPelajar), new { username = newPelajar.Username }, newPelajar);
        }


        [HttpPost("login")]
        public ActionResult<Pelajar> Login([FromBody] LoginReq req)
        {
            int i;
            if (req == null || string.IsNullOrWhiteSpace(req.Username) || string.IsNullOrWhiteSpace(req.Password))
            {
                return BadRequest("Username dan password harus diisi.");
            }

            for (i = 0; i < daftarPelajar.Count; i++)
            {
                if (req.Username == daftarPelajar[i].Username && req.Password == daftarPelajar[i].Password)
                {
                    return Ok(daftarPelajar[i]);
                }
            }

            return Unauthorized("Username atau password salah");
        }
    }
}
