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
    public partial class FrmCrudCliente : TrabalhoComHeranca.FrmBase
    {
        SqlConnection con = Conexao.ConectaAberto();
        public FrmCrudCliente()
        {
            InitializeComponent();
        }
        public void CarregaDgvCliente()
        {
            try
            {
                SqlConnection con = Conexao.ConectaAberto();
                String query = "select * from cliente";
                SqlCommand cmd = new SqlCommand(query, con);
                Conexao.ConectaAberto();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable cliente = new DataTable();
                da.Fill(cliente);
                dgvBase.DataSource = cliente;
                Conexao.ConectaAberto();
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
                cmd.CommandText = "InserirCliente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", mtxtNome.Text);
                cmd.Parameters.AddWithValue("@endereco", mtxtEndereco.Text);
                cmd.Parameters.AddWithValue("@cpf", mtxtCpf.Text);
                cmd.Parameters.AddWithValue("@telefone", mtxtFone.Text);
                cmd.Parameters.AddWithValue("@data_nascimento",Convert.ToDateTime( dtpDataNacimento.Text));
                cmd.Parameters.AddWithValue("@sexo", cbxSexo.Text);
                Conexao.ConectaAberto();
                cmd.ExecuteNonQuery();
                CarregaDgvCliente();
                MessageBox.Show("Cliente Cadastrado  com sucesso!", "Cadastro", MessageBoxButtons.OK);
                Conexao.ConectaFechado();
                mtxtId.Text = "";
                mtxtNome.Text = "";
                mtxtEndereco.Text = "";
                mtxtCpf.Text = "";
                mtxtFone.Text = "";
                dtpDataNacimento.Text = "";
                cbxSexo.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            //MessageBox.Show("Vece esta no Cadastro de cliente", "cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conexao.ConectaAberto();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "AtualizarCliente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", this.mtxtId.Text);
                cmd.Parameters.AddWithValue("@nome", this.mtxtNome.Text);
                cmd.Parameters.AddWithValue("@endereco", this.mtxtEndereco.Text);
                cmd.Parameters.AddWithValue("@cpf", this.mtxtCpf.Text);
                cmd.Parameters.AddWithValue("@telefone", this.mtxtFone.Text);
                cmd.Parameters.AddWithValue("@data_nascimento", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpDataNacimento.Text);
                cmd.Parameters.AddWithValue("@sexo", this.cbxSexo.Text);
                Conexao.ConectaAberto();
                cmd.ExecuteNonQuery();
                CarregaDgvCliente();
                MessageBox.Show("O cliente foi atualizado com sucesso!", "Atualizar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Conexao.ConectaFechado();
                mtxtId.Text = "";
                mtxtNome.Text = "";
                mtxtEndereco.Text = "";
                mtxtCpf.Text = "";
                mtxtFone.Text = "";
                dtpDataNacimento.Text = "";
                cbxSexo.Text = "";
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
                cmd.CommandText = "ExcluirCliente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", this.mtxtId.Text);
                Conexao.ConectaAberto();
                cmd.ExecuteNonQuery();
                CarregaDgvCliente();
                MessageBox.Show("Cliente foi apagado com sucesso!", "Excluir Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Conexao.ConectaFechado();
                mtxtId.Text = "";
                mtxtNome.Text = "";
                mtxtEndereco.Text = "";
                mtxtCpf.Text = "";
                mtxtFone.Text = "";
                dtpDataNacimento.Text = "";
                cbxSexo.Text = "";
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
                cmd.CommandText = "LocalizarCliente";
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
                    dtpDataNacimento.Text = rd["data_nacimento"].ToString();
                    cbxSexo.Text = rd["sexo"].ToString();
                    rd.Close();
                    Conexao.ConectaFechado();
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado!", "Sem registro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Conexao.ConectaFechado();
                }
            }
            finally
            {
            }
        }

        private void FrmCrudCliente_Load(object sender, EventArgs e)
        {
            CarregaDgvCliente();
        }

       
        
    }
}
