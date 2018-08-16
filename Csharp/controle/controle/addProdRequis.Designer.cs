namespace controle
{
    partial class addProdRequis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtqnt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgProd = new System.Windows.Forms.DataGridView();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtqnt);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.dgProd);
            this.groupBox4.Controls.Add(this.txtBusca);
            this.groupBox4.Location = new System.Drawing.Point(94, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(632, 367);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Produtos";
            // 
            // txtqnt
            // 
            this.txtqnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqnt.Location = new System.Drawing.Point(507, 22);
            this.txtqnt.Name = "txtqnt";
            this.txtqnt.Size = new System.Drawing.Size(49, 29);
            this.txtqnt.TabIndex = 27;
            this.txtqnt.TextChanged += new System.EventHandler(this.txtqnt_TextChanged);
            // 
            // button2
            // 
            this.button2.Image = global::controle.Properties.Resources.btnnovo1;
            this.button2.Location = new System.Drawing.Point(562, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 37);
            this.button2.TabIndex = 26;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgProd
            // 
            this.dgProd.AllowUserToAddRows = false;
            this.dgProd.AllowUserToDeleteRows = false;
            this.dgProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProd.Location = new System.Drawing.Point(30, 60);
            this.dgProd.Name = "dgProd";
            this.dgProd.ReadOnly = true;
            this.dgProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgProd.Size = new System.Drawing.Size(581, 291);
            this.dgProd.TabIndex = 16;
            this.dgProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProd_CellContentClick);
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(80, 23);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(133, 30);
            this.txtBusca.TabIndex = 11;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Quantidade:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addProdRequis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Name = "addProdRequis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addProdRequis";
            this.Load += new System.EventHandler(this.addProdRequis_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgProd;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.TextBox txtqnt;
        private System.Windows.Forms.Label label1;
    }
}