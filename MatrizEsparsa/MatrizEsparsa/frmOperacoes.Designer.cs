namespace MatrizEsparsa
{
    partial class frmOperacoes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnLer1 = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnLer2 = new System.Windows.Forms.Button();
            this.dlgArquivo = new System.Windows.Forms.OpenFileDialog();
            this.btnTranspor = new System.Windows.Forms.Button();
            this.btnInverter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 454);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(39, 595);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(735, 454);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(822, 62);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(735, 454);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // btnLer1
            // 
            this.btnLer1.Location = new System.Drawing.Point(1258, 595);
            this.btnLer1.Name = "btnLer1";
            this.btnLer1.Size = new System.Drawing.Size(121, 45);
            this.btnLer1.TabIndex = 3;
            this.btnLer1.Text = "Ler Arquivo 1";
            this.btnLer1.UseVisualStyleBackColor = true;
            this.btnLer1.Click += new System.EventHandler(this.btnLer1_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Enabled = false;
            this.btnSomar.Location = new System.Drawing.Point(1258, 681);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(121, 45);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "Somar Matrizes";
            this.btnSomar.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Enabled = false;
            this.btnMultiplicar.Location = new System.Drawing.Point(1436, 681);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(121, 45);
            this.btnMultiplicar.TabIndex = 5;
            this.btnMultiplicar.Text = "Multiplicar Matrizes";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnLer2
            // 
            this.btnLer2.Enabled = false;
            this.btnLer2.Location = new System.Drawing.Point(1436, 595);
            this.btnLer2.Name = "btnLer2";
            this.btnLer2.Size = new System.Drawing.Size(121, 45);
            this.btnLer2.TabIndex = 6;
            this.btnLer2.Text = "Ler Arquivo 2";
            this.btnLer2.UseVisualStyleBackColor = true;
            this.btnLer2.Click += new System.EventHandler(this.btnLer2_Click);
            // 
            // dlgArquivo
            // 
            this.dlgArquivo.FileName = "openFileDialog1";
            // 
            // btnTranspor
            // 
            this.btnTranspor.Enabled = false;
            this.btnTranspor.Location = new System.Drawing.Point(1258, 764);
            this.btnTranspor.Name = "btnTranspor";
            this.btnTranspor.Size = new System.Drawing.Size(121, 45);
            this.btnTranspor.TabIndex = 7;
            this.btnTranspor.Text = "Transpor Matrizes";
            this.btnTranspor.UseVisualStyleBackColor = true;
            // 
            // btnInverter
            // 
            this.btnInverter.Enabled = false;
            this.btnInverter.Location = new System.Drawing.Point(1436, 764);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(121, 45);
            this.btnInverter.TabIndex = 8;
            this.btnInverter.Text = "Inverter Matrizes";
            this.btnInverter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Resultado:";
            // 
            // frmOperacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 1061);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInverter);
            this.Controls.Add(this.btnTranspor);
            this.Controls.Add(this.btnLer2);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnLer1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmOperacoes";
            this.Text = "Operações";
            this.Load += new System.EventHandler(this.frmOperacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnLer1;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnLer2;
        private System.Windows.Forms.OpenFileDialog dlgArquivo;
        private System.Windows.Forms.Button btnTranspor;
        private System.Windows.Forms.Button btnInverter;
        private System.Windows.Forms.Label label1;
    }
}