namespace DeMaria
{
    partial class NovoCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ContainerPai = new System.Windows.Forms.GroupBox();
            this.txtNascPai = new System.Windows.Forms.MaskedTextBox();
            this.txtUFPai = new System.Windows.Forms.TextBox();
            this.lblUFPai = new System.Windows.Forms.Label();
            this.lblCidadePai = new System.Windows.Forms.Label();
            this.txtCidadePai = new System.Windows.Forms.TextBox();
            this.lblNascPai = new System.Windows.Forms.Label();
            this.txtNomePai = new System.Windows.Forms.TextBox();
            this.lblNomePai = new System.Windows.Forms.Label();
            this.ContainerMae = new System.Windows.Forms.GroupBox();
            this.txtNascMae = new System.Windows.Forms.MaskedTextBox();
            this.txtUFMae = new System.Windows.Forms.TextBox();
            this.txtCidadeMae = new System.Windows.Forms.TextBox();
            this.lblUFMae = new System.Windows.Forms.Label();
            this.lblNomeMae = new System.Windows.Forms.Label();
            this.lblCidadeMae = new System.Windows.Forms.Label();
            this.txtNomeMae = new System.Windows.Forms.TextBox();
            this.lblNascMae = new System.Windows.Forms.Label();
            this.ContainerRegistrado = new System.Windows.Forms.GroupBox();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraNascimento = new System.Windows.Forms.MaskedTextBox();
            this.rdbSexoRegistradoFeminino = new System.Windows.Forms.RadioButton();
            this.rdbSexoRegistradoMasculino = new System.Windows.Forms.RadioButton();
            this.txtNomeRegistrado = new System.Windows.Forms.TextBox();
            this.lblHoraNascimento = new System.Windows.Forms.Label();
            this.lblNomeRegistrado = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.ContainerRegistro = new System.Windows.Forms.GroupBox();
            this.txtDNVDO = new System.Windows.Forms.MaskedTextBox();
            this.rdbForaDoPrazo = new System.Windows.Forms.RadioButton();
            this.rdbDentroDoPrazo = new System.Windows.Forms.RadioButton();
            this.lblRegistroFeitoNoPrazo = new System.Windows.Forms.Label();
            this.txtNumRegistro = new System.Windows.Forms.MaskedTextBox();
            this.txtNumPagina = new System.Windows.Forms.MaskedTextBox();
            this.txtNumLivro = new System.Windows.Forms.MaskedTextBox();
            this.lblNumRegistro = new System.Windows.Forms.Label();
            this.lblNumPagina = new System.Windows.Forms.Label();
            this.lblNumLivro = new System.Windows.Forms.Label();
            this.lblDNVDO = new System.Windows.Forms.Label();
            this.rdbNascimentoMorto = new System.Windows.Forms.RadioButton();
            this.rdbNascimentoVivo = new System.Windows.Forms.RadioButton();
            this.lblTipoNascimento = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.containerPrazo = new System.Windows.Forms.GroupBox();
            this.ContainerPai.SuspendLayout();
            this.ContainerMae.SuspendLayout();
            this.ContainerRegistrado.SuspendLayout();
            this.ContainerRegistro.SuspendLayout();
            this.containerPrazo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContainerPai
            // 
            this.ContainerPai.Controls.Add(this.txtNascPai);
            this.ContainerPai.Controls.Add(this.txtUFPai);
            this.ContainerPai.Controls.Add(this.lblUFPai);
            this.ContainerPai.Controls.Add(this.lblCidadePai);
            this.ContainerPai.Controls.Add(this.txtCidadePai);
            this.ContainerPai.Controls.Add(this.lblNascPai);
            this.ContainerPai.Controls.Add(this.txtNomePai);
            this.ContainerPai.Controls.Add(this.lblNomePai);
            this.ContainerPai.Location = new System.Drawing.Point(12, 12);
            this.ContainerPai.Name = "ContainerPai";
            this.ContainerPai.Size = new System.Drawing.Size(320, 146);
            this.ContainerPai.TabIndex = 0;
            this.ContainerPai.TabStop = false;
            this.ContainerPai.Text = "Dados de Nascimento do Pai";
            // 
            // txtNascPai
            // 
            this.txtNascPai.Location = new System.Drawing.Point(120, 56);
            this.txtNascPai.Mask = "00/00/0000";
            this.txtNascPai.Name = "txtNascPai";
            this.txtNascPai.Size = new System.Drawing.Size(73, 20);
            this.txtNascPai.TabIndex = 19;
            // 
            // txtUFPai
            // 
            this.txtUFPai.Location = new System.Drawing.Point(120, 108);
            this.txtUFPai.Name = "txtUFPai";
            this.txtUFPai.Size = new System.Drawing.Size(184, 20);
            this.txtUFPai.TabIndex = 7;
            // 
            // lblUFPai
            // 
            this.lblUFPai.AutoSize = true;
            this.lblUFPai.Location = new System.Drawing.Point(15, 111);
            this.lblUFPai.Name = "lblUFPai";
            this.lblUFPai.Size = new System.Drawing.Size(80, 13);
            this.lblUFPai.TabIndex = 6;
            this.lblUFPai.Text = "UF Nascimento";
            // 
            // lblCidadePai
            // 
            this.lblCidadePai.AutoSize = true;
            this.lblCidadePai.Location = new System.Drawing.Point(14, 85);
            this.lblCidadePai.Name = "lblCidadePai";
            this.lblCidadePai.Size = new System.Drawing.Size(99, 13);
            this.lblCidadePai.TabIndex = 5;
            this.lblCidadePai.Text = "Cidade Nascimento";
            // 
            // txtCidadePai
            // 
            this.txtCidadePai.Location = new System.Drawing.Point(120, 82);
            this.txtCidadePai.Name = "txtCidadePai";
            this.txtCidadePai.Size = new System.Drawing.Size(184, 20);
            this.txtCidadePai.TabIndex = 4;
            // 
            // lblNascPai
            // 
            this.lblNascPai.AutoSize = true;
            this.lblNascPai.Location = new System.Drawing.Point(14, 59);
            this.lblNascPai.Name = "lblNascPai";
            this.lblNascPai.Size = new System.Drawing.Size(81, 13);
            this.lblNascPai.TabIndex = 2;
            this.lblNascPai.Text = "Nascimento Pai";
            // 
            // txtNomePai
            // 
            this.txtNomePai.Location = new System.Drawing.Point(120, 30);
            this.txtNomePai.Name = "txtNomePai";
            this.txtNomePai.Size = new System.Drawing.Size(184, 20);
            this.txtNomePai.TabIndex = 1;
            // 
            // lblNomePai
            // 
            this.lblNomePai.AutoSize = true;
            this.lblNomePai.Location = new System.Drawing.Point(15, 33);
            this.lblNomePai.Name = "lblNomePai";
            this.lblNomePai.Size = new System.Drawing.Size(53, 13);
            this.lblNomePai.TabIndex = 0;
            this.lblNomePai.Text = "Nome Pai";
            // 
            // ContainerMae
            // 
            this.ContainerMae.Controls.Add(this.txtNascMae);
            this.ContainerMae.Controls.Add(this.txtUFMae);
            this.ContainerMae.Controls.Add(this.txtCidadeMae);
            this.ContainerMae.Controls.Add(this.lblUFMae);
            this.ContainerMae.Controls.Add(this.lblNomeMae);
            this.ContainerMae.Controls.Add(this.lblCidadeMae);
            this.ContainerMae.Controls.Add(this.txtNomeMae);
            this.ContainerMae.Controls.Add(this.lblNascMae);
            this.ContainerMae.Location = new System.Drawing.Point(338, 12);
            this.ContainerMae.Name = "ContainerMae";
            this.ContainerMae.Size = new System.Drawing.Size(320, 146);
            this.ContainerMae.TabIndex = 1;
            this.ContainerMae.TabStop = false;
            this.ContainerMae.Text = "Dados de Nascimento da Mãe";
            // 
            // txtNascMae
            // 
            this.txtNascMae.Location = new System.Drawing.Point(117, 56);
            this.txtNascMae.Mask = "00/00/0000";
            this.txtNascMae.Name = "txtNascMae";
            this.txtNascMae.Size = new System.Drawing.Size(73, 20);
            this.txtNascMae.TabIndex = 20;
            // 
            // txtUFMae
            // 
            this.txtUFMae.Location = new System.Drawing.Point(117, 108);
            this.txtUFMae.Name = "txtUFMae";
            this.txtUFMae.Size = new System.Drawing.Size(184, 20);
            this.txtUFMae.TabIndex = 15;
            // 
            // txtCidadeMae
            // 
            this.txtCidadeMae.Location = new System.Drawing.Point(117, 82);
            this.txtCidadeMae.Name = "txtCidadeMae";
            this.txtCidadeMae.Size = new System.Drawing.Size(184, 20);
            this.txtCidadeMae.TabIndex = 12;
            // 
            // lblUFMae
            // 
            this.lblUFMae.AutoSize = true;
            this.lblUFMae.Location = new System.Drawing.Point(12, 111);
            this.lblUFMae.Name = "lblUFMae";
            this.lblUFMae.Size = new System.Drawing.Size(80, 13);
            this.lblUFMae.TabIndex = 14;
            this.lblUFMae.Text = "UF Nascimento";
            // 
            // lblNomeMae
            // 
            this.lblNomeMae.AutoSize = true;
            this.lblNomeMae.Location = new System.Drawing.Point(12, 33);
            this.lblNomeMae.Name = "lblNomeMae";
            this.lblNomeMae.Size = new System.Drawing.Size(59, 13);
            this.lblNomeMae.TabIndex = 8;
            this.lblNomeMae.Text = "Nome Mãe";
            // 
            // lblCidadeMae
            // 
            this.lblCidadeMae.AutoSize = true;
            this.lblCidadeMae.Location = new System.Drawing.Point(11, 85);
            this.lblCidadeMae.Name = "lblCidadeMae";
            this.lblCidadeMae.Size = new System.Drawing.Size(99, 13);
            this.lblCidadeMae.TabIndex = 13;
            this.lblCidadeMae.Text = "Cidade Nascimento";
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.Location = new System.Drawing.Point(117, 30);
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.Size = new System.Drawing.Size(184, 20);
            this.txtNomeMae.TabIndex = 9;
            // 
            // lblNascMae
            // 
            this.lblNascMae.AutoSize = true;
            this.lblNascMae.Location = new System.Drawing.Point(11, 59);
            this.lblNascMae.Name = "lblNascMae";
            this.lblNascMae.Size = new System.Drawing.Size(87, 13);
            this.lblNascMae.TabIndex = 10;
            this.lblNascMae.Text = "Nascimento Mãe";
            // 
            // ContainerRegistrado
            // 
            this.ContainerRegistrado.Controls.Add(this.txtDataNascimento);
            this.ContainerRegistrado.Controls.Add(this.txtHoraNascimento);
            this.ContainerRegistrado.Controls.Add(this.rdbSexoRegistradoFeminino);
            this.ContainerRegistrado.Controls.Add(this.rdbSexoRegistradoMasculino);
            this.ContainerRegistrado.Controls.Add(this.txtNomeRegistrado);
            this.ContainerRegistrado.Controls.Add(this.lblHoraNascimento);
            this.ContainerRegistrado.Controls.Add(this.lblNomeRegistrado);
            this.ContainerRegistrado.Controls.Add(this.lblDataNascimento);
            this.ContainerRegistrado.Controls.Add(this.lblSexo);
            this.ContainerRegistrado.Location = new System.Drawing.Point(12, 164);
            this.ContainerRegistrado.Name = "ContainerRegistrado";
            this.ContainerRegistrado.Size = new System.Drawing.Size(320, 146);
            this.ContainerRegistrado.TabIndex = 2;
            this.ContainerRegistrado.TabStop = false;
            this.ContainerRegistrado.Text = "Dados do Registrado";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(120, 80);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(73, 20);
            this.txtDataNascimento.TabIndex = 18;
            // 
            // txtHoraNascimento
            // 
            this.txtHoraNascimento.Location = new System.Drawing.Point(120, 110);
            this.txtHoraNascimento.Mask = "90:00";
            this.txtHoraNascimento.Name = "txtHoraNascimento";
            this.txtHoraNascimento.Size = new System.Drawing.Size(35, 20);
            this.txtHoraNascimento.TabIndex = 6;
            this.txtHoraNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // rdbSexoRegistradoFeminino
            // 
            this.rdbSexoRegistradoFeminino.AutoSize = true;
            this.rdbSexoRegistradoFeminino.Location = new System.Drawing.Point(219, 55);
            this.rdbSexoRegistradoFeminino.Name = "rdbSexoRegistradoFeminino";
            this.rdbSexoRegistradoFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbSexoRegistradoFeminino.TabIndex = 17;
            this.rdbSexoRegistradoFeminino.TabStop = true;
            this.rdbSexoRegistradoFeminino.Text = "Feminino";
            this.rdbSexoRegistradoFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbSexoRegistradoMasculino
            // 
            this.rdbSexoRegistradoMasculino.AutoSize = true;
            this.rdbSexoRegistradoMasculino.Location = new System.Drawing.Point(120, 55);
            this.rdbSexoRegistradoMasculino.Name = "rdbSexoRegistradoMasculino";
            this.rdbSexoRegistradoMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbSexoRegistradoMasculino.TabIndex = 16;
            this.rdbSexoRegistradoMasculino.TabStop = true;
            this.rdbSexoRegistradoMasculino.Text = "Masculino";
            this.rdbSexoRegistradoMasculino.UseVisualStyleBackColor = true;
            // 
            // txtNomeRegistrado
            // 
            this.txtNomeRegistrado.Location = new System.Drawing.Point(120, 28);
            this.txtNomeRegistrado.Name = "txtNomeRegistrado";
            this.txtNomeRegistrado.Size = new System.Drawing.Size(184, 20);
            this.txtNomeRegistrado.TabIndex = 9;
            // 
            // lblHoraNascimento
            // 
            this.lblHoraNascimento.AutoSize = true;
            this.lblHoraNascimento.Location = new System.Drawing.Point(15, 109);
            this.lblHoraNascimento.Name = "lblHoraNascimento";
            this.lblHoraNascimento.Size = new System.Drawing.Size(89, 13);
            this.lblHoraNascimento.TabIndex = 14;
            this.lblHoraNascimento.Text = "Hora Nascimento";
            // 
            // lblNomeRegistrado
            // 
            this.lblNomeRegistrado.AutoSize = true;
            this.lblNomeRegistrado.Location = new System.Drawing.Point(15, 31);
            this.lblNomeRegistrado.Name = "lblNomeRegistrado";
            this.lblNomeRegistrado.Size = new System.Drawing.Size(89, 13);
            this.lblNomeRegistrado.TabIndex = 8;
            this.lblNomeRegistrado.Text = "Nome Registrado";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(14, 83);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(89, 13);
            this.lblDataNascimento.TabIndex = 13;
            this.lblDataNascimento.Text = "Data Nascimento";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(14, 57);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(85, 13);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo Registrado";
            // 
            // ContainerRegistro
            // 
            this.ContainerRegistro.Controls.Add(this.txtDNVDO);
            this.ContainerRegistro.Controls.Add(this.txtNumRegistro);
            this.ContainerRegistro.Controls.Add(this.txtNumPagina);
            this.ContainerRegistro.Controls.Add(this.txtNumLivro);
            this.ContainerRegistro.Controls.Add(this.lblNumRegistro);
            this.ContainerRegistro.Controls.Add(this.lblNumPagina);
            this.ContainerRegistro.Controls.Add(this.lblNumLivro);
            this.ContainerRegistro.Controls.Add(this.lblDNVDO);
            this.ContainerRegistro.Controls.Add(this.rdbNascimentoMorto);
            this.ContainerRegistro.Controls.Add(this.rdbNascimentoVivo);
            this.ContainerRegistro.Controls.Add(this.lblTipoNascimento);
            this.ContainerRegistro.Location = new System.Drawing.Point(338, 164);
            this.ContainerRegistro.Name = "ContainerRegistro";
            this.ContainerRegistro.Size = new System.Drawing.Size(320, 111);
            this.ContainerRegistro.TabIndex = 3;
            this.ContainerRegistro.TabStop = false;
            this.ContainerRegistro.Text = "Dados de Registro";
            // 
            // txtDNVDO
            // 
            this.txtDNVDO.Location = new System.Drawing.Point(74, 52);
            this.txtDNVDO.Mask = "00000000";
            this.txtDNVDO.Name = "txtDNVDO";
            this.txtDNVDO.Size = new System.Drawing.Size(227, 20);
            this.txtDNVDO.TabIndex = 38;
            // 
            // rdbForaDoPrazo
            // 
            this.rdbForaDoPrazo.AutoSize = true;
            this.rdbForaDoPrazo.Location = new System.Drawing.Point(171, 46);
            this.rdbForaDoPrazo.Name = "rdbForaDoPrazo";
            this.rdbForaDoPrazo.Size = new System.Drawing.Size(91, 17);
            this.rdbForaDoPrazo.TabIndex = 37;
            this.rdbForaDoPrazo.TabStop = true;
            this.rdbForaDoPrazo.Text = "Fora do Prazo";
            this.rdbForaDoPrazo.UseVisualStyleBackColor = true;
            // 
            // rdbDentroDoPrazo
            // 
            this.rdbDentroDoPrazo.AutoSize = true;
            this.rdbDentroDoPrazo.Location = new System.Drawing.Point(171, 19);
            this.rdbDentroDoPrazo.Name = "rdbDentroDoPrazo";
            this.rdbDentroDoPrazo.Size = new System.Drawing.Size(102, 17);
            this.rdbDentroDoPrazo.TabIndex = 36;
            this.rdbDentroDoPrazo.TabStop = true;
            this.rdbDentroDoPrazo.Text = "Dentro do Prazo";
            this.rdbDentroDoPrazo.UseVisualStyleBackColor = true;
            // 
            // lblRegistroFeitoNoPrazo
            // 
            this.lblRegistroFeitoNoPrazo.AutoSize = true;
            this.lblRegistroFeitoNoPrazo.Location = new System.Drawing.Point(25, 40);
            this.lblRegistroFeitoNoPrazo.Name = "lblRegistroFeitoNoPrazo";
            this.lblRegistroFeitoNoPrazo.Size = new System.Drawing.Size(120, 13);
            this.lblRegistroFeitoNoPrazo.TabIndex = 35;
            this.lblRegistroFeitoNoPrazo.Text = "Registro feito no Prazo?";
            // 
            // txtNumRegistro
            // 
            this.txtNumRegistro.Location = new System.Drawing.Point(260, 83);
            this.txtNumRegistro.Mask = "00000";
            this.txtNumRegistro.Name = "txtNumRegistro";
            this.txtNumRegistro.Size = new System.Drawing.Size(41, 20);
            this.txtNumRegistro.TabIndex = 34;
            this.txtNumRegistro.ValidatingType = typeof(int);
            // 
            // txtNumPagina
            // 
            this.txtNumPagina.Location = new System.Drawing.Point(160, 83);
            this.txtNumPagina.Mask = "00000";
            this.txtNumPagina.Name = "txtNumPagina";
            this.txtNumPagina.Size = new System.Drawing.Size(41, 20);
            this.txtNumPagina.TabIndex = 33;
            this.txtNumPagina.ValidatingType = typeof(int);
            // 
            // txtNumLivro
            // 
            this.txtNumLivro.Location = new System.Drawing.Point(69, 83);
            this.txtNumLivro.Mask = "00000";
            this.txtNumLivro.Name = "txtNumLivro";
            this.txtNumLivro.Size = new System.Drawing.Size(41, 20);
            this.txtNumLivro.TabIndex = 32;
            this.txtNumLivro.ValidatingType = typeof(int);
            // 
            // lblNumRegistro
            // 
            this.lblNumRegistro.AutoSize = true;
            this.lblNumRegistro.Location = new System.Drawing.Point(207, 86);
            this.lblNumRegistro.Name = "lblNumRegistro";
            this.lblNumRegistro.Size = new System.Drawing.Size(46, 13);
            this.lblNumRegistro.TabIndex = 31;
            this.lblNumRegistro.Text = "Registro";
            // 
            // lblNumPagina
            // 
            this.lblNumPagina.AutoSize = true;
            this.lblNumPagina.Location = new System.Drawing.Point(119, 86);
            this.lblNumPagina.Name = "lblNumPagina";
            this.lblNumPagina.Size = new System.Drawing.Size(40, 13);
            this.lblNumPagina.TabIndex = 30;
            this.lblNumPagina.Text = "Pagina";
            // 
            // lblNumLivro
            // 
            this.lblNumLivro.AutoSize = true;
            this.lblNumLivro.Location = new System.Drawing.Point(18, 86);
            this.lblNumLivro.Name = "lblNumLivro";
            this.lblNumLivro.Size = new System.Drawing.Size(45, 13);
            this.lblNumLivro.TabIndex = 19;
            this.lblNumLivro.Text = "Nº Livro";
            // 
            // lblDNVDO
            // 
            this.lblDNVDO.AutoSize = true;
            this.lblDNVDO.Location = new System.Drawing.Point(14, 55);
            this.lblDNVDO.Name = "lblDNVDO";
            this.lblDNVDO.Size = new System.Drawing.Size(51, 13);
            this.lblDNVDO.TabIndex = 28;
            this.lblDNVDO.Text = "DNV/DO";
            // 
            // rdbNascimentoMorto
            // 
            this.rdbNascimentoMorto.AutoSize = true;
            this.rdbNascimentoMorto.Location = new System.Drawing.Point(191, 26);
            this.rdbNascimentoMorto.Name = "rdbNascimentoMorto";
            this.rdbNascimentoMorto.Size = new System.Drawing.Size(52, 17);
            this.rdbNascimentoMorto.TabIndex = 27;
            this.rdbNascimentoMorto.TabStop = true;
            this.rdbNascimentoMorto.Text = "Morto";
            this.rdbNascimentoMorto.UseVisualStyleBackColor = true;
            // 
            // rdbNascimentoVivo
            // 
            this.rdbNascimentoVivo.AutoSize = true;
            this.rdbNascimentoVivo.Location = new System.Drawing.Point(100, 26);
            this.rdbNascimentoVivo.Name = "rdbNascimentoVivo";
            this.rdbNascimentoVivo.Size = new System.Drawing.Size(46, 17);
            this.rdbNascimentoVivo.TabIndex = 26;
            this.rdbNascimentoVivo.TabStop = true;
            this.rdbNascimentoVivo.Text = "Vivo";
            this.rdbNascimentoVivo.UseVisualStyleBackColor = true;
            // 
            // lblTipoNascimento
            // 
            this.lblTipoNascimento.AutoSize = true;
            this.lblTipoNascimento.Location = new System.Drawing.Point(6, 28);
            this.lblTipoNascimento.Name = "lblTipoNascimento";
            this.lblTipoNascimento.Size = new System.Drawing.Size(63, 13);
            this.lblTipoNascimento.TabIndex = 16;
            this.lblTipoNascimento.Text = "Nascimento";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(86, 321);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(167, 321);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // containerPrazo
            // 
            this.containerPrazo.Controls.Add(this.lblRegistroFeitoNoPrazo);
            this.containerPrazo.Controls.Add(this.rdbDentroDoPrazo);
            this.containerPrazo.Controls.Add(this.rdbForaDoPrazo);
            this.containerPrazo.Location = new System.Drawing.Point(339, 281);
            this.containerPrazo.Name = "containerPrazo";
            this.containerPrazo.Size = new System.Drawing.Size(318, 87);
            this.containerPrazo.TabIndex = 38;
            this.containerPrazo.TabStop = false;
            this.containerPrazo.Text = "Prazo";
            // 
            // NovoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 373);
            this.Controls.Add(this.containerPrazo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.ContainerRegistro);
            this.Controls.Add(this.ContainerRegistrado);
            this.Controls.Add(this.ContainerPai);
            this.Controls.Add(this.ContainerMae);
            this.Name = "NovoCadastro";
            this.Text = "Novo Cadastro";
            this.ContainerPai.ResumeLayout(false);
            this.ContainerPai.PerformLayout();
            this.ContainerMae.ResumeLayout(false);
            this.ContainerMae.PerformLayout();
            this.ContainerRegistrado.ResumeLayout(false);
            this.ContainerRegistrado.PerformLayout();
            this.ContainerRegistro.ResumeLayout(false);
            this.ContainerRegistro.PerformLayout();
            this.containerPrazo.ResumeLayout(false);
            this.containerPrazo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ContainerPai;
        private System.Windows.Forms.GroupBox ContainerMae;
        private System.Windows.Forms.GroupBox ContainerRegistrado;
        private System.Windows.Forms.GroupBox ContainerRegistro;
        private System.Windows.Forms.GroupBox containerPrazo;

