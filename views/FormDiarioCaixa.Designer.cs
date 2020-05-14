namespace views
{
    partial class FormDiarioCaixa
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
            this.lblTotalVendas = new System.Windows.Forms.Label();
            this.lblResumoVendasT = new System.Windows.Forms.Label();
            this.lblTotalVendasT = new System.Windows.Forms.Label();
            this.bunifuSeparator7 = new Bunifu.Framework.UI.BunifuSeparator();
            this.painelDinheiro = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblVendaDinheiro = new System.Windows.Forms.Label();
            this.lblVendaDebito = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblVendaFiado = new System.Windows.Forms.Label();
            this.lblVendasCredito = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.painelDinheiro.SuspendLayout();
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
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Controls.Add(this.lblTotalVendas);
            this.panel9.Controls.Add(this.lblResumoVendasT);
            this.panel9.Controls.Add(this.lblTotalVendasT);
            this.panel9.Controls.Add(this.bunifuSeparator7);
            this.panel9.Controls.Add(this.painelDinheiro);
            this.panel9.Controls.Add(this.lblVendaDebito);
            this.panel9.Controls.Add(this.label15);
            this.panel9.Controls.Add(this.lblVendaFiado);
            this.panel9.Controls.Add(this.lblVendasCredito);
            this.panel9.Controls.Add(this.label16);
            this.panel9.Controls.Add(this.label13);
            this.panel9.Location = new System.Drawing.Point(40, 42);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(661, 331);
            this.panel9.TabIndex = 169;
            // 
            // lblTotalVendas
            // 
            this.lblTotalVendas.AutoSize = true;
            this.lblTotalVendas.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVendas.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalVendas.Location = new System.Drawing.Point(390, 287);
            this.lblTotalVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalVendas.Name = "lblTotalVendas";
            this.lblTotalVendas.Size = new System.Drawing.Size(101, 29);
            this.lblTotalVendas.TabIndex = 163;
            this.lblTotalVendas.Text = "R$ 0,00";
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
            this.lblResumoVendasT.Size = new System.Drawing.Size(187, 26);
            this.lblResumoVendasT.TabIndex = 162;
            this.lblResumoVendasT.Text = "RECEITA BRUTA";
            // 
            // lblTotalVendasT
            // 
            this.lblTotalVendasT.AutoSize = true;
            this.lblTotalVendasT.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalVendasT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblTotalVendasT.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalVendasT.Location = new System.Drawing.Point(391, 268);
            this.lblTotalVendasT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalVendasT.Name = "lblTotalVendasT";
            this.lblTotalVendasT.Size = new System.Drawing.Size(95, 15);
            this.lblTotalVendasT.TabIndex = 162;
            this.lblTotalVendasT.Text = "Total de Vendas";
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
            this.bunifuSeparator7.Size = new System.Drawing.Size(661, 10);
            this.bunifuSeparator7.TabIndex = 164;
            this.bunifuSeparator7.Transparency = 255;
            this.bunifuSeparator7.Vertical = false;
            // 
            // painelDinheiro
            // 
            this.painelDinheiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelDinheiro.Controls.Add(this.label12);
            this.painelDinheiro.Controls.Add(this.lblVendaDinheiro);
            this.painelDinheiro.Location = new System.Drawing.Point(383, 62);
            this.painelDinheiro.Name = "painelDinheiro";
            this.painelDinheiro.Size = new System.Drawing.Size(246, 51);
            this.painelDinheiro.TabIndex = 150;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(9, 17);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 17);
            this.label12.TabIndex = 155;
            this.label12.Text = "Venda no Dinheiro:";
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
            // lblVendaDebito
            // 
            this.lblVendaDebito.AutoSize = true;
            this.lblVendaDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblVendaDebito.Location = new System.Drawing.Point(530, 144);
            this.lblVendaDebito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendaDebito.Name = "lblVendaDebito";
            this.lblVendaDebito.Size = new System.Drawing.Size(40, 18);
            this.lblVendaDebito.TabIndex = 152;
            this.lblVendaDebito.Text = "0.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(392, 145);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 17);
            this.label15.TabIndex = 153;
            this.label15.Text = "Venda no Débito:";
            // 
            // lblVendaFiado
            // 
            this.lblVendaFiado.AutoSize = true;
            this.lblVendaFiado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblVendaFiado.Location = new System.Drawing.Point(530, 202);
            this.lblVendaFiado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendaFiado.Name = "lblVendaFiado";
            this.lblVendaFiado.Size = new System.Drawing.Size(40, 18);
            this.lblVendaFiado.TabIndex = 162;
            this.lblVendaFiado.Text = "0.00";
            // 
            // lblVendasCredito
            // 
            this.lblVendasCredito.AutoSize = true;
            this.lblVendasCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblVendasCredito.Location = new System.Drawing.Point(529, 174);
            this.lblVendasCredito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendasCredito.Name = "lblVendasCredito";
            this.lblVendasCredito.Size = new System.Drawing.Size(40, 18);
            this.lblVendasCredito.TabIndex = 150;
            this.lblVendasCredito.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(391, 175);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 17);
            this.label16.TabIndex = 151;
            this.label16.Text = "Venda no Crédito:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(392, 200);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 17);
            this.label13.TabIndex = 163;
            this.label13.Text = "Conta:";
            // 
            // FormDiarioCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1418, 788);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDiarioCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTipoEntrada";
            this.Load += new System.EventHandler(this.FormDiarioCaixa_Load);
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.painelDinheiro.ResumeLayout(false);
            this.painelDinheiro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblTotalVendas;
        private System.Windows.Forms.Label lblResumoVendasT;
        private System.Windows.Forms.Label lblTotalVendasT;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator7;
        private System.Windows.Forms.Panel painelDinheiro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblVendaDinheiro;
        private System.Windows.Forms.Label lblVendaDebito;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblVendaFiado;
        private System.Windows.Forms.Label lblVendasCredito;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
    }
}