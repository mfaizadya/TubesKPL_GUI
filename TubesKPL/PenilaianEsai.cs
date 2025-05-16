using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL
{
    public class PenilaianEsai
    {
        public string JawabanBenar { get; set; }

        public int HitungSkor(string jawabanMahasiswa)
        {
            if (string.IsNullOrWhiteSpace(jawabanMahasiswa)) return 0;
            if (jawabanMahasiswa.Trim().ToLower() == JawabanBenar.Trim().ToLower())
                return 100;
            return 50; 
        }
    }
}
