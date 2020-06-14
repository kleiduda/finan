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
    public partial class FormEntradaDC : Form
    {
        private bool IsNew = true;
        public FormEntradaDC()
        {
            InitializeComponent();
        }
        private void FormEntradas_Load(object sender, EventArgs e)
        {
           
            TabIndex();
            ListTipoEntrada();
            Listpagamento();

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
            lblSaldoAnterior.Text = "";
            lblSaldoFinal.Text = "";

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
        
        private void btnNovo_Click(object sender, EventArgs e)
        {
            cbTipoEntrada.Focus();
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
        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {

            cbTipoEntrada.Focus();
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

        public void UpdateSaldo()
        {
            string rpta = "";
            try
            {
                if (cbTipoEntrada.Text == "Vendas - dinheiro" || cbTipoEntrada.Text == "Vendas - espécie")
                {
                    rpta = DoEntrada.Entrada_UpdateSaldoFinal(Convert.ToDecimal(lblSaldoFinal.Text) + Convert.ToDecimal(txtValor.Text), dateEntrada.Value);
                }

            }
            catch (Exception ex)
            {
                rpta = ex.Message + ex.StackTrace;
            }
        }
        public void SaldoAnterior()
        {
            DataTable dt = new DataTable();
            dt = DoCadastros.SaldoInicial_Lista();
            DateTime data = new DateTime();
            data = Convert.ToDateTime(dateEntrada.Value.ToString());
            var saldoAnterior = dt.AsEnumerable().Where(x => x.Field<string>("data_entrada") == data.AddDays(-1).ToShortDateString()).
                Select(k =>
                {
                    var row = dt.NewRow();
                    row.ItemArray = new object[]
                    {
                        k.Field<decimal>("saldo_final")
                    };
                    return row;
                });
            if (saldoAnterior.Any())
            {
                DataTable dtResult = saldoAnterior.CopyToDataTable();
                lblSaldoAnterior.Text = dtResult.Rows[0][0].ToString();
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            try
            {
                if (txtValor.Text == string.Empty)
                {
                    lblSuc.Visible = false;
                    msgError("Alguns campos obrigatórios não foram preenchidos!");
                }
                else
                {
                    decimal saldoInicial;
                    decimal saldoFinal;
                    if (lblSaldoFinal.Text == "0" && cbTipoEntrada.Text == "Vendas - dinheiro")
                    {
                        saldoInicial = Convert.ToDecimal(lblSaldoAnterior.Text);
                        saldoFinal = Convert.ToDecimal(lblSaldoAnterior.Text) + Convert.ToDecimal(txtValor.Text);
                        rpta = DoCadastros.SaldoInicial_Cadastro(saldoInicial, saldoFinal, DateTime.Parse(dateEntrada.Value.ToString()));
                    }
                    else if (lblSaldoFinal.Text == "0" && cbTipoEntrada.Text != "Vendas - dinheiro")
                    {
                        saldoInicial = Convert.ToDecimal(lblSaldoAnterior.Text);
                        saldoFinal = Convert.ToDecimal(lblSaldoAnterior.Text);
                        rpta = DoCadastros.SaldoInicial_Cadastro(saldoInicial, saldoFinal, DateTime.Parse(dateEntrada.Value.ToString()));
                    }
                    rpta = DoEntrada.CadastroEntrada(
                        dateEntrada.Value,
                        decimal.Parse(txtValor.Text),
                        txtObservacao.Text,
                        Convert.ToInt32(cbTipoEntrada.SelectedValue),
                        Convert.ToInt32(cbPagamento.SelectedValue)
                        );
                }
                if (rpta.Equals("OK") && lblSaldoFinal.Text != "0")
                {
                    msgSuccess("Cadastro realizado com sucesso!");
                    UpdateSaldo();
                }
                else if (rpta.Equals("OK") && lblSaldoFinal.Text == "0")
                {
                    msgSuccess("Cadastrei um novo saldo final");
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
            //DesabilitarEdição();
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

        private void dgvEntradas_Click(object sender, EventArgs e)
        {

        }

        private void dateEntrada_onValueChanged(object sender, EventArgs e)
        {
            DateTime data = Convert.ToDateTime(dateEntrada.Value.ToString());
            DataTable dt = new DataTable();
            dt = DoDiarioDeCaixa.DiarioCaixa_SaldoFinal();
            var saldoFinal = dt.AsEnumerable().Where(x => x.Field<string>("Data") == data.ToShortDateString()).
                Select(k =>
                {
                    var row = dt.NewRow();
                    row.ItemArray = new object[]
                    {
                        k.Field<decimal>("saldo_final")
                    };
                    return row;
                });
            if (saldoFinal.Any())
            {
                DataTable dtResult = saldoFinal.CopyToDataTable();
                lblSaldoFinal.Text = dtResult.Rows[0][0].ToString();
            }
            else
            {
                lblSaldoFinal.Text = "0";
            }
            if (lblSaldoFinal.Text == "0")
            {
                SaldoAnterior();
            }

        }
    }
}
