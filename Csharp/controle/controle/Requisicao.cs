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
        public string idRequisicao; 

        public Requisicao()
        {
            InitializeComponent();
            carregaCombo();

            txtDate.Enabled = false;
            cbFunc.Enabled = false;
            gbProdRequisicao.Enabled = false;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        public Requisicao(string Valor)
        {
            InitializeComponent();
            buscaRequisicao(Valor);

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
                        MessageBox.Show("Gravado com sucesso!!");
                        btnNovo.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnEditar.Enabled = false;
                        btnExcluir.Enabled = false;
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
            busca.ShowDialog();
            string idBusca = busca.id;
            if (idBusca != null && idBusca != string.Empty && idBusca != "")
            {
                idRequisicao = idBusca;
                btnAddProd.Enabled = true;
                buscaRequisicao(idBusca);
                dgProdReq.DataSource = buscaProdutosRequisicao(idBusca);
                gbProdRequisicao.Enabled = true;

            }

        }

        private void Requisicao_Load(object sender, EventArgs e)
        {

        }

        private void openNewForm()
        {
            Application.Run(new buscaRequisicoes());
        }

        private void buscaRequisicao(string id)
        {
            strSql = "select [id], [Dt_retirada], [Funcionario] " +
                "from Requisicao where id="+id;
            sqlcon = new SqlConnection(strCon);

            try
            {
                sqlcon.Open();
                SqlCommand comando = new SqlCommand(strSql, sqlcon);
                SqlDataReader reader = comando.ExecuteReader();

 
                while (reader.Read())
                {
                    txtId.Text = reader.GetValue(0).ToString();
                    txtDate.Text = reader.GetValue(1).ToString();
                    cbFunc.Text = reader.GetValue(2).ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            idRequisicao = txtId.Text;
            addProdRequis add = new addProdRequis(idRequisicao);
            add.ShowDialog();

            if (txtId.Text != string.Empty && txtId.Text != "" && txtId.Text != null)
            {
                dgProdReq.DataSource = buscaProdutosRequisicao(txtId.Text);
            }


        }

        public DataTable buscaProdutosRequisicao(string idReq)
        {
            strSql = "select ir.Id,P.Id id_Produto,P.Nome,ir.Qnt_prod,ir.Preco from Requisicao r inner join ItemsRequisicao ir on r.Id = ir.Id_req inner join Produtos P on ir.Id_prod = P.Id where r.id = "+ idReq;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
           string idProd = dgProdReq.CurrentRow.Cells[0].Value.ToString();

            strSql = "delete from ItemsRequisicao where Id_req="+txtId.Text+" and Id ="+idProd;

            sqlcon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            try
            {
                sqlcon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Produto Removido com sucesso!!");
                dgProdReq.DataSource = buscaProdutosRequisicao(txtId.Text);
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
