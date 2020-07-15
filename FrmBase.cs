using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TrabalhoComHeranca
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            SqlConnection con = Conexao.ConectaAberto();
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void dgvBase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvBase.Rows[e.RowIndex];
                    mtxtId.Text = row.Cells[0].Value.ToString();
                    mtxtNome.Text = row.Cells[1].Value.ToString();
                    mtxtEndereco.Text = row.Cells[2].Value.ToString();
                    mtxtCpf.Text = row.Cells[3].Value.ToString();
                    mtxtFone.Text = row.Cells[4].Value.ToString();
                }
                else
                {
                    mtxtId.Text = "";
                    mtxtNome.Text = "";
                    mtxtCpf.Text = "";
                    mtxtEndereco.Text = "";
                    mtxtFone.Text = "";
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
           
        }
    }
}
