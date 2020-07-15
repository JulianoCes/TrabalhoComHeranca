namespace TrabalhoComHeranca
{
    partial class FrmCrudCliente
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
            this.lblDataNacimento = new System.Windows.Forms.Label();
            this.dtpDataNacimento = new System.Windows.Forms.DateTimePicker();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            // lblDataNacimento
            // 
            this.lblDataNacimento.AutoSize = true;
            this.lblDataNacimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNacimento.ForeColor = System.Drawing.Color.White;
            this.lblDataNacimento.Location = new System.Drawing.Point(16, 151);
            this.lblDataNacimento.Name = "lblDataNacimento";
            this.lblDataNacimento.Size = new System.Drawing.Size(130, 15);
            this.lblDataNacimento.TabIndex = 42;
            this.lblDataNacimento.Text = "Data de Nacimento";
            // 
            // dtpDataNacimento
            // 
            this.dtpDataNacimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNacimento.CalendarForeColor = System.Drawing.Color.White;
            this.dtpDataNacimento.CalendarMonthBackground = System.Drawing.SystemColors.WindowText;
            this.dtpDataNacimento.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dtpDataNacimento.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpDataNacimento.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dtpDataNacimento.CustomFormat = "";
            this.dtpDataNacimento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDataNacimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNacimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataNacimento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDataNacimento.Location = new System.Drawing.Point(153, 146);
            this.dtpDataNacimento.Name = "dtpDataNacimento";
            this.dtpDataNacimento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpDataNacimento.Size = new System.Drawing.Size(92, 21);
            this.dtpDataNacimento.TabIndex = 6;
            this.dtpDataNacimento.Value = new System.DateTime(2020, 7, 15, 0, 0, 0, 0);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.White;
            this.lblSexo.Location = new System.Drawing.Point(251, 146);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 15);
            this.lblSexo.TabIndex = 43;
            this.lblSexo.Text = "Sexo";
            // 
            // cbxSexo
            // 
            this.cbxSexo.BackColor = System.Drawing.SystemColors.WindowText;
            this.cbxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSexo.ForeColor = System.Drawing.Color.White;
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbxSexo.Location = new System.Drawing.Point(301, 146);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(151, 23);
            this.cbxSexo.TabIndex = 7;
            // 
            // FrmCrudCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(589, 389);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.dtpDataNacimento);
            this.Controls.Add(this.lblDataNacimento);
            this.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.Name = "FrmCrudCliente";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.FrmCrudCliente_Load);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.btnCadastrar, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.mtxtId, 0);
            this.Controls.SetChildIndex(this.mtxtNome, 0);
            this.Controls.SetChildIndex(this.mtxtEndereco, 0);
            this.Controls.SetChildIndex(this.mtxtCpf, 0);
            this.Controls.SetChildIndex(this.mtxtFone, 0);
            this.Controls.SetChildIndex(this.lblDataNacimento, 0);
            this.Controls.SetChildIndex(this.dtpDataNacimento, 0);
            this.Controls.SetChildIndex(this.lblSexo, 0);
            this.Controls.SetChildIndex(this.cbxSexo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataNacimento;
        private System.Windows.Forms.DateTimePicker dtpDataNacimento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cbxSexo;
    }
}
