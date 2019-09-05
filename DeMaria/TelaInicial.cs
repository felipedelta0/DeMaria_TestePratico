using DeMaria.src.controllers;
using DeMaria.src.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeMaria
{
    public partial class TelaInicial : Form
    {
        private Database dbConnection;
        public TelaInicial()
        {
            InitializeComponent();

            dbConnection = new Database();

            PopularIndice();
        }

        private void NovoCadastroMenuPrincipal_Click(object sender, EventArgs e)
        {
            NovoCadastro novoCadastro = new NovoCadastro();
            novoCadastro.Show();
        }

        private void PopularIndice()
        {
            gradeDadosCadastrados.DataSource = dbConnection.GetRegistros();
        }
    }
}
