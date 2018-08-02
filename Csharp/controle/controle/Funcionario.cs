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
        }

        SqlConnection sqlcon = null;


      //  string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\dados\\NORTHWND.MDF;Integrated Security=True; Connect Timeout=30;User Instance=True";

        //private string strCon = "Data Source=.\\sqlexpress;Initial Catalog=Controle;Integrated Security=True";
        private string strCon = "Data Source=.\\SQLEXPRESS;AttachDbFilename=Controle.MDF;Integrated Security=True; Connect Timeout=30;User Instance=True";
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

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnBuscar.Enabled = false;
            txtNome.Enabled = true;
            txtCPF.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            strCon = "insert into Funcionario(Nome, Cpf) values(@nome, @cpf)";

            sqlcon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = txtCPF.Text;

            try
            {
                sqlcon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Gravado com sucesso!!");
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
    }
}
