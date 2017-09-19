namespace WindowsFormsWebBI
{
    partial class FormParametros
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edtMensagem = new System.Windows.Forms.TextBox();
            this.edtAssunto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edtDtLimiteAtualizacao = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(563, 468);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(644, 468);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.edtMensagem);
            this.panel1.Controls.Add(this.edtAssunto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.edtDtLimiteAtualizacao);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 450);
            this.panel1.TabIndex = 0;
            // 
            // edtMensagem
            // 
            this.edtMensagem.Location = new System.Drawing.Point(133, 81);
            this.edtMensagem.MaxLength = 100;
            this.edtMensagem.Multiline = true;
            this.edtMensagem.Name = "edtMensagem";
            this.edtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.edtMensagem.Size = new System.Drawing.Size(553, 339);
            this.edtMensagem.TabIndex = 4;
            // 
            // edtAssunto
            // 
            this.edtAssunto.Location = new System.Drawing.Point(133, 55);
            this.edtAssunto.MaxLength = 100;
            this.edtAssunto.Name = "edtAssunto";
            this.edtAssunto.Size = new System.Drawing.Size(553, 20);
            this.edtAssunto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mensagem E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Assunto E-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dt. Limite Atualização:";
            // 
            // edtDtLimiteAtualizacao
            // 
            this.edtDtLimiteAtualizacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edtDtLimiteAtualizacao.Location = new System.Drawing.Point(133, 29);
            this.edtDtLimiteAtualizacao.Name = "edtDtLimiteAtualizacao";
            this.edtDtLimiteAtualizacao.Size = new System.Drawing.Size(103, 20);
            this.edtDtLimiteAtualizacao.TabIndex = 2;
            // 
            // FormParametros
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(731, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormParametros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parâmetros";
            this.Shown += new System.EventHandler(this.FormParametros_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker edtDtLimiteAtualizacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtMensagem;
        private System.Windows.Forms.TextBox edtAssunto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}