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
    public partial class FormTipoEntrada : Form
    {
        public FormTipoEntrada()
        {
            InitializeComponent();
        }

        private void FormTipoEntrada_Load(object sender, EventArgs e)
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
            dgvCadastros.DataSource = DoCadastros.TipoEntrada_Lista();
            dgvCadastros.Columns["id"].Visible = false;
            dgvCadastros.Columns["descricao"].DisplayIndex = 0;
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
                int Especie = 0;
                if (string.IsNullOrEmpty(txtCadastro.Text))
                {
                    lblError.Visible = true;
                    lblSuc.Visible = false;
                    msgError("Campo não pode estar vazio!");
                }
                else
                {
                    if (DoCadastros.TipoEntrada_Valida(txtCadastro.Text))
                    {
                        lblSuc.Visible = false;
                        lblError.Visible = true;
                        msgError("Já existe um tipo de Entrada com descrição: " + txtCadastro.Text.Trim().ToUpper());
                    }
                    else
                    {
                        if (chkEspecie.Checked == true)
                        {
                            Especie = 1;
                        }
                        rpta = DoCadastros.TipoEntrada_Cadastro(txtCadastro.Text.Trim().ToUpper(), Especie);
                    }
                    if (rpta.Equals("OK"))
                    {
                        lblError.Visible = false;
                        msgSuccess("Tipo de Entrada " + txtCadastro.Text.Trim().ToUpper() + ", cadastrado com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                msgError(ex.Message + ex.StackTrace);
            }
            Lista();
            txtCadastro.Clear();
            chkEspecie.Checked = false;
            txtCadastro.Focus();
        }

        private void dgvCadastros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string rpta = "";
                try
                {
                    if (MessageBox.Show("Excluir Tipo de entrada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rpta = DoCadastros.TipoEntrada_Delete(int.Parse(dgvCadastros.CurrentRow.Cells["id"].Value.ToString()));
                    }
                    else
                    {
                        // user clicked no
                    }
                    if (rpta.Equals("OK"))
                    {
                        lblError.Visible = false;
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
