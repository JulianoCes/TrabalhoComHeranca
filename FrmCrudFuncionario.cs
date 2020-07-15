using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TrabalhoComHeranca
{
    public partial class FrmCrudFuncionario : TrabalhoComHeranca.FrmBase
    {
       
         
        SqlConnection con = Conexao.ConectaAberto();
        public FrmCrudFuncionario()
        {
            InitializeComponent();
        }

        public void CarregaDgvFuncionario()
        {
            /*SqlConnection con = Conexao.ConectaAberto();
            String query = "select * from Funcinario";
            SqlCommand cmd = new SqlCommand(query, con);
            Conexao.ConectaAberto();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable funcionario = new DataTable();
            da.Fill(funcionario);
            mdgvBase.DataSource = funcionario;
            Conexao.ConectaFechado();*/
        }

        private void mbtnCadastrar_Click(object sender, EventArgs e)
        {
           /* try
            {
                SqlConnection con = Conexao.ConectaAberto();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "InserirFuncionario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", mtxtNome.Text);
                cmd.Parameters.AddWithValue("@endereco", mtxtEndereco);
                cmd.Parameters.AddWithValue("@cpf", mtxtCpf.Text);
                cmd.Parameters.AddWithValue("@telefone", mtxtFone);
                cmd.Parameters.AddWithValue("@funcao", mcbxFuncao);
                cmd.Parameters.Add("@salario", SqlDbType.Decimal, 3).Value = (mtxtSalario);
                Conexao.ConectaAberto();
                cmd.ExecuteNonQuery();
                CarregaDgvFuncionario();
                MessageBox.Show("Funcionario cadastrado com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Conexao.ConectaFechado();
                mtxtId.Text = "";
                mtxtNome.Text = "";
                mtxtEndereco.Text = "";
                mtxtCpf.Text = "";
                mtxtFone.Text = "";
                mcbxFuncao.Text = "";
                mtxtSalario.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }*/
        }

        private void mbtnEditar_Click(object sender, EventArgs e)
        {
           /* try
            {
                SqlConnection con = Conexao.ConectaAberto();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "AtualizarFuncionario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.mtxtId.Text);
                cmd.Parameters.AddWithValue("@nome", this.mtxtNome.Text);
                cmd.Parameters.AddWithValue("@endereco", this.mtxtEndereco.Text);
                cmd.Parameters.AddWithValue("@cpf", this.mtxtEndereco.Text);
                cmd.Parameters.AddWithValue("@telefone", this.mtxtFone.Text);
                cmd.Parameters.AddWithValue("@funcao", this.mcbxFuncao.Text);
                cmd.Parameters.Add("@salario", SqlDbType.Decimal, 3).Value = mtxtSalario.Text;
                Conexao.ConectaAberto();
                cmd.ExecuteNonQuery();
                CarregaDgvFuncionario();
                MessageBox.Show("Funcionario atualizado com sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Conexao.ConectaFechado();
                mtxtId.Text = "";
                mtxtNome.Text = "";
                mtxtEndereco.Text = "";
                mtxtCpf.Text = "";
                mtxtFone.Text = "";
                mcbxFuncao.Text = "";
                mtxtSalario.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }*/
        }
    }
}
