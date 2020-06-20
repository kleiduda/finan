namespace views
{
    partial class FormEntradaDC
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
            this.pProduct = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtParcelas = new System.Windows.Forms.TextBox();
            this.lblSaldoAnterior = new System.Windows.Forms.Label();
            this.chkRecorrencia = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblSaldoFinal = new System.Windows.Forms.Label();
            this.cbPagamento = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblSuc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateEntrada = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.cbTipoEntrada = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pButtons = new System.Windows.Forms.Panel();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbRecorrencia = new System.Windows.Forms.ComboBox();
            this.pRecorrencia = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pProduct.SuspendLayout();
            this.pButtons.SuspendLayout();
            this.pRecorrencia.SuspendLayout();
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
            // pProduct
            // 
            this.pProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pProduct.Controls.Add(this.pRecorrencia);
            this.pProduct.Controls.Add(this.lblSaldoAnterior);
            this.pProduct.Controls.Add(this.chkRecorrencia);
            this.pProduct.Controls.Add(this.lblSaldoFinal);
            this.pProduct.Controls.Add(this.cbPagamento);
            this.pProduct.Controls.Add(this.lblError);
            this.pProduct.Controls.Add(this.lblSuc);
            this.pProduct.Controls.Add(this.label2);
            this.pProduct.Controls.Add(this.label4);
            this.pProduct.Controls.Add(this.label3);
            this.pProduct.Controls.Add(this.dateEntrada);
            this.pProduct.Controls.Add(this.label1);
            this.pProduct.Controls.Add(this.txtValor);
            this.pProduct.Controls.Add(this.label10);
            this.pProduct.Controls.Add(this.txtObservacao);
            this.pProduct.Controls.Add(this.cbTipoEntrada);
            this.pProduct.Controls.Add(this.label7);
            this.pProduct.Location = new System.Drawing.Point(25, 21);
            this.pProduct.Margin = new System.Windows.Forms.Padding(4);
            this.pProduct.Name = "pProduct";
            this.pProduct.Size = new System.Drawing.Size(1363, 667);
            this.pProduct.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(11, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 14);
            this.label5.TabIndex = 169;
            this.label5.Text = "Parcelas";
            // 
            // txtParcelas
            // 
            this.txtParcelas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtParcelas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtParcelas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParcelas.Font = new System.Drawing.Font("Arial", 16F);
            this.txtParcelas.ForeColor = System.Drawing.Color.Black;
            this.txtParcelas.Location = new System.Drawing.Point(10, 95);
            this.txtParcelas.Margin = new System.Windows.Forms.Padding(4);
            this.txtParcelas.MaxLength = 150;
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Size = new System.Drawing.Size(255, 38);
            this.txtParcelas.TabIndex = 168;
            // 
            // lblSaldoAnterior
            // 
            this.lblSaldoAnterior.AutoSize = true;
            this.lblSaldoAnterior.Location = new System.Drawing.Point(151, 20);
            this.lblSaldoAnterior.Name = "lblSaldoAnterior";
            this.lblSaldoAnterior.Size = new System.Drawing.Size(92, 17);
            this.lblSaldoAnterior.TabIndex = 167;
            this.lblSaldoAnterior.Text = "saldoAnterior";
            // 
            // chkRecorrencia
            // 
            this.chkRecorrencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkRecorrencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkRecorrencia.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkRecorrencia.Checked = false;
            this.chkRecorrencia.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkRecorrencia.ForeColor = System.Drawing.Color.White;
            this.chkRecorrencia.Location = new System.Drawing.Point(427, 393);
            this.chkRecorrencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkRecorrencia.Name = "chkRecorrencia";
            this.chkRecorrencia.Size = new System.Drawing.Size(20, 20);
            this.chkRecorrencia.TabIndex = 165;
            this.chkRecorrencia.OnChange += new System.EventHandler(this.chkRecorrencia_OnChange);
            // 
            // lblSaldoFinal
            // 
            this.lblSaldoFinal.AutoSize = true;
            this.lblSaldoFinal.Location = new System.Drawing.Point(48, 20);
            this.lblSaldoFinal.Name = "lblSaldoFinal";
            this.lblSaldoFinal.Size = new System.Drawing.Size(42, 17);
            this.lblSaldoFinal.TabIndex = 166;
            this.lblSaldoFinal.Text = "saldo";
            // 
            // cbPagamento
            // 
            this.cbPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPagamento.BackColor = System.Drawing.SystemColors.Control;
            this.cbPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPagamento.FormattingEnabled = true;
            this.cbPagamento.Location = new System.Drawing.Point(51, 295);
            this.cbPagamento.Name = "cbPagamento";
            this.cbPagamento.Size = new System.Drawing.Size(405, 33);
            this.cbPagamento.TabIndex = 164;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(502, 553);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(234, 20);
            this.lblError.TabIndex = 144;
            this.lblError.Text = "         erro ao fazer o login";
            this.lblError.Visible = false;
            // 
            // lblSuc
            // 
            this.lblSuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSuc.AutoSize = true;
            this.lblSuc.BackColor = System.Drawing.Color.Transparent;
            this.lblSuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(175)))), ((int)(((byte)(115)))));
            this.lblSuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSuc.Location = new System.Drawing.Point(532, 553);
            this.lblSuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuc.Name = "lblSuc";
            this.lblSuc.Size = new System.Drawing.Size(278, 20);
            this.lblSuc.TabIndex = 145;
            this.lblSuc.Text = "         erro ao cadastrar produto";
            this.lblSuc.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(57, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 14);
            this.label2.TabIndex = 163;
            this.label2.Text = "Forma Pagamento";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(346, 396);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 14);
            this.label4.TabIndex = 162;
            this.label4.Text = "Recorrência?";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(51, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 14);
            this.label3.TabIndex = 160;
            this.label3.Text = "Data Entrada";
            // 
            // dateEntrada
            // 
            this.dateEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateEntrada.BackColor = System.Drawing.Color.Gray;
            this.dateEntrada.BorderRadius = 0;
            this.dateEntrada.ForeColor = System.Drawing.Color.White;
            this.dateEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEntrada.FormatCustom = null;
            this.dateEntrada.Location = new System.Drawing.Point(51, 116);
            this.dateEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateEntrada.Name = "dateEntrada";
            this.dateEntrada.Size = new System.Drawing.Size(405, 40);
            this.dateEntrada.TabIndex = 159;
            this.dateEntrada.Value = new System.DateTime(2020, 6, 14, 0, 0, 0, 0);
            this.dateEntrada.onValueChanged += new System.EventHandler(this.dateEntrada_onValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(55, 361);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 155;
            this.label1.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Arial", 16F);
            this.txtValor.ForeColor = System.Drawing.Color.Black;
            this.txtValor.Location = new System.Drawing.Point(51, 384);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.MaxLength = 150;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(265, 38);
            this.txtValor.TabIndex = 154;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(57, 487);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 14);
            this.label10.TabIndex = 153;
            this.label10.Text = "Detalhes da operação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservacao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.Font = new System.Drawing.Font("Arial", 16F);
            this.txtObservacao.ForeColor = System.Drawing.Color.Black;
            this.txtObservacao.Location = new System.Drawing.Point(51, 505);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacao.MaxLength = 150;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(405, 105);
            this.txtObservacao.TabIndex = 152;
            // 
            // cbTipoEntrada
            // 
            this.cbTipoEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTipoEntrada.BackColor = System.Drawing.SystemColors.Control;
            this.cbTipoEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoEntrada.FormattingEnabled = true;
            this.cbTipoEntrada.Location = new System.Drawing.Point(51, 215);
            this.cbTipoEntrada.Name = "cbTipoEntrada";
            this.cbTipoEntrada.Size = new System.Drawing.Size(405, 33);
            this.cbTipoEntrada.TabIndex = 151;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(57, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 14);
            this.label7.TabIndex = 142;
            this.label7.Text = "Tipo de Entrada";
            // 
            // pButtons
            // 
            this.pButtons.Controls.Add(this.btnNovoCadastro);
            this.pButtons.Controls.Add(this.btnEditar);
            this.pButtons.Controls.Add(this.btnCancelar);
            this.pButtons.Controls.Add(this.btnSalvar);
            this.pButtons.Location = new System.Drawing.Point(25, 695);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(1363, 81);
            this.pButtons.TabIndex = 175;
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
            this.btnNovoCadastro.Size = new System.Drawing.Size(154, 31);
            this.btnNovoCadastro.TabIndex = 162;
            this.btnNovoCadastro.Text = "LANÇAMENTO";
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
            this.btnEditar.Location = new System.Drawing.Point(897, 25);
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
            this.btnCancelar.Location = new System.Drawing.Point(1055, 25);
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
            this.btnSalvar.Location = new System.Drawing.Point(1238, 25);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(111, 31);
            this.btnSalvar.TabIndex = 165;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbRecorrencia
            // 
            this.cbRecorrencia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbRecorrencia.BackColor = System.Drawing.SystemColors.Control;
            this.cbRecorrencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRecorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRecorrencia.FormattingEnabled = true;
            this.cbRecorrencia.Location = new System.Drawing.Point(10, 24);
            this.cbRecorrencia.Name = "cbRecorrencia";
            this.cbRecorrencia.Size = new System.Drawing.Size(255, 33);
            this.cbRecorrencia.TabIndex = 170;
            // 
            // pRecorrencia
            // 
            this.pRecorrencia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pRecorrencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pRecorrencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pRecorrencia.Controls.Add(this.label6);
            this.pRecorrencia.Controls.Add(this.label5);
            this.pRecorrencia.Controls.Add(this.cbRecorrencia);
            this.pRecorrencia.Controls.Add(this.txtParcelas);
            this.pRecorrencia.Location = new System.Drawing.Point(477, 342);
            this.pRecorrencia.Name = "pRecorrencia";
            this.pRecorrencia.Size = new System.Drawing.Size(282, 149);
            this.pRecorrencia.TabIndex = 179;
            this.pRecorrencia.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(11, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 14);
            this.label6.TabIndex = 180;
            this.label6.Text = "Tipo";
            // 
            // FormEntradaDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1418, 788);
            this.Controls.Add(this.pButtons);
            this.Controls.Add(this.pProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormEntradaDC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTipoEntrada";
            this.Load += new System.EventHandler(this.FormEntradas_Load);
            this.pProduct.ResumeLayout(false);
            this.pProduct.PerformLayout();
            this.pButtons.ResumeLayout(false);
            this.pRecorrencia.ResumeLayout(false);
            this.pRecorrencia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel pProduct;
        private System.Windows.Forms.Label lblSaldoAnterior;
        private System.Windows.Forms.Label lblSaldoFinal;
        private Bunifu.Framework.UI.BunifuCheckbox chkRecorrencia;
        private System.Windows.Forms.ComboBox cbPagamento;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblSuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker dateEntrada;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.ComboBox cbTipoEntrada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtParcelas;
        private System.Windows.Forms.ComboBox cbRecorrencia;
        private System.Windows.Forms.Panel pRecorrencia;
        private System.Windows.Forms.Label label6;
    }
}