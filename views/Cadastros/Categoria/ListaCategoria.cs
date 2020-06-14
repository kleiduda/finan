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
    public partial class ListaCategoria : Form
    {
        public ListaCategoria()
        {
            InitializeComponent();
        }

        private void ListaCategoria_Load(object sender, EventArgs e)
        {
            ListRegistros();
        }
        public void ListRegistros()
        {
            dgvRegistros.DataSource = DoCadastros.Categoria_Lista();
            dgvRegistros.Columns["id"].Visible = false;
            dgvRegistros.Columns["descricao"].DisplayIndex = 1;
            dgvRegistros.Columns["descricao"].HeaderText = "Nome";
            dgvRegistros.Columns["Expr1"].DisplayIndex = 2;
            dgvRegistros.Columns["Expr1"].HeaderText = "Centro de Custo";
            dgvRegistros.Columns["Expr2"].DisplayIndex = 3;
            dgvRegistros.Columns["Expr2"].HeaderText = "Sub Categoria";
            dgvRegistros.Columns["delete"].DisplayIndex = 4;
            dgvRegistros.Columns["delete"].HeaderText = "...";
            dgvRegistros.Columns["delete"].Width = 50;
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
                        rpta = DoCadastros.Categoria_Delete(int.Parse(dgvRegistros.CurrentRow.Cells["id"].Value.ToString()));
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
            Categoria frm = new Categoria("novo");
            frm.ShowDialog();
            ListRegistros();
        }

        private void dgvRegistros_DoubleClick(object sender, EventArgs e)
        {
            Categoria _frm = new Categoria(dgvRegistros.CurrentRow.Cells["id"].Value.ToString());
            _frm.ShowDialog();
            ListRegistros();
        }
    }
}
