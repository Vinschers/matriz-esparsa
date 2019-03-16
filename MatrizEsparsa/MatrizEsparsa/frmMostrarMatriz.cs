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
    public partial class frmMostrarMatriz : Form
    {
        public frmMostrarMatriz()
        {
            InitializeComponent();
        }

        private void btnLerArquivo_Click(object sender, EventArgs e) // permite que o usuário exiba a matriz após a leitura
        {
            btnExibirMatriz.Enabled = true;
        }

        private void btnExibirMatriz_Click(object sender, EventArgs e) //permite que o usuário pesquise 
        {                                                             //informações apenas após a exibição dos dados
            btnExcluirMatriz.Enabled = true;
            btnExcluirCelula.Enabled = true;
            btnProcurarCelula.Enabled = true;
            label1.Enabled = true;
            label2.Enabled = true;
            nUDColuna.Enabled = true;
            nUDLinha.Enabled = true;
            btnAdicionarK.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
