namespace TrabalhoComHeranca
{
    partial class FrmRelFuncionario
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.relFuncionario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.JulianoDataSet1 = new TrabalhoComHeranca.JulianoDataSet1();
            this.FuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FuncionarioTableAdapter = new TrabalhoComHeranca.JulianoDataSet1TableAdapters.FuncionarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.JulianoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // relFuncionario
            // 
            reportDataSource1.Name = "RelFuncionario";
            reportDataSource1.Value = this.FuncionarioBindingSource;
            this.relFuncionario.LocalReport.DataSources.Add(reportDataSource1);
            this.relFuncionario.LocalReport.ReportEmbeddedResource = "TrabalhoComHeranca.Report1.rdlc";
            this.relFuncionario.Location = new System.Drawing.Point(12, 12);
            this.relFuncionario.Name = "relFuncionario";
            this.relFuncionario.ServerReport.BearerToken = null;
            this.relFuncionario.Size = new System.Drawing.Size(576, 334);
            this.relFuncionario.TabIndex = 0;
            // 
            // JulianoDataSet1
            // 
            this.JulianoDataSet1.DataSetName = "JulianoDataSet1";
            this.JulianoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FuncionarioBindingSource
            // 
            this.FuncionarioBindingSource.DataMember = "Funcionario";
            this.FuncionarioBindingSource.DataSource = this.JulianoDataSet1;
            // 
            // FuncionarioTableAdapter
            // 
            this.FuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 346);
            this.Controls.Add(this.relFuncionario);
            this.Name = "FrmRelFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRelFuncionario";
            this.Load += new System.EventHandler(this.FrmRelFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JulianoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer relFuncionario;
        private System.Windows.Forms.BindingSource FuncionarioBindingSource;
        private JulianoDataSet1 JulianoDataSet1;
        private JulianoDataSet1TableAdapters.FuncionarioTableAdapter FuncionarioTableAdapter;
    }
}