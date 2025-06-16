using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoalLibrary;

namespace TubesKPL
{
    public class Level
    {
            public int IdLevel { get; set; }
            public string NamaLevel { get; set; }
            public List<Soal> SoalList { get; set; }
    }
}

