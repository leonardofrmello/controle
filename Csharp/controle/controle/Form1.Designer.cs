namespace controle
{
    partial class Controle
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoCompostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requisiçãoRetiradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionarioToolStripMenuItem,
            this.produtoSimplesToolStripMenuItem,
            this.produtoCompostoToolStripMenuItem,
            this.requisiçãoRetiradaToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionarioToolStripMenuItem.Text = "Funcionario";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // produtoSimplesToolStripMenuItem
            // 
            this.produtoSimplesToolStripMenuItem.Name = "produtoSimplesToolStripMenuItem";
            this.produtoSimplesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtoSimplesToolStripMenuItem.Text = "Produto Simples";
            this.produtoSimplesToolStripMenuItem.Click += new System.EventHandler(this.produtoSimplesToolStripMenuItem_Click);
            // 
            // produtoCompostoToolStripMenuItem
            // 
            this.produtoCompostoToolStripMenuItem.Name = "produtoCompostoToolStripMenuItem";
            this.produtoCompostoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtoCompostoToolStripMenuItem.Text = "Produto Composto";
            this.produtoCompostoToolStripMenuItem.Click += new System.EventHandler(this.produtoCompostoToolStripMenuItem_Click);
            // 
            // requisiçãoRetiradaToolStripMenuItem
            // 
            this.requisiçãoRetiradaToolStripMenuItem.Name = "requisiçãoRetiradaToolStripMenuItem";
            this.requisiçãoRetiradaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.requisiçãoRetiradaToolStripMenuItem.Text = "Requisição Retirada";
            this.requisiçãoRetiradaToolStripMenuItem.Click += new System.EventHandler(this.requisiçãoRetiradaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Controle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 573);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Controle";
            this.Text = "Controle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoCompostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requisiçãoRetiradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

