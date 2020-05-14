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
    public partial class FormSaidas : Form
    {
        private bool IsNew = true;
        public FormSaidas()
        {
            InitializeComponent();
        }
        private void FormSaidas_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            TabIndex();
            ListTipoSaida();
            Listpagamento();
            ListSaidas();
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
        private void ListTipoSaida()
        {
            cbTipoSaida.DataSource = DoTipoEntrada.ListaTipoSaida();
            cbTipoSaida.ValueMember = "id";
            cbTipoSaida.DisplayMember = "descricao";
        }
        private void Listpagamento()
        {
            cbPagamento.DataSource = DoPagamento.ListaPagamento();
            cbPagamento.ValueMember = "id";
            cbPagamento.DisplayMember = "descricao";
        }
        public void CarregarDataGrid()
        {
        }
        public void TabIndex()
        {
            cbTipoSaida.TabIndex = 1;
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
            cbTipoSaida.Enabled = false;
            cbPagamento.Enabled = false;
        }
        public void EnabledEdit()
        {
            txtValor.Enabled = true;
            txtObservacao.Enabled = true;
            cbTipoSaida.Enabled = true;
            cbPagamento.Enabled = true;
            cbTipoSaida.Focus();
        }
        public void ListSaidas()
        {
            dgvEntradas.DataSource = DoSaida.ListSaida();
            dgvEntradas.Columns["id"].Visible = false;
            dgvEntradas.Columns["data_saida"].HeaderText = "Data";
            dgvEntradas.Columns["valor"].HeaderText = "Valor";
            dgvEntradas.Columns["observacao"].HeaderText = "Obs";
            dgvEntradas.Columns["descricao"].HeaderText = "Tipo Saída";
            dgvEntradas.Columns["pagamento"].HeaderText = "Tipo Pagamento";
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            cbTipoSaida.Focus();
            LimparCampos();
            EnabledEdit();
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
            cbTipoSaida.Focus();
            LimparCampos();
            EnabledEdit();
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
                    rpta = DoSaida.CadastroSaida(
                        dateEntrada.Value, 
                        decimal.Parse(txtValor.Text),
                        txtObservacao.Text,
                        Convert.ToInt32(cbTipoSaida.SelectedValue),
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
            ListSaidas();
            DesabilitarEdição();
        }

       

        
    }
}
