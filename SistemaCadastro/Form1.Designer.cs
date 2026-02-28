namespace SistemaCadastro
{
    partial class frmCadastro
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
            this.fra = new System.Windows.Forms.GroupBox();
            this.cmdLimpar = new System.Windows.Forms.Button();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmdCadastro = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.fraGenero = new System.Windows.Forms.GroupBox();
            this.optOutro = new System.Windows.Forms.RadioButton();
            this.optNoInformation = new System.Windows.Forms.RadioButton();
            this.optNaoBinario = new System.Windows.Forms.RadioButton();
            this.optMulher = new System.Windows.Forms.RadioButton();
            this.optHomem = new System.Windows.Forms.RadioButton();
            this.chkPossuiVeiculo = new System.Windows.Forms.CheckBox();
            this.chkCasa = new System.Windows.Forms.CheckBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fra.SuspendLayout();
            this.fraGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // fra
            // 
            this.fra.Controls.Add(this.cmdLimpar);
            this.fra.Controls.Add(this.cmdExcluir);
            this.fra.Controls.Add(this.cmdCadastro);
            this.fra.Controls.Add(this.lista);
            this.fra.Controls.Add(this.fraGenero);
            this.fra.Controls.Add(this.chkPossuiVeiculo);
            this.fra.Controls.Add(this.chkCasa);
            this.fra.Controls.Add(this.txtTelefone);
            this.fra.Controls.Add(this.cboEstadoCivil);
            this.fra.Controls.Add(this.txtData);
            this.fra.Controls.Add(this.txtNome);
            this.fra.Controls.Add(this.label4);
            this.fra.Controls.Add(this.label3);
            this.fra.Controls.Add(this.label2);
            this.fra.Controls.Add(this.label1);
            this.fra.Location = new System.Drawing.Point(12, 12);
            this.fra.Name = "fra";
            this.fra.Size = new System.Drawing.Size(569, 386);
            this.fra.TabIndex = 12;
            this.fra.TabStop = false;
            // 
            // cmdLimpar
            // 
            this.cmdLimpar.Location = new System.Drawing.Point(438, 308);
            this.cmdLimpar.Name = "cmdLimpar";
            this.cmdLimpar.Size = new System.Drawing.Size(125, 24);
            this.cmdLimpar.TabIndex = 26;
            this.cmdLimpar.Text = "Limpar";
            this.cmdLimpar.UseVisualStyleBackColor = true;
            this.cmdLimpar.Click += new System.EventHandler(this.cmdLimpar_Click);
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.Location = new System.Drawing.Point(140, 308);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(125, 24);
            this.cmdExcluir.TabIndex = 25;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdCadastro
            // 
            this.cmdCadastro.Location = new System.Drawing.Point(9, 307);
            this.cmdCadastro.Name = "cmdCadastro";
            this.cmdCadastro.Size = new System.Drawing.Size(125, 24);
            this.cmdCadastro.TabIndex = 24;
            this.cmdCadastro.Text = "Cadastrar / Alterar";
            this.cmdCadastro.UseVisualStyleBackColor = true;
            this.cmdCadastro.Click += new System.EventHandler(this.cmdCadastro_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(9, 337);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(554, 43);
            this.lista.TabIndex = 23;
            this.lista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lista_MouseDoubleClick);
            // 
            // fraGenero
            // 
            this.fraGenero.Controls.Add(this.optOutro);
            this.fraGenero.Controls.Add(this.optNoInformation);
            this.fraGenero.Controls.Add(this.optNaoBinario);
            this.fraGenero.Controls.Add(this.optMulher);
            this.fraGenero.Controls.Add(this.optHomem);
            this.fraGenero.Location = new System.Drawing.Point(139, 198);
            this.fraGenero.Name = "fraGenero";
            this.fraGenero.Size = new System.Drawing.Size(239, 104);
            this.fraGenero.TabIndex = 22;
            this.fraGenero.TabStop = false;
            this.fraGenero.Text = "Genero";
            // 
            // optOutro
            // 
            this.optOutro.AutoSize = true;
            this.optOutro.Location = new System.Drawing.Point(115, 27);
            this.optOutro.Name = "optOutro";
            this.optOutro.Size = new System.Drawing.Size(51, 17);
            this.optOutro.TabIndex = 4;
            this.optOutro.TabStop = true;
            this.optOutro.Text = "Outro";
            this.optOutro.UseVisualStyleBackColor = true;
            // 
            // optNoInformation
            // 
            this.optNoInformation.AutoSize = true;
            this.optNoInformation.Location = new System.Drawing.Point(115, 50);
            this.optNoInformation.Name = "optNoInformation";
            this.optNoInformation.Size = new System.Drawing.Size(116, 17);
            this.optNoInformation.TabIndex = 3;
            this.optNoInformation.TabStop = true;
            this.optNoInformation.Text = "Prefiro não informar";
            this.optNoInformation.UseVisualStyleBackColor = true;
            // 
            // optNaoBinario
            // 
            this.optNaoBinario.AutoSize = true;
            this.optNaoBinario.Location = new System.Drawing.Point(14, 73);
            this.optNaoBinario.Name = "optNaoBinario";
            this.optNaoBinario.Size = new System.Drawing.Size(80, 17);
            this.optNaoBinario.TabIndex = 2;
            this.optNaoBinario.TabStop = true;
            this.optNaoBinario.Text = "Nao Binario";
            this.optNaoBinario.UseVisualStyleBackColor = true;
            // 
            // optMulher
            // 
            this.optMulher.AutoSize = true;
            this.optMulher.Location = new System.Drawing.Point(14, 50);
            this.optMulher.Name = "optMulher";
            this.optMulher.Size = new System.Drawing.Size(57, 17);
            this.optMulher.TabIndex = 1;
            this.optMulher.TabStop = true;
            this.optMulher.Text = "Mulher";
            this.optMulher.UseVisualStyleBackColor = true;
            // 
            // optHomem
            // 
            this.optHomem.AutoSize = true;
            this.optHomem.Checked = true;
            this.optHomem.Location = new System.Drawing.Point(16, 27);
            this.optHomem.Name = "optHomem";
            this.optHomem.Size = new System.Drawing.Size(61, 17);
            this.optHomem.TabIndex = 0;
            this.optHomem.TabStop = true;
            this.optHomem.Text = "Homem";
            this.optHomem.UseVisualStyleBackColor = true;
            // 
            // chkPossuiVeiculo
            // 
            this.chkPossuiVeiculo.AutoSize = true;
            this.chkPossuiVeiculo.Location = new System.Drawing.Point(139, 175);
            this.chkPossuiVeiculo.Name = "chkPossuiVeiculo";
            this.chkPossuiVeiculo.Size = new System.Drawing.Size(95, 17);
            this.chkPossuiVeiculo.TabIndex = 21;
            this.chkPossuiVeiculo.Text = "Possui Veiculo";
            this.chkPossuiVeiculo.UseVisualStyleBackColor = true;
            // 
            // chkCasa
            // 
            this.chkCasa.AutoSize = true;
            this.chkCasa.Location = new System.Drawing.Point(139, 152);
            this.chkCasa.Name = "chkCasa";
            this.chkCasa.Size = new System.Drawing.Size(120, 17);
            this.chkCasa.TabIndex = 20;
            this.chkCasa.Text = "Possui Casa Propria";
            this.chkCasa.UseVisualStyleBackColor = true;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(139, 114);
            this.txtTelefone.Mask = "(00)00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(124, 28);
            this.txtTelefone.TabIndex = 19;
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(139, 83);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(125, 29);
            this.cboEstadoCivil.TabIndex = 18;
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(139, 53);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(331, 28);
            this.txtData.TabIndex = 17;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(139, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(331, 28);
            this.txtNome.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Estado Civil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data Nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome";
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 410);
            this.Controls.Add(this.fra);
            this.Name = "frmCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.fra.ResumeLayout(false);
            this.fra.PerformLayout();
            this.fraGenero.ResumeLayout(false);
            this.fraGenero.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox fra;
        private System.Windows.Forms.Button cmdLimpar;
        private System.Windows.Forms.Button cmdExcluir;
        private System.Windows.Forms.Button cmdCadastro;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.GroupBox fraGenero;
        private System.Windows.Forms.RadioButton optOutro;
        private System.Windows.Forms.RadioButton optNoInformation;
        private System.Windows.Forms.RadioButton optNaoBinario;
        private System.Windows.Forms.RadioButton optMulher;
        private System.Windows.Forms.RadioButton optHomem;
        private System.Windows.Forms.CheckBox chkPossuiVeiculo;
        private System.Windows.Forms.CheckBox chkCasa;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.ComboBox cboEstadoCivil;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

