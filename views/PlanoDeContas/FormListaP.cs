using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace views
{
    public partial class FormListaP : Form
    {
        public FormListaP()
        {
            InitializeComponent();
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            FormEntradaP frm = new FormEntradaP();
            frm.ShowDialog();
        }

        private void FormListaP_Load(object sender, EventArgs e)
        {
            PlanoContas_Lista();
        }
        public void PlanoContas_Lista()
        {
            dgvLancamentos.DataSource = DoCadastros.PlanoContas_Lista();
            dgvLancamentos.Columns["id"].Visible = false;

            dgvLancamentos.Columns["descricao"].HeaderText = "Descrição";
            dgvLancamentos.Columns["valor"].HeaderText = "Valor";
            dgvLancamentos.Columns["data_pagamento"].HeaderText = "Data";
            dgvLancamentos.Columns["status"].HeaderText = "STATUS";
            dgvLancamentos.Columns["doc"].HeaderText = "DOC";
            dgvLancamentos.Columns["parcela"].HeaderText = "Parcela";
            dgvLancamentos.Columns["observacao"].HeaderText = "Observação";

        }
    }
}
