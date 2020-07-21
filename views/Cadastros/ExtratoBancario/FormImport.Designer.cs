namespace views.Cadastros.ExtratoBancario
{
    partial class FormImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImport));
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.backGroundWork = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImportar = new System.Windows.Forms.Button();
            this.txtArquivoExcel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLocalizarArquivoExcel = new System.Windows.Forms.Button();
            this.dgvDados = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.circleProgres = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblValidate = new System.Windows.Forms.Label();
            this.btnSqlServer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd1
            // 
            this.ofd1.FileName = "ofd1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnImportar);
            this.panel2.Controls.Add(this.txtArquivoExcel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnLocalizarArquivoExcel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1308, 126);
            this.panel2.TabIndex = 164;
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportar.Location = new System.Drawing.Point(1017, 42);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(275, 44);
            this.btnImportar.TabIndex = 150;
            this.btnImportar.Text = "Validar Arquivo";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // txtArquivoExcel
            // 
            this.txtArquivoExcel.Location = new System.Drawing.Point(11, 53);
            this.txtArquivoExcel.Margin = new System.Windows.Forms.Padding(4);
            this.txtArquivoExcel.Name = "txtArquivoExcel";
            this.txtArquivoExcel.Size = new System.Drawing.Size(721, 22);
            this.txtArquivoExcel.TabIndex = 148;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 155;
            this.label2.Text = "Arquivo a ser importado";
            // 
            // btnLocalizarArquivoExcel
            // 
            this.btnLocalizarArquivoExcel.Location = new System.Drawing.Point(741, 53);
            this.btnLocalizarArquivoExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnLocalizarArquivoExcel.Name = "btnLocalizarArquivoExcel";
            this.btnLocalizarArquivoExcel.Size = new System.Drawing.Size(32, 26);
            this.btnLocalizarArquivoExcel.TabIndex = 149;
            this.btnLocalizarArquivoExcel.Text = "...";
            this.btnLocalizarArquivoExcel.UseVisualStyleBackColor = true;
            this.btnLocalizarArquivoExcel.Click += new System.EventHandler(this.btnLocalizarArquivoExcel_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDados.BackgroundColor = System.Drawing.Color.White;
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDados.DoubleBuffered = true;
            this.dgvDados.EnableHeadersVisualStyles = false;
            this.dgvDados.GridColor = System.Drawing.Color.White;
            this.dgvDados.HeaderBgColor = System.Drawing.Color.White;
            this.dgvDados.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvDados.Location = new System.Drawing.Point(49, 134);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDados.MultiSelect = false;
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.RowHeadersWidth = 40;
            this.dgvDados.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvDados.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDados.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.dgvDados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDados.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDados.RowTemplate.DividerHeight = 1;
            this.dgvDados.RowTemplate.Height = 30;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(1187, 486);
            this.dgvDados.TabIndex = 165;
            this.dgvDados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDados_CellFormatting);
            // 
            // circleProgres
            // 
            this.circleProgres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.circleProgres.animated = false;
            this.circleProgres.animationIterval = 5;
            this.circleProgres.animationSpeed = 300;
            this.circleProgres.BackColor = System.Drawing.Color.White;
            this.circleProgres.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleProgres.BackgroundImage")));
            this.circleProgres.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.circleProgres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.circleProgres.LabelVisible = true;
            this.circleProgres.LineProgressThickness = 5;
            this.circleProgres.LineThickness = 2;
            this.circleProgres.Location = new System.Drawing.Point(492, 252);
            this.circleProgres.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.circleProgres.MaxValue = 100;
            this.circleProgres.Name = "circleProgres";
            this.circleProgres.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circleProgres.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.circleProgres.Size = new System.Drawing.Size(265, 265);
            this.circleProgres.TabIndex = 166;
            this.circleProgres.Value = 0;
            // 
            // panelInfo
            // 
            this.panelInfo.AllowDrop = true;
            this.panelInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInfo.Controls.Add(this.lblValidate);
            this.panelInfo.Controls.Add(this.btnSqlServer);
            this.panelInfo.Controls.Add(this.label4);
            this.panelInfo.Controls.Add(this.lblError);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Location = new System.Drawing.Point(13, 637);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1266, 123);
            this.panelInfo.TabIndex = 167;
            // 
            // lblValidate
            // 
            this.lblValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblValidate.AutoSize = true;
            this.lblValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidate.Location = new System.Drawing.Point(21, 89);
            this.lblValidate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidate.Name = "lblValidate";
            this.lblValidate.Size = new System.Drawing.Size(124, 17);
            this.lblValidate.TabIndex = 168;
            this.lblValidate.Text = "Linhas Validadas: ";
            this.lblValidate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSqlServer
            // 
            this.btnSqlServer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnSqlServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSqlServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnSqlServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSqlServer.BorderRadius = 0;
            this.btnSqlServer.ButtonText = "Importar Dados";
            this.btnSqlServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSqlServer.DisabledColor = System.Drawing.Color.Gray;
            this.btnSqlServer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSqlServer.Iconimage = null;
            this.btnSqlServer.Iconimage_right = null;
            this.btnSqlServer.Iconimage_right_Selected = null;
            this.btnSqlServer.Iconimage_Selected = null;
            this.btnSqlServer.IconMarginLeft = 0;
            this.btnSqlServer.IconMarginRight = 0;
            this.btnSqlServer.IconRightVisible = true;
            this.btnSqlServer.IconRightZoom = 0D;
            this.btnSqlServer.IconVisible = true;
            this.btnSqlServer.IconZoom = 90D;
            this.btnSqlServer.IsTab = false;
            this.btnSqlServer.Location = new System.Drawing.Point(936, 39);
            this.btnSqlServer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSqlServer.Name = "btnSqlServer";
            this.btnSqlServer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnSqlServer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnSqlServer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSqlServer.selected = false;
            this.btnSqlServer.Size = new System.Drawing.Size(237, 52);
            this.btnSqlServer.TabIndex = 152;
            this.btnSqlServer.Text = "Importar Dados";
            this.btnSqlServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSqlServer.Textcolor = System.Drawing.Color.White;
            this.btnSqlServer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqlServer.Click += new System.EventHandler(this.btnSqlServer_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 17);
            this.label4.TabIndex = 167;
            this.label4.Text = "Linhas que merecem sua atenção: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(21, 43);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(118, 17);
            this.lblError.TabIndex = 166;
            this.lblError.Text = "Linhas com erro: ";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 165;
            this.label1.Text = "Informações";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 773);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.circleProgres);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.panel2);
            this.Name = "FormImport";
            this.Text = "FormImport";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.ComponentModel.BackgroundWorker backGroundWork;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.TextBox txtArquivoExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLocalizarArquivoExcel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDados;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circleProgres;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblValidate;
        private Bunifu.Framework.UI.BunifuFlatButton btnSqlServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label1;
    }
}