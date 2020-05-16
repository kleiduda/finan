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
    public partial class FormPlanoDeContas : Form
    {
        private bool IsNew = true;
        public FormPlanoDeContas()
        {
            InitializeComponent();
        }
        private void FormPlanoDeContas_Load(object sender, EventArgs e)
        {

        }
        public void ResultadoMes()
        {
            DataTable dt = new DataTable();
            dt = DoDiarioDeCaixa.DiarioDeCaixa_Resultado();
            //
        }
        
        private void calendario_DayClick(object sender, Pabo.Calendar.DayClickEventArgs e)
        {
            //removendo os controles entrada
            foreach (Control item in painelEntradas.Controls.OfType<Panel>())
            {
                painelEntradas.Controls.Clear();
            }
            foreach (Control item in pTotal.Controls.OfType<Label>())
            {
                pTotal.Controls.Clear();
            }
            //
            //removendo os controles saida
            foreach (Control item in painelSaidas.Controls.OfType<Panel>())
            {
                painelSaidas.Controls.Clear();
            }
            foreach (Control item in pTotal.Controls.OfType<Label>())
            {
                pTotal.Controls.Clear();
            }
            //
            DateTime datetime;
            datetime = DateTime.Parse(e.Date);
            DataTable dtResultado = new DataTable();
            dtResultado = DoDiarioDeCaixa.DiarioDeCaixa_Resultado();
            decimal valorTotal = 0;
            if (dtResultado != null)
            {
                //var jc8x = dt.AsEnumerable().Where(x => x.Field<string>("Data") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("Valor"));

                //var dinheiro = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 1).Where(x => x.Field<string>("data_fechamento") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
                var dt = dtResultado.AsEnumerable().Where(x=>x.Field<string>("Data") == datetime.ToShortDateString()).
                    Select(k=>
                    {
                        var row = dtResultado.NewRow();
                        row.ItemArray = new object[]
                        {
                            k.Field<string>("descricao"),
                            k.Field<decimal>("Valor")
                        };
                        return row;
                    }
                    );
                if (dt.Any())
                {
                    DataTable dtNew = dt.CopyToDataTable();
                    for (int i = 0; i < dtNew.Rows.Count; i++)
                    {
                        #region entradas
                        Panel p = new Panel();
                        p.Name = "painelDinamico";
                        p.Width = 246;
                        p.Height = 51;
                        p.BorderStyle = BorderStyle.FixedSingle;
                        p.Left = 3;
                        p.Top = i * 54;
                        p.BackColor = Color.WhiteSmoke;
                        painelEntradas.Controls.Add(p);
                        Label descricao = new Label();
                        descricao.AutoSize = true;
                        descricao.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Regular);
                        descricao.ForeColor = Color.Black;
                        descricao.Text = dtNew.Rows[i][0].ToString() + ": " + dtNew.Rows[i][1].ToString();
                        descricao.Left = 3;
                        descricao.Top = 15;
                        p.Controls.Add(descricao);
                        //total de entradas
                        Label tEntrada = new Label();
                        tEntrada.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Bold);
                        tEntrada.ForeColor = Color.Gray;
                        tEntrada.Left = 7;
                        tEntrada.Top = 10;
                        tEntrada.Text = "Total Entradas";
                        tEntrada.AutoSize = true;
                        pTotal.Controls.Add(tEntrada);
                        Label TotalEntrada = new Label();
                        TotalEntrada.Name = "valorEntrada";
                        TotalEntrada.Font = new Font("Micrsoft Sans Serif", 14, FontStyle.Regular);
                        TotalEntrada.ForeColor = Color.Gray;
                        TotalEntrada.AutoSize = true;
                        var total = dtResultado.AsEnumerable().Where(x => x.Field<string>("Data") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("Valor"));
                        TotalEntrada.Text = total.ToString("C");
                        TotalEntrada.Top = 22;
                        TotalEntrada.Left = 7;
                        pTotal.Controls.Add(TotalEntrada);
                        //entrada em dinheiro
                        Label tDinheiro = new Label();
                        tDinheiro.Font = new Font("Microsoft Sans Serif", 6, FontStyle.Bold);
                        tDinheiro.ForeColor = Color.Gray;
                        tDinheiro.Left = 170;
                        tDinheiro.Top = 10;
                        tDinheiro.Text = "Total Dinheiro";
                        tDinheiro.AutoSize = true;
                        pTotal.Controls.Add(tDinheiro);
                        Label TotalEntradaDinheiro = new Label();
                        TotalEntradaDinheiro.Name = "dinheiro";
                        TotalEntradaDinheiro.Font = new Font("Micrsoft Sans Serif", 12, FontStyle.Regular);
                        TotalEntradaDinheiro.ForeColor = Color.Gray;
                        TotalEntradaDinheiro.AutoSize = true;
                        var totalDinheiro = dtResultado.AsEnumerable().Where(x => x.Field<string>("Data") == datetime.ToShortDateString()).Where(x=>x.Field<int>("Dinheiro")== 1).Sum(x=>x.Field<decimal>("Valor"));
                        TotalEntradaDinheiro.Text = totalDinheiro.ToString("C");
                        TotalEntradaDinheiro.Top = 22;
                        TotalEntradaDinheiro.Left = 170;
                        pTotal.Controls.Add(TotalEntradaDinheiro);
                        #endregion entradas
                        
                    }

                }
            }
            DataTable dtSaidas = new DataTable();
            dtSaidas = DoDiarioDeCaixa.DiarioDeCaixaResultadoSaida();
            if (dtSaidas != null)
            {
                //var jc8x = dt.AsEnumerable().Where(x => x.Field<string>("Data") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("Valor"));

                //var dinheiro = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 1).Where(x => x.Field<string>("data_fechamento") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
                var dt = dtSaidas.AsEnumerable().Where(x => x.Field<string>("Data") == datetime.ToShortDateString()).
                    Select(k =>
                    {
                        var row = dtSaidas.NewRow();
                        row.ItemArray = new object[]
                        {
                            k.Field<string>("descricao"),
                            k.Field<decimal>("Valor")
                        };
                        return row;
                    }
                    );
                if (dt.Any())
                {
                    DataTable dtNew = dt.CopyToDataTable();
                    for (int i = 0; i < dtNew.Rows.Count; i++)
                    {
                        #region saidas
                        Panel s = new Panel();
                        s.Name = "painelDinamico";
                        s.Width = 246;
                        s.Height = 51;
                        s.BorderStyle = BorderStyle.FixedSingle;
                        s.Left = 3;
                        s.Top = i * 54;
                        s.BackColor = Color.WhiteSmoke;
                        painelSaidas.Controls.Add(s);
                        Label tituloS = new Label();
                        tituloS.AutoSize = true;
                        tituloS.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Regular);
                        tituloS.ForeColor = Color.Black;
                        tituloS.Text = dtNew.Rows[i][0].ToString() + ": " + dtNew.Rows[i][1].ToString();
                        tituloS.Left = 3;
                        tituloS.Top = 15;
                        s.Controls.Add(tituloS);
                        //total de entradas
                        Label tSaida = new Label();
                        tSaida.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Bold);
                        tSaida.ForeColor = Color.Gray;
                        tSaida.Left = 358;
                        tSaida.Top = 10;
                        tSaida.Text = "Total Saídas";
                        tSaida.AutoSize = true;
                        pTotal.Controls.Add(tSaida);
                        Label TotalSaida = new Label();
                        TotalSaida.Name = "valorSaida";
                        TotalSaida.Font = new Font("Micrsoft Sans Serif", 14, FontStyle.Regular);
                        TotalSaida.ForeColor = Color.Gray;
                        TotalSaida.AutoSize = true;
                        var totalSaida = dtSaidas.AsEnumerable().Where(x => x.Field<string>("Data") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("Valor"));
                        TotalSaida.Text = totalSaida.ToString("C");
                        TotalSaida.Top = 22;
                        TotalSaida.Left = 358;
                        pTotal.Controls.Add(TotalSaida);
                        //entrada em dinheiro
                        Label sDinheiro = new Label();
                        sDinheiro.Font = new Font("Microsoft Sans Serif", 6, FontStyle.Bold);
                        sDinheiro.ForeColor = Color.Gray;
                        sDinheiro.Left = 535;
                        sDinheiro.Top = 10;
                        sDinheiro.Text = "Total Dinheiro";
                        sDinheiro.AutoSize = true;
                        pTotal.Controls.Add(sDinheiro);
                        Label TotalSaidaDinheiro = new Label();
                        TotalSaidaDinheiro.Name = "dinheiro";
                        TotalSaidaDinheiro.Font = new Font("Micrsoft Sans Serif", 12, FontStyle.Regular);
                        TotalSaidaDinheiro.ForeColor = Color.Gray;
                        TotalSaidaDinheiro.AutoSize = true;
                        var totalSDinheiro = dtSaidas.AsEnumerable().Where(x => x.Field<string>("Data") == datetime.ToShortDateString()).Where(x => x.Field<int>("Dinheiro") == 1).Sum(x => x.Field<decimal>("Valor"));
                        TotalSaidaDinheiro.Text = totalSDinheiro.ToString("C");
                        TotalSaidaDinheiro.Top = 22;
                        TotalSaidaDinheiro.Left = 535;
                        pTotal.Controls.Add(TotalSaidaDinheiro);
                        #endregion saidas
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void calendario_MonthChanged(object sender, Pabo.Calendar.MonthChangedEventArgs e)
        {
            DateTime mes = new DateTime();

        }
    }
}
