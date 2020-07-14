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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mlblId = new MetroFramework.Controls.MetroLabel();
            this.mtxtId = new MetroFramework.Controls.MetroTextBox();
            this.mbtnLocalizar = new MetroFramework.Controls.MetroButton();
            this.mbtnCadastrar = new MetroFramework.Controls.MetroButton();
            this.mbtnEditar = new MetroFramework.Controls.MetroButton();
            this.mbtnSair = new MetroFramework.Controls.MetroButton();
            this.mdgvBase = new MetroFramework.Controls.MetroGrid();
            this.mbtnExcluir = new MetroFramework.Controls.MetroButton();
            this.mtxtCpf = new MetroFramework.Controls.MetroTextBox();
            this.mlblCpf = new MetroFramework.Controls.MetroLabel();
            this.mtxtNome = new MetroFramework.Controls.MetroTextBox();
            this.mlblNome = new MetroFramework.Controls.MetroLabel();
            this.mtxtEndereco = new MetroFramework.Controls.MetroTextBox();
            this.mlblEndereco = new MetroFramework.Controls.MetroLabel();
            this.mtxtFone = new MetroFramework.Controls.MetroTextBox();
            this.mlblFone = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvBase)).BeginInit();
            this.SuspendLayout();
            // 
            // mlblId
            // 
            resources.ApplyResources(this.mlblId, "mlblId");
            this.mlblId.BackColor = System.Drawing.Color.White;
            this.mlblId.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblId.ForeColor = System.Drawing.Color.DarkBlue;
            this.mlblId.Name = "mlblId";
            this.mlblId.UseCustomBackColor = true;
            this.mlblId.UseCustomForeColor = true;
            this.mlblId.UseStyleColors = true;
            this.mlblId.UseWaitCursor = true;
            // 
            // mtxtId
            // 
            resources.ApplyResources(this.mtxtId, "mtxtId");
            // 
            // 
            // 
            this.mtxtId.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription");
            this.mtxtId.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName");
            this.mtxtId.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor")));
            this.mtxtId.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize")));
            this.mtxtId.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode")));
            this.mtxtId.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage")));
            this.mtxtId.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout")));
            this.mtxtId.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock")));
            this.mtxtId.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle")));
            this.mtxtId.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            this.mtxtId.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.mtxtId.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign")));
            this.mtxtId.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex")));
            this.mtxtId.CustomButton.ImageKey = resources.GetString("resource.ImageKey");
            this.mtxtId.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.mtxtId.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.mtxtId.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize")));
            this.mtxtId.CustomButton.Name = "";
            this.mtxtId.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft")));
            this.mtxtId.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.mtxtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtId.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.mtxtId.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign")));
            this.mtxtId.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation")));
            this.mtxtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtId.CustomButton.UseSelectable = true;
            this.mtxtId.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.mtxtId.Lines = new string[0];
            this.mtxtId.MaxLength = 32767;
            this.mtxtId.Name = "mtxtId";
            this.mtxtId.PasswordChar = '\0';
            this.mtxtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtId.SelectedText = "";
            this.mtxtId.SelectionLength = 0;
            this.mtxtId.SelectionStart = 0;
            this.mtxtId.ShortcutsEnabled = true;
            this.mtxtId.UseSelectable = true;
            this.mtxtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtnLocalizar
            // 
            resources.ApplyResources(this.mbtnLocalizar, "mbtnLocalizar");
            this.mbtnLocalizar.BackColor = System.Drawing.Color.Gray;
            this.mbtnLocalizar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtnLocalizar.ForeColor = System.Drawing.Color.Navy;
            this.mbtnLocalizar.Name = "mbtnLocalizar";
            this.mbtnLocalizar.UseSelectable = true;
            // 
            // mbtnCadastrar
            // 
            resources.ApplyResources(this.mbtnCadastrar, "mbtnCadastrar");
            this.mbtnCadastrar.BackColor = System.Drawing.Color.DarkSalmon;
            this.mbtnCadastrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtnCadastrar.ForeColor = System.Drawing.Color.Navy;
            this.mbtnCadastrar.Name = "mbtnCadastrar";
            this.mbtnCadastrar.UseSelectable = true;
            // 
            // mbtnEditar
            // 
            resources.ApplyResources(this.mbtnEditar, "mbtnEditar");
            this.mbtnEditar.BackColor = System.Drawing.Color.Gray;
            this.mbtnEditar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtnEditar.ForeColor = System.Drawing.Color.Navy;
            this.mbtnEditar.Name = "mbtnEditar";
            this.mbtnEditar.TabStop = false;
            this.mbtnEditar.UseSelectable = true;
            // 
            // mbtnSair
            // 
            resources.ApplyResources(this.mbtnSair, "mbtnSair");
            this.mbtnSair.BackColor = System.Drawing.Color.Gray;
            this.mbtnSair.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtnSair.ForeColor = System.Drawing.Color.Navy;
            this.mbtnSair.Name = "mbtnSair";
            this.mbtnSair.UseSelectable = true;
            this.mbtnSair.Click += new System.EventHandler(this.mbtnSair_Click);
            // 
            // mdgvBase
            // 
            resources.ApplyResources(this.mdgvBase, "mdgvBase");
            this.mdgvBase.AllowUserToResizeRows = false;
            this.mdgvBase.BackgroundColor = System.Drawing.Color.DimGray;
            this.mdgvBase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvBase.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvBase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvBase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.mdgvBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvBase.DefaultCellStyle = dataGridViewCellStyle11;
            this.mdgvBase.EnableHeadersVisualStyles = false;
            this.mdgvBase.GridColor = System.Drawing.Color.DimGray;
            this.mdgvBase.Name = "mdgvBase";
            this.mdgvBase.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvBase.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.mdgvBase.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // mbtnExcluir
            // 
            resources.ApplyResources(this.mbtnExcluir, "mbtnExcluir");
            this.mbtnExcluir.BackColor = System.Drawing.Color.Gray;
            this.mbtnExcluir.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtnExcluir.ForeColor = System.Drawing.Color.Navy;
            this.mbtnExcluir.Name = "mbtnExcluir";
            this.mbtnExcluir.UseSelectable = true;
            // 
            // mtxtCpf
            // 
            resources.ApplyResources(this.mtxtCpf, "mtxtCpf");
            // 
            // 
            // 
            this.mtxtCpf.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription1");
            this.mtxtCpf.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName1");
            this.mtxtCpf.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor1")));
            this.mtxtCpf.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize1")));
            this.mtxtCpf.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode1")));
            this.mtxtCpf.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage1")));
            this.mtxtCpf.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout1")));
            this.mtxtCpf.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock1")));
            this.mtxtCpf.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle1")));
            this.mtxtCpf.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font1")));
            this.mtxtCpf.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.mtxtCpf.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign1")));
            this.mtxtCpf.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex1")));
            this.mtxtCpf.CustomButton.ImageKey = resources.GetString("resource.ImageKey1");
            this.mtxtCpf.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.mtxtCpf.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.mtxtCpf.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize1")));
            this.mtxtCpf.CustomButton.Name = "";
            this.mtxtCpf.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft1")));
            this.mtxtCpf.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.mtxtCpf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtCpf.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.mtxtCpf.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign1")));
            this.mtxtCpf.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation1")));
            this.mtxtCpf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtCpf.CustomButton.UseSelectable = true;
            this.mtxtCpf.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.mtxtCpf.Lines = new string[0];
            this.mtxtCpf.MaxLength = 32767;
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.PasswordChar = '\0';
            this.mtxtCpf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCpf.SelectedText = "";
            this.mtxtCpf.SelectionLength = 0;
            this.mtxtCpf.SelectionStart = 0;
            this.mtxtCpf.ShortcutsEnabled = true;
            this.mtxtCpf.UseSelectable = true;
            this.mtxtCpf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtCpf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblCpf
            // 
            resources.ApplyResources(this.mlblCpf, "mlblCpf");
            this.mlblCpf.BackColor = System.Drawing.Color.White;
            this.mlblCpf.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.mlblCpf.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblCpf.ForeColor = System.Drawing.Color.Navy;
            this.mlblCpf.Name = "mlblCpf";
            this.mlblCpf.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mlblCpf.UseCustomBackColor = true;
            this.mlblCpf.UseCustomForeColor = true;
            this.mlblCpf.UseStyleColors = true;
            this.mlblCpf.UseWaitCursor = true;
            // 
            // mtxtNome
            // 
            resources.ApplyResources(this.mtxtNome, "mtxtNome");
            // 
            // 
            // 
            this.mtxtNome.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription2");
            this.mtxtNome.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName2");
            this.mtxtNome.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor2")));
            this.mtxtNome.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize2")));
            this.mtxtNome.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode2")));
            this.mtxtNome.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage2")));
            this.mtxtNome.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout2")));
            this.mtxtNome.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock2")));
            this.mtxtNome.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle2")));
            this.mtxtNome.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font2")));
            this.mtxtNome.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.mtxtNome.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign2")));
            this.mtxtNome.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex2")));
            this.mtxtNome.CustomButton.ImageKey = resources.GetString("resource.ImageKey2");
            this.mtxtNome.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode2")));
            this.mtxtNome.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.mtxtNome.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize2")));
            this.mtxtNome.CustomButton.Name = "";
            this.mtxtNome.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft2")));
            this.mtxtNome.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.mtxtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtNome.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.mtxtNome.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign2")));
            this.mtxtNome.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation2")));
            this.mtxtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtNome.CustomButton.UseSelectable = true;
            this.mtxtNome.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible2")));
            this.mtxtNome.Lines = new string[0];
            this.mtxtNome.MaxLength = 32767;
            this.mtxtNome.Name = "mtxtNome";
            this.mtxtNome.PasswordChar = '\0';
            this.mtxtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtNome.SelectedText = "";
            this.mtxtNome.SelectionLength = 0;
            this.mtxtNome.SelectionStart = 0;
            this.mtxtNome.ShortcutsEnabled = true;
            this.mtxtNome.UseSelectable = true;
            this.mtxtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblNome
            // 
            resources.ApplyResources(this.mlblNome, "mlblNome");
            this.mlblNome.BackColor = System.Drawing.Color.White;
            this.mlblNome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblNome.ForeColor = System.Drawing.Color.Navy;
            this.mlblNome.Name = "mlblNome";
            this.mlblNome.UseCustomBackColor = true;
            this.mlblNome.UseCustomForeColor = true;
            this.mlblNome.UseStyleColors = true;
            this.mlblNome.UseWaitCursor = true;
            // 
            // mtxtEndereco
            // 
            resources.ApplyResources(this.mtxtEndereco, "mtxtEndereco");
            // 
            // 
            // 
            this.mtxtEndereco.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription3");
            this.mtxtEndereco.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName3");
            this.mtxtEndereco.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor3")));
            this.mtxtEndereco.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize3")));
            this.mtxtEndereco.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode3")));
            this.mtxtEndereco.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage3")));
            this.mtxtEndereco.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout3")));
            this.mtxtEndereco.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock3")));
            this.mtxtEndereco.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle3")));
            this.mtxtEndereco.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font3")));
            this.mtxtEndereco.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.mtxtEndereco.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign3")));
            this.mtxtEndereco.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex3")));
            this.mtxtEndereco.CustomButton.ImageKey = resources.GetString("resource.ImageKey3");
            this.mtxtEndereco.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode3")));
            this.mtxtEndereco.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location3")));
            this.mtxtEndereco.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize3")));
            this.mtxtEndereco.CustomButton.Name = "";
            this.mtxtEndereco.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft3")));
            this.mtxtEndereco.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size3")));
            this.mtxtEndereco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtEndereco.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex3")));
            this.mtxtEndereco.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign3")));
            this.mtxtEndereco.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation3")));
            this.mtxtEndereco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtEndereco.CustomButton.UseSelectable = true;
            this.mtxtEndereco.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible3")));
            this.mtxtEndereco.Lines = new string[0];
            this.mtxtEndereco.MaxLength = 32767;
            this.mtxtEndereco.Name = "mtxtEndereco";
            this.mtxtEndereco.PasswordChar = '\0';
            this.mtxtEndereco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtEndereco.SelectedText = "";
            this.mtxtEndereco.SelectionLength = 0;
            this.mtxtEndereco.SelectionStart = 0;
            this.mtxtEndereco.ShortcutsEnabled = true;
            this.mtxtEndereco.UseSelectable = true;
            this.mtxtEndereco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtEndereco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblEndereco
            // 
            resources.ApplyResources(this.mlblEndereco, "mlblEndereco");
            this.mlblEndereco.BackColor = System.Drawing.Color.White;
            this.mlblEndereco.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.mlblEndereco.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblEndereco.ForeColor = System.Drawing.Color.Navy;
            this.mlblEndereco.Name = "mlblEndereco";
            this.mlblEndereco.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mlblEndereco.UseCustomBackColor = true;
            this.mlblEndereco.UseCustomForeColor = true;
            this.mlblEndereco.UseStyleColors = true;
            this.mlblEndereco.UseWaitCursor = true;
            // 
            // mtxtFone
            // 
            resources.ApplyResources(this.mtxtFone, "mtxtFone");
            // 
            // 
            // 
            this.mtxtFone.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription4");
            this.mtxtFone.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName4");
            this.mtxtFone.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor4")));
            this.mtxtFone.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize4")));
            this.mtxtFone.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode4")));
            this.mtxtFone.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage4")));
            this.mtxtFone.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout4")));
            this.mtxtFone.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock4")));
            this.mtxtFone.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle4")));
            this.mtxtFone.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font4")));
            this.mtxtFone.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.mtxtFone.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign4")));
            this.mtxtFone.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex4")));
            this.mtxtFone.CustomButton.ImageKey = resources.GetString("resource.ImageKey4");
            this.mtxtFone.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode4")));
            this.mtxtFone.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location4")));
            this.mtxtFone.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize4")));
            this.mtxtFone.CustomButton.Name = "";
            this.mtxtFone.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft4")));
            this.mtxtFone.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size4")));
            this.mtxtFone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtFone.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex4")));
            this.mtxtFone.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign4")));
            this.mtxtFone.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation4")));
            this.mtxtFone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtFone.CustomButton.UseSelectable = true;
            this.mtxtFone.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible4")));
            this.mtxtFone.Lines = new string[0];
            this.mtxtFone.MaxLength = 32767;
            this.mtxtFone.Name = "mtxtFone";
            this.mtxtFone.PasswordChar = '\0';
            this.mtxtFone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtFone.SelectedText = "";
            this.mtxtFone.SelectionLength = 0;
            this.mtxtFone.SelectionStart = 0;
            this.mtxtFone.ShortcutsEnabled = true;
            this.mtxtFone.UseSelectable = true;
            this.mtxtFone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtFone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblFone
            // 
            resources.ApplyResources(this.mlblFone, "mlblFone");
            this.mlblFone.BackColor = System.Drawing.Color.White;
            this.mlblFone.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.mlblFone.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblFone.ForeColor = System.Drawing.Color.Navy;
            this.mlblFone.Name = "mlblFone";
            this.mlblFone.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mlblFone.UseCustomBackColor = true;
            this.mlblFone.UseCustomForeColor = true;
            this.mlblFone.UseStyleColors = true;
            this.mlblFone.UseWaitCursor = true;
            // 
            // FrmBase
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackLocation = MetroFramework.Forms.BackLocation.BottomLeft;
            this.Controls.Add(this.mtxtFone);
            this.Controls.Add(this.mlblFone);
            this.Controls.Add(this.mtxtEndereco);
            this.Controls.Add(this.mlblEndereco);
            this.Controls.Add(this.mtxtNome);
            this.Controls.Add(this.mlblNome);
            this.Controls.Add(this.mtxtCpf);
            this.Controls.Add(this.mlblCpf);
            this.Controls.Add(this.mbtnExcluir);
            this.Controls.Add(this.mdgvBase);
            this.Controls.Add(this.mbtnSair);
            this.Controls.Add(this.mbtnEditar);
            this.Controls.Add(this.mbtnCadastrar);
            this.Controls.Add(this.mbtnLocalizar);
            this.Controls.Add(this.mtxtId);
            this.Controls.Add(this.mlblId);
            this.ForeColor = System.Drawing.Color.Navy;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBase";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.LightPink;
            ((System.ComponentModel.ISupportInitialize)(this.mdgvBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlblId;
        private MetroFramework.Controls.MetroTextBox mtxtId;
        private MetroFramework.Controls.MetroButton mbtnLocalizar;
        private MetroFramework.Controls.MetroButton mbtnCadastrar;
        private MetroFramework.Controls.MetroButton mbtnEditar;
        private MetroFramework.Controls.MetroButton mbtnSair;
        private MetroFramework.Controls.MetroGrid mdgvBase;
        private MetroFramework.Controls.MetroButton mbtnExcluir;
        private MetroFramework.Controls.MetroTextBox mtxtCpf;
        private MetroFramework.Controls.MetroLabel mlblCpf;
        private MetroFramework.Controls.MetroTextBox mtxtNome;
        private MetroFramework.Controls.MetroLabel mlblNome;
        private MetroFramework.Controls.MetroTextBox mtxtEndereco;
        private MetroFramework.Controls.MetroLabel mlblEndereco;
        private MetroFramework.Controls.MetroTextBox mtxtFone;
        private MetroFramework.Controls.MetroLabel mlblFone;
    }
}