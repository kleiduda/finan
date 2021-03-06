﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reactive.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace views
{
    public partial class FormDiarioCaixa : Form
    {
        private bool IsNew = true;
        private decimal totalEntradaDinheiro = 0;
        private decimal totalSaidaDinheiro = 0;
        private decimal troco = 0;
        private decimal openingBalance = 0;
        private decimal saldo = 0;
        public FormDiarioCaixa()
        {
            InitializeComponent();
        }
        private void FormDiarioCaixa_Load(object sender, EventArgs e)
        {
            lblMes.Text = "";
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
            dtResultado = DoDiarioDeCaixa.DiarioDeCaixa_ResultadoEntrada();
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
                        descricao.Text = dtNew.Rows[i][0].ToString() + ": " + dtNew.Rows[i][2].ToString();
                        descricao.Left = 3;
                        descricao.Top = 15;
                        p.Controls.Add(descricao);
                        //total de entradas
                        Panel pTotalEntrada = new Panel();
                        pTotalEntrada.Width = 294;
                        pTotalEntrada.Height = 65;
                        pTotalEntrada.Top = 3;
                        pTotalEntrada.Left = 9;
                        pTotalEntrada.BackColor = Color.Green;
                        pTotais.Controls.Add(pTotalEntrada);
                        Label tEntrada = new Label();
                        tEntrada.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Bold);
                        tEntrada.ForeColor = Color.White;
                        tEntrada.Left = 7;
                        tEntrada.Top = 10;
                        tEntrada.Text = "Total Entradas";
                        tEntrada.AutoSize = true;
                        pTotalEntrada.Controls.Add(tEntrada);
                        Label TotalEntrada = new Label();
                        TotalEntrada.Name = "valorEntrada";
                        TotalEntrada.Font = new Font("Micrsoft Sans Serif", 14, FontStyle.Regular);
                        TotalEntrada.ForeColor = Color.White;
                        TotalEntrada.AutoSize = true;
                        var totalEntrada = dtResultado.AsEnumerable().Where(x => x.Field<string>("Data") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("Valor"));
                        TotalEntrada.Text = totalEntrada.ToString("C");
                        TotalEntrada.Top = 22;
                        TotalEntrada.Left = 7;
                        pTotalEntrada.Controls.Add(TotalEntrada);
                        //entrada em dinheiro
                        Label tDinheiro = new Label();
                        tDinheiro.Font = new Font("Microsoft Sans Serif", 6, FontStyle.Bold);
                        tDinheiro.ForeColor = Color.White;
                        tDinheiro.Left = 170;
                        tDinheiro.Top = 10;
                        tDinheiro.Text = "Total Dinheiro";
                        tDinheiro.AutoSize = true;
                        pTotalEntrada.Controls.Add(tDinheiro);
                        Label TotalEntradaDinheiro = new Label();
                        TotalEntradaDinheiro.Name = "dinheiro";
                        TotalEntradaDinheiro.Font = new Font("Micrsoft Sans Serif", 12, FontStyle.Regular);
                        TotalEntradaDinheiro.ForeColor = Color.White;
                        TotalEntradaDinheiro.AutoSize = true;
                        totalEntradaDinheiro = dtResultado.AsEnumerable().Where(x => x.Field<string>("Data") == datetime.ToShortDateString()).Where(x => x.Field<int>("Dinheiro") == 1).Sum(x => x.Field<decimal>("Valor"));
                        TotalEntradaDinheiro.Text = totalEntradaDinheiro.ToString("C");
                        TotalEntradaDinheiro.Top = 22;
                        TotalEntradaDinheiro.Left = 170;
                        pTotalEntrada.Controls.Add(TotalEntradaDinheiro);
                        //
                        var totalMensalEntrada = dtResultado.AsEnumerable().Where(x => x.Field<int>("Mes") == datetime.Month).Sum(x => x.Field<decimal>("Valor"));
                        totalMesEntrada.Text = totalMensalEntrada.ToString("C");


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

            //saldo inicial

            //DoCadastros.SaldoInicial_NovoDia(Convert.ToDateTime(datetime.ToShortDateString()));
            DataTable dtSaldo = new DataTable();
            dtSaldo = DoDiarioDeCaixa.DiarioCaixa_SaldoInicial();
            var saldoInicial = dtSaldo.AsEnumerable().Where(x => x.Field<string>("Data") == datetime.ToShortDateString()).
                Select(k =>
                {
                    var row = dtSaldo.NewRow();
                    row.ItemArray = new object[]
                    {
                        k.Field<decimal>("saldo_inicial")
                    };
                    return row;
                });
            if (saldoInicial.Any())
            {
                DataTable dtNew = saldoInicial.CopyToDataTable();
                Panel pSaldoInicial = new Panel();
                pSaldoInicial.Width = 294;
                pSaldoInicial.Height = 65;
                pSaldoInicial.BorderStyle = BorderStyle.FixedSingle;
                pSaldoInicial.Top = 144;
                pSaldoInicial.Left = 9;
                pTotais.Controls.Add(pSaldoInicial);
                //
                Label saldoTitulo = new Label();
                saldoTitulo.Name = "saldoTitulo";
                saldoTitulo.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Regular);
                saldoTitulo.ForeColor = Color.Black;
                saldoTitulo.AutoSize = true;
                saldoTitulo.Text = "Saldo Inicial";
                saldoTitulo.Top = 10;
                saldoTitulo.Left = 7;
                pSaldoInicial.Controls.Add(saldoTitulo);
                //
                Label saldoI = new Label();
                saldoI.Name = "saldoInicial";
                saldoI.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                saldoI.ForeColor = Color.Black;
                saldoI.AutoSize = true;
                openingBalance = decimal.Parse(dtNew.Rows[0][0].ToString());

                saldoI.Text = openingBalance.ToString();
                saldoI.Top = 22;
                saldoI.Left = 7;
                pSaldoInicial.Controls.Add(saldoI);

            }
            DataTable dtSaldoFinal = new DataTable();
            dtSaldoFinal = DoDiarioDeCaixa.DiarioCaixa_SaldoFinal();
            var saldoFinal = dtSaldoFinal.AsEnumerable().Where(x => x.Field<string>("Data") == datetime.ToShortDateString()).
                Select(k =>
                {
                    var row = dtSaldoFinal.NewRow();
                    row.ItemArray = new object[]
                    {
                        k.Field<decimal>("saldo_final")
                    };
                    return row;
                });
            if (saldoFinal.Any())
            {
                DataTable dtResult = saldoFinal.CopyToDataTable();
                //troco
                Panel pTroco = new Panel();
                pTroco.Width = 294;
                pTroco.Height = 65;
                pTroco.BorderStyle = BorderStyle.FixedSingle;
                pTroco.Top = 213;
                pTroco.Left = 9;
                pTotais.Controls.Add(pTroco);
                //
                Label trocoTitulo = new Label();
                trocoTitulo.Name = "trocoTitulo";
                trocoTitulo.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Regular);
                trocoTitulo.ForeColor = Color.Black;
                trocoTitulo.AutoSize = true;
                trocoTitulo.Text = "Troco";
                trocoTitulo.Top = 10;
                trocoTitulo.Left = 7;
                pTroco.Controls.Add(trocoTitulo);
                //
                Label troco = new Label();
                troco.Name = "troco";
                troco.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                troco.ForeColor = Color.Black;
                troco.AutoSize = true;
                decimal valorTroco = Convert.ToDecimal(dtResult.Rows[0][0].ToString());
                //decimal valorTroco = Convert.ToDecimal(dtSaldoCaixa.Rows[0][0].ToString());
                troco.Text = valorTroco.ToString("C");
                troco.Top = 22;
                troco.Left = 7;
                pTroco.Controls.Add(troco);

                //DoCadastros.SaldoInicial_Troco(valorTroco, Convert.ToDateTime(datetime.ToShortDateString()));
            }
        }

        private void calendario_MonthChanged(object sender, Pabo.Calendar.MonthChangedEventArgs e)
        {
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

        }
    }
}
