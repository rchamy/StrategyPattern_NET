using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CalculoPagoComprador : IComenzar
    {
        public string Ejecutar()
        {
            return "Calcular Comision - Calcular otra cosa - Calcular - Enviar Correo";

        }

        private decimal CalcularComision()
        {
            return 0;
        }
    }
}
