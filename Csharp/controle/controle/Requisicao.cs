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
    public partial class Requisicao : Form
    {
        SqlConnection sqlcon = null;
        private string strCon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Controle;Data Source=.\\sqlexpress";
        private string strSql = string.Empty;
        private string comando = string.Empty;

        public Requisicao()
        {
            InitializeComponent();
            carregaCombo();

            txtDate.Enabled = false;
            cbFunc.Enabled = false;

            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        public void carregaCombo()
        {
            strSql = "select * from Funcionario";
            sqlcon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlcon);
            SqlDataReader lista;

            try
            {
                sqlcon.Open();
                lista = comando.ExecuteReader();
                while (lista.Read())
                {
                    string nome = lista.GetString(1);
                    cbFunc.Items.Add(nome);
                }

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

        private void EventoSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;


            txtDate.Enabled = true;
            cbFunc.Enabled = true;

            txtDate.Value = DateTime.Now;
            cbFunc.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            //insert
            if (txtId.Text == string.Empty)
            {
                if (txtDate.Text == string.Empty || cbFunc.Text == string.Empty)
                {
                    MessageBox.Show("Existem campos em branco");
                }
                else
                {
                    strSql = "insert into Requisicao(Dt_retirada, Funcionario) values(@dtretirada, @func)";

                    sqlcon = new SqlConnection(strCon);
                    SqlCommand comando = new SqlCommand(strSql, sqlcon);

                    comando.Parameters.Add("@dtretirada", SqlDbType.VarChar).Value = txtDate.Text;
                    comando.Parameters.Add("@func", SqlDbType.VarChar).Value = cbFunc.Text;

                    try
                    {
                        sqlcon.Open();
                        comando.ExecuteNonQuery();
                        //dgFunc.DataSource = listaFunc(string.Empty);
                        MessageBox.Show("Gravado com sucesso!!");
                        btnNovo.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnEditar.Enabled = false;
                        btnExcluir.Enabled = false;
                        //txtNome.Enabled = false;
                        //txtCPF.Enabled = false;

                        //txtNome.Clear();
                        //txtCPF.Clear();

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
                strSql = "UPDATE Requisicao set Dt_retirada = @dtRetirada, Funcionario = @func where Id = @id";

                sqlcon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlcon);

                comando.Parameters.Add("@dtRetirada", SqlDbType.VarChar).Value = txtDate.Text;
                comando.Parameters.Add("@Funcionario", SqlDbType.VarChar).Value = cbFunc.Text;

                try
                {
                    sqlcon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Dados alterados com sucesso!!");
                    //txtNome.Enabled = false;
                    //txtCPF.Enabled = false;
                    //dgFunc.DataSource = listaFunc(string.Empty);
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

        private void btnBusca_Click(object sender, EventArgs e)
        {
            buscaRequisicoes busca = new buscaRequisicoes();
            busca.Show();
        }
    }
}
