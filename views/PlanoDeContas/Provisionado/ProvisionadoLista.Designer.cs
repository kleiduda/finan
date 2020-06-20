namespace views
{
    partial class ProvisionadoLista
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
            this.pDataGrid = new System.Windows.Forms.Panel();
            this.dgvLancamentos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pButtons = new System.Windows.Forms.Panel();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.lblProvisionado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pesquisa = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamentos)).BeginInit();
            this.pButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pDataGrid
            // 
            this.pDataGrid.Controls.Add(this.dgvLancamentos);
            this.pDataGrid.Location = new System.Drawing.Point(32, 57);
            this.pDataGrid.Name = "pDataGrid";
            this.pDataGrid.Size = new System.Drawing.Size(1363, 667);
            this.pDataGrid.TabIndex = 175;
            // 
            // dgvLancamentos
            // 
            this.dgvLancamentos.AllowUserToAddRows = false;
            this.dgvLancamentos.AllowUserToDeleteRows = false;
            this.dgvLancamentos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvLancamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLancamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLancamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLancamentos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvLancamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLancamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLancamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLancamentos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLancamentos.DoubleBuffered = true;
            this.dgvLancamentos.EnableHeadersVisualStyles = false;
            this.dgvLancamentos.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvLancamentos.HeaderBgColor = System.Drawing.Color.WhiteSmoke;
            this.dgvLancamentos.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvLancamentos.Location = new System.Drawing.Point(9, 19);
            this.dgvLancamentos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLancamentos.MultiSelect = false;
            this.dgvLancamentos.Name = "dgvLancamentos";
            this.dgvLancamentos.ReadOnly = true;
            this.dgvLancamentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLancamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLancamentos.RowHeadersVisible = false;
            this.dgvLancamentos.RowHeadersWidth = 62;
            this.dgvLancamentos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvLancamentos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.dgvLancamentos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLancamentos.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.dgvLancamentos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvLancamentos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLancamentos.RowTemplate.Height = 40;
            this.dgvLancamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLancamentos.Size = new System.Drawing.Size(1349, 634);
            this.dgvLancamentos.TabIndex = 168;
            this.dgvLancamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLancamentos_CellClick);
            this.dgvLancamentos.DoubleClick += new System.EventHandler(this.dgvLancamentos_DoubleClick);
            // 
            // pButtons
            // 
            this.pButtons.Controls.Add(this.btnNovoCadastro);
            this.pButtons.Controls.Add(this.lblProvisionado);
            this.pButtons.Controls.Add(this.label7);
            this.pButtons.Controls.Add(this.dtInicio);
            this.pButtons.Controls.Add(this.dtFim);
            this.pButtons.Controls.Add(this.btnFiltro);
            this.pButtons.Controls.Add(this.label1);
            this.pButtons.Controls.Add(this.pesquisa);
            this.pButtons.Controls.Add(this.txtSearch);
            this.pButtons.Location = new System.Drawing.Point(32, 730);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(1363, 88);
            this.pButtons.TabIndex = 174;
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.FlatAppearance.BorderSize = 0;
            this.btnNovoCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCadastro.Image = global::views.Properties.Resources.add__lista;
            this.btnNovoCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoCadastro.Location = new System.Drawing.Point(9, 30);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Size = new System.Drawing.Size(143, 31);
            this.btnNovoCadastro.TabIndex = 180;
            this.btnNovoCadastro.Text = "LANÇAMENTO";
            this.btnNovoCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoCadastro.UseVisualStyleBackColor = true;
            this.btnNovoCadastro.Click += new System.EventHandler(this.btnNovoCadastro_Click);
            // 
            // lblProvisionado
            // 
            this.lblProvisionado.AutoSize = true;
            this.lblProvisionado.Location = new System.Drawing.Point(428, 40);
            this.lblProvisionado.Name = "lblProvisionado";
            this.lblProvisionado.Size = new System.Drawing.Size(94, 17);
            this.lblProvisionado.TabIndex = 179;
            this.lblProvisionado.Text = "Provisionado:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(1138, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 14);
            this.label7.TabIndex = 170;
            this.label7.Text = "Data Inicio:";
            // 
            // dtInicio
            // 
            this.dtInicio.CustomFormat = "";
            this.dtInicio.Location = new System.Drawing.Point(1216, 9);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(130, 22);
            this.dtInicio.TabIndex = 169;
            this.dtInicio.Value = new System.DateTime(2020, 6, 16, 0, 9, 46, 0);
            // 
            // dtFim
            // 
            this.dtFim.CustomFormat = "";
            this.dtFim.Location = new System.Drawing.Point(1216, 36);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(130, 22);
            this.dtFim.TabIndex = 175;
            this.dtFim.Value = new System.DateTime(2020, 6, 16, 0, 9, 46, 0);
            // 
            // btnFiltro
            // 
            this.btnFiltro.FlatAppearance.BorderSize = 0;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.Image = global::views.Properties.Resources.sucesso;
            this.btnFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltro.Location = new System.Drawing.Point(1240, 60);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(103, 23);
            this.btnFiltro.TabIndex = 174;
            this.btnFiltro.Text = "FILTRAR";
            this.btnFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1138, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 172;
            this.label1.Text = "Data Fim:";
            // 
            // pesquisa
            // 
            this.pesquisa.AutoSize = true;
            this.pesquisa.Location = new System.Drawing.Point(638, 40);
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.Size = new System.Drawing.Size(66, 17);
            this.pesquisa.TabIndex = 169;
            this.pesquisa.Text = "Pesquisa";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtSearch.ForeColor = System.Drawing.Color.LightGray;
            this.txtSearch.Location = new System.Drawing.Point(710, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(362, 38);
            this.txtSearch.TabIndex = 167;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(357, 44);
            this.label9.TabIndex = 173;
            this.label9.Text = "#PROVISIONADOS";
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
            // ProvisionadoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1418, 826);
            this.Controls.Add(this.pDataGrid);
            this.Controls.Add(this.pButtons);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProvisionadoLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provisionados";
            this.Load += new System.EventHandler(this.ProvisionadoLista_Load);
            this.pDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamentos)).EndInit();
            this.pButtons.ResumeLayout(false);
            this.pButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel pDataGrid;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvLancamentos;
        private System.Windows.Forms.Label pesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label lblProvisionado;
        private System.Windows.Forms.Button btnNovoCadastro;
    }
}