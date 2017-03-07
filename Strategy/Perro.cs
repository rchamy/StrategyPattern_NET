using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Perro : ICorrer
    {
        public string Correr()
        {
            return "corro en 4 patas";
        }
    }
}
