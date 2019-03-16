namespace MatrizEsparsa
{
    partial class frmPrincipal
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
            this.btnMostrarMatriz = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnOperacoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarMatriz
            // 
            this.btnMostrarMatriz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMostrarMatriz.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarMatriz.Location = new System.Drawing.Point(59, 17);
            this.btnMostrarMatriz.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarMatriz.Name = "btnMostrarMatriz";
            this.btnMostrarMatriz.Size = new System.Drawing.Size(150, 28);
            this.btnMostrarMatriz.TabIndex = 0;
            this.btnMostrarMatriz.Text = "Exibir Matriz";
            this.btnMostrarMatriz.UseVisualStyleBackColor = true;
            this.btnMostrarMatriz.Click += new System.EventHandler(this.btnMostrarMatriz_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(59, 121);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 28);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnOperacoes
            // 
            this.btnOperacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOperacoes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperacoes.Location = new System.Drawing.Point(59, 69);
            this.btnOperacoes.Margin = new System.Windows.Forms.Padding(4);
            this.btnOperacoes.Name = "btnOperacoes";
            this.btnOperacoes.Size = new System.Drawing.Size(150, 28);
            this.btnOperacoes.TabIndex = 2;
            this.btnOperacoes.Text = "Operações";
            this.btnOperacoes.UseVisualStyleBackColor = true;
            this.btnOperacoes.Click += new System.EventHandler(this.btnOperacoes_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(271, 201);
            this.Controls.Add(this.btnOperacoes);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMostrarMatriz);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.Text = "Projeto Matriz Esparsa";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarMatriz;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnOperacoes;
    }
}

