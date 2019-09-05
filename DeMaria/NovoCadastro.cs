using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeMaria.src.controllers;
using DeMaria.src.methods;

namespace DeMaria
{
    public partial class NovoCadastro : Form
    {
        public NovoCadastro()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //IDictionary<string, string> dados = new Dictionary<string, string>();
            Registro novoRegistro = new Registro();

            novoRegistro.NomePai = txtNomePai.Text;
            novoRegistro.NascPai = txtNascPai.Text;
            novoRegistro.CidadePai = txtCidadePai.Text;
            novoRegistro.UFPai = txtUFPai.Text;

            novoRegistro.NomeMae = txtNomeMae.Text;
            novoRegistro.NascMae = txtNascMae.Text;
            novoRegistro.CidadeMae = txtCidadeMae.Text;
            novoRegistro.UFMae = txtUFMae.Text;

            novoRegistro.NomeRegistrado = txtNomeRegistrado.Text;
            novoRegistro.DataNascimento = txtDataNascimento.Text;
            novoRegistro.HoraNascimento = txtHoraNascimento.Text;
            novoRegistro.SexoRegistrado = rdbSexoRegistradoMasculino.Checked ? "Masculino" : (rdbSexoRegistradoFeminino.Checked ? "Feminino" : null);

            novoRegistro.Livro = rdbNascimentoVivo.Checked ? "A" : (rdbNascimentoMorto.Checked ? "C AUX" : null);
            novoRegistro.DNVDO = txtDNVDO.Text;

            novoRegistro.NumLivro = txtNumLivro.Text;
            novoRegistro.NumPagina = txtNumPagina.Text;
            novoRegistro.NumRegistro = txtNumRegistro.Text;

            novoRegistro.Prazo = rdbDentroDoPrazo.Checked ? "S" : (rdbForaDoPrazo.Checked ? "N" : null);

            IDictionary<string, string> pai = new Dictionary<string, string>();
            pai.Add("nome", novoRegistro.NomePai);
            pai.Add("nascimento", novoRegistro.NascPai);
            pai.Add("cidade", novoRegistro.CidadePai);
            pai.Add("uf", novoRegistro.UFPai);

            IDictionary<string, string> mae = new Dictionary<string, string>();
            mae.Add("nome", novoRegistro.NomeMae);
            mae.Add("nascimento", novoRegistro.NascMae);
            mae.Add("cidade", novoRegistro.CidadeMae);
            mae.Add("uf", novoRegistro.UFMae);

            bool paiValido = Registro.validarDadosFamilia(pai);
            bool maeValido = Registro.validarDadosFamilia(mae);

            if (paiValido && maeValido)
            {
                MessageBox.Show("Valido");
                novoRegistro.Salvar();
                this.Close();
            } else
            {
                MessageBox.Show("Invalido");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
