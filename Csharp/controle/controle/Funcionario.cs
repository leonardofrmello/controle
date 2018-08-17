using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
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
        private string strCon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Controle;Data Source=.\\sqlexpress";
        private string strSql = string.Empty;
        private string comando = string.Empty;

        private void Funcionario_Load(object sender, EventArgs e)
        {
            
        }

        private void Funcionario_Load_1(object sender, EventArgs e)
        {
           dgFunc.DataSource = listaFunc(string.Empty);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String query = string.Empty;
            query = " where Nome like '%" + txtPesquisa.Text + "%'";
            dgFunc.DataSource = listaFunc(query);
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
            txtCPF.Enabled = true;
            txtPesquisa.Enabled = false;



            txtId.Clear();
            txtNome.Clear();
            txtPesquisa.Clear();
            txtCPF.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //insert
            if (txtId.Text == string.Empty)
            {
                if (txtCPF.Text == string.Empty || txtNome.Text == string.Empty)
                {
                    MessageBox.Show("Existem campos em branco");
                }
                else
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
                        dgFunc.DataSource = listaFunc(string.Empty);
                        MessageBox.Show("Gravado com sucesso!!");
                        btnNovo.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnEditar.Enabled = false;
                        btnExcluir.Enabled = false;
                        txtNome.Enabled = false;
                        txtCPF.Enabled = false;

                        txtNome.Clear();
                        txtCPF.Clear();

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
                    txtNome.Enabled = false;
                    txtCPF.Enabled = false;
                    dgFunc.DataSource = listaFunc(string.Empty);
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

            dgFunc.DataSource = listaFunc(string.Empty);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (txtId.Text != string.Empty)
            {
                txtNome.Enabled = true;
                txtCPF.Enabled = true;
                btnSalvar.Enabled = true;
               
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (txtId.Text != string.Empty)
            {
                strSql = "delete from Funcionario where Id = @id";

                sqlcon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlcon);

                comando.Parameters.Add("@id", SqlDbType.VarChar).Value = txtId.Text;

                try
                {
                    sqlcon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Funcionário Excluido com sucesso!!");
                    btnExcluir.Enabled = false;
                    txtPesquisa.Clear();
                    btnCancelar_Click(sender, e);
                    dgFunc.DataSource = listaFunc(string.Empty);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNome.Clear();
            txtCPF.Clear();
            txtPesquisa.Enabled = true;
            txtId.Enabled = false;
            txtNome.Enabled = false;
            txtCPF.Enabled = false;

            btnNovo.Enabled = true;
            btnCancelar.Visible = false;

        }

        public DataTable listaFunc(string where)
        {
            strSql = "select [Id], [Nome], [Cpf] from Funcionario"+where;
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

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgFunc_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgFunc.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgFunc.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCPF.Text = dgFunc.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (txtId.Text != string.Empty)
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
                
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dgFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