        private System.Windows.Forms.TextBox txtNomePai;
        private System.Windows.Forms.TextBox txtCidadePai;
        private System.Windows.Forms.TextBox txtUFPai;
        private System.Windows.Forms.TextBox txtNomeMae;
        private System.Windows.Forms.TextBox txtCidadeMae;
        private System.Windows.Forms.TextBox txtUFMae;
        private System.Windows.Forms.TextBox txtNomeRegistrado;

        private System.Windows.Forms.MaskedTextBox txtHoraNascimento;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.MaskedTextBox txtNascPai;
        private System.Windows.Forms.MaskedTextBox txtNascMae;
        private System.Windows.Forms.MaskedTextBox txtNumLivro;
        private System.Windows.Forms.MaskedTextBox txtNumPagina;
        private System.Windows.Forms.MaskedTextBox txtNumRegistro;
        private System.Windows.Forms.MaskedTextBox txtDNVDO;

        private System.Windows.Forms.Label lblNomePai;
        private System.Windows.Forms.Label lblNascPai;
        private System.Windows.Forms.Label lblCidadePai;
        private System.Windows.Forms.Label lblUFPai;
        private System.Windows.Forms.Label lblUFMae;
        private System.Windows.Forms.Label lblNomeMae;
        private System.Windows.Forms.Label lblCidadeMae;
        private System.Windows.Forms.Label lblNascMae;
        private System.Windows.Forms.Label lblHoraNascimento;
        private System.Windows.Forms.Label lblNomeRegistrado;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTipoNascimento;
        private System.Windows.Forms.Label lblDNVDO;
        private System.Windows.Forms.Label lblNumLivro;
        private System.Windows.Forms.Label lblNumPagina;
        private System.Windows.Forms.Label lblNumRegistro;
        private System.Windows.Forms.Label lblRegistroFeitoNoPrazo;

        private System.Windows.Forms.RadioButton rdbSexoRegistradoFeminino;
        private System.Windows.Forms.RadioButton rdbSexoRegistradoMasculino;
        private System.Windows.Forms.RadioButton rdbNascimentoMorto;
        private System.Windows.Forms.RadioButton rdbNascimentoVivo;
        private System.Windows.Forms.RadioButton rdbDentroDoPrazo;
        private System.Windows.Forms.RadioButton rdbForaDoPrazo;

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}