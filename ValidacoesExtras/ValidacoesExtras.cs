using System;

namespace Validacoes
{
    public class ValidacoesExtras
    {
        public int calculaIdade(string nasc, string reg, string novoNasc = null, bool noPrazo = false)
        {
            int anos;
            if (!noPrazo)
            {
                anos = (int)((DateTime.Parse(reg) - DateTime.Parse(nasc)).TotalDays / 365);
            }
            else
            {
                anos = (int)((DateTime.Parse(novoNasc) - DateTime.Parse(nasc)).TotalDays / 365);
            }
            return anos;
        }


        public int getDV(string numero)
        {
            return Convert.ToInt32(numero) % 11;
        }

        public string regraDV1(string numero, bool dnv)
        {
            return numero.ToString() + "-" + (Convert.ToInt32(numero) % 11).ToString();
        }

        public string regraDV2(string numero, bool dnv)
        {
            int somatorio = 0;
            int cont = 0;
            if (dnv)
            {
                cont = 9;
                foreach (var num in numero)
                {
                    string number = Char.GetNumericValue(num).ToString();
                    somatorio += Convert.ToInt32(number) * cont;
                    cont -= 1;
                }
                int dividido = (somatorio + 9 + getDV(numero)) % 11; // Padrão 30-XXX
                int resultado = 11 - dividido;
                string final = resultado == 10 || resultado == 11 ? "0" : resultado.ToString();

                string finalString = "30-" + numero + "-" + final;

                return finalString;
            }
            else
            {
                cont = 9;
                foreach (var num in numero)
                {
                    string number = Char.GetNumericValue(num).ToString();
                    somatorio += Convert.ToInt32(number) * cont;
                    cont -= 1;
                }
                int dividido = (somatorio + getDV(numero)) % 11;
                int resultado = 11 - dividido;
                string final = resultado == 10 || resultado == 11 ? "0" : resultado.ToString();

                string finalString = numero + "-" + final;

                return finalString;
            }
        }

        public string ValidarDNV(string inserido)
        {
            int numero = Convert.ToInt32(inserido);

            if (numero < 43700001)
            {
                return inserido;
            }
            else if (numero >= 43700001 && numero < 48101001)
            {
                return this.regraDV1(inserido, true);
            } 
            else
            {
                return this.regraDV2(inserido, true);
            }
        }

        public string ValidarDO(string inserido)
        {
            int numero = Convert.ToInt32(inserido);

            if (numero < 12075501)
            {
                return inserido;
            }
            else if (numero >= 12075501 && numero < 13600000)
            {
                return this.regraDV1(inserido, false);
            }
            else
            {
                return this.regraDV2(inserido, false);
            }
        }
    }
}
