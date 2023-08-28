using Horoscopo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ejercicio3Tema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su dia de nacimiento:");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese su mes de nacimiento:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese su año de nacimiento:");
            int year = Convert.ToInt32(Console.ReadLine());

            if (ValidarFecha(day,month))
            {
                DateTime FechaNac = new DateTime(year, month, day);
                
                Console.WriteLine($"Su signo zodiacal es {Horoscopo.Horoscopo.SignoZodiacal(FechaNac)}");

                Console.Write($"El año chino de su nacimiento fué {Horoscopo.Horoscopo.SignoChino(FechaNac)}");
            }
            
            
            
            Console.ReadKey();
        }

        private static bool ValidarFecha(int day, int month)
        {
            if (day>=0 || day <=31 && month >=1 || month <=12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
