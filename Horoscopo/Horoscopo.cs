using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoscopo
{
    public static class Horoscopo
    {
        public static string SignoZodiacal(DateTime FechaNac)
        {
            string signo;

            int day = FechaNac.Day;
            int month = FechaNac.Month;
            if (day>=22 || day <= 20 && month>=12 || month==1 ) 
            {
                signo = "Capricornio";
            }
            else if (day >= 21 || day <= 19 && month >= 1 || month <=2)
            {
                signo = "Acuario";
            }
            else if (day >= 20 || day <= 20 && month >= 2 || month <= 3)
            {
                signo = "Pisis";
            }
            else if (day >= 21 || day <= 20 && month >= 3 || month <= 4)
            {
                signo = "Aries";
            }
            else if (day >= 21 || day <= 21 && month >= 4 || month <= 5)
            {
                signo = "Tauro";
            }
            else if (day >= 22 || day <= 21 && month >= 5 || month <= 6)
            {
                signo = "Géminis";
            }
            else if (day >= 22 || day <= 22 && month >= 6 || month <= 7)
            {
                signo = "Cáncer";
            }
            else if (day >= 23 || day <= 22 && month >= 7 || month <= 8)
            {
                signo = "Leo";
            }
            else if (day >= 23 || day <= 22 && month >= 8 || month <= 9)
            {
                signo = "Virgo";
            }
            else if (day >= 23 || day <= 22 && month >= 9 || month <= 10)
            {
                signo = "Libra";
            }
            else if (day >= 23 || day <= 22 && month >= 10 || month <= 11)
            {
                signo = "Escorpio";
            }
            else
            {
                signo = "Sagitario";
            }
            return signo;
        }
        public static string SignoChino(DateTime FechaNac)
        {
            string Signo;
            int anio = FechaNac.Year;
            int resto = anio % 12;
            if (resto == 0)
            {
                Signo = "MONO";
            }
            else if (resto == 1)
            {
                Signo = "GALLO";
            }
            else if (resto==2)
            {
                Signo = "PERRO";
            }
            else if (resto==3)
            {
                Signo = "CERDO";
            }
            else if (resto==4)
            {
                Signo = "RATA";
            }
            else if (resto==5)
            {
                Signo = "BUEY";
            }
            else if (resto==6)
            {
                Signo = "TIRGRE";
            }
            else if (resto==7)
            {
                Signo = "CONEJO";
            }
            else if (resto == 8)
            {
                Signo = "DRAGÓN";
            }
            else if (resto == 9)
            {
                Signo = "SERPIENTE";
            }
            else if (resto == 10)
            {
                Signo = "CABALLO";
            }
            else
            {
                Signo = "CABRA";
            }
            return Signo;           
        }
       
    }
}
