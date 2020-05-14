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
    public partial class FormCentroCusto : Form
    {
        private bool IsNew = true;
        public FormCentroCusto()
        {
            InitializeComponent();
        }

        private void FormCentroCusto_Load(object sender, EventArgs e)
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
            dgvCadastros.DataSource = DoCentroCusto.ListCentroCusto();
            dgvCadastros.Columns["id"].Visible = false;
            dgvCadastros.Columns["descricao"].DisplayIndex = 1;
            dgvCadastros.Columns["descricao"].HeaderText = "Nome";
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
                if (string.IsNullOrEmpty(txtCadastro.Text))
                {
                    msgError("Campo não pode estar vazio!");
                }
                else if (DoCentroCusto.Valida(txtCadastro.Text))
                {
                    lblError.Visible = true;
                    msgError("Já existe um Centro de Custo com descrição: " + txtCadastro.Text.Trim().ToUpper());
                }
                else
                {
                    rpta = DoCentroCusto.CadastroCentroCusto(txtCadastro.Text.Trim().ToUpper());
                }
                if (rpta.Equals("OK"))
                {
                    lblError.Visible = false;
                    msgSuccess("Centro de Custo " + txtCadastro.Text.Trim().ToUpper() + ", cadastrado com sucesso!");
                }
                else
                {
                    lblSuc.Visible = false;
                    msgError(rpta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            Lista();
            txtCadastro.Clear();
            txtCadastro.Focus();
        }

        private void dgvCadastros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string rpta = "";
                try
                {
                    if (MessageBox.Show("Excluir Tipo de pagamento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rpta = DoCentroCusto.DeleteCentroCusto(int.Parse(dgvCadastros.CurrentRow.Cells["id"].Value.ToString()));
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
