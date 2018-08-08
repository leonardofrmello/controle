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
    public partial class buscaRequisicoes : Form
    {

        SqlConnection sqlcon = null;
        private string strCon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Controle;Data Source=.\\sqlexpress";
        private string strSql = string.Empty;
        private string comando = string.Empty;
     

        public buscaRequisicoes()
        {
            InitializeComponent();
        }

        private void dgFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buscaRequisicoes_Load(object sender, EventArgs e)
        {
            dgRequisicoes.DataSource = listaRequisicoes(string.Empty);

        }

        public DataTable listaRequisicoes(string where)
        {
            strSql = "set dateformat dmy;select [Id], [Dt_retirada], [Funcionario] from Requisicao" + where;
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

        private void btnBusca_Click(object sender, EventArgs e)
        {
            string where = " where Id > 0";

            if (txtId.Text != String.Empty)
            {
                where += " and Id = '" + txtId.Text +"'";
            }

            if (txtFunc.Text != String.Empty)
            {
                where += " and Funcionario like '%"+txtFunc.Text+"%'";
            }
            if (txtData.Text != String.Empty)
            {
                where += " and Dt_retirada ='"+txtData.Text+"'";
            }
           dgRequisicoes.DataSource = listaRequisicoes(where);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
