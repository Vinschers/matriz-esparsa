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
            this.dgvA = new System.Windows.Forms.DataGridView();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.dgvB = new System.Windows.Forms.DataGridView();
            this.btnLer1 = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnLer2 = new System.Windows.Forms.Button();
            this.dlgArquivo = new System.Windows.Forms.OpenFileDialog();
            this.btnTranspor = new System.Windows.Forms.Button();
            this.btnInverter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUma = new System.Windows.Forms.Button();
            this.btnDuas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvA
            // 
            this.dgvA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA.Location = new System.Drawing.Point(39, 62);
            this.dgvA.Name = "dgvA";
            this.dgvA.Size = new System.Drawing.Size(735, 454);
            this.dgvA.TabIndex = 0;
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(39, 595);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(735, 454);
            this.dgvResultado.TabIndex = 1;
            this.dgvResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dgvB
            // 
            this.dgvB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvB.Location = new System.Drawing.Point(822, 62);
            this.dgvB.Name = "dgvB";
            this.dgvB.Size = new System.Drawing.Size(735, 454);
            this.dgvB.TabIndex = 2;
            this.dgvB.Visible = false;
            this.dgvB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // btnLer1
            // 
            this.btnLer1.Enabled = false;
            this.btnLer1.Location = new System.Drawing.Point(910, 630);
            this.btnLer1.Name = "btnLer1";
            this.btnLer1.Size = new System.Drawing.Size(121, 45);
            this.btnLer1.TabIndex = 3;
            this.btnLer1.Text = "Ler Arquivo A";
            this.btnLer1.UseVisualStyleBackColor = true;
            this.btnLer1.Click += new System.EventHandler(this.btnLer1_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Enabled = false;
            this.btnSomar.Location = new System.Drawing.Point(1177, 721);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(121, 45);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "Somar Matrizes";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Enabled = false;
            this.btnMultiplicar.Location = new System.Drawing.Point(1177, 811);
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
            this.btnLer2.Location = new System.Drawing.Point(1177, 630);
            this.btnLer2.Name = "btnLer2";
            this.btnLer2.Size = new System.Drawing.Size(121, 45);
            this.btnLer2.TabIndex = 6;
            this.btnLer2.Text = "Ler Arquivo B";
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
            this.btnTranspor.Location = new System.Drawing.Point(910, 721);
            this.btnTranspor.Name = "btnTranspor";
            this.btnTranspor.Size = new System.Drawing.Size(121, 45);
            this.btnTranspor.TabIndex = 7;
            this.btnTranspor.Text = "Transpor Matriz";
            this.btnTranspor.UseVisualStyleBackColor = true;
            // 
            // btnInverter
            // 
            this.btnInverter.Enabled = false;
            this.btnInverter.Location = new System.Drawing.Point(910, 811);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(121, 45);
            this.btnInverter.TabIndex = 8;
            this.btnInverter.Text = "Inverter Matriz";
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
            // btnUma
            // 
            this.btnUma.Location = new System.Drawing.Point(910, 544);
            this.btnUma.Name = "btnUma";
            this.btnUma.Size = new System.Drawing.Size(121, 45);
            this.btnUma.TabIndex = 10;
            this.btnUma.Text = "Uma matriz";
            this.btnUma.UseVisualStyleBackColor = true;
            this.btnUma.Click += new System.EventHandler(this.btnUma_Click);
            // 
            // btnDuas
            // 
            this.btnDuas.Location = new System.Drawing.Point(1177, 548);
            this.btnDuas.Name = "btnDuas";
            this.btnDuas.Size = new System.Drawing.Size(121, 45);
            this.btnDuas.TabIndex = 11;
            this.btnDuas.Text = "Duas Matrizes";
            this.btnDuas.UseVisualStyleBackColor = true;
            this.btnDuas.Click += new System.EventHandler(this.btnDuas_Click);
            // 
            // frmOperacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 1061);
            this.Controls.Add(this.btnDuas);
            this.Controls.Add(this.btnUma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInverter);
            this.Controls.Add(this.btnTranspor);
            this.Controls.Add(this.btnLer2);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnLer1);
            this.Controls.Add(this.dgvB);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.dgvA);
            this.Name = "frmOperacoes";
            this.Text = "Operações";
            this.Load += new System.EventHandler(this.frmOperacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvA;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridView dgvB;
        private System.Windows.Forms.Button btnLer1;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnLer2;
        private System.Windows.Forms.OpenFileDialog dlgArquivo;
        private System.Windows.Forms.Button btnTranspor;
        private System.Windows.Forms.Button btnInverter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUma;
        private System.Windows.Forms.Button btnDuas;
    }
}