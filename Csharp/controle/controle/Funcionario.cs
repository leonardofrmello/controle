using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
            txtNome.Enabled = false;
            txtCPF.Enabled = false;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        SqlConnection sqlcon = null;


        //  string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\dados\\NORTHWND.MDF;Integrated Security=True; Connect Timeout=30;User Instance=True";

        //localhost\sqlexpress;Initial Catalog=ERP_ACESSO;Persist Security Info=True;User ID=sa;Password=mudar123
        //private string strCon = "localhost\\sqlexpress;Initial Catalog=Controle;Persist Security Info=True;User ID=sa;Password=sivis123";
        private string strCon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Controle;Data Source=.\\sqlexpress";
        private string strSql = string.Empty;

        private void Funcionario_Load(object sender, EventArgs e)
        {
            
        }

        private void Funcionario_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            strSql = "select * from Funcionario where Nome = @nome";

            sqlcon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtPesquisa.Text;

            try
            {
                if (txtPesquisa.Text == string.Empty)
                {
                    MessageBox.Show("Você precisa digitar um nome!");
                }
                sqlcon.Open();
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("Este nome nao esta cadastrado");
                }

                dr.Read();

                txtId.Text = Convert.ToString(dr["Id"]);
                txtNome.Text = Convert.ToString(dr["Nome"]);
                txtCPF.Text = Convert.ToString(dr["Cpf"]);
                txtNome.Enabled = true;
                txtCPF.Enabled = true;
                btnEditar.Enabled = true;

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally{
                sqlcon.Close();
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnBuscar.Enabled = false;
            txtNome.Enabled = true;
            txtCPF.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            strSql = "insert into Funcionario(Nome, Cpf) values(@nome, @cpf)";

            sqlcon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = txtCPF.Text;

            try
            {
                sqlcon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Gravado com sucesso!!");
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnBuscar.Enabled = true;
                txtNome.Enabled = false;
                txtCPF.Enabled = false;

                txtNome.Clear();
                txtCPF.Clear();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            strSql = "UPDATE Funcionario set Nome = @nome, Cpf = @cpf where Id = @id";

            sqlcon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@id", SqlDbType.VarChar).Value = txtId.Text;
            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = txtCPF.Text;

            try
            {
                sqlcon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados alterados com sucesso!!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }
        }
    }
}
