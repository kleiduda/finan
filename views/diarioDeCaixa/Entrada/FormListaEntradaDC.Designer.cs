namespace views
{
    partial class FormListaEntradaDC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pDataGrid = new System.Windows.Forms.Panel();
            this.dgvEntradas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pButtons = new System.Windows.Forms.Panel();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            this.pButtons.SuspendLayout();
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
            // pDataGrid
            // 
            this.pDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pDataGrid.Controls.Add(this.dgvEntradas);
            this.pDataGrid.Location = new System.Drawing.Point(32, 57);
            this.pDataGrid.Name = "pDataGrid";
            this.pDataGrid.Size = new System.Drawing.Size(1363, 667);
            this.pDataGrid.TabIndex = 175;
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.AllowUserToAddRows = false;
            this.dgvEntradas.AllowUserToDeleteRows = false;
            this.dgvEntradas.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEntradas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntradas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEntradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEntradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntradas.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEntradas.DoubleBuffered = true;
            this.dgvEntradas.EnableHeadersVisualStyles = false;
            this.dgvEntradas.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEntradas.HeaderBgColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEntradas.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvEntradas.Location = new System.Drawing.Point(8, 14);
            this.dgvEntradas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEntradas.MultiSelect = false;
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.ReadOnly = true;
            this.dgvEntradas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntradas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEntradas.RowHeadersVisible = false;
            this.dgvEntradas.RowHeadersWidth = 62;
            this.dgvEntradas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEntradas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.dgvEntradas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEntradas.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.dgvEntradas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvEntradas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEntradas.RowTemplate.Height = 40;
            this.dgvEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntradas.Size = new System.Drawing.Size(1349, 642);
            this.dgvEntradas.TabIndex = 168;
            this.dgvEntradas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntradas_CellClick);
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.Image = global::views.Properties.Resources.cancel1;
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // pButtons
            // 
            this.pButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pButtons.Controls.Add(this.btnNovoCadastro);
            this.pButtons.Controls.Add(this.txtSearch);
            this.pButtons.Location = new System.Drawing.Point(32, 730);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(1363, 81);
            this.pButtons.TabIndex = 174;
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.FlatAppearance.BorderSize = 0;
            this.btnNovoCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCadastro.Image = global::views.Properties.Resources.add__lista;
            this.btnNovoCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoCadastro.Location = new System.Drawing.Point(10, 25);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Size = new System.Drawing.Size(179, 31);
            this.btnNovoCadastro.TabIndex = 162;
            this.btnNovoCadastro.Text = "NOVO CADASTRO";
            this.btnNovoCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoCadastro.UseVisualStyleBackColor = true;
            this.btnNovoCadastro.Click += new System.EventHandler(this.btnNovoCadastro_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtSearch.ForeColor = System.Drawing.Color.LightGray;
            this.txtSearch.Location = new System.Drawing.Point(238, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1108, 31);
            this.txtSearch.TabIndex = 167;
            this.txtSearch.Text = "Pesquisar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(421, 44);
            this.label9.TabIndex = 173;
            this.label9.Text = "#LISTA DE ENTRADAS";
            // 
            // FormListaEntradaDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1418, 826);
            this.Controls.Add(this.pDataGrid);
            this.Controls.Add(this.pButtons);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListaEntradaDC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTipoEntrada";
            this.Load += new System.EventHandler(this.FormListaP_Load);
            this.pDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            this.pButtons.ResumeLayout(false);
            this.pButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel pDataGrid;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvEntradas;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}