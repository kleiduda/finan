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
            dgvLancamentos.Columns["cnpj"].Visible = false;
            dgvLancamentos.Columns["id_tipo_entrada"].Visible = false;
            dgvLancamentos.Columns["id_tipo_saida"].Visible = false;

            dgvLancamentos.Columns["descricao"].HeaderText = "Descrição";
            dgvLancamentos.Columns["valor"].HeaderText = "Valor";
            dgvLancamentos.Columns["data_pagamento"].HeaderText = "Data";
            dgvLancamentos.Columns["id_status"].HeaderText = "STATUS";
            dgvLancamentos.Columns["id_pagamento"].HeaderText = "Forma Pagamento";
            dgvLancamentos.Columns["doc"].HeaderText = "DOC";
            dgvLancamentos.Columns["parcela"].HeaderText = "Parcela";
            dgvLancamentos.Columns["id_empresa"].HeaderText = "Empresa";
            dgvLancamentos.Columns["id_sub_categoria"].HeaderText = "Sub Categoria";
            dgvLancamentos.Columns["observacao"].HeaderText = "Observação";

        }
    }
}
