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
            this.lblValor = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblConverterPara = new System.Windows.Forms.Label();
            this.cbBaseDoValor = new System.Windows.Forms.ComboBox();
            this.cbConverterPara = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblBaseDoValor = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.Location = new System.Drawing.Point(49, 31);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(42, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(100, 31);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(119, 20);
            this.tbValor.TabIndex = 0;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(195, 125);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 3;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblConverterPara
            // 
            this.lblConverterPara.Location = new System.Drawing.Point(14, 97);
            this.lblConverterPara.Name = "lblConverterPara";
            this.lblConverterPara.Size = new System.Drawing.Size(77, 13);
            this.lblConverterPara.TabIndex = 4;
            this.lblConverterPara.Text = "Converter para";
            this.lblConverterPara.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbBaseDoValor
            // 
            this.cbBaseDoValor.FormattingEnabled = true;
            this.cbBaseDoValor.Location = new System.Drawing.Point(100, 57);
            this.cbBaseDoValor.Name = "cbBaseDoValor";
            this.cbBaseDoValor.Size = new System.Drawing.Size(97, 21);
            this.cbBaseDoValor.TabIndex = 1;
            // 
            // cbConverterPara
            // 
            this.cbConverterPara.FormattingEnabled = true;
            this.cbConverterPara.Location = new System.Drawing.Point(100, 89);
            this.cbConverterPara.Name = "cbConverterPara";
            this.cbConverterPara.Size = new System.Drawing.Size(97, 21);
            this.cbConverterPara.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(195, 209);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblBaseDoValor
            // 
            this.lblBaseDoValor.Location = new System.Drawing.Point(19, 65);
            this.lblBaseDoValor.Name = "lblBaseDoValor";
            this.lblBaseDoValor.Size = new System.Drawing.Size(72, 13);
            this.lblBaseDoValor.TabIndex = 3;
            this.lblBaseDoValor.Text = "Base do valor";
            this.lblBaseDoValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(97, 163);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(122, 20);
            this.lblResult.TabIndex = 10;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 256);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbConverterPara);
            this.Controls.Add(this.cbBaseDoValor);
            this.Controls.Add(this.lblConverterPara);
            this.Controls.Add(this.lblBaseDoValor);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.lblValor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblConverterPara;
        private System.Windows.Forms.ComboBox cbBaseDoValor;
        private System.Windows.Forms.ComboBox cbConverterPara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblBaseDoValor;
        private System.Windows.Forms.Label lblResult;
    }
}

