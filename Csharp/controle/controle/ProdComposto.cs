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
        private string itemSelect = string.Empty;
        private string itemSelectExcluir = string.Empty;


        private void ProdComposto_Load(object sender, EventArgs e)
        {
            dgProdComp.DataSource = listaProdComposto(string.Empty);
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

        public DataTable listaProdComposto(string where)
        {
            strSql = "select [Id], [Nome], [Preco_custo],[Preco_venda] from Produtos where Tipo_prod = 2" + where;
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
                    strSql = "insert into Produtos(Nome, Preco_custo, Preco_venda, Tipo_prod) values(@nome, @precocust, @precovenda, 2)";

                    sqlcon = new SqlConnection(strCon);
                    SqlCommand comando = new SqlCommand(strSql, sqlcon);

                    comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
                    comando.Parameters.Add("@precocust", SqlDbType.VarChar).Value = txtprecoCust.Text;
                    comando.Parameters.Add("@precovenda", SqlDbType.VarChar).Value = txtprecoVend.Text;


                    try
                    {
                        sqlcon.Open();
                        comando.ExecuteNonQuery();
                        dgProdComp.DataSource = listaProdComposto(string.Empty);
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

                    dgProdComp.DataSource = listaProdComposto(string.Empty);
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

        private void dgFunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProdComp.Rows[e.RowIndex].Cells[0].Value != null) {
                txtId.Text = dgProdComp.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dgProdComp.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtprecoCust.Text = dgProdComp.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtprecoVend.Text = dgProdComp.Rows[e.RowIndex].Cells[3].Value.ToString();
            }


            if (txtId.Text != string.Empty)
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                groupItemsProd.Visible = true;
                dgProdSimples.DataSource = listaProdutosEspecifico(txtId.Text);
            }
        }

        private void dgItemsAdicionados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            itemSelect = dgAdicinarItems.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        public DataTable listaProdutosEspecifico(string idprodComp)
        {
            strSql = "select ps.Id [Id],ps.Nome [Nome], pc.Qnt_comp [Quantidade], ps.Preco_custo [Preco Custo], ps.Preco_venda [Preco Venda] from ProdComp pc inner join Produtos ps on pc.Id_prod = ps.Id where pc.Id_comp = " + idprodComp;
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

        public DataTable listaProdutosSimples()
        {
            strSql = "select [Id],[Nome], [Preco_custo], [Preco_venda] from Produtos where Tipo_prod = 1";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            prodSimples.Visible = true;
            dgAdicinarItems.DataSource = listaProdutosSimples();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtqnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtqnt.Text == string.Empty)
            {
                MessageBox.Show("Digite a quantidade");
                return;
            }

            if (itemSelect == "")
            {
                MessageBox.Show("Selecione o Produto Primeiro");
                return;
            }

            strSql = "insert into ProdComp(Id_comp, Id_prod, Qnt_comp) values(@id_comp, @id_prod, @qnt)";

            sqlcon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@id_comp", SqlDbType.VarChar).Value = txtId.Text;
            comando.Parameters.Add("@id_prod", SqlDbType.VarChar).Value = itemSelect.ToString();
            comando.Parameters.Add("@qnt", SqlDbType.VarChar).Value = txtqnt.Text;

            try
            {
                sqlcon.Open();
                comando.ExecuteNonQuery();
                dgProdComp.DataSource = listaProdComposto(string.Empty);
                MessageBox.Show("Produto inserido com sucesso!!");
                dgProdSimples.DataSource = listaProdutosEspecifico(txtId.Text);
            }

            catch (Exception ex)
            {
                string s1 = ex.Message;
                int temChave = Convert.ToInt32(s1.IndexOf("chave duplicada"));
                if (temChave > 0)
                {
                    MessageBox.Show("Esse produto já esta adicionado na lista!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }

            }

            finally
            {
                sqlcon.Close();
            }


        }

        private void os_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgAdicinarItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            itemSelect = dgAdicinarItems.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            strSql = "delete ProdComp where Id_comp = @id_comp and Id_prod = @id_prod";

            sqlcon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@id_comp", SqlDbType.VarChar).Value = txtId.Text;
            comando.Parameters.Add("@id_prod", SqlDbType.VarChar).Value = itemSelectExcluir.ToString();


            try
            {
                sqlcon.Open();
                comando.ExecuteNonQuery();
                dgProdComp.DataSource = listaProdComposto(string.Empty);
                MessageBox.Show("Produto excluido com sucesso!!");
                dgProdSimples.DataSource = listaProdutosEspecifico(txtId.Text);

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

        private void dgProdSimples_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dts.Tables["contatos"].rows.count > 0($exception).Message
            //var index = dgProdSimples.Rows[e.RowIndex].Cells[0].RowIndex;
                itemSelectExcluir = dgProdSimples.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
