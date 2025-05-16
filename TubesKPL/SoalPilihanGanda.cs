using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL
{
    public class SoalPilihanGanda
    {
        public string Pertanyaan { get; set; }
        public List<string> Opsi { get; set; }
        public string JawabanBenar { get; set; }

        public SoalPilihanGanda(string pertanyaan)
        {
            Pertanyaan = pertanyaan;
            Opsi = new List<string>();
        }

        public void TambahOpsi(string opsi)
        {
            Opsi.Add(opsi);
        }

        public void SetJawabanBenar(string jawaban)
        {
            JawabanBenar = jawaban;
        }
    }
}
