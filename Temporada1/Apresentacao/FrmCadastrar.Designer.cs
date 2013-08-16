namespace Apresentacao
{
    partial class FrmCadastrar
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
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNascimento = new System.Windows.Forms.Label();
            this.dateNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelSexo = new System.Windows.Forms.Label();
            this.radioSexoMasculino = new System.Windows.Forms.RadioButton();
            this.radioSexoFeminino = new System.Windows.Forms.RadioButton();
            this.labelLimiteDeCompra = new System.Windows.Forms.Label();
            this.textBoxLimiteCompra = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(12, 9);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Código";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(12, 25);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.ReadOnly = true;
            this.textBoxCodigo.Size = new System.Drawing.Size(51, 20);
            this.textBoxCodigo.TabIndex = 1;
            this.textBoxCodigo.TabStop = false;
            this.textBoxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 53);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 69);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(225, 20);
            this.textBoxNome.TabIndex = 3;
            // 
            // labelNascimento
            // 
            this.labelNascimento.AutoSize = true;
            this.labelNascimento.Location = new System.Drawing.Point(12, 97);
            this.labelNascimento.Name = "labelNascimento";
            this.labelNascimento.Size = new System.Drawing.Size(63, 13);
            this.labelNascimento.TabIndex = 4;
            this.labelNascimento.Text = "Nascimento";
            // 
            // dateNascimento
            // 
            this.dateNascimento.CustomFormat = "";
            this.dateNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNascimento.Location = new System.Drawing.Point(12, 113);
            this.dateNascimento.Name = "dateNascimento";
            this.dateNascimento.Size = new System.Drawing.Size(114, 20);
            this.dateNascimento.TabIndex = 5;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(12, 136);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(31, 13);
            this.labelSexo.TabIndex = 6;
            this.labelSexo.Text = "Sexo";
            // 
            // radioSexoMasculino
            // 
            this.radioSexoMasculino.AutoSize = true;
            this.radioSexoMasculino.Checked = true;
            this.radioSexoMasculino.Location = new System.Drawing.Point(12, 152);
            this.radioSexoMasculino.Name = "radioSexoMasculino";
            this.radioSexoMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioSexoMasculino.TabIndex = 7;
            this.radioSexoMasculino.TabStop = true;
            this.radioSexoMasculino.Text = "Masculino";
            this.radioSexoMasculino.UseVisualStyleBackColor = true;
            // 
            // radioSexoFeminino
            // 
            this.radioSexoFeminino.AutoSize = true;
            this.radioSexoFeminino.Location = new System.Drawing.Point(94, 152);
            this.radioSexoFeminino.Name = "radioSexoFeminino";
            this.radioSexoFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioSexoFeminino.TabIndex = 8;
            this.radioSexoFeminino.TabStop = true;
            this.radioSexoFeminino.Text = "Feminino";
            this.radioSexoFeminino.UseVisualStyleBackColor = true;
            // 
            // labelLimiteDeCompra
            // 
            this.labelLimiteDeCompra.AutoSize = true;
            this.labelLimiteDeCompra.Location = new System.Drawing.Point(12, 176);
            this.labelLimiteDeCompra.Name = "labelLimiteDeCompra";
            this.labelLimiteDeCompra.Size = new System.Drawing.Size(88, 13);
            this.labelLimiteDeCompra.TabIndex = 9;
            this.labelLimiteDeCompra.Text = "Limite de Compra";
            // 
            // textBoxLimiteCompra
            // 
            this.textBoxLimiteCompra.Location = new System.Drawing.Point(12, 192);
            this.textBoxLimiteCompra.Name = "textBoxLimiteCompra";
            this.textBoxLimiteCompra.Size = new System.Drawing.Size(117, 20);
            this.textBoxLimiteCompra.TabIndex = 10;
            this.textBoxLimiteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(72, 234);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 11;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(162, 234);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FrmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 275);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxLimiteCompra);
            this.Controls.Add(this.labelLimiteDeCompra);
            this.Controls.Add(this.radioSexoFeminino);
            this.Controls.Add(this.radioSexoMasculino);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.dateNascimento);
            this.Controls.Add(this.labelNascimento);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNascimento;
        private System.Windows.Forms.DateTimePicker dateNascimento;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.RadioButton radioSexoMasculino;
        private System.Windows.Forms.RadioButton radioSexoFeminino;
        private System.Windows.Forms.Label labelLimiteDeCompra;
        private System.Windows.Forms.TextBox textBoxLimiteCompra;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}