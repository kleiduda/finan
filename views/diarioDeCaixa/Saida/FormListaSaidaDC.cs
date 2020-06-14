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
    public partial class FormListaSaidaDC : Form
    {
        public FormListaSaidaDC()
        {
            InitializeComponent();
        }

        private void FormListaSaidaDC_Load(object sender, EventArgs e)
        {
            ListSaidas();
        }
        public void ListSaidas()
        {
            dgvSaidas.DataSource = DoSaida.Saida_Lista();
            dgvSaidas.Columns["data_saida"].HeaderText = "Data";
            dgvSaidas.Columns["valor"].HeaderText = "Valor";
            dgvSaidas.Columns["observacao"].HeaderText = "Obs";
            dgvSaidas.Columns["descricao"].HeaderText = "Tipo Saída";
            dgvSaidas.Columns["Expr1"].HeaderText = "Tipo Pagamento";
            dgvSaidas.Columns["id"].Visible = false;
            dgvSaidas.Columns["delete"].DisplayIndex = 6;
        }
        private void dgvSaidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string rpta = "";
                try
                {
                    if (MessageBox.Show("Excluir Saída?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rpta = DoSaida.Saida_Delete(int.Parse(dgvSaidas.CurrentRow.Cells["id"].Value.ToString()));
                    }
                    else
                    {
                        // user clicked no
                    }
                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("Saída excluida com sucesso!");
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
                ListSaidas();
            }
        }
        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            FormSaidaDC frm = new FormSaidaDC();
            frm.ShowDialog();
            ListSaidas();
        }
    }
}
