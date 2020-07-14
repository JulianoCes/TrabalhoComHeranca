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
    public partial class FrmBase : MetroFramework.Forms.MetroForm
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        private void mbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
