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
    public partial class FrmRelFuncionario : Form
    {
        public FrmRelFuncionario()
        {
            InitializeComponent();
        }

        private void FrmRelFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'JulianoDataSet1.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.FuncionarioTableAdapter.Fill(this.JulianoDataSet1.Funcionario);

            this.relFuncionario.RefreshReport();
        }
    }
}
