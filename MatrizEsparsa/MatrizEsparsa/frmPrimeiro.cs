using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrizEsparsa
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnMostrarMatriz_Click(object sender, EventArgs e) // cria e mostra um formulário de MostrarMatriz.cs
        {
            frmMostrarMatriz exibir = new frmMostrarMatriz(); 
            exibir.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();    // finalizar o programa quando o usuário clicar
        }

        private void btnOperacoes_Click(object sender, EventArgs e)
        {
            frmOperacoes op = new frmOperacoes();
            op.Show();
        }
    }
}
