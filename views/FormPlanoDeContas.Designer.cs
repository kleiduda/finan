﻿namespace views
{
    partial class FormPlanoDeContas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panelCalendario = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calendario = new Pabo.Calendar.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.painelDinheiro = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVendaDinheiro = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.pContainer = new System.Windows.Forms.Panel();
            this.pTotal = new System.Windows.Forms.Panel();
            this.painelSaidas = new System.Windows.Forms.Panel();
            this.painelEntradas = new System.Windows.Forms.Panel();
            this.lblResumoVendasT = new System.Windows.Forms.Label();
            this.bunifuSeparator7 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panelCalendario.SuspendLayout();
            this.panel2.SuspendLayout();
            this.painelDinheiro.SuspendLayout();
            this.pContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Excluir";
            this.dataGridViewImageColumn1.Image = global::views.Properties.Resources.cancel;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ToolTipText = "Excluir";
            this.dataGridViewImageColumn1.Width = 623;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1418, 788);
            this.panel1.TabIndex = 160;
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Controls.Add(this.panelCalendario);
            this.panel9.Controls.Add(this.pContainer);
            this.panel9.Controls.Add(this.lblResumoVendasT);
            this.panel9.Controls.Add(this.bunifuSeparator7);
            this.panel9.Location = new System.Drawing.Point(12, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1394, 764);
            this.panel9.TabIndex = 169;
            // 
            // panelCalendario
            // 
            this.panelCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelCalendario.Controls.Add(this.panel2);
            this.panelCalendario.Controls.Add(this.calendario);
            this.panelCalendario.Controls.Add(this.label2);
            this.panelCalendario.Controls.Add(this.painelDinheiro);
            this.panelCalendario.Controls.Add(this.bunifuSeparator1);
            this.panelCalendario.Controls.Add(this.label3);
            this.panelCalendario.Location = new System.Drawing.Point(1025, 17);
            this.panelCalendario.Name = "panelCalendario";
            this.panelCalendario.Size = new System.Drawing.Size(350, 715);
            this.panelCalendario.TabIndex = 183;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(9, 529);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 51);
            this.panel2.TabIndex = 156;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 155;
            this.label1.Text = "Total Saída:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(147, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 154;
            this.label4.Text = "0.00";
            // 
            // calendario
            // 
            this.calendario.ActiveMonth.Month = 4;
            this.calendario.ActiveMonth.Year = 2020;
            this.calendario.BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.calendario.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.calendario.Footer.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.calendario.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.calendario.Footer.Format = Pabo.Calendar.mcTodayFormat.Long;
            this.calendario.Footer.Text = "Vendas do dia 21";
            this.calendario.Header.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.calendario.Header.BackColor2 = System.Drawing.Color.Black;
            this.calendario.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendario.ImageList = null;
            this.calendario.Location = new System.Drawing.Point(8, 61);
            this.calendario.MaxDate = new System.DateTime(2030, 4, 20, 21, 3, 2, 326);
            this.calendario.MinDate = new System.DateTime(2010, 4, 20, 21, 3, 2, 326);
            this.calendario.Month.BackgroundImage = null;
            this.calendario.Month.BorderStyles.Focus = System.Windows.Forms.ButtonBorderStyle.None;
            this.calendario.Month.BorderStyles.Selected = System.Windows.Forms.ButtonBorderStyle.None;
            this.calendario.Month.Colors.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.calendario.Month.Colors.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.calendario.Month.Colors.Days.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.calendario.Month.Colors.Days.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.calendario.Month.Colors.Days.Border = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.calendario.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.calendario.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.calendario.Name = "calendario";
            this.calendario.SelectTrailingDates = false;
            this.calendario.ShowTrailingDates = false;
            this.calendario.Size = new System.Drawing.Size(333, 255);
            this.calendario.TabIndex = 174;
            this.calendario.TodayColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.calendario.Weekdays.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.calendario.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.calendario.Weekdays.TextColor = System.Drawing.Color.Black;
            this.calendario.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.calendario.MonthChanged += new Pabo.Calendar.MonthChangedEventHandler(this.calendario_MonthChanged);
            this.calendario.DayClick += new Pabo.Calendar.DayClickEventHandler(this.calendario_DayClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(4, 405);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 29);
            this.label2.TabIndex = 150;
            this.label2.Text = "Resumo de Vendas  Mensal";
            // 
            // painelDinheiro
            // 
            this.painelDinheiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelDinheiro.Controls.Add(this.label6);
            this.painelDinheiro.Controls.Add(this.lblVendaDinheiro);
            this.painelDinheiro.Location = new System.Drawing.Point(8, 472);
            this.painelDinheiro.Name = "painelDinheiro";
            this.painelDinheiro.Size = new System.Drawing.Size(321, 51);
            this.painelDinheiro.TabIndex = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(9, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 155;
            this.label6.Text = "Total Entrada:";
            // 
            // lblVendaDinheiro
            // 
            this.lblVendaDinheiro.AutoSize = true;
            this.lblVendaDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblVendaDinheiro.Location = new System.Drawing.Point(147, 16);
            this.lblVendaDinheiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendaDinheiro.Name = "lblVendaDinheiro";
            this.lblVendaDinheiro.Size = new System.Drawing.Size(40, 18);
            this.lblVendaDinheiro.TabIndex = 154;
            this.lblVendaDinheiro.Text = "0.00";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(8, 40);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(333, 14);
            this.bunifuSeparator1.TabIndex = 148;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 26);
            this.label3.TabIndex = 145;
            this.label3.Text = "Vendas do Dia";
            // 
            // pContainer
            // 
            this.pContainer.Controls.Add(this.pTotal);
            this.pContainer.Controls.Add(this.painelSaidas);
            this.pContainer.Controls.Add(this.painelEntradas);
            this.pContainer.Location = new System.Drawing.Point(18, 121);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1001, 612);
            this.pContainer.TabIndex = 174;
            // 
            // pTotal
            // 
            this.pTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTotal.Location = new System.Drawing.Point(17, 545);
            this.pTotal.Name = "pTotal";
            this.pTotal.Size = new System.Drawing.Size(662, 65);
            this.pTotal.TabIndex = 182;
            // 
            // painelSaidas
            // 
            this.painelSaidas.Location = new System.Drawing.Point(351, 3);
            this.painelSaidas.Name = "painelSaidas";
            this.painelSaidas.Size = new System.Drawing.Size(328, 536);
            this.painelSaidas.TabIndex = 181;
            // 
            // painelEntradas
            // 
            this.painelEntradas.Location = new System.Drawing.Point(17, 3);
            this.painelEntradas.Name = "painelEntradas";
            this.painelEntradas.Size = new System.Drawing.Size(328, 536);
            this.painelEntradas.TabIndex = 175;
            // 
            // lblResumoVendasT
            // 
            this.lblResumoVendasT.AutoSize = true;
            this.lblResumoVendasT.BackColor = System.Drawing.Color.Transparent;
            this.lblResumoVendasT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumoVendasT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.lblResumoVendasT.Location = new System.Drawing.Point(9, 14);
            this.lblResumoVendasT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoVendasT.Name = "lblResumoVendasT";
            this.lblResumoVendasT.Size = new System.Drawing.Size(221, 26);
            this.lblResumoVendasT.TabIndex = 162;
            this.lblResumoVendasT.Text = "PLANO DE CONTAS";
            // 
            // bunifuSeparator7
            // 
            this.bunifuSeparator7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator7.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.bunifuSeparator7.LineThickness = 3;
            this.bunifuSeparator7.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator7.Name = "bunifuSeparator7";
            this.bunifuSeparator7.Size = new System.Drawing.Size(1394, 10);
            this.bunifuSeparator7.TabIndex = 164;
            this.bunifuSeparator7.Transparency = 255;
            this.bunifuSeparator7.Vertical = false;
            // 
            // FormPlanoDeContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1418, 788);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPlanoDeContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTipoEntrada";
            this.Load += new System.EventHandler(this.FormPlanoDeContas_Load);
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panelCalendario.ResumeLayout(false);
            this.panelCalendario.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.painelDinheiro.ResumeLayout(false);
            this.painelDinheiro.PerformLayout();
            this.pContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblResumoVendasT;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator7;
        private System.Windows.Forms.Panel pContainer;
        private Pabo.Calendar.MonthCalendar calendario;
        private System.Windows.Forms.Panel painelEntradas;
        private System.Windows.Forms.Panel painelSaidas;
        private System.Windows.Forms.Panel pTotal;
        private System.Windows.Forms.Panel panelCalendario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel painelDinheiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVendaDinheiro;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label3;
    }
}