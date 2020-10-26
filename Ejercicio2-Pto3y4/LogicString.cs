using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Pto3y4
{
    class LogicString
    {
        //Punto4
        public static void ThrowExPersonalizado()
        {

                string text1;
                string text2;

                Console.WriteLine("Ingrese su primer mensaje:");
                text1 = Console.ReadLine();
                Console.WriteLine("Ingrese su segundo mensaje:");

                text2 = Console.ReadLine();
                Console.WriteLine(Message($"Su Mensaje: {text1} {text2}"));
                
                throw new ExcepcionPersonalizado();
            
        }

        static string Message(string text1)
        {
            return text1;
        }
        static string Message(string text1, string text2)
        {
            return Message(text1 + " " + text2);
        }

    }
}
