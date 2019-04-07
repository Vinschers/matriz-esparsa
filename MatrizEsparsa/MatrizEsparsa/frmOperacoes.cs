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

        private void btnLer1_Click(object sender, EventArgs e)
        {
            if (dlgArquivo.ShowDialog() == DialogResult.OK)
            {
                string arquivo = dlgArquivo.FileName;
                if (File.Exists(arquivo))
                    matrizA = new ListaCruzada(new StreamReader(arquivo));
                else
                    File.Create(arquivo);
            }
            if (dlgArquivo.ShowDialog() == DialogResult.OK)
            {
                string arquivo = dlgArquivo.FileName;
                if (File.Exists(arquivo))
                    matrizB = new ListaCruzada(new StreamReader(arquivo));
                else
                    File.Create(arquivo);
            }
            matrizA.Exibir(ref dgvA);
            matrizB.Exibir(ref dgvB);
            btnMultiplicar.Enabled = true;
            btnSomar.Enabled = true;
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

        private void label1_Click(object sender, EventArgs e)
        {

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

    }
}
