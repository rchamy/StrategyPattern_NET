using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Persona : ICorrer
    {
        public string Correr()
        {
            return "corro con 2 piernas";
        }
    }
}
