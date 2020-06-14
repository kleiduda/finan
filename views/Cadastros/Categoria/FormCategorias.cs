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
    public partial class FormCategorias : Form
    {
        private bool IsNew = true;
        public FormCategorias()
        {
            InitializeComponent();
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            Lista();
            ListCentroCusto();
            ListSubCategoria();
        }
        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }
        private void msgSuccess(string msg)
        {
            lblSuc.Text = "      " + msg;
            lblSuc.Visible = true;
        }
        public void Lista()
        {
            dgvCadastros.DataSource = DoCadastros.Categoria_Lista();
            dgvCadastros.Columns["id"].Visible = false;
            dgvCadastros.Columns["descricao"].DisplayIndex = 1;
            dgvCadastros.Columns["descricao"].HeaderText = "Nome";
            dgvCadastros.Columns["Expr1"].DisplayIndex = 2;
            dgvCadastros.Columns["Expr1"].HeaderText = "Centro de Custo";
            dgvCadastros.Columns["Expr2"].DisplayIndex = 3;
            dgvCadastros.Columns["Expr2"].HeaderText = "Sub Categoria";

            dgvCadastros.Columns["delete"].DisplayIndex = 4;
            dgvCadastros.Columns["delete"].HeaderText = "...";
            dgvCadastros.Columns["delete"].Width = 50;
        }
        public void ListCentroCusto()
        {
            cbCentroCusto.DataSource = DoCadastros.CentroCusto_Lista();
            cbCentroCusto.ValueMember = "id";
            cbCentroCusto.DisplayMember = "descricao";
        }
        public void ListSubCategoria()
        {
            cbSubCategoria.DataSource = DoCadastros.Categoria_ListaSubCategoria();
            cbSubCategoria.ValueMember = "id";
            cbSubCategoria.DisplayMember = "descricao";
        }

        private void txtCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar_Click(sender, e);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (string.IsNullOrEmpty(txtCategoria.Text))
                {
                    lblError.Visible = true;
                    lblSuc.Visible = false;
                    msgError("Campo não pode estar vazio!");
                }
                else
                {
                    if (DoCadastros.Categoria_Valida(txtCategoria.Text))
                    {
                        lblSuc.Visible = false;
                        lblError.Visible = true;
                        msgError("Já existe uma Categoria com descrição: " + txtCategoria.Text.Trim().ToUpper());
                    }
                    else
                    {
                        rpta = DoCadastros.Categoria_Cadastro(txtCategoria.Text.Trim().ToUpper(), Convert.ToInt32(cbCentroCusto.SelectedValue), cbSubCategoria.Text);
                    }
                    if (rpta.Equals("OK"))
                    {
                        lblError.Visible = false;
                        msgSuccess("Categoria " + txtCategoria.Text.Trim().ToUpper() + ", cadastrado com sucesso!");
                    }

                }
            }
            catch (Exception ex)
            {
                msgError(ex.Message + ex.StackTrace);
            }
            Lista();
            txtCategoria.Clear();
            txtCategoria.Focus();
        }

        private void dgvCadastros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string rpta = "";
                try
                {
                    if (MessageBox.Show("Excluir Categoria?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rpta = DoCadastros.Categoria_Delete(int.Parse(dgvCadastros.CurrentRow.Cells["id"].Value.ToString()));
                    }
                    else
                    {
                        // user clicked no
                    }
                    if (rpta.Equals("OK"))
                    {
                        msgSuccess("Cadastro excluido com sucesso!");
                    }
                    else
                    {
                        msgError("Erro ao tentar excluir");
                    }
                }
                catch (Exception ex)
                {
                    rpta = ex.Message + ex.StackTrace;
                }
                Lista();
            }
        }

        private void btnNovaSubCategoria_Click(object sender, EventArgs e)
        {
            //pSubCategoria.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
        }
    }
}
