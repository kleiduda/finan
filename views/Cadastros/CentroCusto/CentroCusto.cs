﻿using System;
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
    public partial class CentroCusto : Form
    {
        private bool IsNew = true;
        public CentroCusto()
        {
            InitializeComponent();
        }

        private void CentroCusto_Load(object sender, EventArgs e)
        {
            if (lblID.Text != "novo")
            {
                IsNew = false;
                Edit();
            }
           
        }
        public CentroCusto(string value)
        {
            InitializeComponent();
            lblID.Text = value;
        }
        
        public void Edit()
        {
            DataTable dt = new DataTable();
            dt = DoCadastros.CentroCusto_ListaPorID(int.Parse(lblID.Text));
            txtCadastro.Text = dt.Rows[0]["descricao"].ToString();
        }
        private void LimparCampos()
        {
            txtCadastro.Clear();
            

        }
        public void DesabilitarEdição()
        {
            txtCadastro.Enabled = false;
        }
        public void EnabledEdit()
        {
            txtCadastro.Enabled = true;
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
                    if (DoCadastros.CentroCusto_Valida(txtCadastro.Text))
                    {
                        lblSuc.Visible = false;
                        lblError.Visible = true;
                        msgError("Já existe um tipo de Entrada com descrição: " + txtCadastro.Text.Trim().ToUpper());
                    }
                    else if (IsNew == true)
                    {
                        
                        rpta = DoCadastros.CentroCusto_Cadastro(txtCadastro.Text.Trim().ToUpper());
                    } else if (IsNew == false)
                    {
                        DoCadastros.CentroCusto_Update(int.Parse(lblID.Text), txtCadastro.Text);
                    }
                    if (rpta.Equals("OK") && IsNew == true)
                    {
                        lblError.Visible = false;
                        msgSuccess("Tipo de Entrada " + txtCadastro.Text.Trim().ToUpper() + ", cadastrado com sucesso!");
                    }
                    else
                    {
                        msgSuccess("Tipo de Entrada " + txtCadastro.Text.Trim().ToUpper() + ", atualizado com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                msgError(ex.Message + ex.StackTrace);
            }
            txtCadastro.Clear();
            txtCadastro.Focus();
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            txtCadastro.Clear();
            btnNovoCadastro.Enabled = false;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
            lblSuc.Visible = false;
            lblError.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtCadastro.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCadastro.Enabled = false;
            btnNovoCadastro.Enabled = true;

        }

        
    }
}
