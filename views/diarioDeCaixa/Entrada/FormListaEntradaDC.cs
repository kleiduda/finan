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
    public partial class FormListaEntradaDC : Form
    {
        public FormListaEntradaDC()
        {
            InitializeComponent();
        }

        private void FormListaP_Load(object sender, EventArgs e)
        {
            ListEntradas();
        }
        public void ListEntradas()
        {
            dgvEntradas.DataSource = DoEntrada.ListEntradas();
            dgvEntradas.Columns["data_entrada"].HeaderText = "Data";
            dgvEntradas.Columns["valor"].HeaderText = "Valor";
            dgvEntradas.Columns["observacao"].HeaderText = "Obs";
            dgvEntradas.Columns["descricao"].HeaderText = "Tipo Entrada";
            dgvEntradas.Columns["Expr1"].HeaderText = "Tipo Pagamento";
            dgvEntradas.Columns["id"].Visible = false;
            dgvEntradas.Columns["delete"].DisplayIndex = 6;
        }
        private void dgvEntradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string rpta = "";
                try
                {
                    if (MessageBox.Show("Excluir Entrada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rpta = DoEntrada.Entrada_Delete(int.Parse(dgvEntradas.CurrentRow.Cells["id"].Value.ToString()));
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
                ListEntradas();
            }
        }
        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            FormEntradaDC frm = new FormEntradaDC();
            frm.ShowDialog();
            ListEntradas();
        }
    }
}
