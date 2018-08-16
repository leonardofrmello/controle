namespace controle
{
    partial class Requisicao
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbFunc = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbProdRequisicao = new System.Windows.Forms.GroupBox();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.dgProdReq = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbProdRequisicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdReq)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbFunc);
            this.groupBox3.Controls.Add(this.txtDate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(119, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 123);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // cbFunc
            // 
            this.cbFunc.FormattingEnabled = true;
            this.cbFunc.Location = new System.Drawing.Point(79, 78);
            this.cbFunc.Name = "cbFunc";
            this.cbFunc.Size = new System.Drawing.Size(198, 21);
            this.cbFunc.TabIndex = 19;
            // 
            // txtDate
            // 
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(77, 52);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(200, 20);
            this.txtDate.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(77, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(50, 20);
            this.txtId.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBusca);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Location = new System.Drawing.Point(170, 148);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox2.Size = new System.Drawing.Size(491, 70);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.UseCompatibleTextRendering = true;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnBusca
            // 
            this.btnBusca.Image = global::controle.Properties.Resources.btnedit;
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBusca.Location = new System.Drawing.Point(396, 14);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(75, 47);
            this.btnBusca.TabIndex = 26;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::controle.Properties.Resources.btncancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(305, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 47);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::controle.Properties.Resources.btnexcluir1;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(305, 14);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 47);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::controle.Properties.Resources.btnnovo1;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(20, 14);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(64, 47);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::controle.Properties.Resources.btnedit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(206, 14);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 47);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::controle.Properties.Resources.btnsave1;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(105, 14);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 47);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbProdRequisicao
            // 
            this.gbProdRequisicao.Controls.Add(this.btnRemove);
            this.gbProdRequisicao.Controls.Add(this.btnAddProd);
            this.gbProdRequisicao.Controls.Add(this.dgProdReq);
            this.gbProdRequisicao.Location = new System.Drawing.Point(119, 231);
            this.gbProdRequisicao.Name = "gbProdRequisicao";
            this.gbProdRequisicao.Size = new System.Drawing.Size(584, 313);
            this.gbProdRequisicao.TabIndex = 24;
            this.gbProdRequisicao.TabStop = false;
            this.gbProdRequisicao.Text = "Produtos Requisição";
            this.gbProdRequisicao.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnAddProd
            // 
            this.btnAddProd.Image = global::controle.Properties.Resources.btnnovo1;
            this.btnAddProd.Location = new System.Drawing.Point(469, 17);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(49, 37);
            this.btnAddProd.TabIndex = 26;
            this.btnAddProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgProdReq
            // 
            this.dgProdReq.AllowUserToAddRows = false;
            this.dgProdReq.AllowUserToDeleteRows = false;
            this.dgProdReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdReq.Location = new System.Drawing.Point(15, 60);
            this.dgProdReq.Name = "dgProdReq";
            this.dgProdReq.ReadOnly = true;
            this.dgProdReq.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgProdReq.Size = new System.Drawing.Size(558, 239);
            this.dgProdReq.TabIndex = 16;
            this.dgProdReq.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::controle.Properties.Resources.btnexcluir;
            this.btnRemove.Location = new System.Drawing.Point(524, 17);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(49, 37);
            this.btnRemove.TabIndex = 27;
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Requisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.gbProdRequisicao);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Requisicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requisicao";
            this.Load += new System.EventHandler(this.Requisicao_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbProdRequisicao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdReq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gbProdRequisicao;
        private System.Windows.Forms.DataGridView dgProdReq;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.ComboBox cbFunc;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnRemove;
    }
}