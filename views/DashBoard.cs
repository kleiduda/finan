using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace views
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
        public void AbrirFormulario<MyForm>() where MyForm : Form, new()
        {
            Form frm;
            frm = pConteudo.Controls.OfType<MyForm>().FirstOrDefault();
            if (frm == null)
            {
                frm = new MyForm();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                pConteudo.Controls.Add(frm);
                pConteudo.Tag = frm;
                frm.Show();
                frm.BringToFront();
            }
            else
            {
                frm.BringToFront();
            }
        }
        private void btnTiposEntrada_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormTipoEntrada>();
        }
        private void btnTiposSaida_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormTipoSaida>();
        }

        private void btnFormasPagto_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormPagamento>();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormEntradas>();
        }

        private void btnCentroCusto_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormCentroCusto>();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormCategorias>();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormSaidas>();
        }

        private void btnDiarioCaixa_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormDiarioCaixa>();
        }
    }
}
