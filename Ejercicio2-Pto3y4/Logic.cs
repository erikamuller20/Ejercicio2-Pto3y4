using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Pto3y4
{
    public class Logic
    {
        public static void throwcustomexception()
        {

            //PUNTO 3 DEL EJERCICIO2
             int num1 = 0;
             bool esNum = false;
             while (!esNum) //Mientras esNum sea falso
             {
                 Console.WriteLine("Introduzca el dividendo");
                 esNum = int.TryParse(Console.ReadLine(), out num1);
                 if (!esNum)
                 {
                     Console.WriteLine($"Seguro Ingreso una letra o no ingreso nada! {Environment.NewLine}");
                     throw new MensajeExcepcion();
                 }
             }

             int num2 = 0;
             bool esNum2 = false;
             while (!esNum2) //Mientras esNum sea falso
             {
                 Console.WriteLine("Introduzca el divisor");
                 esNum2 = int.TryParse(Console.ReadLine(), out num2);
                 if (!esNum2)
                 {
                     Console.WriteLine($"Seguro Ingreso una letra o no ingreso nada! {Environment.NewLine}");
                     throw new MensajeExcepcion();
                 }
             }

             try
             {
                 int division = num1 / num2;
                 Console.WriteLine($"La division es { division }");
             }
             catch (DivideByZeroException ex)
             {
                 Console.WriteLine("Solo Chuck Norris divide por cero!");
                 Console.WriteLine($"Mensaje de error: {ex.Message} ");
                 throw new MensajeExcepcion();
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Ocurrio un error: {ex.Message}");
                 throw new MensajeExcepcion();
             }
             finally
             {
                 Console.WriteLine("Proceso finalizado");
             }

             Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

        }

    }
}
