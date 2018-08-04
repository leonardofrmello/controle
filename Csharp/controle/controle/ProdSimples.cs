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
    public partial class ProdSimples : Form
    {
        public ProdSimples()
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

        private void ProdSimples_Load(object sender, EventArgs e)
        {
            dgFunc.DataSource = listaProdSimples(string.Empty);
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String query = string.Empty;
            query = " where Nome like '%" + txtPesquisa.Text + "%'";
            dgFunc.DataSource = listaProdSimples(query);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNome.Clear();
            txtprecoCust.Clear();
            txtprecoVend.Clear();

            txtPesquisa.Enabled = true;
            txtId.Enabled = false;
            txtNome.Enabled = false;
            txtprecoCust.Enabled = false;
            txtprecoVend.Enabled = false;

            btnNovo.Enabled = true;
            btnCancelar.Visible = false;
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
            //insert
            if (txtId.Text == string.Empty)
            {
                if (txtNome.Text == string.Empty || txtprecoCust.Text == string.Empty || txtprecoVend.Text == string.Empty)
                {
                    MessageBox.Show("Existem campos em branco");
                }
                else
                {
                    strSql = "insert into Produtos(Nome, Preco_custo, Preco_venda) values(@nome, @precocust, @precovenda)";

                    sqlcon = new SqlConnection(strCon);
                    SqlCommand comando = new SqlCommand(strSql, sqlcon);

                    comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
                    comando.Parameters.Add("@precocust", SqlDbType.VarChar).Value = txtprecoCust.Text;
                    comando.Parameters.Add("@precovenda", SqlDbType.VarChar).Value = txtprecoVend.Text;

                    try
                    {
                        sqlcon.Open();
                        comando.ExecuteNonQuery();
                        dgFunc.DataSource = listaProdSimples(string.Empty);
                        MessageBox.Show("Gravado com sucesso!!");
                        btnNovo.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnEditar.Enabled = false;
                        btnExcluir.Enabled = false;
                        txtNome.Enabled = false;
                        txtprecoCust.Enabled = false;
                        txtprecoVend.Enabled = false;

                        txtNome.Clear();
                        txtprecoCust.Clear();
                        txtprecoVend.Clear();
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
            //update
            else
            {
                strSql = "UPDATE Produtos set Nome = @nome, Preco_custo = @precocusto, Preco_venda = @precovenda  where Id = @id";

                sqlcon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlcon);

                comando.Parameters.Add("@id", SqlDbType.VarChar).Value = txtId.Text;
                comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
                comando.Parameters.Add("@precocusto", SqlDbType.VarChar).Value = txtprecoCust.Text;
                comando.Parameters.Add("@precovenda", SqlDbType.VarChar).Value = txtprecoVend.Text;


                try
                {
                    sqlcon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Dados alterados com sucesso!!");
                    txtNome.Enabled = false;
                    txtprecoCust.Enabled = false;
                    txtprecoVend.Enabled = false;

                    dgFunc.DataSource = listaProdSimples(string.Empty);
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

            dgFunc.DataSource = listaProdSimples(string.Empty);
        }
    }
}
