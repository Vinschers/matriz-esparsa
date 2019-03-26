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
    public partial class frmOperacoes : Form
    {
        const string arquivoA = "matrizA.txt";
        const string arquivoB = "matrizB.txt";
        ListaCruzada matrizA, matrizB, matrizC;
        public frmOperacoes()
        {
            InitializeComponent();
            matrizA = new ListaCruzada();
            matrizB = new ListaCruzada();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmOperacoes_Load(object sender, EventArgs e)
        {

        }

        private void btnLer2_Click(object sender, EventArgs e)
        {
            if (File.Exists(arquivoB))
                matrizB = new ListaCruzada(new StreamReader(arquivoB));
            else
                File.Create(arquivoB);
            matrizB.Exibir(ref dgvB);
            btnMultiplicar.Enabled = true;
            btnSomar.Enabled = true;
        }

        private void btnLer1_Click(object sender, EventArgs e)
        {
            if (File.Exists(arquivoA))
                matrizA = new ListaCruzada(new StreamReader(arquivoA));
            else
                File.Create(arquivoA);
            matrizA.Exibir(ref dgvA);
            btnTranspor.Enabled = true;
            btnInverter.Enabled = true;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                matrizC = matrizA.Multiplicar(matrizB);
                matrizC.Exibir(ref dgvResultado);
            }
            catch (Exception erro) { MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                matrizC = matrizA.Somar(matrizB);
                matrizC.Exibir(ref dgvResultado);
            }
            catch (Exception erro) { MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void btnUma_Click(object sender, EventArgs e)
        {
            btnLer1.Enabled = true;
        }

        private void btnDuas_Click(object sender, EventArgs e)
        {
            btnLer2.Enabled = true;
            btnLer1.Enabled = true;
            dgvResultado.Visible = true;
            dgvB.Visible = true;
        }
    }
}
