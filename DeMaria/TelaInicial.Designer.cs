namespace DeMaria
{
    partial class TelaInicial
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.novoCadastroMenuPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.gradeDadosCadastrados = new System.Windows.Forms.DataGridView();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeDadosCadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalCadastros});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1016, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "Menu Principal";
            // 
            // menuPrincipalCadastros
            // 
            this.menuPrincipalCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCadastroMenuPrincipal});
            this.menuPrincipalCadastros.Name = "menuPrincipalCadastros";
            this.menuPrincipalCadastros.Size = new System.Drawing.Size(71, 20);
            this.menuPrincipalCadastros.Text = "Cadastros";
            // 
            // novoCadastroMenuPrincipal
            // 
            this.novoCadastroMenuPrincipal.Name = "novoCadastroMenuPrincipal";
            this.novoCadastroMenuPrincipal.Size = new System.Drawing.Size(153, 22);
            this.novoCadastroMenuPrincipal.Text = "Novo Cadastro";
            this.novoCadastroMenuPrincipal.Click += new System.EventHandler(this.NovoCadastroMenuPrincipal_Click);
            // 
            // gradeDadosCadastrados
            // 
            this.gradeDadosCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeDadosCadastrados.Location = new System.Drawing.Point(12, 27);
            this.gradeDadosCadastrados.Name = "gradeDadosCadastrados";
            this.gradeDadosCadastrados.Size = new System.Drawing.Size(992, 447);
            this.gradeDadosCadastrados.TabIndex = 1;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 486);
            this.Controls.Add(this.gradeDadosCadastrados);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "TelaInicial";
            this.Text = "Tela Inicial";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeDadosCadastrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalCadastros;
        private System.Windows.Forms.ToolStripMenuItem novoCadastroMenuPrincipal;

        private System.Windows.Forms.DataGridView gradeDadosCadastrados;
    }
}