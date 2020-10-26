using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Pto3y4
{
    public class MensajeExcepcion : Exception
    {
        public MensajeExcepcion() : base("Mensaje de Error Excepcion test") { }

    }
}