using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL
{
    class Level_dan_Soal
    {
        public class Soal
        {
            public int IdSoal { get; set; }
            public string JenisSoal { get; set; }
            public string Pertanyaan { get; set; }
            public string Jawaban { get; set; }
            public List<string> Opsi { get; set; }
        }

        public class Level
        {
            public int IdLevel { get; set; }
            public string NamaLevel { get; set; }
            public List<Soal> SoalList { get; set; }
        }
    }
}
