namespace views.PlanoDeContas.Provisionado
{
    partial class Parcelas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvParcelas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pagamento = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSelecionarTudo = new System.Windows.Forms.Button();
            this.lblFpagto = new System.Windows.Forms.Label();
            this.lblSucCat = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvParcelas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParcelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParcelas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvParcelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvParcelas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParcelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pagamento});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParcelas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvParcelas.DoubleBuffered = true;
            this.dgvParcelas.EnableHeadersVisualStyles = false;
            this.dgvParcelas.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvParcelas.HeaderBgColor = System.Drawing.Color.WhiteSmoke;
            this.dgvParcelas.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvParcelas.Location = new System.Drawing.Point(13, 13);
            this.dgvParcelas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvParcelas.MultiSelect = false;
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParcelas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvParcelas.RowHeadersVisible = false;
            this.dgvParcelas.RowHeadersWidth = 62;
            this.dgvParcelas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvParcelas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.dgvParcelas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvParcelas.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.dgvParcelas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvParcelas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvParcelas.RowTemplate.Height = 40;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(1147, 482);
            this.dgvParcelas.TabIndex = 169;
            this.dgvParcelas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParcelas_CellClick);
            this.dgvParcelas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParcelas_CellContentClick);
            this.dgvParcelas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvParcelas_CellFormatting);
            // 
            // pagamento
            // 
            this.pagamento.FalseValue = "0";
            this.pagamento.HeaderText = "Status";
            this.pagamento.MinimumWidth = 6;
            this.pagamento.Name = "pagamento";
            this.pagamento.ReadOnly = true;
            this.pagamento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pagamento.TrueValue = "1";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(793, 528);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 17);
            this.lblId.TabIndex = 170;
            this.lblId.Text = "id";
            this.lblId.Visible = false;
            // 
            // btnSelecionarTudo
            // 
            this.btnSelecionarTudo.FlatAppearance.BorderSize = 0;
            this.btnSelecionarTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarTudo.Image = global::views.Properties.Resources.sucesso;
            this.btnSelecionarTudo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionarTudo.Location = new System.Drawing.Point(13, 514);
            this.btnSelecionarTudo.Name = "btnSelecionarTudo";
            this.btnSelecionarTudo.Size = new System.Drawing.Size(155, 31);
            this.btnSelecionarTudo.TabIndex = 171;
            this.btnSelecionarTudo.Text = "Selecionar Tudo";
            this.btnSelecionarTudo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionarTudo.UseVisualStyleBackColor = true;
            this.btnSelecionarTudo.Click += new System.EventHandler(this.btnSelecionarTudo_Click);
            // 
            // lblFpagto
            // 
            this.lblFpagto.AutoSize = true;
            this.lblFpagto.Location = new System.Drawing.Point(832, 528);
            this.lblFpagto.Name = "lblFpagto";
            this.lblFpagto.Size = new System.Drawing.Size(40, 17);
            this.lblFpagto.TabIndex = 172;
            this.lblFpagto.Text = "fpgto";
            this.lblFpagto.Visible = false;
            // 
            // lblSucCat
            // 
            this.lblSucCat.AutoSize = true;
            this.lblSucCat.Location = new System.Drawing.Point(889, 528);
            this.lblSucCat.Name = "lblSucCat";
            this.lblSucCat.Size = new System.Drawing.Size(52, 17);
            this.lblSucCat.TabIndex = 173;
            this.lblSucCat.Text = "subCat";
            this.lblSucCat.Visible = false;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(959, 528);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(63, 17);
            this.lblEmpresa.TabIndex = 174;
            this.lblEmpresa.Text = "empresa";
            this.lblEmpresa.Visible = false;
            // 
            // Parcelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1173, 564);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblSucCat);
            this.Controls.Add(this.lblFpagto);
            this.Controls.Add(this.btnSelecionarTudo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvParcelas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Parcelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parcelas";
            this.Load += new System.EventHandler(this.Parcelas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvParcelas;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnSelecionarTudo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pagamento;
        private System.Windows.Forms.Label lblFpagto;
        private System.Windows.Forms.Label lblSucCat;
        private System.Windows.Forms.Label lblEmpresa;
    }
}