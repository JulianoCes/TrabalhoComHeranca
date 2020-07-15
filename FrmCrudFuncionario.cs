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
            try
            {
                SqlConnection con = Conexao.ConectaAberto();
                String query = "select * from Funcionario";
                SqlCommand cmd = new SqlCommand(query, con);
                Conexao.ConectaAberto();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable func = new DataTable();
                sd.Fill(func);
                dgvBase.DataSource = func;
                Conexao.ConectaFechado();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
           
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conexao.ConectaAberto();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "InserirFuncionario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", mtxtNome.Text);
                cmd.Parameters.AddWithValue("@endereco", mtxtEndereco.Text);
                cmd.Parameters.AddWithValue("@cpf", mtxtCpf.Text);
                cmd.Parameters.AddWithValue("@telefone", mtxtFone.Text);
                cmd.Parameters.AddWithValue("@funcao", cbxFuncao.Text);
                cmd.Parameters.AddWithValue("@salario", mtxtSalario.Text);
                Conexao.ConectaAberto();
                cmd.ExecuteNonQuery();
                CarregaDgvFuncionario();
                MessageBox.Show("Funcionario Cadastrado  com sucesso!", "Cadastro", MessageBoxButtons.OK);
                Conexao.ConectaFechado();
                mtxtId.Text = "";
                mtxtNome.Text = "";
                mtxtEndereco.Text = "";
                mtxtCpf.Text = "";
                mtxtFone.Text = "";
                cbxFuncao.Text = "";
                mtxtSalario.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conexao.ConectaAberto();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "AtualizarFuncionario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", this.mtxtId.Text);
                cmd.Parameters.AddWithValue("@nome", this.mtxtNome.Text);
                cmd.Parameters.AddWithValue("@endereco", this.mtxtEndereco.Text);
                cmd.Parameters.AddWithValue("@cpf", this.mtxtCpf.Text);
                cmd.Parameters.AddWithValue("@telefone", this.mtxtFone.Text);
                cmd.Parameters.AddWithValue("@funcao", this.cbxFuncao.Text);
                cmd.Parameters.Add("@Salario", SqlDbType.Decimal, 3).Value = mtxtSalario.Text;
                Conexao.ConectaAberto();
                cmd.ExecuteNonQuery();
                CarregaDgvFuncionario();
                MessageBox.Show("Funcionario atualizado com sucesso!", "Editar Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Conexao.ConectaFechado();
                mtxtId.Text = "";
                mtxtNome.Text = "";
                mtxtEndereco.Text = "";
                mtxtCpf.Text = "";
                mtxtFone.Text = "";
                cbxFuncao.Text = "";
                mtxtSalario.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conexao.ConectaAberto();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "ExcluirFuncionario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", this.mtxtId.Text);
                Conexao.ConectaAberto();
                cmd.ExecuteNonQuery();
                CarregaDgvFuncionario();
                MessageBox.Show("Funcionario foi apagado com sucesso!", "Excluir Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Conexao.ConectaFechado();
                mtxtId.Text = "";
                mtxtNome.Text = "";
                mtxtEndereco.Text = "";
                mtxtCpf.Text = "";
                mtxtFone.Text = "";
                cbxFuncao.Text = "";
                mtxtSalario.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conexao.ConectaAberto();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "LocalizarFuncionario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", this.mtxtId.Text);
                Conexao.ConectaAberto();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    mtxtNome.Text = rd["nome"].ToString();
                    mtxtEndereco.Text = rd["endereco"].ToString();
                    mtxtCpf.Text = rd["cpf"].ToString();
                    mtxtFone.Text = rd["telefone"].ToString();
                    cbxFuncao.Text = rd["funcao"].ToString();
                    mtxtSalario.Text = rd["salario"].ToString();
                    rd.Close();
                    Conexao.ConectaFechado();
                }
                else
                {
                    MessageBox.Show("Este registro não foi encontrado!", "Sem registro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Conexao.ConectaFechado();
                }
            }
            finally
            {
            }
        }

        private void FrmCrudFuncionario_Load(object sender, EventArgs e)
        {
            CarregaDgvFuncionario();
        }
    }
}
