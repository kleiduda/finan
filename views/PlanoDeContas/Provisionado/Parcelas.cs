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
        public Parcelas()
        {
            InitializeComponent();
        }
        public Parcelas(string value)
        {
            InitializeComponent();
            lblId.Text = value;
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
            string rpta = "";
            try
            {
                if (dgvParcelas.CurrentRow.Cells["status_pagamento"].Value.ToString() == "PENDENTE")
                {
                    dgvParcelas.CurrentRow.Cells["pagamento"].Value = true;
                    rpta = DoCadastros.Parcela_Update(
                        Convert.ToInt32(dgvParcelas.CurrentRow.Cells["id"].Value.ToString()),
                        Convert.ToInt32(Support.Enum.PagtoRec.Pago)
                        );
                }
                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("Blz");
                }
                else
                {
                    MessageBox.Show("nada feito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
        }
    }
}
