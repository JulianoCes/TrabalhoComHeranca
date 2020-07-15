namespace TrabalhoComHeranca
{
    partial class FrmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.mtxtId = new System.Windows.Forms.TextBox();
            this.mtxtNome = new System.Windows.Forms.TextBox();
            this.mtxtEndereco = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.dgvBase = new System.Windows.Forms.DataGridView();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.mtxtFone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mtxtCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxtId
            // 
            this.mtxtId.BackColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.mtxtId, "mtxtId");
            this.mtxtId.ForeColor = System.Drawing.Color.AliceBlue;
            this.mtxtId.Name = "mtxtId";
            this.mtxtId.UseWaitCursor = true;
            // 
            // mtxtNome
            // 
            this.mtxtNome.BackColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.mtxtNome, "mtxtNome");
            this.mtxtNome.ForeColor = System.Drawing.Color.AliceBlue;
            this.mtxtNome.Name = "mtxtNome";
            // 
            // mtxtEndereco
            // 
            this.mtxtEndereco.BackColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.mtxtEndereco, "mtxtEndereco");
            this.mtxtEndereco.ForeColor = System.Drawing.Color.AliceBlue;
            this.mtxtEndereco.Name = "mtxtEndereco";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.btnPesquisar, "btnPesquisar");
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.btnCadastrar, "btnCadastrar");
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.btnEditar, "btnEditar");
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.btnExcluir, "btnExcluir");
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblId
            // 
            resources.ApplyResources(this.lblId, "lblId");
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Name = "lblId";
            // 
            // lblNome
            // 
            resources.ApplyResources(this.lblNome, "lblNome");
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Name = "lblNome";
            // 
            // lblEndereco
            // 
            resources.ApplyResources(this.lblEndereco, "lblEndereco");
            this.lblEndereco.ForeColor = System.Drawing.Color.White;
            this.lblEndereco.Name = "lblEndereco";
            // 
            // dgvBase
            // 
            resources.ApplyResources(this.dgvBase, "dgvBase");
            this.dgvBase.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBase.GridColor = System.Drawing.SystemColors.Control;
            this.dgvBase.Name = "dgvBase";
            this.dgvBase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBase_CellClick);
            // 
            // lblDescricao
            // 
            resources.ApplyResources(this.lblDescricao, "lblDescricao");
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Name = "lblDescricao";
            // 
            // mtxtFone
            // 
            this.mtxtFone.BackColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.mtxtFone, "mtxtFone");
            this.mtxtFone.ForeColor = System.Drawing.Color.AliceBlue;
            this.mtxtFone.Name = "mtxtFone";
            // 
            // lblTelefone
            // 
            resources.ApplyResources(this.lblTelefone, "lblTelefone");
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Name = "lblTelefone";
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.BackColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.mtxtCpf, "mtxtCpf");
            this.mtxtCpf.ForeColor = System.Drawing.Color.AliceBlue;
            this.mtxtCpf.Name = "mtxtCpf";
            // 
            // lblCpf
            // 
            resources.ApplyResources(this.lblCpf, "lblCpf");
            this.lblCpf.ForeColor = System.Drawing.Color.White;
            this.lblCpf.Name = "lblCpf";
            // 
            // FrmBase
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.dgvBase);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.mtxtFone);
            this.Controls.Add(this.mtxtCpf);
            this.Controls.Add(this.mtxtEndereco);
            this.Controls.Add(this.mtxtNome);
            this.Controls.Add(this.mtxtId);
            this.ForeColor = System.Drawing.Color.Black;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBase";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.ForestGreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox mtxtId;
        public System.Windows.Forms.TextBox mtxtEndereco;
        public System.Windows.Forms.TextBox mtxtNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblDescricao;
        public System.Windows.Forms.TextBox mtxtFone;
        private System.Windows.Forms.Label lblTelefone;
        public System.Windows.Forms.TextBox mtxtCpf;
        private System.Windows.Forms.Label lblCpf;
        public System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.Button btnCadastrar;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.DataGridView dgvBase;
    }
}