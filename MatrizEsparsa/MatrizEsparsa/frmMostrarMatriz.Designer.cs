namespace MatrizEsparsa
{
    partial class frmMostrarMatriz
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
            this.btnLerArquivo = new System.Windows.Forms.Button();
            this.btnExibirMatriz = new System.Windows.Forms.Button();
            this.btnProcurarCelula = new System.Windows.Forms.Button();
            this.btnExcluirMatriz = new System.Windows.Forms.Button();
            this.btnExcluirCelula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nUDLinha = new System.Windows.Forms.NumericUpDown();
            this.nUDColuna = new System.Windows.Forms.NumericUpDown();
            this.dlgArquivo = new System.Windows.Forms.OpenFileDialog();
            this.btnAdicionarK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDColuna)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(773, 549);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnLerArquivo
            // 
            this.btnLerArquivo.Location = new System.Drawing.Point(16, 574);
            this.btnLerArquivo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLerArquivo.Name = "btnLerArquivo";
            this.btnLerArquivo.Size = new System.Drawing.Size(139, 40);
            this.btnLerArquivo.TabIndex = 1;
            this.btnLerArquivo.Text = "Ler Arquivo";
            this.btnLerArquivo.UseVisualStyleBackColor = true;
            this.btnLerArquivo.Click += new System.EventHandler(this.btnLerArquivo_Click);
            // 
            // btnExibirMatriz
            // 
            this.btnExibirMatriz.Enabled = false;
            this.btnExibirMatriz.Location = new System.Drawing.Point(16, 642);
            this.btnExibirMatriz.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExibirMatriz.Name = "btnExibirMatriz";
            this.btnExibirMatriz.Size = new System.Drawing.Size(139, 40);
            this.btnExibirMatriz.TabIndex = 2;
            this.btnExibirMatriz.Text = "Exibir Matriz";
            this.btnExibirMatriz.UseVisualStyleBackColor = true;
            this.btnExibirMatriz.Click += new System.EventHandler(this.btnExibirMatriz_Click);
            // 
            // btnProcurarCelula
            // 
            this.btnProcurarCelula.Enabled = false;
            this.btnProcurarCelula.Location = new System.Drawing.Point(728, 591);
            this.btnProcurarCelula.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnProcurarCelula.Name = "btnProcurarCelula";
            this.btnProcurarCelula.Size = new System.Drawing.Size(139, 40);
            this.btnProcurarCelula.TabIndex = 3;
            this.btnProcurarCelula.Text = "Procurar dado";
            this.btnProcurarCelula.UseVisualStyleBackColor = true;
            // 
            // btnExcluirMatriz
            // 
            this.btnExcluirMatriz.Enabled = false;
            this.btnExcluirMatriz.Location = new System.Drawing.Point(197, 574);
            this.btnExcluirMatriz.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExcluirMatriz.Name = "btnExcluirMatriz";
            this.btnExcluirMatriz.Size = new System.Drawing.Size(139, 40);
            this.btnExcluirMatriz.TabIndex = 4;
            this.btnExcluirMatriz.Text = "Excluir Matriz";
            this.btnExcluirMatriz.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCelula
            // 
            this.btnExcluirCelula.Enabled = false;
            this.btnExcluirCelula.Location = new System.Drawing.Point(728, 669);
            this.btnExcluirCelula.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExcluirCelula.Name = "btnExcluirCelula";
            this.btnExcluirCelula.Size = new System.Drawing.Size(139, 40);
            this.btnExcluirCelula.TabIndex = 5;
            this.btnExcluirCelula.Text = "Excluir Dado";
            this.btnExcluirCelula.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 606);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Linha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 687);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Coluna:";
            // 
            // nUDLinha
            // 
            this.nUDLinha.Enabled = false;
            this.nUDLinha.Location = new System.Drawing.Point(505, 606);
            this.nUDLinha.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nUDLinha.Name = "nUDLinha";
            this.nUDLinha.Size = new System.Drawing.Size(160, 23);
            this.nUDLinha.TabIndex = 8;
            // 
            // nUDColuna
            // 
            this.nUDColuna.Enabled = false;
            this.nUDColuna.Location = new System.Drawing.Point(505, 687);
            this.nUDColuna.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nUDColuna.Name = "nUDColuna";
            this.nUDColuna.Size = new System.Drawing.Size(160, 23);
            this.nUDColuna.TabIndex = 9;
            // 
            // dlgArquivo
            // 
            this.dlgArquivo.FileName = "openFileDialog1";
            // 
            // btnAdicionarK
            // 
            this.btnAdicionarK.Enabled = false;
            this.btnAdicionarK.Location = new System.Drawing.Point(887, 615);
            this.btnAdicionarK.Name = "btnAdicionarK";
            this.btnAdicionarK.Size = new System.Drawing.Size(144, 57);
            this.btnAdicionarK.TabIndex = 10;
            this.btnAdicionarK.Text = "Adicionar K na coluna";
            this.btnAdicionarK.UseVisualStyleBackColor = true;
            // 
            // frmMostrarMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1043, 746);
            this.Controls.Add(this.btnAdicionarK);
            this.Controls.Add(this.nUDColuna);
            this.Controls.Add(this.nUDLinha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluirCelula);
            this.Controls.Add(this.btnExcluirMatriz);
            this.Controls.Add(this.btnProcurarCelula);
            this.Controls.Add(this.btnExibirMatriz);
            this.Controls.Add(this.btnLerArquivo);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMostrarMatriz";
            this.Text = "Exibição da Matriz";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDColuna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLerArquivo;
        private System.Windows.Forms.Button btnExibirMatriz;
        private System.Windows.Forms.Button btnProcurarCelula;
        private System.Windows.Forms.Button btnExcluirMatriz;
        private System.Windows.Forms.Button btnExcluirCelula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUDLinha;
        private System.Windows.Forms.NumericUpDown nUDColuna;
        private System.Windows.Forms.OpenFileDialog dlgArquivo;
        private System.Windows.Forms.Button btnAdicionarK;
    }
}