namespace views
{
    partial class Categoria
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
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblID = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblSuc = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pButtons = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCentroCusto = new System.Windows.Forms.ComboBox();
            this.btnNovaSubCategoria = new System.Windows.Forms.PictureBox();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pSubCategoria = new System.Windows.Forms.Panel();
            this.txtSubCategoria = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSaveSubCategoria = new System.Windows.Forms.Button();
            this.pCategoria = new System.Windows.Forms.Panel();
            this.btnSaveCategoria = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pCentroCusto = new System.Windows.Forms.Panel();
            this.btnSaveCC = new System.Windows.Forms.Button();
            this.txtCentroCusto = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovaSubCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pSubCategoria.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pCategoria.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pCentroCusto.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.2F);
            this.label9.Location = new System.Drawing.Point(61, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(705, 33);
            this.label9.TabIndex = 157;
            this.label9.Text = "#CENTRO CUSTO, CATEGORIA, SUB CATEGORIA";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Gray;
            this.lblID.Location = new System.Drawing.Point(1111, -3);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 24);
            this.lblID.TabIndex = 176;
            this.lblID.Text = "id";
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Image = global::views.Properties.Resources.report_min;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(63, 457);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(234, 20);
            this.lblError.TabIndex = 178;
            this.lblError.Text = "         erro ao fazer o login";
            this.lblError.Visible = false;
            // 
            // lblSuc
            // 
            this.lblSuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSuc.AutoSize = true;
            this.lblSuc.BackColor = System.Drawing.Color.Transparent;
            this.lblSuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(175)))), ((int)(((byte)(115)))));
            this.lblSuc.Image = global::views.Properties.Resources.sucesso;
            this.lblSuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSuc.Location = new System.Drawing.Point(63, 457);
            this.lblSuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuc.Name = "lblSuc";
            this.lblSuc.Size = new System.Drawing.Size(278, 20);
            this.lblSuc.TabIndex = 179;
            this.lblSuc.Text = "         erro ao cadastrar produto";
            this.lblSuc.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(64, 225);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 180;
            this.label12.Text = "Categoria";
            // 
            // pButtons
            // 
            this.pButtons.Controls.Add(this.btnSalvar);
            this.pButtons.Location = new System.Drawing.Point(57, 507);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(803, 81);
            this.pButtons.TabIndex = 184;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::views.Properties.Resources.save;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(651, 25);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(111, 31);
            this.btnSalvar.TabIndex = 165;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 186;
            this.label1.Text = "Centro de Custo";
            // 
            // cbCentroCusto
            // 
            this.cbCentroCusto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCentroCusto.BackColor = System.Drawing.SystemColors.Control;
            this.cbCentroCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCentroCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCentroCusto.FormattingEnabled = true;
            this.cbCentroCusto.Location = new System.Drawing.Point(66, 147);
            this.cbCentroCusto.Name = "cbCentroCusto";
            this.cbCentroCusto.Size = new System.Drawing.Size(352, 33);
            this.cbCentroCusto.TabIndex = 185;
            // 
            // btnNovaSubCategoria
            // 
            this.btnNovaSubCategoria.Image = global::views.Properties.Resources.add__lista;
            this.btnNovaSubCategoria.Location = new System.Drawing.Point(428, 370);
            this.btnNovaSubCategoria.Name = "btnNovaSubCategoria";
            this.btnNovaSubCategoria.Size = new System.Drawing.Size(34, 33);
            this.btnNovaSubCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnNovaSubCategoria.TabIndex = 189;
            this.btnNovaSubCategoria.TabStop = false;
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSubCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.cbSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Location = new System.Drawing.Point(66, 369);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(352, 33);
            this.cbSubCategoria.TabIndex = 188;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 336);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 187;
            this.label2.Text = "Sub Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(66, 258);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(352, 33);
            this.cbCategoria.TabIndex = 190;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::views.Properties.Resources.add__lista;
            this.pictureBox1.Location = new System.Drawing.Point(428, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 191;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::views.Properties.Resources.add__lista;
            this.pictureBox2.Location = new System.Drawing.Point(428, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 192;
            this.pictureBox2.TabStop = false;
            // 
            // pSubCategoria
            // 
            this.pSubCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pSubCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pSubCategoria.Controls.Add(this.btnSaveSubCategoria);
            this.pSubCategoria.Controls.Add(this.txtSubCategoria);
            this.pSubCategoria.Controls.Add(this.panel6);
            this.pSubCategoria.Location = new System.Drawing.Point(468, 334);
            this.pSubCategoria.Name = "pSubCategoria";
            this.pSubCategoria.Size = new System.Drawing.Size(392, 103);
            this.pSubCategoria.TabIndex = 175;
            // 
            // txtSubCategoria
            // 
            this.txtSubCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSubCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSubCategoria.Location = new System.Drawing.Point(44, 36);
            this.txtSubCategoria.Name = "txtSubCategoria";
            this.txtSubCategoria.Size = new System.Drawing.Size(279, 36);
            this.txtSubCategoria.TabIndex = 176;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(28, 103);
            this.panel6.TabIndex = 174;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::views.Properties.Resources.arrow_left;
            this.pictureBox3.Location = new System.Drawing.Point(6, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // btnSaveSubCategoria
            // 
            this.btnSaveSubCategoria.FlatAppearance.BorderSize = 0;
            this.btnSaveSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSubCategoria.Image = global::views.Properties.Resources.save;
            this.btnSaveSubCategoria.Location = new System.Drawing.Point(344, 38);
            this.btnSaveSubCategoria.Name = "btnSaveSubCategoria";
            this.btnSaveSubCategoria.Size = new System.Drawing.Size(26, 31);
            this.btnSaveSubCategoria.TabIndex = 166;
            this.btnSaveSubCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveSubCategoria.UseVisualStyleBackColor = true;
            this.btnSaveSubCategoria.Click += new System.EventHandler(this.btnSaveSubCategoria_Click);
            // 
            // pCategoria
            // 
            this.pCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pCategoria.Controls.Add(this.btnSaveCategoria);
            this.pCategoria.Controls.Add(this.txtCategoria);
            this.pCategoria.Controls.Add(this.panel2);
            this.pCategoria.Location = new System.Drawing.Point(468, 222);
            this.pCategoria.Name = "pCategoria";
            this.pCategoria.Size = new System.Drawing.Size(392, 103);
            this.pCategoria.TabIndex = 177;
            // 
            // btnSaveCategoria
            // 
            this.btnSaveCategoria.FlatAppearance.BorderSize = 0;
            this.btnSaveCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCategoria.Image = global::views.Properties.Resources.save;
            this.btnSaveCategoria.Location = new System.Drawing.Point(344, 38);
            this.btnSaveCategoria.Name = "btnSaveCategoria";
            this.btnSaveCategoria.Size = new System.Drawing.Size(26, 31);
            this.btnSaveCategoria.TabIndex = 166;
            this.btnSaveCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveCategoria.UseVisualStyleBackColor = true;
            this.btnSaveCategoria.Click += new System.EventHandler(this.btnSaveCategoria_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCategoria.Location = new System.Drawing.Point(44, 36);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(279, 36);
            this.txtCategoria.TabIndex = 176;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(28, 103);
            this.panel2.TabIndex = 174;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::views.Properties.Resources.arrow_left;
            this.pictureBox4.Location = new System.Drawing.Point(6, 38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pCentroCusto
            // 
            this.pCentroCusto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pCentroCusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pCentroCusto.Controls.Add(this.btnSaveCC);
            this.pCentroCusto.Controls.Add(this.txtCentroCusto);
            this.pCentroCusto.Controls.Add(this.panel3);
            this.pCentroCusto.Location = new System.Drawing.Point(468, 109);
            this.pCentroCusto.Name = "pCentroCusto";
            this.pCentroCusto.Size = new System.Drawing.Size(392, 103);
            this.pCentroCusto.TabIndex = 178;
            // 
            // btnSaveCC
            // 
            this.btnSaveCC.FlatAppearance.BorderSize = 0;
            this.btnSaveCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCC.Image = global::views.Properties.Resources.save;
            this.btnSaveCC.Location = new System.Drawing.Point(344, 38);
            this.btnSaveCC.Name = "btnSaveCC";
            this.btnSaveCC.Size = new System.Drawing.Size(26, 31);
            this.btnSaveCC.TabIndex = 166;
            this.btnSaveCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveCC.UseVisualStyleBackColor = true;
            this.btnSaveCC.Click += new System.EventHandler(this.btnSaveCC_Click);
            // 
            // txtCentroCusto
            // 
            this.txtCentroCusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCentroCusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCentroCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCentroCusto.Location = new System.Drawing.Point(44, 36);
            this.txtCentroCusto.Name = "txtCentroCusto";
            this.txtCentroCusto.Size = new System.Drawing.Size(279, 36);
            this.txtCentroCusto.TabIndex = 176;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(28, 103);
            this.panel3.TabIndex = 174;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::views.Properties.Resources.arrow_left;
            this.pictureBox5.Location = new System.Drawing.Point(6, 38);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 611);
            this.Controls.Add(this.pCentroCusto);
            this.Controls.Add(this.pCategoria);
            this.Controls.Add(this.pSubCategoria);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.btnNovaSubCategoria);
            this.Controls.Add(this.cbSubCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCentroCusto);
            this.Controls.Add(this.pButtons);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblSuc);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTipoEntrada";
            this.Load += new System.EventHandler(this.Categoria_Load);
            this.pButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNovaSubCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pSubCategoria.ResumeLayout(false);
            this.pSubCategoria.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pCategoria.ResumeLayout(false);
            this.pCategoria.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pCentroCusto.ResumeLayout(false);
            this.pCentroCusto.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblSuc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCentroCusto;
        private System.Windows.Forms.PictureBox btnNovaSubCategoria;
        private System.Windows.Forms.ComboBox cbSubCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pSubCategoria;
        private System.Windows.Forms.TextBox txtSubCategoria;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSaveSubCategoria;
        private System.Windows.Forms.Panel pCategoria;
        private System.Windows.Forms.Button btnSaveCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel pCentroCusto;
        private System.Windows.Forms.Button btnSaveCC;
        private System.Windows.Forms.TextBox txtCentroCusto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}