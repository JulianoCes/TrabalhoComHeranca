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

        private void mbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
