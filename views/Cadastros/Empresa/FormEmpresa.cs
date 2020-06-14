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
    public partial class FormEmpresa : Form
    {
        public FormEmpresa()
        {
            InitializeComponent();
        }

        private void FormEmpresa_Load(object sender, EventArgs e)
        {
            Lista();
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
            dgvCadastros.DataSource = DoCadastros.EmpresaLista();
            dgvCadastros.Columns["id"].Visible = false;
            dgvCadastros.Columns["nome_fantasia"].DisplayIndex = 0;
            dgvCadastros.Columns["nome_fantasia"].HeaderText = "Empresa";
            dgvCadastros.Columns["cnpj"].DisplayIndex = 1;
            dgvCadastros.Columns["cnpj"].HeaderText = "Cnpj";
            dgvCadastros.Columns["delete"].DisplayIndex = 2;
            dgvCadastros.Columns["delete"].HeaderText = "...";
            dgvCadastros.Columns["delete"].Width = 50;
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
                if (string.IsNullOrEmpty(txtCnpj.Text))
                {
                    lblError.Visible = true;
                    lblSuc.Visible = false;
                    msgError("Campo não pode estar vazio!");
                }
                else
                {
                    if (DoCadastros.EmpresaValida(txtCnpj.Text))
                    {
                        lblSuc.Visible = false;
                        lblError.Visible = true;
                        msgError("Já existe uma Empresa com CNPJ: " + txtCnpj.Text.Trim().ToUpper());
                    }
                    else
                    {
                        rpta = DoCadastros.EmpresaCadastro( txtNomeFantasia.Text.Trim().ToUpper(),txtCnpj.Text.Trim().ToUpper());
                    }
                    if (rpta.Equals("OK"))
                    {
                        lblError.Visible = false;
                        msgSuccess("Empresa " + txtNomeFantasia.Text.Trim().ToUpper() + ", cadastrado com sucesso!");
                    }

                }
            }
            catch (Exception ex)
            {
                msgError(ex.Message + ex.StackTrace);
            }
            Lista();
            txtNomeFantasia.Clear();
            txtCnpj.Clear();
            txtNomeFantasia.Focus();
        }
        private void dgvCadastros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string rpta = "";
                try
                {
                    if (MessageBox.Show("Excluir Empresa?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rpta = DoCadastros.Empresa_Delete(int.Parse(dgvCadastros.CurrentRow.Cells["id"].Value.ToString()));
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
    }
}
