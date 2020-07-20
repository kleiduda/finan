using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Support;



namespace views.PlanoDeContas.Provisionado
{
    public partial class Parcelas : Form
    {
        private bool Pagto = true;
        public Parcelas()
        {
            InitializeComponent();
        }
        public Parcelas(string value, string value2, string value3, string value4)
        {
            InitializeComponent();
            lblId.Text = value;
            lblFpagto.Text = value2;
            lblSucCat.Text = value3;
            lblEmpresa.Text = value4;
        }
        private void Parcelas_Load(object sender, EventArgs e)
        {
            ListarParcelas();
            Cheked();

        }
        public void ListarParcelas()
        {
            dgvParcelas.DataSource = DoCadastros.Parcela_ListaPorID(Convert.ToInt32(lblId.Text));
        }
        public void Cheked()
        {
            for (int i = 0; i < dgvParcelas.RowCount; i++)
            {
                if (dgvParcelas.Rows[i].Cells["status_pagamento"].Value.ToString() == "PAGO")
                {
                    dgvParcelas.Rows[i].Cells["pagamento"].Value = true;
                }
                else
                {
                    dgvParcelas.Rows[i].Cells["pagamento"].Value = false;
                }
            }

        }
        private void btnSelecionarTudo_Click(object sender, EventArgs e)
        {

        }

        private void dgvParcelas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvParcelas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvParcelas.Columns[e.ColumnIndex].Name == "status_pagamento")
            {
                if (e.Value.ToString() == "PAGO")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(24, 209, 185);

                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(245, 58, 58);
                }

            }
        }

        private void dgvParcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string rpta = "";
            string pago = "";

            try
            {
                if (e.ColumnIndex == 0)
                {
                    if (dgvParcelas.CurrentRow.Cells["status_pagamento"].Value.ToString() == "PENDENTE")
                    {
                        dgvParcelas.CurrentRow.Cells["pagamento"].Value = true;
                        rpta = DoCadastros.Parcela_Update(
                            Convert.ToInt32(dgvParcelas.CurrentRow.Cells["id"].Value.ToString()),
                            Convert.ToInt32(Support.Enum.PagtoRec.Pago)
                            );
                    }
                    else if (dgvParcelas.CurrentRow.Cells["status_pagamento"].Value.ToString() == "PAGO")
                    {
                        rpta = DoCadastros.Parcela_Update(
                            Convert.ToInt32(dgvParcelas.CurrentRow.Cells["id"].Value.ToString()),
                            Convert.ToInt32(Support.Enum.PagtoRec.Pendente)
                            );
                    }
                    if (rpta.Equals("OK"))
                    {
                        pago = DoCadastros.PlanoContas_Cadastro
                            (
                                dgvParcelas.CurrentRow.Cells["descricao"].Value.ToString(),
                                Convert.ToDecimal(dgvParcelas.CurrentRow.Cells["valor"].Value.ToString()),
                                Convert.ToDateTime(dgvParcelas.CurrentRow.Cells["DataPagamento"].Value.ToString()),
                                Convert.ToInt32(Status.pago),
                                Convert.ToInt32(lblFpagto.Text),
                                "",
                                dgvParcelas.CurrentRow.Cells["parcela"].Value.ToString(),
                                Convert.ToInt32(lblEmpresa.Text),
                                Convert.ToInt32(lblSucCat.Text),
                                ""
                            );
                        if (pago.Equals("OK"))
                        {
                            MessageBox.Show("Status alterado para PAGO");
                        }
                        else
                        {
                            MessageBox.Show(pago);
                        }
                    }
                    else
                    {
                        MessageBox.Show("não é possivel desfazer o pagamento (consulte o administrador do sistema)");
                    }
                    ListarParcelas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}

