﻿using System;
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
    public partial class frmOperacoes : Form
    {
        public frmOperacoes()
        {
            InitializeComponent();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmOperacoes_Load(object sender, EventArgs e)
        {

        }

        private void btnLer2_Click(object sender, EventArgs e)
        {
            btnMultiplicar.Enabled = true;
            btnSomar.Enabled = true;
        }

        private void btnLer1_Click(object sender, EventArgs e)
        {
            btnTranspor.Enabled = true;
            btnInverter.Enabled = true;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUma_Click(object sender, EventArgs e)
        {
            btnLer1.Enabled = true;
        }

        private void btnDuas_Click(object sender, EventArgs e)
        {
            btnLer2.Enabled = true;
            dataGridView2.Visible = true;
        }
    }
}
