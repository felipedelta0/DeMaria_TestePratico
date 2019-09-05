using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeMaria.src.database;
using DeMaria.src.methods;

namespace DeMaria.src.controllers
{
    class Registro
    {
        public string Livro;
        public string NumLivro;
        public string NumPagina;
        public string NumRegistro;
        public string DataRegistro;
        public string NomeRegistrado;
        public string SexoRegistrado;
        public string DataNascimento;
        public string HoraNascimento;
        public string NomePai;
        public string NascPai;
        public string IdadePai;
        public string CidadePai;
        public string UFPai;
        public string NomeMae;
        public string NascMae;
        public string IdadeMae;
        public string CidadeMae;
        public string UFMae;
        public string DNVDO;
        public string Prazo;

        public Registro() { }
        public Registro(IDictionary<string, string> dados) { }

        public static bool validarDadosFamilia(IDictionary<string, string> familiar)
        {
            foreach (var dado in familiar)
            {
                if (dado.Key == "nome" || dado.Key == "cidade" || dado.Key == "uf")
                {
                    if (dado.Value == "")
                        return false;
                }
                else if (dado.Key == "nascimento")
                {
                    if (!UtilMethods.validarData(dado.Value))
                        return false;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public bool validarSexo()
        {
            if (this.SexoRegistrado == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validarNascimento()
        {
            return UtilMethods.validarData(this.DataNascimento) && UtilMethods.validarHora(this.HoraNascimento);
        }

        public bool validarDNVDO(int reg)
        {
            if (reg == 1)
            {
                return this.validarDNV();
            }
            else if (reg == 2)
            {
                return this.validarDO();
            }
            else
            {
                return false;
            }
        }

        public bool validarDNV()
        {
            return true;
        }

        public bool validarDO()
        {
            return true;
        }

        public string CalcularIdadePai()
        {
            return "todo";
        }

        public string CalcularIdadeMae()
        {
            return "todo";
        }

        public bool validarPrazo()
        {
            if (this.Prazo.ToUpper() == "S" || this.Prazo.ToUpper() == "N")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Salvar()
        {
            DateTime dtRegistro = DateTime.Now;
            this.DataRegistro = dtRegistro.ToString("dd/MM/yyyy");

            this.IdadePai = this.CalcularIdadePai();
            this.IdadeMae = this.CalcularIdadeMae();

            if (this.Prazo.ToUpper() == "S")
                this.Prazo = "Sim";
            else
                this.Prazo = "Não";

            try
            {
                Database.Adicionar(this);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
