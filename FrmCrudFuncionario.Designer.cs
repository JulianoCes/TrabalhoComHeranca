namespace TrabalhoComHeranca
{
    partial class FrmCrudFuncionario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFuncao = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.mtxtSalario = new System.Windows.Forms.TextBox();
            this.cbxFuncao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.Location = new System.Drawing.Point(88, 115);
            this.mtxtCpf.Size = new System.Drawing.Size(131, 21);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncao.ForeColor = System.Drawing.Color.White;
            this.lblFuncao.Location = new System.Drawing.Point(21, 148);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(54, 15);
            this.lblFuncao.TabIndex = 42;
            this.lblFuncao.Text = "Função";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.ForeColor = System.Drawing.Color.White;
            this.lblSalario.Location = new System.Drawing.Point(268, 149);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(53, 15);
            this.lblSalario.TabIndex = 43;
            this.lblSalario.Text = "Salário";
            // 
            // mtxtSalario
            // 
            this.mtxtSalario.BackColor = System.Drawing.SystemColors.WindowText;
            this.mtxtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtSalario.ForeColor = System.Drawing.Color.White;
            this.mtxtSalario.Location = new System.Drawing.Point(336, 147);
            this.mtxtSalario.Name = "mtxtSalario";
            this.mtxtSalario.Size = new System.Drawing.Size(116, 21);
            this.mtxtSalario.TabIndex = 7;
            // 
            // cbxFuncao
            // 
            this.cbxFuncao.BackColor = System.Drawing.SystemColors.WindowText;
            this.cbxFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFuncao.ForeColor = System.Drawing.Color.White;
            this.cbxFuncao.FormattingEnabled = true;
            this.cbxFuncao.Items.AddRange(new object[] {
            "Administração",
            "Amoxerifado",
            "Auxiliar",
            "Operador",
            "Servisos Gerais"});
            this.cbxFuncao.Location = new System.Drawing.Point(88, 147);
            this.cbxFuncao.Name = "cbxFuncao";
            this.cbxFuncao.Size = new System.Drawing.Size(159, 23);
            this.cbxFuncao.TabIndex = 6;
            // 
            // FrmCrudFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(588, 394);
            this.Controls.Add(this.cbxFuncao);
            this.Controls.Add(this.mtxtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblFuncao);
            this.Name = "FrmCrudFuncionario";
            this.Text = "Cadastro de Funcionario";
            this.Load += new System.EventHandler(this.FrmCrudFuncionario_Load);
            this.Controls.SetChildIndex(this.mtxtId, 0);
            this.Controls.SetChildIndex(this.mtxtNome, 0);
            this.Controls.SetChildIndex(this.mtxtEndereco, 0);
            this.Controls.SetChildIndex(this.mtxtCpf, 0);
            this.Controls.SetChildIndex(this.mtxtFone, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.btnCadastrar, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.lblFuncao, 0);
            this.Controls.SetChildIndex(this.lblSalario, 0);
            this.Controls.SetChildIndex(this.mtxtSalario, 0);
            this.Controls.SetChildIndex(this.cbxFuncao, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox mtxtSalario;
        private System.Windows.Forms.ComboBox cbxFuncao;
    }
}
