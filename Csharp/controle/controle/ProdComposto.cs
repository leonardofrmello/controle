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
    public partial class ProdComposto : Form
    {
        public ProdComposto()
        {
            InitializeComponent();
            txtId.Enabled = false;
            txtNome.Enabled = false;
            txtprecoCust.Enabled = false;
            txtprecoVend.Enabled = false;
            txtPesquisa.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        SqlConnection sqlcon = null;
        private string strCon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Controle;Data Source=.\\sqlexpress";
        private string strSql = string.Empty;
        private string comando = string.Empty;


        private void ProdComposto_Load(object sender, EventArgs e)
        {
            dgFunc.DataSource = listaProdSimples(string.Empty);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;

            txtNome.Enabled = true;
            txtprecoCust.Enabled = true;
            txtprecoVend.Enabled = true;
            txtPesquisa.Enabled = false;

            txtId.Clear();
            txtNome.Clear();
            txtPesquisa.Clear();
            txtprecoCust.Clear();
            txtprecoVend.Clear();
        }

        public DataTable listaProdSimples(string where)
        {
            strSql = "select [Id], [Nome], [Preco_custo],[Preco_venda] from Produtos" + where;
            sqlcon = new SqlConnection(strCon);

            try
            {
                SqlCommand comando = new SqlCommand(strSql, sqlcon);
                SqlDataAdapter adp = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                sqlcon.Open();

                return dt;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }
            return null;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
