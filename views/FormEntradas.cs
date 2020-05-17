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
    public partial class FormEntradas : Form
    {
        private bool IsNew = true;
        public FormEntradas()
        {
            InitializeComponent();
        }
        private void FormEntradas_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            TabIndex();
            ListTipoEntrada();
            Listpagamento();
            ListEntradas();
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
        private void ListTipoEntrada()
        {
            cbTipoEntrada.DataSource = DoCadastros.TipoEntrada_Lista();
            cbTipoEntrada.ValueMember = "id";
            cbTipoEntrada.DisplayMember = "descricao";
        }
        private void Listpagamento()
        {
            cbPagamento.DataSource = DoCadastros.Pagamento_Lista();
            cbPagamento.ValueMember = "id";
            cbPagamento.DisplayMember = "descricao";
        }
        public void CarregarDataGrid()
        {
        }
        public void TabIndex()
        {
            cbTipoEntrada.TabIndex = 1;
            cbPagamento.TabIndex = 2;
            dateEntrada.TabIndex = 3;
            txtValor.TabIndex = 4;
            txtObservacao.TabIndex = 5;
            btnSalvar.TabIndex = 6;
        }
        //formatando string para moeda
        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception ex)
            {

            }
        }
        private void LimparCampos()
        {
            txtValor.Clear();
            txtObservacao.Clear();
            
        }
        public void DesabilitarEdição()
        {
            txtValor.Enabled = false;
            txtObservacao.Enabled = false;
            cbTipoEntrada.Enabled = false;
            cbPagamento.Enabled = false;
        }
        public void EnabledEdit()
        {
            txtValor.Enabled = true;
            txtObservacao.Enabled = true;
            cbTipoEntrada.Enabled = true;
            cbPagamento.Enabled = true;
            cbTipoEntrada.Focus();
        }
        public void ListEntradas()
        {
            dgvEntradas.DataSource = DoEntrada.ListEntradas();
            dgvEntradas.Columns["data_entrada"].HeaderText = "Data";
            dgvEntradas.Columns["valor"].HeaderText = "Valor";
            dgvEntradas.Columns["observacao"].HeaderText = "Obs";
            dgvEntradas.Columns["descricao"].HeaderText = "Tipo Entrada";
            dgvEntradas.Columns["Expr1"].HeaderText = "Tipo Pagamento";

        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            cbTipoEntrada.Focus();
            LimparCampos();
            EnabledEdit();
            btnNovoCadastro.Enabled = false;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
            lblSuc.Visible = false;
            lblError.Visible = false;
            this.IsNew = true;
        }
        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            cbTipoEntrada.Focus();
            LimparCampos();
            EnabledEdit();
            btnNovo.Enabled = false;
            btnNovoCadastro.Enabled = false;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
            lblSuc.Visible = false;
            lblError.Visible = false;
            this.IsNew = true;
        }
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtValor);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            try
            {
                if (this.txtValor.Text == string.Empty)
                {
                    lblSuc.Visible = false;
                    msgError("Alguns campos obrigatórios não foram preenchidos!");
                }
                else
                {
                    rpta = DoEntrada.CadastroEntrada(
                        dateEntrada.Value, 
                        decimal.Parse(txtValor.Text),
                        txtObservacao.Text,
                        Convert.ToInt32(cbTipoEntrada.SelectedValue),
                        Convert.ToInt32(cbPagamento.SelectedValue)
                        );
                }
                if (rpta.Equals("OK"))
                {
                    msgSuccess("Cadastro realizado com sucesso!");
                }
                else
                {
                    msgError(rpta);
                }
            }
            catch (Exception ex)
            {
                rpta = ex.Message + ex.StackTrace;
            }
            ListEntradas();
            DesabilitarEdição();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesabilitarEdição();
            btnNovo.Enabled = true;
            btnNovoCadastro.Enabled = true;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = true;
            btnSalvar.Enabled = false;
            lblSuc.Visible = false;
            lblError.Visible = false;
            this.IsNew = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EnabledEdit();
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btnNovoCadastro.Enabled = false;
        }

        private void dgvEntradas_Click(object sender, EventArgs e)
        {
            
        }
    }
}
