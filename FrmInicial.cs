using System;
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
    public partial class FrmInicial : MetroFramework.Forms.MetroForm
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrudFuncionario fun = new FrmCrudFuncionario();
            fun.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrudCliente cli = new FrmCrudCliente();
            cli.Show();
        }
    }
}
