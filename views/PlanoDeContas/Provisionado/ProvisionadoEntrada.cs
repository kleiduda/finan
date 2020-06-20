using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
    public partial class ProvisionadoEntrada : Form
    {
        private bool IsNew = true;
        public ProvisionadoEntrada()
        {
            InitializeComponent();
        }
        public ProvisionadoEntrada(string value, string value2)
        {
            InitializeComponent();
            lblID.Text = value;
            lblUltimoIdCadastrado.Text = value2;
        }
        private void ProvisionadoEntrada_Load(object sender, EventArgs e)
        {
            if (lblID.Text != "novo")
            {
                IsNew = false;
                Edit();
            }
            TabIndex();
            ListSubCategoria();
            ListEmpresa();
            Listpagamento();
            ListTipoRecorrencia();

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
        private void ListTipoRecorrencia()
        {
            cbRecorrencia.DataSource = DoCadastros.RecorrenciaTipo_Lista();
            cbRecorrencia.ValueMember = "id";
            cbRecorrencia.DisplayMember = "tipo_recorrencia";
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

        public void Edit()
        {
            DataTable dt = new DataTable();
            dt = DoCadastros.Recorrencia_ListaPorID(int.Parse(lblID.Text));
            dateEntrada.Value = Convert.ToDateTime(dt.Rows[0]["data_inicio"].ToString());
            txtDescricao.Text = dt.Rows[0]["descricao"].ToString();
            txtValor.Text = dt.Rows[0]["valor"].ToString();
            cbRecorrencia.Text = dt.Rows[0]["tipo_recorrencia"].ToString();
            txtParcelas.Text = dt.Rows[0]["parcelas"].ToString();
            cbPagamento.Text = dt.Rows[0]["forma_pagamento"].ToString();
            cbSubCategoria.Text = dt.Rows[0]["sub_categoria"].ToString();
            cbEmpresa.Text = dt.Rows[0]["empresa"].ToString();
        }

        public void TabIndex()
        {
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
            dateEntrada.ResetText();
            cbEmpresa.ResetText();
            cbPagamento.ResetText();
            cbSubCategoria.ResetText();

        }
        public void DesabilitarEdição()
        {
            txtValor.Enabled = false;
            txtObservacao.Enabled = false;
            txtDescricao.Enabled = false;
            dateEntrada.Enabled = false;
            cbEmpresa.Enabled = false;
            cbPagamento.Enabled = false;
            cbSubCategoria.Enabled = false;
        }
        public void EnabledEdit()
        {
            txtValor.Enabled = true;
            txtObservacao.Enabled = true;
            txtDescricao.Enabled = true;
            dateEntrada.Enabled = true;
            cbEmpresa.Enabled = true;
            cbPagamento.Enabled = true;
            cbSubCategoria.Enabled = true;
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
        public void CadastroParcelas()
        {
            string rpta = "";
            try
            {
                DateTime data;
                for (int i = 0; i < int.Parse(txtParcelas.Text); i++)
                {
                    data = Convert.ToDateTime(dateEntrada.Value.AddMonths(i).ToString());
                    rpta = DoCadastros.Parcela_Cadastro(
                          data,
                          txtDescricao.Text,
                          i.ToString(),
                          Convert.ToInt32(Support.Enum.PagtoRec.Pendente),
                          Convert.ToInt32(lblUltimoIdCadastrado.Text)
                          );
                }
            }
            catch (Exception ex)
            {

            }

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            string parcela = "";
            try
            {
                if (string.IsNullOrEmpty(txtValor.Text))
                {
                    MessageBox.Show("Campo valor não pode estar vazio!");
                }
                else if (IsNew == true)
                {
                    rpta = DoCadastros.Recorrencia_Cadastro
                    (
                        dateEntrada.Value,
                        txtDescricao.Text,
                        Convert.ToDecimal(txtValor.Text),
                        Convert.ToInt32(cbRecorrencia.SelectedValue),
                        Convert.ToInt32(txtParcelas.Text),
                        Convert.ToInt32(cbPagamento.SelectedValue),
                        Convert.ToInt32(cbSubCategoria.SelectedValue),
                        Convert.ToInt32(cbEmpresa.SelectedValue),
                        Convert.ToInt32(Support.Enum.PagtoRec.Pendente)
                    );
                    
                }
                else if (IsNew == false)
                {
                    rpta = DoCadastros.Recorrencia_Update
                        (
                        Convert.ToInt32(lblID.Text),
                        txtDescricao.Text,
                        Convert.ToDecimal(txtValor.Text),
                        Convert.ToInt32(cbRecorrencia.SelectedValue),
                        Convert.ToInt32(txtParcelas.Text),
                        Convert.ToInt32(cbPagamento.SelectedValue),
                        Convert.ToInt32(cbSubCategoria.SelectedValue),
                        Convert.ToInt32(cbEmpresa.SelectedValue)
                        );
                }
                if (rpta.Equals("OK") && IsNew == true)
                {
                    DateTime data;
                    var ultimoId = Convert.ToInt32(lblUltimoIdCadastrado.Text) + 1;
                    for (int i = 0; i < int.Parse(txtParcelas.Text); i++)
                    {
                        data = Convert.ToDateTime(dateEntrada.Value.AddMonths(i).ToString());
                        parcela = DoCadastros.Parcela_Cadastro(
                              data,
                              txtDescricao.Text,
                              i.ToString(),
                              Convert.ToInt32(Support.Enum.PagtoRec.Pendente),
                              ultimoId
                              );
                    }
                    if (parcela.Equals("OK"))
                    {
                        msgSuccess("Cadastro Realizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show(parcela);
                    }
                    //msgSuccess("Cadastro REALIZADO com sucesso!");
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

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(txtParcelas.Text); i++)
            {
                MessageBox.Show(dateEntrada.Value.AddMonths(i).ToString());
            }
        }
    }
}
