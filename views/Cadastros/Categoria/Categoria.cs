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
    public partial class Categoria : Form
    {
        private bool IsNew = true;
        public Categoria()
        {
            InitializeComponent();
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            ListCentroCusto();
            ListCategoria();
            ListSubCategoria();
            if (lblID.Text != "novo")
            {
                IsNew = false;
                Edit();
            }
           
        }
        public Categoria(string value)
        {
            InitializeComponent();
            lblID.Text = value;
        }
        
        public void Edit()
        {
            DataTable dt = new DataTable();
            dt = DoCadastros.Categoria_ListaPorID(int.Parse(lblID.Text));
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
        public void ListCentroCusto()
        {
            cbCentroCusto.DataSource = DoCadastros.CentroCusto_Lista();
            cbCentroCusto.ValueMember = "id";
            cbCentroCusto.DisplayMember = "descricao";
        }
        public void ListCategoria()
        {
            cbCategoria.DataSource = DoCadastros.Categoria_Lista2();
            cbCategoria.ValueMember = "id";
            cbCategoria.DisplayMember = "descricao";
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
            string rpta = "";
            try
            {
                rpta = DoCadastros.Categoria_Agrupamento(cbCategoria.Text, Convert.ToInt32(cbCentroCusto.SelectedValue), Convert.ToInt32(cbCategoria.SelectedValue), cbSubCategoria.Text);
                if (rpta.Equals("OK"))
                {
                    msgSuccess("Cadastro realizado com sucesso!");
                }
                else
                {
                    msgError("Erro no cadastro");
                }
            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            lblSuc.Visible = false;
            lblError.Visible = false;
        }

        private void btnSaveCC_Click(object sender, EventArgs e)
        {
            string rpta = "";
            try
            {
                if (string.IsNullOrEmpty(txtCentroCusto.Text))
                {
                    txtCentroCusto.BackColor = Color.Red;
                }
                else
                {
                    rpta = DoCadastros.CentroCusto_Cadastro(txtCentroCusto.Text);
                }
                if (rpta.Equals("OK"))
                {
                    txtCentroCusto.Clear();
                    pCentroCusto.Visible = false;
                    ListCentroCusto();
                }
                else
                {
                    MessageBox.Show(rpta);
                }
            }
            catch (Exception ex)
            {
                rpta = ex.Message + ex.StackTrace;
            }
        }

        private void btnSaveCategoria_Click(object sender, EventArgs e)
        {
            string rpta = "";
            try
            {
                if (string.IsNullOrEmpty(txtCategoria.Text))
                {
                    txtCategoria.BackColor = Color.Red;
                }
                else
                {
                    rpta = DoCadastros.Categoria_Cadastro(txtCategoria.Text);
                }
                if (rpta.Equals("OK"))
                {
                    txtCategoria.Clear();
                    pCategoria.Visible = false;
                    ListCategoria();
                }
                else
                {
                    MessageBox.Show(rpta);
                }
            }
            catch (Exception ex)
            {
                rpta = ex.Message + ex.StackTrace;
            }
        }

        private void btnSaveSubCategoria_Click(object sender, EventArgs e)
        {
            string rpta = "";
            try
            {
                if (string.IsNullOrEmpty(txtSubCategoria.Text))
                {
                    txtSubCategoria.BackColor = Color.Red;
                }
                else
                {
                    rpta = DoCadastros.SubCategoria_Cadastro(txtSubCategoria.Text);
                }
                if (rpta.Equals("OK"))
                {
                    txtSubCategoria.Clear();
                    pSubCategoria.Visible = false;
                    ListSubCategoria();
                }
                else
                {
                    MessageBox.Show(rpta);
                }
            }
            catch (Exception ex)
            {
                rpta = ex.Message + ex.StackTrace;
            }
        }
    }

}
