﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoComHeranca
{
    public partial class FrmRelCliente : Form
    {
        public FrmRelCliente()
        {
            InitializeComponent();
        }

        private void FrmRelCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'JulianoDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.ClienteTableAdapter.Fill(this.JulianoDataSet.Cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
