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
            pMenuDiarioC.Height = 36;
            pPlanoContas.Height = 36;
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
            AbrirFormulario<ListaTipoEntrada>();
            pLogo.Hide();
        }
        private void btnTiposSaida_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ListaTipoSaida>();
            pLogo.Hide();
        }

        private void btnFormasPagto_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ListaPagamento>();
            pLogo.Hide();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormListaEntradaDC>();
            pLogo.Hide();
        }

        private void btnCentroCusto_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ListaCentroCusto>();
            pLogo.Hide();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ListaCategoria>();
            pLogo.Hide();
        }
        private void btnSaida_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormListaSaidaDC>();
            pLogo.Hide();
        }
        private void btnDiarioCaixa_Click(object sender, EventArgs e)
        {
            if (pMenuDiarioC.Height == 36)
            {
                pMenuDiarioC.Height = 144;
            }
            else
            {
                pMenuDiarioC.Height = 36;
            }
            
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormEmpresa>();
        }

        private void btnPContas_Click(object sender, EventArgs e)
        {
            if (pPlanoContas.Height == 36)
            {
                pPlanoContas.Height = 144;
            }
            else
            {
                pPlanoContas.Height = 36;
            }
        }

        private void btnEntradaP_Click(object sender, EventArgs e)
        {
            pLogo.Hide();
            AbrirFormulario<FormListaP>();
        }

        private void btnSaidaP_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConsolidadoDC_Click(object sender, EventArgs e)
        {
            pLogo.Hide();
            AbrirFormulario<FormDiarioCaixa>();
        }

        private void btnSaldoInicial_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormSaldoInicial>();
        }

        private void btnConsolidadoPC_Click(object sender, EventArgs e)
        {
            pLogo.Hide();
            AbrirFormulario<FormPlanoConsolidado>();
        }
    }
}
