namespace ConversorParaBinario
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
      this.tbValor = new System.Windows.Forms.TextBox();
      this.btnConverter = new System.Windows.Forms.Button();
      this.lblConverterPara = new System.Windows.Forms.Label();
      this.cbBaseDoValor = new System.Windows.Forms.ComboBox();
      this.cbConverterPara = new System.Windows.Forms.ComboBox();
      this.lblBaseDoValor = new System.Windows.Forms.Label();
      this.gbBaseNumerica = new System.Windows.Forms.GroupBox();
      this.gbResultado = new System.Windows.Forms.GroupBox();
      this.lblResult = new System.Windows.Forms.Label();
      this.btnLimpar = new System.Windows.Forms.Button();
      this.gbValor = new System.Windows.Forms.GroupBox();
      this.gbBaseNumerica.SuspendLayout();
      this.gbResultado.SuspendLayout();
      this.gbValor.SuspendLayout();
      this.SuspendLayout();
      // 
      // tbValor
      // 
      this.tbValor.Location = new System.Drawing.Point(11, 17);
      this.tbValor.Name = "tbValor";
      this.tbValor.Size = new System.Drawing.Size(204, 20);
      this.tbValor.TabIndex = 0;
      this.tbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValor_KeyPress);
      // 
      // btnConverter
      // 
      this.btnConverter.Location = new System.Drawing.Point(221, 45);
      this.btnConverter.Name = "btnConverter";
      this.btnConverter.Size = new System.Drawing.Size(61, 23);
      this.btnConverter.TabIndex = 2;
      this.btnConverter.Text = "Converter";
      this.btnConverter.UseVisualStyleBackColor = true;
      this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
      // 
      // lblConverterPara
      // 
      this.lblConverterPara.Location = new System.Drawing.Point(8, 50);
      this.lblConverterPara.Name = "lblConverterPara";
      this.lblConverterPara.Size = new System.Drawing.Size(77, 13);
      this.lblConverterPara.TabIndex = 4;
      this.lblConverterPara.Text = "Converter para";
      this.lblConverterPara.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // cbBaseDoValor
      // 
      this.cbBaseDoValor.FormattingEnabled = true;
      this.cbBaseDoValor.Location = new System.Drawing.Point(88, 20);
      this.cbBaseDoValor.Name = "cbBaseDoValor";
      this.cbBaseDoValor.Size = new System.Drawing.Size(113, 21);
      this.cbBaseDoValor.TabIndex = 0;
      // 
      // cbConverterPara
      // 
      this.cbConverterPara.FormattingEnabled = true;
      this.cbConverterPara.Location = new System.Drawing.Point(88, 47);
      this.cbConverterPara.Name = "cbConverterPara";
      this.cbConverterPara.Size = new System.Drawing.Size(113, 21);
      this.cbConverterPara.TabIndex = 1;
      // 
      // lblBaseDoValor
      // 
      this.lblBaseDoValor.Location = new System.Drawing.Point(13, 23);
      this.lblBaseDoValor.Name = "lblBaseDoValor";
      this.lblBaseDoValor.Size = new System.Drawing.Size(72, 13);
      this.lblBaseDoValor.TabIndex = 3;
      this.lblBaseDoValor.Text = "Base do valor";
      this.lblBaseDoValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // gbBaseNumerica
      // 
      this.gbBaseNumerica.Controls.Add(this.cbConverterPara);
      this.gbBaseNumerica.Controls.Add(this.lblBaseDoValor);
      this.gbBaseNumerica.Controls.Add(this.lblConverterPara);
      this.gbBaseNumerica.Controls.Add(this.cbBaseDoValor);
      this.gbBaseNumerica.Controls.Add(this.btnConverter);
      this.gbBaseNumerica.Location = new System.Drawing.Point(12, 61);
      this.gbBaseNumerica.Name = "gbBaseNumerica";
      this.gbBaseNumerica.Size = new System.Drawing.Size(292, 78);
      this.gbBaseNumerica.TabIndex = 1;
      this.gbBaseNumerica.TabStop = false;
      this.gbBaseNumerica.Text = "Bases Numéricas";
      // 
      // gbResultado
      // 
      this.gbResultado.Controls.Add(this.lblResult);
      this.gbResultado.Controls.Add(this.btnLimpar);
      this.gbResultado.Location = new System.Drawing.Point(12, 143);
      this.gbResultado.Name = "gbResultado";
      this.gbResultado.Size = new System.Drawing.Size(292, 54);
      this.gbResultado.TabIndex = 2;
      this.gbResultado.TabStop = false;
      this.gbResultado.Text = "Resultado";
      // 
      // lblResult
      // 
      this.lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblResult.Location = new System.Drawing.Point(11, 20);
      this.lblResult.Name = "lblResult";
      this.lblResult.Size = new System.Drawing.Size(204, 20);
      this.lblResult.TabIndex = 0;
      this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // btnLimpar
      // 
      this.btnLimpar.Location = new System.Drawing.Point(221, 19);
      this.btnLimpar.Name = "btnLimpar";
      this.btnLimpar.Size = new System.Drawing.Size(61, 23);
      this.btnLimpar.TabIndex = 1;
      this.btnLimpar.Text = "Limpar";
      this.btnLimpar.UseVisualStyleBackColor = true;
      // 
      // gbValor
      // 
      this.gbValor.Controls.Add(this.tbValor);
      this.gbValor.Location = new System.Drawing.Point(12, 6);
      this.gbValor.Name = "gbValor";
      this.gbValor.Size = new System.Drawing.Size(291, 50);
      this.gbValor.TabIndex = 0;
      this.gbValor.TabStop = false;
      this.gbValor.Text = "Valor";
      // 
      // FormPrincipal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(315, 207);
      this.Controls.Add(this.gbValor);
      this.Controls.Add(this.gbResultado);
      this.Controls.Add(this.gbBaseNumerica);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormPrincipal";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Conversor de Bases Numéricas";
      this.gbBaseNumerica.ResumeLayout(false);
      this.gbResultado.ResumeLayout(false);
      this.gbValor.ResumeLayout(false);
      this.gbValor.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblConverterPara;
        private System.Windows.Forms.ComboBox cbBaseDoValor;
        private System.Windows.Forms.ComboBox cbConverterPara;
        private System.Windows.Forms.Label lblBaseDoValor;
        private System.Windows.Forms.GroupBox gbBaseNumerica;
    private System.Windows.Forms.GroupBox gbResultado;
    private System.Windows.Forms.Label lblResult;
    private System.Windows.Forms.Button btnLimpar;
    private System.Windows.Forms.GroupBox gbValor;
  }
}

