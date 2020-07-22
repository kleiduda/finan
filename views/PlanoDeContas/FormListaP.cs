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
            FormEntradaP frm = new FormEntradaP("novo");
            frm.ShowDialog();
            PlanoContas_Lista();
        }

        private void FormListaP_Load(object sender, EventArgs e)
        {
            PlanoContas_Lista();
        }
        public void CalculoTotais()
        {
            decimal entradas = Convert.ToDecimal(dgvLancamentos.Rows.Cast<DataGridViewRow>().Where(x => x.Cells["status"].Value.ToString() == "Recebido").Sum(x => Convert.ToDecimal(x.Cells["Valor"].Value ?? 0)).ToString());
            decimal saidas = Convert.ToDecimal(dgvLancamentos.Rows.Cast<DataGridViewRow>().Where(x => x.Cells["status"].Value.ToString() == "Pago").Sum(x => Convert.ToDecimal(x.Cells["Valor"].Value ?? 0)).ToString());
            decimal total = entradas - saidas;
            lblTEntradas.Text = "Entradas: " + entradas.ToString("C");
            lblTSaidas.Text = "Saídas: " + saidas.ToString("C");
            lblTotal.Text = "Total: " + total.ToString("C");
        }
        public void PlanoContas_Lista()
        {
            dgvLancamentos.DataSource = DoCadastros.PlanoContas_Lista();
            dgvLancamentos.Columns["id"].Visible = false;
            CalculoTotais();

            dgvLancamentos.Columns["descricao"].HeaderText = "DESCRIÇÂO";
            dgvLancamentos.Columns["valor"].HeaderText = "VALOR";
            dgvLancamentos.Columns["data_pagamento"].HeaderText = "DATA";
            dgvLancamentos.Columns["status"].HeaderText = "STATUS";
            dgvLancamentos.Columns["doc"].HeaderText = "DOC";
            dgvLancamentos.Columns["parcela"].HeaderText = "PARCELA";
            dgvLancamentos.Columns["observacao"].HeaderText = "OBS";
            dgvLancamentos.Columns["Pagamento"].HeaderText = "F.PAGTO";
            dgvLancamentos.Columns["Categoria"].HeaderText = "CATEGORIA";
            dgvLancamentos.Columns["SubCategoria"].HeaderText = "SUBCATEGORIA";
            dgvLancamentos.Columns["Empresa"].HeaderText = "EMPRESA";
            dgvLancamentos.Columns["CentroCusto"].HeaderText = "C.CUSTO";
            dgvLancamentos.Columns["delete"].DisplayIndex = 13;


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvLancamentos.DataSource = DoCadastros.PlanoContas_Pesquisa(txtSearch.Text);
            CalculoTotais();
        }
        private void dgvLancamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string rpta = "";
                try
                {
                    if (MessageBox.Show("Excluir Entrada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rpta = DoCadastros.PlanoContas_Delete(int.Parse(dgvLancamentos.CurrentRow.Cells["id"].Value.ToString()));
                    }
                    else
                    {
                        // user clicked no
                    }
                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("Entrada excluida com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show(rpta);
                    }
                }
                catch (Exception ex)
                {
                    rpta = ex.Message + ex.StackTrace;
                }
                PlanoContas_Lista();
            }
        }
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            var inicio = DateTime.Parse(dtInicio.Value.ToString()).ToShortDateString();
            var fim = DateTime.Parse(dtFim.Value.ToString()).ToShortDateString();
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                dgvLancamentos.DataSource = DoCadastros.PlanoContas_FiltroDataSemDescricao(Convert.ToDateTime(inicio), Convert.ToDateTime(fim));
            }
            else
            {
                dgvLancamentos.DataSource = DoCadastros.PlanoContas_FiltroData(Convert.ToDateTime(inicio), Convert.ToDateTime(fim), txtSearch.Text);
            }

            CalculoTotais();
        }

        private void dgvLancamentos_DoubleClick(object sender, EventArgs e)
        {
            FormEntradaP _frm = new FormEntradaP(dgvLancamentos.CurrentRow.Cells["id"].Value.ToString());
            _frm.ShowDialog();
            PlanoContas_Lista();
        }

        private void dgvLancamentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }
    }
}
