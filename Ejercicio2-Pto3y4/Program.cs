using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Pto3y4
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Logic.throwcustomexception();
            }
            catch (MensajeExcepcion ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();


            try
            {
                LogicString.ThrowExPersonalizado();
            }
            catch(ExcepcionPersonalizado ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Presione una tecla para finalizar");
            Console.ReadLine();

        }
    }
}
