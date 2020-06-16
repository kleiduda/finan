using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace views
{
    public partial class FormPlanoConsolidado : Form
    {
        public FormPlanoConsolidado()
        {
            InitializeComponent();
        }
        private void FormDiarioCaixa_Load(object sender, EventArgs e)
        {
            

        }
        private void calendario_DayClick(object sender, Pabo.Calendar.DayClickEventArgs e)
        {
            

           
        }

        private void calendario_MonthChanged(object sender, Pabo.Calendar.MonthChangedEventArgs e)
        {
            //removendo os controles entrada
            foreach (Control item in painelEntradas.Controls.OfType<Panel>())
            {
                painelEntradas.Controls.Clear();
            }
            switch (e.Month)
            {
                case 1:
                    lblMes.Text = "JANEIRO" + " / " + e.Year.ToString();
                    break;
                case 2:
                    lblMes.Text = "FEVEREIRO" + " / " + e.Year.ToString();
                    break;
                case 3:
                    lblMes.Text = "MARÇO" + " / " + e.Year.ToString();
                    break;
                case 4:
                    lblMes.Text = "ABRIL" + " / " + e.Year.ToString();
                    break;
                case 5:
                    lblMes.Text = "MAIO" + " / " + e.Year.ToString();
                    break;
                case 6:
                    lblMes.Text = "JUNHO" + " / " + e.Year.ToString();
                    break;
                case 7:
                    lblMes.Text = "JULHO" + " / " + e.Year.ToString();
                    break;
                case 8:
                    lblMes.Text = "AGOSTO" + " / " + e.Year.ToString();
                    break;
                case 9:
                    lblMes.Text = "SETEMBRO" + " / " + e.Year.ToString();
                    break;
                case 10:
                    lblMes.Text = "OUTUBRO" + " / " + e.Year.ToString();
                    break;
                case 11:
                    lblMes.Text = "NOVEMBRO" + " / " + e.Year.ToString();
                    break;
                case 12:
                    lblMes.Text = "DEZEMBRO" + " / " + e.Year.ToString();
                    break;
                default:
                    break;
            }
            DataTable dt = new DataTable();
            dt = DoCadastros.PlanoContas_Consolidado();
            var planoContas = dt.AsEnumerable().Where(x => x.Field<int>("Mes") == e.Month).Select(k =>
            {

                var row = dt.NewRow();
                row.ItemArray = new object[]
                {
                    k.Field<string>("descricao"),
                    k.Field<decimal>("Valor")
                };
                return row;
            });
            if (planoContas.Any())
            {
                DataTable dtResult = planoContas.CopyToDataTable();
                for (int i = 0; i < dtResult.Rows.Count; i++)
                {
                    Panel pResult = new Panel();
                    pResult.Name = "painelDinamico";
                    pResult.Width = 246;
                    pResult.Height = 51;
                    pResult.BorderStyle = BorderStyle.FixedSingle;
                    pResult.Left = 3;
                    pResult.Top = i * 54;
                    pResult.BackColor = Color.WhiteSmoke;
                    painelEntradas.Controls.Add(pResult);
                    Label descricao = new Label();
                    descricao.AutoSize = true;
                    descricao.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Regular);
                    descricao.ForeColor = Color.Black;
                    decimal valor = Convert.ToDecimal(dtResult.Rows[i][1].ToString());
                    descricao.Text = dtResult.Rows[i][0].ToString() + ": " + valor.ToString("C");
                    descricao.Left = 3;
                    descricao.Top = 15;
                    pResult.Controls.Add(descricao);
                }

            }
        }
    }
}


