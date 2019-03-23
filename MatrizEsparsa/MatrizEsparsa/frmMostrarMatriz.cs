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
        ListaCruzada matriz;
        public frmMostrarMatriz()
        {
            InitializeComponent();
            matriz = new ListaCruzada();
        }

        private void btnLerArquivo_Click(object sender, EventArgs e) // permite que o usuário exiba a matriz após a leitura
        {
            btnExibirMatriz.Enabled = true;
        }

        private void btnExibirMatriz_Click(object sender, EventArgs e) //permite que o usuário pesquise 
        {                                                             //informações apenas após a exibição dos dados
            btnExcluirMatriz.Enabled = true;
            btnExcluirCelula.Enabled = true;
            btnExibirCelula.Enabled = true;
            label1.Enabled = true;
            label2.Enabled = true;
            nUDColuna.Enabled = true;
            nUDLinha.Enabled = true;
            btnAdicionarK.Enabled = true;
            dgv.RowCount = matriz.Linhas;
            dgv.ColumnCount = matriz.Colunas;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtLargura_TextChanged(object sender, EventArgs e)
        {
            if (txtAltura.Text != "" && txtLargura.Text != "")
            {
                int l = int.Parse(txtAltura.Text);
                int c = int.Parse(txtLargura.Text);
                if (l > 1 && c > 1)
                    matriz.MudarDimensao(l, c);
            }
        }

        private void txtLargura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnExibirCelula_Click(object sender, EventArgs e)
        {
            int linha = (int)nUDLinha.Value;
            int coluna = (int)nUDColuna.Value;
            if (linha <= matriz.Linhas && coluna <= matriz.Colunas)
                txtValorCelula.Text = matriz.Achar(linha, coluna).ToString();
            else
                MessageBox.Show("Linha ou coluna está fora da matriz", "Erro de parâmetro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnExcluirCelula_Click(object sender, EventArgs e)
        {
            int linha = (int)nUDLinha.Value;
            int coluna = (int)nUDColuna.Value;
            if (linha <= matriz.Linhas && coluna <= matriz.Colunas)
            {
                matriz.Remover(linha, coluna);
                txtValorCelula.Text = matriz.Achar(linha, coluna).ToString();
            }
            else
                MessageBox.Show("Linha ou coluna está fora da matriz", "Erro de parâmetro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtValorCelula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}
