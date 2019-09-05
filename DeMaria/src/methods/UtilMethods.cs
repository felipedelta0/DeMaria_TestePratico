using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMaria.src.methods
{
    class UtilMethods
    {
        public static bool validarData(string dataString)
        {
            int dia, mes, ano;
            var fullDate = dataString.Split('/');
            try
            {
                int.TryParse(fullDate[0], out dia);
                int.TryParse(fullDate[1], out mes);
                int.TryParse(fullDate[2], out ano);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            if (mes == 1 || mes == 3 || mes == 5 ||
                mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                if (dia >= 1 && dia <= 31)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                if (dia >= 1 && dia <= 30)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (mes == 2)
            {
                if (dia >= 1 && dia <= 29 && ano % 4 == 0)
                {
                    return true;
                }
                else if (dia >= 1 && dia <= 28 && ano % 4 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public static bool validarHora(string horaString)
        {
            int hora, minuto;

            var fullHour = horaString.Split('/');

            try
            {
                int.TryParse(fullHour[0], out hora);
                int.TryParse(fullHour[1], out minuto);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            if (hora >= 00 && hora <= 23)
            {
                if (minuto >= 00 && minuto <= 59)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
