using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Factory
    {
        private bool RequireAuth()
        {
            return false;
        }

        public IComenzar CreateStrategy()
        {
            string o = "hola";
            if (RequireAuth() && o != "hola")
                return new AutorizacionProceso();
            else if (RequireAuth() && o != "hola")
                return new CalculoPagoComprador();
            else return new OtraEstrategia();
        }
    }
}
