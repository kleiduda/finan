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
            if (dgvLancamentos.Rows.Count !=0)
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
            if (e.ColumnIndex == 5)
            {
                Parcelas frm = new Parcelas(dgvLancamentos.CurrentRow.Cells["id"].Value.ToString());
                frm.ShowDialog();
            }
        }
    }
}
