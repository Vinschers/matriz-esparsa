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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnLerArquivo = new System.Windows.Forms.Button();
            this.btnExibirMatriz = new System.Windows.Forms.Button();
            this.btnExibirCelula = new System.Windows.Forms.Button();
            this.btnExcluirMatriz = new System.Windows.Forms.Button();
            this.btnExcluirCelula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nUDLinha = new System.Windows.Forms.NumericUpDown();
            this.nUDColuna = new System.Windows.Forms.NumericUpDown();
            this.dlgArquivo = new System.Windows.Forms.OpenFileDialog();
            this.btnAdicionarK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorCelula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dlgSalvar = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDColuna)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(1, 1);
            this.dgv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(773, 549);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
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
            this.btnExibirMatriz.Location = new System.Drawing.Point(16, 642);
            this.btnExibirMatriz.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExibirMatriz.Name = "btnExibirMatriz";
            this.btnExibirMatriz.Size = new System.Drawing.Size(139, 40);
            this.btnExibirMatriz.TabIndex = 2;
            this.btnExibirMatriz.Text = "Exibir Matriz";
            this.btnExibirMatriz.UseVisualStyleBackColor = true;
            this.btnExibirMatriz.Click += new System.EventHandler(this.btnExibirMatriz_Click);
            // 
            // btnExibirCelula
            // 
            this.btnExibirCelula.Location = new System.Drawing.Point(537, 688);
            this.btnExibirCelula.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExibirCelula.Name = "btnExibirCelula";
            this.btnExibirCelula.Size = new System.Drawing.Size(139, 40);
            this.btnExibirCelula.TabIndex = 3;
            this.btnExibirCelula.Text = "Exibir dado";
            this.btnExibirCelula.UseVisualStyleBackColor = true;
            this.btnExibirCelula.Click += new System.EventHandler(this.btnExibirCelula_Click);
            // 
            // btnExcluirMatriz
            // 
            this.btnExcluirMatriz.Location = new System.Drawing.Point(197, 574);
            this.btnExcluirMatriz.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExcluirMatriz.Name = "btnExcluirMatriz";
            this.btnExcluirMatriz.Size = new System.Drawing.Size(139, 40);
            this.btnExcluirMatriz.TabIndex = 4;
            this.btnExcluirMatriz.Text = "Excluir Matriz";
            this.btnExcluirMatriz.UseVisualStyleBackColor = true;
            this.btnExcluirMatriz.Click += new System.EventHandler(this.btnExcluirMatriz_Click);
            // 
            // btnExcluirCelula
            // 
            this.btnExcluirCelula.Location = new System.Drawing.Point(388, 688);
            this.btnExcluirCelula.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExcluirCelula.Name = "btnExcluirCelula";
            this.btnExcluirCelula.Size = new System.Drawing.Size(139, 40);
            this.btnExcluirCelula.TabIndex = 5;
            this.btnExcluirCelula.Text = "Excluir Dado";
            this.btnExcluirCelula.UseVisualStyleBackColor = true;
            this.btnExcluirCelula.Click += new System.EventHandler(this.btnExcluirCelula_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
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
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 642);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Coluna:";
            // 
            // nUDLinha
            // 
            this.nUDLinha.Location = new System.Drawing.Point(465, 606);
            this.nUDLinha.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nUDLinha.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDLinha.Name = "nUDLinha";
            this.nUDLinha.Size = new System.Drawing.Size(85, 23);
            this.nUDLinha.TabIndex = 8;
            this.nUDLinha.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUDColuna
            // 
            this.nUDColuna.Location = new System.Drawing.Point(465, 644);
            this.nUDColuna.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nUDColuna.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDColuna.Name = "nUDColuna";
            this.nUDColuna.Size = new System.Drawing.Size(85, 23);
            this.nUDColuna.TabIndex = 9;
            this.nUDColuna.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dlgArquivo
            // 
            this.dlgArquivo.FileName = "openFileDialog1";
            // 
            // btnAdicionarK
            // 
            this.btnAdicionarK.Enabled = false;
            this.btnAdicionarK.Location = new System.Drawing.Point(850, 474);
            this.btnAdicionarK.Name = "btnAdicionarK";
            this.btnAdicionarK.Size = new System.Drawing.Size(144, 57);
            this.btnAdicionarK.TabIndex = 10;
            this.btnAdicionarK.Text = "Adicionar K na coluna";
            this.btnAdicionarK.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 642);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dimensões:";
            // 
            // txtLargura
            // 
            this.txtLargura.Location = new System.Drawing.Point(197, 669);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(115, 23);
            this.txtLargura.TabIndex = 12;
            this.txtLargura.TextChanged += new System.EventHandler(this.txtLargura_TextChanged);
            this.txtLargura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLargura_KeyPress);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(197, 720);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(115, 23);
            this.txtAltura.TabIndex = 13;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtLargura_TextChanged);
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLargura_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 695);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "X";
            // 
            // txtValorCelula
            // 
            this.txtValorCelula.Location = new System.Drawing.Point(614, 627);
            this.txtValorCelula.Name = "txtValorCelula";
            this.txtValorCelula.Size = new System.Drawing.Size(62, 23);
            this.txtValorCelula.TabIndex = 16;
            this.txtValorCelula.TextChanged += new System.EventHandler(this.txtValorCelula_TextChanged);
            this.txtValorCelula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorCelula_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(560, 627);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Valor:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(890, 703);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(139, 40);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar Matriz";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmMostrarMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1043, 756);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtValorCelula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtLargura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdicionarK);
            this.Controls.Add(this.nUDColuna);
            this.Controls.Add(this.nUDLinha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluirCelula);
            this.Controls.Add(this.btnExcluirMatriz);
            this.Controls.Add(this.btnExibirCelula);
            this.Controls.Add(this.btnExibirMatriz);
            this.Controls.Add(this.btnLerArquivo);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMostrarMatriz";
            this.Text = "Exibição da Matriz";
            this.Load += new System.EventHandler(this.frmMostrarMatriz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDColuna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnLerArquivo;
        private System.Windows.Forms.Button btnExibirMatriz;
        private System.Windows.Forms.Button btnExibirCelula;
        private System.Windows.Forms.Button btnExcluirMatriz;
        private System.Windows.Forms.Button btnExcluirCelula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUDLinha;
        private System.Windows.Forms.NumericUpDown nUDColuna;
        private System.Windows.Forms.OpenFileDialog dlgArquivo;
        private System.Windows.Forms.Button btnAdicionarK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorCelula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.SaveFileDialog dlgSalvar;
    }
}