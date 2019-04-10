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
            this.btnLer = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.dlgArquivo = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvA
            // 
            this.dgvA.AllowUserToAddRows = false;
            this.dgvA.AllowUserToDeleteRows = false;
            this.dgvA.AllowUserToOrderColumns = true;
            this.dgvA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA.ColumnHeadersVisible = false;
            this.dgvA.Location = new System.Drawing.Point(39, 62);
            this.dgvA.Name = "dgvA";
            this.dgvA.RowHeadersVisible = false;
            this.dgvA.Size = new System.Drawing.Size(578, 313);
            this.dgvA.TabIndex = 0;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.AllowUserToOrderColumns = true;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.ColumnHeadersVisible = false;
            this.dgvResultado.Location = new System.Drawing.Point(39, 412);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.RowHeadersVisible = false;
            this.dgvResultado.Size = new System.Drawing.Size(578, 350);
            this.dgvResultado.TabIndex = 1;
            this.dgvResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dgvB
            // 
            this.dgvB.AllowUserToAddRows = false;
            this.dgvB.AllowUserToDeleteRows = false;
            this.dgvB.AllowUserToOrderColumns = true;
            this.dgvB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvB.ColumnHeadersVisible = false;
            this.dgvB.Location = new System.Drawing.Point(702, 62);
            this.dgvB.Name = "dgvB";
            this.dgvB.RowHeadersVisible = false;
            this.dgvB.Size = new System.Drawing.Size(578, 313);
            this.dgvB.TabIndex = 2;
            this.dgvB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(722, 425);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(121, 45);
            this.btnLer.TabIndex = 3;
            this.btnLer.Text = "Ler Arquivos";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer1_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Enabled = false;
            this.btnSomar.Location = new System.Drawing.Point(702, 556);
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
            this.btnMultiplicar.Location = new System.Drawing.Point(999, 539);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(121, 45);
            this.btnMultiplicar.TabIndex = 5;
            this.btnMultiplicar.Text = "Multiplicar Matrizes";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // dlgArquivo
            // 
            this.dlgArquivo.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Resultado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmOperacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 882);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnLer);
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
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.OpenFileDialog dlgArquivo;
        private System.Windows.Forms.Label label1;
    }
}