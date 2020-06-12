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
        private bool IsNew = true;
        private decimal totalEntradaDinheiro = 0;
        private decimal totalSaidaDinheiro = 0;
        private decimal troco = 0;
        private decimal openingBalance = 0;
        private decimal saldo = 0;
        public FormPlanoConsolidado()
        {
            InitializeComponent();
        }
        private void FormDiarioCaixa_Load(object sender, EventArgs e)
        {
            #region Teste
            //inserindo o valor de troco ao dia seguinte
            //var observable = Observable.Interval(TimeSpan.FromSeconds(5));
            //observable.Subscribe((x) =>
            //{
            //    DataTable dt = new DataTable();
            //    dt = DoCadastros.SaldoInicial_Lista();
            //    var dtSaldo = dt.AsEnumerable().Where(y => y.Field<DateTime>("data_entrada") == DateTime.Now.AddDays(-1)).Select(k =>
            //        {
            //            var row = dt.NewRow();
            //            row.ItemArray = new object[]
            //            {
            //                k.Field<decimal>("valor")
            //            };
            //            return row;
            //        });
            //    if (dtSaldo.Any())
            //    {
            //        DataTable newDt = new DataTable();
            //        newDt = dtSaldo.CopyToDataTable();
            //        var saldoIni = newDt.Rows[0][0].ToString();
            //        DoCadastros.SaldoInicial_Cadastro(decimal.Parse(saldoIni), DateTime.Now);
            //    }
            //});
            #endregion

        }
        private void calendario_DayClick(object sender, Pabo.Calendar.DayClickEventArgs e)
        {
            //removendo os controles entrada
            foreach (Control item in painelEntradas.Controls.OfType<Panel>())
            {
                painelEntradas.Controls.Clear();
            }
            foreach (Control item in pTotais.Controls.OfType<Panel>())
            {
                pTotais.Controls.Clear();
            }
            //
            //removendo os controles saida
            foreach (Control item in painelSaidas.Controls.OfType<Panel>())
            {
                painelSaidas.Controls.Clear();
            }
            foreach (Control item in pTotais.Controls.OfType<Panel>())
            {
                pTotais.Controls.Clear();
            }
            //
            DateTime datetime;
            datetime = DateTime.Parse(e.Date);
            #region entradas
            DataTable dtResultado = new DataTable();
            dtResultado = DoCadastros.PlanoContas_Consolidado();
            decimal valorTotal = 0;
            if (dtResultado != null)
            {
                //var jc8x = dt.AsEnumerable().Where(x => x.Field<string>("Data") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("Valor"));
                //var dinheiro = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 1).Where(x => x.Field<string>("data_fechamento") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
                var dt = dtResultado.AsEnumerable().Where(x => x.Field<string>("Data") == datetime.ToShortDateString()).
                    Select(k =>
                    {
                        var row = dtResultado.NewRow();
                        row.ItemArray = new object[]
                        {
                            k.Field<string>("descricao"),
                            k.Field<decimal>("Valor"),
                            k.Field<string>("Data"),
                            k.Field<int>("Mes")
                        };
                        return row;
                    }
                    );
                if (dt.Any())
                {
                    DataTable dtNew = dt.CopyToDataTable();
                    for (int i = 0; i < dtNew.Rows.Count; i++)
                    {
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
                        //descricao + valor diario
                        descricao.Text = dtNew.Rows[i][0].ToString() + ": " + dtNew.Rows[i][1].ToString();
                        descricao.Left = 3;
                        descricao.Top = 15;
                        p.Controls.Add(descricao);
                    }
                }
            }
            #endregion entradas
            #region saidas
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
                            k.Field<int>("Dinheiro"),
                            k.Field<decimal>("Valor"),
                            k.Field<int>("Mes")
                        };
                        return row;
                    }
                    );
                if (dt.Any())
                {
                    DataTable dtNew = dt.CopyToDataTable();
                    for (int i = 0; i < dtNew.Rows.Count; i++)
                    {

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
                        tituloS.Text = dtNew.Rows[i][0].ToString() + ": " + dtNew.Rows[i][2].ToString();
                        tituloS.Left = 3;
                        tituloS.Top = 15;
                        s.Controls.Add(tituloS);
                        //total de Saidas
                        Panel pTotalSaida = new Panel();
                        pTotalSaida.Width = 294;
                        pTotalSaida.Height = 65;
                        pTotalSaida.BackColor = Color.Red;
                        pTotalSaida.Top = 74;
                        pTotalSaida.Left = 9;
                        pTotais.Controls.Add(pTotalSaida);
                        //
                        Label tSaida = new Label();
                        tSaida.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Bold);
                        tSaida.ForeColor = Color.White;
                        tSaida.Left = 7;
                        tSaida.Top = 10;
                        tSaida.Text = "Total Saídas";
                        tSaida.AutoSize = true;
                        pTotalSaida.Controls.Add(tSaida);
                        Label TotalSaida = new Label();
                        TotalSaida.Name = "valorSaida";
                        TotalSaida.Font = new Font("Micrsoft Sans Serif", 14, FontStyle.Regular);
                        TotalSaida.ForeColor = Color.White;
                        TotalSaida.AutoSize = true;
                        var totalSaida = dtSaidas.AsEnumerable().Where(x => x.Field<string>("Data") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("Valor"));
                        TotalSaida.Text = totalSaida.ToString("C");
                        TotalSaida.Top = 22;
                        TotalSaida.Left = 7;
                        pTotalSaida.Controls.Add(TotalSaida);
                        //saida em dinheiro
                        Label sDinheiro = new Label();
                        sDinheiro.Font = new Font("Microsoft Sans Serif", 6, FontStyle.Bold);
                        sDinheiro.ForeColor = Color.White;
                        sDinheiro.Left = 170;
                        sDinheiro.Top = 10;
                        sDinheiro.Text = "Total Dinheiro";
                        sDinheiro.AutoSize = true;
                        pTotalSaida.Controls.Add(sDinheiro);
                        Label TotalSaidaDinheiro = new Label();
                        TotalSaidaDinheiro.Name = "dinheiro";
                        TotalSaidaDinheiro.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
                        TotalSaidaDinheiro.ForeColor = Color.White;
                        TotalSaidaDinheiro.AutoSize = true;
                        totalSaidaDinheiro = dtSaidas.AsEnumerable().Where(x => x.Field<string>("Data") == datetime.ToShortDateString()).Where(x => x.Field<int>("Dinheiro") == 1).Sum(x => x.Field<decimal>("Valor"));
                        TotalSaidaDinheiro.Text = totalSaidaDinheiro.ToString("C");
                        TotalSaidaDinheiro.Top = 22;
                        TotalSaidaDinheiro.Left = 170;
                        var valorMensalSaida = dtSaidas.AsEnumerable().Where(x => x.Field<int>("Mes") == datetime.Month).Sum(x => x.Field<decimal>("Valor"));
                        totalMesSaida.Text = valorMensalSaida.ToString("C");
                        pTotalSaida.Controls.Add(TotalSaidaDinheiro);
                    }
                }
            }
            #endregion saidas



        }

        private void calendario_MonthChanged(object sender, Pabo.Calendar.MonthChangedEventArgs e)
        {
            //removendo os controles entrada
            foreach (Control item in painelEntradas.Controls.OfType<Panel>())
            {
                painelEntradas.Controls.Clear();
            }
            foreach (Control item in pTotais.Controls.OfType<Panel>())
            {
                pTotais.Controls.Clear();
            }
            //
            //removendo os controles saida
            foreach (Control item in painelSaidas.Controls.OfType<Panel>())
            {
                painelSaidas.Controls.Clear();
            }
            foreach (Control item in pTotais.Controls.OfType<Panel>())
            {
                pTotais.Controls.Clear();
            }
            //
            //DateTime datetime;
            //datetime = DateTime.Parse(e.Month.ToString());
            
            DataTable dtResultado = new DataTable();
            dtResultado = DoCadastros.PlanoContas_Consolidado();
            decimal valorTotal = 0;
            if (dtResultado != null)
            {
                //var jc8x = dt.AsEnumerable().Where(x => x.Field<string>("Data") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("Valor"));
                //var dinheiro = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 1).Where(x => x.Field<string>("data_fechamento") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
                var dt = dtResultado.AsEnumerable().Where(x => x.Field<int>("Mes") == Convert.ToInt32(e.Month.ToString())).
                    Select(k =>
                    {
                        var row = dtResultado.NewRow();
                        row.ItemArray = new object[]
                        {
                            k.Field<string>("descricao"),
                            k.Field<decimal>("Valor"),
                            k.Field<string>("Data"),
                            k.Field<int>("Mes")
                        };
                        return row;
                    }
                    );
                if (dt.Any())
                {
                    DataTable dtNew = dt.CopyToDataTable();
                    for (int i = 0; i < dtNew.Rows.Count; i++)
                    {
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
                        //descricao + valor diario
                        descricao.Text = dtNew.Rows[i][0].ToString() + ": " + dtNew.Rows[i][1].ToString();
                        descricao.Left = 3;
                        descricao.Top = 15;
                        p.Controls.Add(descricao);
                    }
                }
            }
        }
    }
}


