using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoalLibrary
{
    // Representasi struktur data untuk sebuah soal
    public class Soal
    {
        public int Id { get; set; }
        public JenisSoal Jenis { get; set; }
        public string Pertanyaan { get; set; }
        public string Jawaban { get; set; }
        public List<string>? Opsi { get; set; }
    }
}
