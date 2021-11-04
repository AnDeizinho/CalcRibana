namespace ConsumoRibana
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgram = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlarg = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.larg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtqtd
            // 
            this.txtqtd.Location = new System.Drawing.Point(46, 58);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(160, 20);
            this.txtqtd.TabIndex = 1;
            this.txtqtd.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Qual a quantidade de camisas ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Qual a gramatura da ribana ?";
            // 
            // txtgram
            // 
            this.txtgram.Location = new System.Drawing.Point(50, 134);
            this.txtgram.Name = "txtgram";
            this.txtgram.Size = new System.Drawing.Size(156, 20);
            this.txtgram.TabIndex = 3;
            this.txtgram.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Qual a largura total da ribana ?";
            // 
            // txtlarg
            // 
            this.txtlarg.Location = new System.Drawing.Point(50, 207);
            this.txtlarg.Name = "txtlarg";
            this.txtlarg.Size = new System.Drawing.Size(156, 20);
            this.txtlarg.TabIndex = 5;
            this.txtlarg.Text = "1,40";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qtd,
            this.kilos,
            this.gram,
            this.larg,
            this.compr});
            this.dataGridView1.Location = new System.Drawing.Point(50, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(506, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // qtd
            // 
            this.qtd.DataPropertyName = "QtdCamisas";
            this.qtd.HeaderText = "Qtd Camisas";
            this.qtd.Name = "qtd";
            this.qtd.ReadOnly = true;
            // 
            // kilos
            // 
            this.kilos.DataPropertyName = "Kilos";
            this.kilos.HeaderText = "Total Kilos";
            this.kilos.Name = "kilos";
            this.kilos.ReadOnly = true;
            // 
            // gram
            // 
            this.gram.DataPropertyName = "Gramatura";
            this.gram.HeaderText = "Gramatura";
            this.gram.Name = "gram";
            this.gram.ReadOnly = true;
            // 
            // larg
            // 
            this.larg.DataPropertyName = "Largura";
            this.larg.HeaderText = "Largura";
            this.larg.Name = "larg";
            this.larg.ReadOnly = true;
            // 
            // compr
            // 
            this.compr.DataPropertyName = "Metros";
            this.compr.HeaderText = "Comprimento";
            this.compr.Name = "compr";
            this.compr.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 439);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlarg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtgram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtqtd);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Consumo de Ribana";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtqtd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgram;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlarg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilos;
        private System.Windows.Forms.DataGridViewTextBoxColumn gram;
        private System.Windows.Forms.DataGridViewTextBoxColumn larg;
        private System.Windows.Forms.DataGridViewTextBoxColumn compr;
    }
}

