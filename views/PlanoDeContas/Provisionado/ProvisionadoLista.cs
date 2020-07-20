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
using views.PlanoDeContas.Provisionado;

namespace views
{
    public partial class ProvisionadoLista : Form
    {
        public ProvisionadoLista()
        {
            InitializeComponent();
        }



        private void ProvisionadoLista_Load(object sender, EventArgs e)
        {
            Provisionados_Lista();
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            var ultimoId = "0";
            if (dgvLancamentos.Rows.Count != 0)
            {
                ultimoId = this.dgvLancamentos.Rows[this.dgvLancamentos.Rows.Count - 1].Cells["id"].Value.ToString();
            }
            ProvisionadoEntrada frm = new ProvisionadoEntrada("novo", ultimoId);
            frm.ShowDialog();
            Provisionados_Lista();
        }
        public void CalculoTotais()
        {
            decimal total = Convert.ToDecimal(dgvLancamentos.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(x.Cells["Valor"].Value ?? 0)).ToString());
            lblProvisionado.Text = "Provisionado: " + total.ToString("C");
        }
        public void Provisionados_Lista()
        {
            dgvLancamentos.DataSource = DoCadastros.Recorrencia_Lista();
            dgvLancamentos.Columns["id"].Visible = false;
            dgvLancamentos.Columns["id_sub"].Visible = false;
            dgvLancamentos.Columns["id_emp"].Visible = false;
            dgvLancamentos.Columns["id_pagto"].Visible = false;
            dgvLancamentos.Columns["delete"].DisplayIndex = 12;
            CalculoTotais();

            // dgvLancamentos.Columns["descricao"].HeaderText = "DESCRIÇÂO";


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // dgvLancamentos.DataSource = DoCadastros.PlanoContas_Pesquisa(txtSearch.Text);
            // CalculoTotais();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            //var inicio = DateTime.Parse(dtInicio.Value.ToString()).ToShortDateString();
            //var fim = DateTime.Parse(dtFim.Value.ToString()).ToShortDateString();
            //if (string.IsNullOrEmpty(txtSearch.Text))
            //{
            //    dgvLancamentos.DataSource = DoCadastros.PlanoContas_FiltroDataSemDescricao(Convert.ToDateTime(inicio), Convert.ToDateTime(fim));
            //}
            //else
            //{
            //    dgvLancamentos.DataSource = DoCadastros.PlanoContas_FiltroData(Convert.ToDateTime(inicio), Convert.ToDateTime(fim), txtSearch.Text);
            //}

            //CalculoTotais();
        }

        private void dgvLancamentos_DoubleClick(object sender, EventArgs e)
        {
            var ultimoId = this.dgvLancamentos.Rows[this.dgvLancamentos.Rows.Count - 1].Cells["id"].Value.ToString();
            ProvisionadoEntrada _frm = new ProvisionadoEntrada(dgvLancamentos.CurrentRow.Cells["id"].Value.ToString(), ultimoId);
            _frm.ShowDialog();
            Provisionados_Lista();
        }

        private void dgvLancamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                Parcelas frm = new Parcelas(
                    dgvLancamentos.CurrentRow.Cells["id"].Value.ToString(),
                    dgvLancamentos.CurrentRow.Cells["id_pagto"].Value.ToString(),
                    dgvLancamentos.CurrentRow.Cells["id_sub"].Value.ToString(),
                    dgvLancamentos.CurrentRow.Cells["id_emp"].Value.ToString()
                    );
                frm.ShowDialog();
            }
            if (e.ColumnIndex == 0)
            {
                string rpta = "";
                try
                {
                    if (MessageBox.Show("Excluir Registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rpta = DoCadastros.Recorrencia_Delete(int.Parse(dgvLancamentos.CurrentRow.Cells["id"].Value.ToString()));
                    }
                    else
                    {
                        // user clicked no
                    }
                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("Registro excluida com sucesso!");
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
                Provisionados_Lista();
            }
        }
        private void dgvLancamentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvLancamentos.Columns[e.ColumnIndex].Name == "empresa")
            {
                e.CellStyle.BackColor = Color.Red;
            }
        }

    }
}
