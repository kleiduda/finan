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
using Support;

namespace views
{
    public partial class FormEntradaP : Form
    {
        private bool IsNew = true;
        public FormEntradaP()
        {
            InitializeComponent();
        }
        public FormEntradaP(string value)
        {
            InitializeComponent();
            lblID.Text = value;
        }
        private void FormEntradas_Load(object sender, EventArgs e)
        {
            TabIndex();
            ListSubCategoria();
            ListEmpresa();
            Listpagamento();
            ListStatus();
            if (lblID.Text != "novo")
            {
                IsNew = false;
                Edit();
            }
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

        private void ListEmpresa()
        {
            cbEmpresa.DataSource = DoCadastros.EmpresaLista();
            cbEmpresa.ValueMember = "id";
            cbEmpresa.DisplayMember = "nome_fantasia";
        }

        private void ListSubCategoria()
        {
            cbSubCategoria.DataSource = DoCadastros.Categoria_ListaSubCategoria();
            cbSubCategoria.ValueMember = "id";
            cbSubCategoria.DisplayMember = "descricao";
        }
        private void Listpagamento()
        {
            cbPagamento.DataSource = DoCadastros.Pagamento_Lista();
            cbPagamento.ValueMember = "id";
            cbPagamento.DisplayMember = "descricao";
        }
        private void ListStatus()
        {
            cbStatus.DataSource = DoCadastros.Status_Lista();
            cbStatus.ValueMember = "id";
            cbStatus.DisplayMember = "status";
        }
        public void Edit()
        {
            DataTable dt = new DataTable();
            dt = DoCadastros.PlanoContas_ListaPorID(int.Parse(lblID.Text));
            txtDescricao.Text = dt.Rows[0]["descricao"].ToString();
            txtValor.Text = dt.Rows[0]["valor"].ToString();
            txtDoc.Text = dt.Rows[0]["doc"].ToString();
            txtParcela.Text = dt.Rows[0]["parcela"].ToString();
            txtObservacao.Text = dt.Rows[0]["observacao"].ToString();
            cbSubCategoria.Text = dt.Rows[0]["SubCategoria"].ToString();
            cbEmpresa.Text = dt.Rows[0]["Empresa"].ToString();
            cbPagamento.Text = dt.Rows[0]["Pagamento"].ToString();
            cbStatus.Text = dt.Rows[0]["status"].ToString();
        }

        public void TabIndex()
        {
            cbStatus.TabIndex = 1;
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
            txtDescricao.Clear();
            txtParcela.Clear();
            txtDoc.Clear();
            dateEntrada.ResetText();
            cbEmpresa.ResetText();
            cbPagamento.ResetText();
            Status.ResetText();
            cbSubCategoria.ResetText();
            cbStatus.ResetText();

        }
        public void DesabilitarEdição()
        {
            txtValor.Enabled = false;
            txtObservacao.Enabled = false;
            txtDescricao.Enabled = false;
            txtParcela.Enabled = false;
            txtDoc.Enabled = false;
            dateEntrada.Enabled = false;
            cbEmpresa.Enabled = false;
            cbPagamento.Enabled = false;
            Status.Enabled = false;
            cbSubCategoria.Enabled = false;
            cbStatus.Enabled = false;
        }
        public void EnabledEdit()
        {
            txtValor.Enabled = true;
            txtObservacao.Enabled = true;
            txtDescricao.Enabled = true;
            txtParcela.Enabled = true;
            txtDoc.Enabled = true;
            dateEntrada.Enabled = true;
            cbEmpresa.Enabled = true;
            cbPagamento.Enabled = true;
            Status.Enabled = true;
            cbSubCategoria.Enabled = true;
            cbStatus.Enabled = true;
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            dateEntrada.Focus();
            LimparCampos();
            EnabledEdit();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesabilitarEdição();
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
            btnNovoCadastro.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            try
            {
                if (string.IsNullOrEmpty(txtValor.Text))
                {
                    MessageBox.Show("Campo valor não pode estar vazio!");
                }
                else if (IsNew == true)
                {
                    rpta = DoCadastros.PlanoContas_Cadastro
                    (
                        txtDescricao.Text,
                        Convert.ToDecimal(txtValor.Text),
                        dateEntrada.Value,
                        Convert.ToInt32(cbStatus.SelectedValue),
                        Convert.ToInt32(cbPagamento.SelectedValue),
                        txtDoc.Text,
                        txtParcela.Text,
                        Convert.ToInt32(cbEmpresa.SelectedValue),
                        Convert.ToInt32(cbSubCategoria.SelectedValue),
                        txtObservacao.Text
                    );
                }
                else if (IsNew == false)
                {
                    rpta = DoCadastros.PlanoContas_Update
                        (
                        Convert.ToInt32(lblID.Text),
                        txtDescricao.Text,
                        Convert.ToDecimal(txtValor.Text),
                        dateEntrada.Value,
                        Convert.ToInt32(cbStatus.SelectedValue),
                        Convert.ToInt32(cbPagamento.SelectedValue),
                        txtDoc.Text,
                        txtParcela.Text,
                        Convert.ToInt32(cbEmpresa.SelectedValue),
                        Convert.ToInt32(cbSubCategoria.SelectedValue),
                        txtObservacao.Text
                        );
                }

                if (rpta.Equals("OK") && IsNew == true)
                {
                    msgSuccess("Cadastro REALIZADO com sucesso!");
                }
                else
                {
                    //msgError(rpta);
                    msgSuccess("Cadastro ATUALIZADO com sucesso!");
                }
            }
            catch (Exception ex)
            {
                msgError(ex.Message);
            }
        }

    }
}
