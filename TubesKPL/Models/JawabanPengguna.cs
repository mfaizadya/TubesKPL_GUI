using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL.Models
{
    public class JawabanPengguna
    {
        public int IdSoal { get; set; }
        public string Jawaban { get; set; } = "";
        public double Skor { get; set; }
    }
}
