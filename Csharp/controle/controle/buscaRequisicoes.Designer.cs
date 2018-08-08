namespace controle
{
    partial class buscaRequisicoes
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
            this.dgRequisicoes = new System.Windows.Forms.DataGridView();
            this.txtFunc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.Data = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgRequisicoes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgRequisicoes
            // 
            this.dgRequisicoes.AllowUserToAddRows = false;
            this.dgRequisicoes.AllowUserToDeleteRows = false;
            this.dgRequisicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRequisicoes.Location = new System.Drawing.Point(143, 123);
            this.dgRequisicoes.Name = "dgRequisicoes";
            this.dgRequisicoes.ReadOnly = true;
            this.dgRequisicoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgRequisicoes.Size = new System.Drawing.Size(399, 204);
            this.dgRequisicoes.TabIndex = 17;
            this.dgRequisicoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFunc_CellContentClick);
            // 
            // txtFunc
            // 
            this.txtFunc.Location = new System.Drawing.Point(97, 34);
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.Size = new System.Drawing.Size(101, 20);
            this.txtFunc.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Funcionario";
            // 
            // txtData
            // 
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(223, 35);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(111, 20);
            this.txtData.TabIndex = 20;
            this.txtData.Value = new System.DateTime(2018, 9, 2, 0, 0, 0, 0);
            this.txtData.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(223, 15);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(30, 13);
            this.Data.TabIndex = 21;
            this.Data.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(22, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(54, 20);
            this.txtId.TabIndex = 23;
            // 
            // btnBusca
            // 
            this.btnBusca.Image = global::controle.Properties.Resources.btnBusca;
            this.btnBusca.Location = new System.Drawing.Point(347, 24);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(42, 31);
            this.btnBusca.TabIndex = 27;
            this.btnBusca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.btnBusca);
            this.groupBox1.Controls.Add(this.txtFunc);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Data);
            this.groupBox1.Location = new System.Drawing.Point(143, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 65);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buscaRequisicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgRequisicoes);
            this.Name = "buscaRequisicoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "buscaRequisicoes";
            this.Load += new System.EventHandler(this.buscaRequisicoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRequisicoes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRequisicoes;
        private System.Windows.Forms.TextBox txtFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}