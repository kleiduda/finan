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
    public partial class ListaCentroCusto : Form
    {
        public ListaCentroCusto()
        {
            InitializeComponent();
        }

        private void ListaCentroCusto_Load(object sender, EventArgs e)
        {
            ListRegistros();
        }
        public void ListRegistros()
        {
            dgvRegistros.DataSource = DoCadastros.CentroCusto_Lista();
            dgvRegistros.Columns["descricao"].HeaderText = "Descrição";
            dgvRegistros.Columns["id"].Visible = false;
            dgvRegistros.Columns["delete"].DisplayIndex = 2;
        }
        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string rpta = "";
                try
                {
                    if (MessageBox.Show("Excluir Registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rpta = DoCadastros.CentroCusto_Delete(int.Parse(dgvRegistros.CurrentRow.Cells["id"].Value.ToString()));
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
                ListRegistros();
            }
        }
        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            CentroCusto frm = new CentroCusto("novo");
            frm.ShowDialog();
            ListRegistros();
        }

        private void dgvRegistros_DoubleClick(object sender, EventArgs e)
        {
            CentroCusto _frm = new CentroCusto(dgvRegistros.CurrentRow.Cells["id"].Value.ToString());
            _frm.ShowDialog();
            ListRegistros();
        }
    }
}
