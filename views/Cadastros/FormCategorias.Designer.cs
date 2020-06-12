namespace views
{
    partial class FormCategorias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategorias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.lblSuc = new System.Windows.Forms.Label();
            this.pTipo = new System.Windows.Forms.Panel();
            this.btnNovaSubCategoria = new System.Windows.Forms.PictureBox();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCentroCusto = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pProduct = new System.Windows.Forms.Panel();
            this.pSubCategoria = new System.Windows.Forms.Panel();
            this.btnOk = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSubCategoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pCadastros = new System.Windows.Forms.Panel();
            this.dgvCadastros = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.pTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovaSubCategoria)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pProduct.SuspendLayout();
            this.pSubCategoria.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pCadastros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(108, 303);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 24);
            this.label8.TabIndex = 152;
            this.label8.Text = "cadastro";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 365);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(288, 44);
            this.label9.TabIndex = 157;
            this.label9.Text = "#CATEGORIAS";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.lblSuc);
            this.panel1.Controls.Add(this.pTipo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pProduct);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(100, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 715);
            this.panel1.TabIndex = 158;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Image = global::views.Properties.Resources.report_min;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(21, 687);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(234, 20);
            this.lblError.TabIndex = 183;
            this.lblError.Text = "         erro ao fazer o login";
            this.lblError.Visible = false;
            // 
            // lblSuc
            // 
            this.lblSuc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSuc.AutoSize = true;
            this.lblSuc.BackColor = System.Drawing.Color.Transparent;
            this.lblSuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(175)))), ((int)(((byte)(115)))));
            this.lblSuc.Image = global::views.Properties.Resources.sucesso;
            this.lblSuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSuc.Location = new System.Drawing.Point(21, 687);
            this.lblSuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuc.Name = "lblSuc";
            this.lblSuc.Size = new System.Drawing.Size(278, 20);
            this.lblSuc.TabIndex = 184;
            this.lblSuc.Text = "         erro ao cadastrar produto";
            this.lblSuc.Visible = false;
            // 
            // pTipo
            // 
            this.pTipo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pTipo.Controls.Add(this.btnNovaSubCategoria);
            this.pTipo.Controls.Add(this.cbSubCategoria);
            this.pTipo.Controls.Add(this.label2);
            this.pTipo.Controls.Add(this.label1);
            this.pTipo.Controls.Add(this.cbCentroCusto);
            this.pTipo.Controls.Add(this.btnSalvar);
            this.pTipo.Controls.Add(this.panel4);
            this.pTipo.Controls.Add(this.txtCategoria);
            this.pTipo.Controls.Add(this.panel3);
            this.pTipo.Controls.Add(this.label12);
            this.pTipo.Location = new System.Drawing.Point(21, 366);
            this.pTipo.Name = "pTipo";
            this.pTipo.Size = new System.Drawing.Size(437, 318);
            this.pTipo.TabIndex = 173;
            // 
            // btnNovaSubCategoria
            // 
            this.btnNovaSubCategoria.Image = global::views.Properties.Resources.add__lista;
            this.btnNovaSubCategoria.Location = new System.Drawing.Point(372, 222);
            this.btnNovaSubCategoria.Name = "btnNovaSubCategoria";
            this.btnNovaSubCategoria.Size = new System.Drawing.Size(34, 33);
            this.btnNovaSubCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnNovaSubCategoria.TabIndex = 182;
            this.btnNovaSubCategoria.TabStop = false;
            this.btnNovaSubCategoria.Click += new System.EventHandler(this.btnNovaSubCategoria_Click);
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSubCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.cbSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Location = new System.Drawing.Point(14, 222);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(352, 33);
            this.cbSubCategoria.TabIndex = 181;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 180;
            this.label2.Text = "Sub Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 179;
            this.label1.Text = "Centro de Custo";
            // 
            // cbCentroCusto
            // 
            this.cbCentroCusto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCentroCusto.BackColor = System.Drawing.SystemColors.Control;
            this.cbCentroCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCentroCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCentroCusto.FormattingEnabled = true;
            this.cbCentroCusto.Location = new System.Drawing.Point(12, 72);
            this.cbCentroCusto.Name = "cbCentroCusto";
            this.cbCentroCusto.Size = new System.Drawing.Size(391, 33);
            this.cbCentroCusto.TabIndex = 178;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.BorderRadius = 0;
            this.btnSalvar.ButtonText = "SALVAR";
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalvar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalvar.Iconimage = global::views.Properties.Resources.save;
            this.btnSalvar.Iconimage_right = null;
            this.btnSalvar.Iconimage_right_Selected = null;
            this.btnSalvar.Iconimage_Selected = null;
            this.btnSalvar.IconMarginLeft = 0;
            this.btnSalvar.IconMarginRight = 0;
            this.btnSalvar.IconRightVisible = false;
            this.btnSalvar.IconRightZoom = 0D;
            this.btnSalvar.IconVisible = true;
            this.btnSalvar.IconZoom = 30D;
            this.btnSalvar.IsTab = false;
            this.btnSalvar.Location = new System.Drawing.Point(13, 262);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSalvar.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSalvar.selected = false;
            this.btnSalvar.Size = new System.Drawing.Size(127, 44);
            this.btnSalvar.TabIndex = 177;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Textcolor = System.Drawing.Color.Gray;
            this.btnSalvar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(437, 10);
            this.panel4.TabIndex = 175;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCategoria.Location = new System.Drawing.Point(12, 143);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(391, 36);
            this.txtCategoria.TabIndex = 168;
            this.txtCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCadastro_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 37);
            this.panel3.TabIndex = 174;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::views.Properties.Resources.arrow_top;
            this.pictureBox5.Location = new System.Drawing.Point(7, 17);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(10, 119);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 167;
            this.label12.Text = "Categoria";
            // 
            // pProduct
            // 
            this.pProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pProduct.Controls.Add(this.pSubCategoria);
            this.pProduct.Controls.Add(this.pCadastros);
            this.pProduct.Location = new System.Drawing.Point(221, 48);
            this.pProduct.Margin = new System.Windows.Forms.Padding(4);
            this.pProduct.Name = "pProduct";
            this.pProduct.Size = new System.Drawing.Size(1028, 639);
            this.pProduct.TabIndex = 2;
            // 
            // pSubCategoria
            // 
            this.pSubCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pSubCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pSubCategoria.Controls.Add(this.btnOk);
            this.pSubCategoria.Controls.Add(this.txtSubCategoria);
            this.pSubCategoria.Controls.Add(this.label5);
            this.pSubCategoria.Controls.Add(this.panel6);
            this.pSubCategoria.Location = new System.Drawing.Point(235, 440);
            this.pSubCategoria.Name = "pSubCategoria";
            this.pSubCategoria.Size = new System.Drawing.Size(312, 134);
            this.pSubCategoria.TabIndex = 174;
            this.pSubCategoria.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.BorderRadius = 0;
            this.btnOk.ButtonText = "SALVAR";
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.DisabledColor = System.Drawing.Color.Gray;
            this.btnOk.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOk.Iconimage = global::views.Properties.Resources.save;
            this.btnOk.Iconimage_right = null;
            this.btnOk.Iconimage_right_Selected = null;
            this.btnOk.Iconimage_Selected = null;
            this.btnOk.IconMarginLeft = 0;
            this.btnOk.IconMarginRight = 0;
            this.btnOk.IconRightVisible = false;
            this.btnOk.IconRightZoom = 0D;
            this.btnOk.IconVisible = true;
            this.btnOk.IconZoom = 30D;
            this.btnOk.IsTab = false;
            this.btnOk.Location = new System.Drawing.Point(52, 95);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnOk.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnOk.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnOk.selected = false;
            this.btnOk.Size = new System.Drawing.Size(127, 34);
            this.btnOk.TabIndex = 183;
            this.btnOk.Text = "SALVAR";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.Textcolor = System.Drawing.Color.Gray;
            this.btnOk.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtSubCategoria
            // 
            this.txtSubCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSubCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSubCategoria.Location = new System.Drawing.Point(52, 38);
            this.txtSubCategoria.Name = "txtSubCategoria";
            this.txtSubCategoria.Size = new System.Drawing.Size(240, 36);
            this.txtSubCategoria.TabIndex = 176;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(54, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 175;
            this.label5.Text = "Sub Categoria";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(28, 134);
            this.panel6.TabIndex = 174;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::views.Properties.Resources.arrow_left;
            this.pictureBox1.Location = new System.Drawing.Point(6, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pCadastros
            // 
            this.pCadastros.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pCadastros.BackColor = System.Drawing.Color.Gainsboro;
            this.pCadastros.Controls.Add(this.dgvCadastros);
            this.pCadastros.Controls.Add(this.label4);
            this.pCadastros.Location = new System.Drawing.Point(299, 94);
            this.pCadastros.Name = "pCadastros";
            this.pCadastros.Size = new System.Drawing.Size(672, 542);
            this.pCadastros.TabIndex = 179;
            // 
            // dgvCadastros
            // 
            this.dgvCadastros.AllowUserToAddRows = false;
            this.dgvCadastros.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCadastros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCadastros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCadastros.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvCadastros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCadastros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCadastros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCadastros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCadastros.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCadastros.DoubleBuffered = true;
            this.dgvCadastros.EnableHeadersVisualStyles = false;
            this.dgvCadastros.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvCadastros.HeaderBgColor = System.Drawing.Color.Gainsboro;
            this.dgvCadastros.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvCadastros.Location = new System.Drawing.Point(24, 62);
            this.dgvCadastros.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCadastros.MultiSelect = false;
            this.dgvCadastros.Name = "dgvCadastros";
            this.dgvCadastros.ReadOnly = true;
            this.dgvCadastros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCadastros.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCadastros.RowHeadersVisible = false;
            this.dgvCadastros.RowHeadersWidth = 62;
            this.dgvCadastros.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvCadastros.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.dgvCadastros.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCadastros.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.dgvCadastros.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCadastros.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCadastros.RowTemplate.Height = 40;
            this.dgvCadastros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCadastros.Size = new System.Drawing.Size(624, 374);
            this.dgvCadastros.TabIndex = 159;
            this.dgvCadastros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadastros_CellClick);
            // 
            // delete
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.delete.DefaultCellStyle = dataGridViewCellStyle3;
            this.delete.HeaderText = "";
            this.delete.Image = global::views.Properties.Resources.cancel;
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.ToolTipText = "Excluir";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(20, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 157;
            this.label4.Text = "#CADASTRADOS";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1270, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 143;
            this.btnClose.TabStop = false;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImageColumn1.HeaderText = "Excluir";
            this.dataGridViewImageColumn1.Image = global::views.Properties.Resources.cancel;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.ToolTipText = "Excluir";
            this.dataGridViewImageColumn1.Width = 623;
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1418, 788);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTipoEntrada";
            this.Load += new System.EventHandler(this.FormCategorias_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pTipo.ResumeLayout(false);
            this.pTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovaSubCategoria)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pProduct.ResumeLayout(false);
            this.pSubCategoria.ResumeLayout(false);
            this.pSubCategoria.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pCadastros.ResumeLayout(false);
            this.pCadastros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pProduct;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel pTipo;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalvar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pCadastros;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCadastros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCentroCusto;
        private System.Windows.Forms.ComboBox cbSubCategoria;
        private System.Windows.Forms.PictureBox btnNovaSubCategoria;
        private System.Windows.Forms.Panel pSubCategoria;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnOk;
        private System.Windows.Forms.TextBox txtSubCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblSuc;
    }
}