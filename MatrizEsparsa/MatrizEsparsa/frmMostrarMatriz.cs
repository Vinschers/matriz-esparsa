using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MatrizEsparsa
{
    public partial class frmMostrarMatriz : Form
    {
        ListaCruzada matriz;
        string arquivo;
        bool exibindoMatriz = false, exibindoValorDaCelula, alterandoTextDimensao = false;
        public frmMostrarMatriz()
        {
            InitializeComponent();
            matriz = new ListaCruzada();
        }

        private void btnLerArquivo_Click(object sender, EventArgs e) // permite que o usuário exiba a matriz após a leitura
        {
            if (dlgArquivo.ShowDialog() == DialogResult.OK)
            {
                arquivo = dlgArquivo.FileName;
                btnExibirMatriz.Enabled = true;
                if (File.Exists(arquivo))
                    matriz = new ListaCruzada(new StreamReader(arquivo));
                else
                    File.Create(arquivo);
                alterandoTextDimensao = true;
                txtLargura.Text = matriz.Colunas.ToString();
                txtAltura.Text = matriz.Linhas.ToString();
                alterandoTextDimensao = false;
                dgv.RowCount = matriz.Linhas;
                dgv.ColumnCount = matriz.Colunas;
                exibindoMatriz = true;
                matriz.Exibir(ref dgv);
                exibindoMatriz = false;
            }
        }

        private void btnExibirMatriz_Click(object sender, EventArgs e) //permite que o usuário pesquise 
        {                                                             //informações apenas após a exibição dos dados
            if (matriz != null)
            {
                dgv.RowCount = matriz.Linhas;
                dgv.ColumnCount = matriz.Colunas;
                exibindoMatriz = true;
                matriz.Exibir(ref dgv);
                exibindoMatriz = false;
            }
            else
                matriz = new ListaCruzada(ref dgv);
            btnExcluirMatriz.Enabled = true;
            btnExcluirCelula.Enabled = true;
            btnExibirCelula.Enabled = true;
            label1.Enabled = true;
            label2.Enabled = true;
            nUDColuna.Enabled = true;
            nUDLinha.Enabled = true;
            btnAdicionarK.Enabled = true;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtLargura_TextChanged(object sender, EventArgs e)
        {
            if (txtAltura.Text != "" && txtLargura.Text != "" && !alterandoTextDimensao)
            {
                int l = int.Parse(txtAltura.Text);
                int c = int.Parse(txtLargura.Text);
                nUDColuna.Maximum = c;
                nUDLinha.Maximum = l;
                if (l > 1 && c > 1)
                {
                    matriz.MudarDimensao(l, c);
                    dgv.RowCount = l;
                    dgv.ColumnCount = c;
                    exibindoMatriz = true;
                    foreach (DataGridViewRow r in dgv.Rows)
                        foreach (DataGridViewCell co in r.Cells)
                            co.Value = 0;
                    matriz.Exibir(ref dgv);
                    exibindoMatriz = false;
                }
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
            exibindoValorDaCelula = true;
            int linha = (int)nUDLinha.Value;
            int coluna = (int)nUDColuna.Value;
            if (linha <= matriz.Linhas && coluna <= matriz.Colunas)
            {
                txtValorCelula.Text = matriz[linha, coluna].ToString();
                exibindoValorDaCelula = false;
            }
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
                exibindoValorDaCelula = true;
                txtValorCelula.Text = "0";
                exibindoValorDaCelula = false;
                exibindoMatriz = true;
                matriz.Exibir(ref dgv);
                exibindoMatriz = false;
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

        private void txtValorCelula_TextChanged(object sender, EventArgs e)
        {
            if (!exibindoValorDaCelula)
            {
                int linha = (int)nUDLinha.Value;
                int coluna = (int)nUDColuna.Value;
                if (matriz[linha, coluna] == 0)
                    matriz.Adicionar(new Celula(double.Parse(txtValorCelula.Text), linha, coluna));
                else
                    matriz.Alterar(linha, coluna, double.Parse(txtValorCelula.Text));
            }
        }

        private void btnExcluirMatriz_Click(object sender, EventArgs e)
        {
            matriz.RemoverTudo();
            matriz.Exibir(ref dgv);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            matriz.Salvar(new StreamWriter(arquivo));
        }

        //SCHERER, precisa somar K inclusive nas linhas com 0?

        private void btnAdicionarK_Click(object sender, EventArgs e)
        {
            int coluna = Convert.ToInt16(nUDColuna.Value);
            int valor = Convert.ToInt16(txtK.Text);
            for (int i = 1; i < matriz.Linhas + 1; i++)
                matriz.Alterar(i, coluna, matriz[i, coluna] + valor);
            matriz.Exibir(ref dgv);
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!exibindoMatriz)
            {
                int linha = e.RowIndex + 1;
                int coluna = e.ColumnIndex + 1;
                double valor = Convert.ToDouble(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (valor == 0)
                {
                    if (matriz[linha, coluna] != 0)
                        matriz.Remover(linha, coluna);
                }
                else
                {
                    if (matriz[linha, coluna] == 0)
                        matriz.Adicionar(new Celula(valor, linha, coluna));
                    else
                        matriz.Alterar(linha, coluna, valor);
                }
            }
        }

        private void frmMostrarMatriz_Load(object sender, EventArgs e)
        {
            alterandoTextDimensao = true;
            txtAltura.Text = txtLargura.Text = ListaCruzada.dimensaoDefault.ToString();
            nUDLinha.Maximum = nUDColuna.Maximum = ListaCruzada.dimensaoDefault;
            alterandoTextDimensao = false;
        }
    }
}
