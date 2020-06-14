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
            this.txtCadastro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pButtons = new System.Windows.Forms.Panel();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCentroCusto = new System.Windows.Forms.ComboBox();
            this.btnNovaSubCategoria = new System.Windows.Forms.PictureBox();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovaSubCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(826, 44);
            this.label9.TabIndex = 157;
            this.label9.Text = "#CADASTRO CATEGORIA E SUBCATEGORIA";
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
            this.lblID.Location = new System.Drawing.Point(54, 87);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 24);
            this.lblID.TabIndex = 176;
            this.lblID.Text = "id";
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
            this.lblError.Location = new System.Drawing.Point(63, 418);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(234, 20);
            this.lblError.TabIndex = 178;
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
            this.lblSuc.Location = new System.Drawing.Point(63, 418);
            this.lblSuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuc.Name = "lblSuc";
            this.lblSuc.Size = new System.Drawing.Size(278, 20);
            this.lblSuc.TabIndex = 179;
            this.lblSuc.Text = "         erro ao cadastrar produto";
            this.lblSuc.Visible = false;
            // 
            // txtCadastro
            // 
            this.txtCadastro.BackColor = System.Drawing.Color.White;
            this.txtCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCadastro.Location = new System.Drawing.Point(58, 250);
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.Size = new System.Drawing.Size(395, 36);
            this.txtCadastro.TabIndex = 181;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(55, 220);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 180;
            this.label12.Text = "Categoria";
            // 
            // pButtons
            // 
            this.pButtons.Controls.Add(this.btnNovoCadastro);
            this.pButtons.Controls.Add(this.btnEditar);
            this.pButtons.Controls.Add(this.btnCancelar);
            this.pButtons.Controls.Add(this.btnSalvar);
            this.pButtons.Location = new System.Drawing.Point(57, 470);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(803, 81);
            this.pButtons.TabIndex = 184;
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
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::views.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(301, 25);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 31);
            this.btnEditar.TabIndex = 163;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::views.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(459, 25);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 31);
            this.btnCancelar.TabIndex = 164;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.label1.Location = new System.Drawing.Point(55, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 186;
            this.label1.Text = "Centro de Custo";
            // 
            // cbCentroCusto
            // 
            this.cbCentroCusto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCentroCusto.BackColor = System.Drawing.SystemColors.Control;
            this.cbCentroCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCentroCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCentroCusto.FormattingEnabled = true;
            this.cbCentroCusto.Location = new System.Drawing.Point(57, 169);
            this.cbCentroCusto.Name = "cbCentroCusto";
            this.cbCentroCusto.Size = new System.Drawing.Size(391, 33);
            this.cbCentroCusto.TabIndex = 185;
            // 
            // btnNovaSubCategoria
            // 
            this.btnNovaSubCategoria.Image = global::views.Properties.Resources.add__lista;
            this.btnNovaSubCategoria.Location = new System.Drawing.Point(419, 349);
            this.btnNovaSubCategoria.Name = "btnNovaSubCategoria";
            this.btnNovaSubCategoria.Size = new System.Drawing.Size(34, 33);
            this.btnNovaSubCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnNovaSubCategoria.TabIndex = 189;
            this.btnNovaSubCategoria.TabStop = false;
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSubCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.cbSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Location = new System.Drawing.Point(56, 349);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(352, 33);
            this.cbSubCategoria.TabIndex = 188;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(54, 322);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 187;
            this.label2.Text = "Sub Categoria";
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 573);
            this.Controls.Add(this.btnNovaSubCategoria);
            this.Controls.Add(this.cbSubCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCentroCusto);
            this.Controls.Add(this.pButtons);
            this.Controls.Add(this.txtCadastro);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblSuc;
        private System.Windows.Forms.TextBox txtCadastro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCentroCusto;
        private System.Windows.Forms.PictureBox btnNovaSubCategoria;
        private System.Windows.Forms.ComboBox cbSubCategoria;
        private System.Windows.Forms.Label label2;
    }
}