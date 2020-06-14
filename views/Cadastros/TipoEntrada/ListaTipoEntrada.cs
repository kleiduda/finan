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
    public partial class ListaTipoEntrada : Form
    {
        public ListaTipoEntrada()
        {
            InitializeComponent();
        }

        private void ListaTipoEntrada_Load(object sender, EventArgs e)
        {
            ListRegistros();
        }
        public void ListRegistros()
        {
            dgvRegistros.DataSource = DoCadastros.TipoEntrada_Lista();
            dgvRegistros.Columns["descricao"].HeaderText = "Descrição";
            dgvRegistros.Columns["dinheiro"].HeaderText = "Espécie?";
            dgvRegistros.Columns["id"].Visible = false;
            dgvRegistros.Columns["delete"].DisplayIndex = 3;
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
                        rpta = DoCadastros.TipoEntrada_Delete(int.Parse(dgvRegistros.CurrentRow.Cells["id"].Value.ToString()));
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
            TipoEntrada frm = new TipoEntrada("novo");
            frm.ShowDialog();
            ListRegistros();
        }

        private void dgvRegistros_DoubleClick(object sender, EventArgs e)
        {
            TipoEntrada _frm = new TipoEntrada(dgvRegistros.CurrentRow.Cells["id"].Value.ToString());
            _frm.ShowDialog();
            ListRegistros();
        }
    }
}
