using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace controle
{
    public partial class addProdRequis : Form
    {
        SqlConnection sqlcon = null;
        private string strCon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Controle;Data Source=.\\sqlexpress";
        private string strSql = string.Empty;
        private string comando = string.Empty;
        public string idRequisicao;

        public addProdRequis(string idReq)
        {
            InitializeComponent();
            dgProd.DataSource = listaProd(string.Empty);
            idRequisicao = idReq;
            
        }

        private void txtqnt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addProdRequis_Load(object sender, EventArgs e)
        {

        }

        public DataTable listaProd(string where)
        {
            strSql = "select [Id], [Nome], [Tipo_prod],[Preco_custo],[Preco_venda] from Produtos" + where;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBusca.Text != string.Empty){
                String where = " where Nome like '%" + txtBusca.Text + "%'";
                dgProd.DataSource = listaProd(where);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtqnt.Text != string.Empty && txtqnt.Text != null && txtqnt.Text != "")
            {
                string idProd = dgProd.CurrentRow.Cells[0].Value.ToString();
                addProd(idProd, txtqnt.Text);

            }
            else
            {
                MessageBox.Show("Digite a quantidade!");
            }
        }

        public void addProd(string idProd, string qnt)
        {
            //insert into ItemsRequisicao(Id_req, Id_prod,Qnt_prod,Preco)values(2,2,50,50.0);

            strSql = "insert into ItemsRequisicao(Id_req, Id_prod,Qnt_prod,Preco) values(@id_req, @id_prod, @qnt, 1)";

            sqlcon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@id_req", SqlDbType.VarChar).Value = idRequisicao;
            comando.Parameters.Add("@id_prod", SqlDbType.VarChar).Value = idProd;
            comando.Parameters.Add("@qnt", SqlDbType.VarChar).Value = qnt;


            try
            {
                sqlcon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Gravado com sucesso!!");

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

        private void dgProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
