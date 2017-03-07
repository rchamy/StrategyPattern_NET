using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class AutorizacionProceso : IComenzar
    {
        public string Ejecutar()
        {
            return "Solicitar Autorizacion - Agregar comentario - Enviar Notificacion";
        }
    }
}
