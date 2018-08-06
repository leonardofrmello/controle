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
    public partial class FuncionarioRelatorio : Form
    {
        public FuncionarioRelatorio()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = null;
        private string strCon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Controle;Data Source=.\\sqlexpress";
        private string strSql = string.Empty;
        private string comando = string.Empty;

        private void FuncionarioRelatorio_Load(object sender, EventArgs e)
        {
            strSql = "select * from Funcionario";
            sqlcon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter(comando);
            //DataTable dt = new DataTable();

            DataSet1 ds = new DataSet1();
            adp.Fill(ds.Tables["dataTable1"]);

            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(ds.Tables["dataTable1"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
