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
            if (string.IsNullOrWhiteSpace(jawabanMahasiswa))
                return 0;

            string jawabanBenarNormalized = JawabanBenar?.Trim().ToLowerInvariant() ?? string.Empty;
            string jawabanMahasiswaNormalized = jawabanMahasiswa.Trim().ToLowerInvariant();

            if (jawabanMahasiswaNormalized == jawabanBenarNormalized)
                return 100;

            return 50;
        }
    }
}
