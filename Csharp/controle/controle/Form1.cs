using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle
{
    public partial class Controle : Form
    {
        public Controle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();
            func.ShowDialog();
        }

        private void produtoSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdSimples prodsimp = new ProdSimples();
            prodsimp.ShowDialog();
        }

        private void produtoCompostoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdComposto prodcomp = new ProdComposto();
            prodcomp.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void requisiçãoRetiradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Requisicao req = new Requisicao();
            req.ShowDialog();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncionarioRelatorio funcRel = new FuncionarioRelatorio();
            funcRel.ShowDialog();
        }
    }
}
