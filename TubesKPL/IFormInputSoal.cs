using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoalLibrary;

namespace TubesKPL
{
    public interface IFormInputSoal<T> where T : Soal
    {
        T AmbilSoal();
    }
}
