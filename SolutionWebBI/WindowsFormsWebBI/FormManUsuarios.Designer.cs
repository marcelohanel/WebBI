namespace WindowsFormsWebBI
{
    partial class FormManUsuarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkSSL = new System.Windows.Forms.CheckBox();
            this.edtPortaMail = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.edtServidorMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.edtSenhaMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edtUsuarioMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.chkAdministrador = new System.Windows.Forms.CheckBox();
            this.edtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edtConfirmar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edtSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.edtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkSSL);
            this.panel1.Controls.Add(this.edtPortaMail);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.edtServidorMail);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.edtSenhaMail);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.edtUsuarioMail);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.chkAdministrador);
            this.panel1.Controls.Add(this.edtMail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.edtConfirmar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.edtSenha);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.edtUsuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.edtCodigo);
            this.panel1.Controls.Add(this.edtNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 379);
            this.panel1.TabIndex = 0;
            // 
            // chkSSL
            // 
            this.chkSSL.AutoSize = true;
            this.chkSSL.Location = new System.Drawing.Point(195, 287);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(80, 17);
            this.chkSSL.TabIndex = 18;
            this.chkSSL.Text = "Utilizar SSL";
            this.chkSSL.UseVisualStyleBackColor = true;
            // 
            // edtPortaMail
            // 
            this.edtPortaMail.Location = new System.Drawing.Point(139, 285);
            this.edtPortaMail.Mask = "00000";
            this.edtPortaMail.Name = "edtPortaMail";
            this.edtPortaMail.PromptChar = ' ';
            this.edtPortaMail.Size = new System.Drawing.Size(50, 20);
            this.edtPortaMail.TabIndex = 9;
            this.edtPortaMail.Text = "25";
            this.edtPortaMail.ValidatingType = typeof(int);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Porta E-mail:";
            // 
            // edtServidorMail
            // 
            this.edtServidorMail.Location = new System.Drawing.Point(139, 259);
            this.edtServidorMail.MaxLength = 50;
            this.edtServidorMail.Name = "edtServidorMail";
            this.edtServidorMail.Size = new System.Drawing.Size(355, 20);
            this.edtServidorMail.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Servidor E-mail:";
            // 
            // edtSenhaMail
            // 
            this.edtSenhaMail.Location = new System.Drawing.Point(139, 233);
            this.edtSenhaMail.MaxLength = 50;
            this.edtSenhaMail.Name = "edtSenhaMail";
            this.edtSenhaMail.PasswordChar = '*';
            this.edtSenhaMail.Size = new System.Drawing.Size(355, 20);
            this.edtSenhaMail.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Senha E-mail:";
            // 
            // edtUsuarioMail
            // 
            this.edtUsuarioMail.Location = new System.Drawing.Point(139, 207);
            this.edtUsuarioMail.MaxLength = 50;
            this.edtUsuarioMail.Name = "edtUsuarioMail";
            this.edtUsuarioMail.Size = new System.Drawing.Size(355, 20);
            this.edtUsuarioMail.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Usuário E-mail:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.Blue;
            this.lblTipo.Location = new System.Drawing.Point(7, 7);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo";
            // 
            // chkAdministrador
            // 
            this.chkAdministrador.AutoSize = true;
            this.chkAdministrador.Location = new System.Drawing.Point(139, 311);
            this.chkAdministrador.Name = "chkAdministrador";
            this.chkAdministrador.Size = new System.Drawing.Size(89, 17);
            this.chkAdministrador.TabIndex = 10;
            this.chkAdministrador.Text = "Administrador";
            this.chkAdministrador.UseVisualStyleBackColor = true;
            // 
            // edtMail
            // 
            this.edtMail.Location = new System.Drawing.Point(139, 181);
            this.edtMail.MaxLength = 100;
            this.edtMail.Name = "edtMail";
            this.edtMail.Size = new System.Drawing.Size(355, 20);
            this.edtMail.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "E-mail:";
            // 
            // edtConfirmar
            // 
            this.edtConfirmar.Location = new System.Drawing.Point(139, 155);
            this.edtConfirmar.MaxLength = 20;
            this.edtConfirmar.Name = "edtConfirmar";
            this.edtConfirmar.PasswordChar = '*';
            this.edtConfirmar.Size = new System.Drawing.Size(155, 20);
            this.edtConfirmar.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Confirmar Senha:";
            // 
            // edtSenha
            // 
            this.edtSenha.Location = new System.Drawing.Point(139, 129);
            this.edtSenha.MaxLength = 20;
            this.edtSenha.Name = "edtSenha";
            this.edtSenha.PasswordChar = '*';
            this.edtSenha.Size = new System.Drawing.Size(155, 20);
            this.edtSenha.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Senha:";
            // 
            // edtUsuario
            // 
            this.edtUsuario.Location = new System.Drawing.Point(139, 103);
            this.edtUsuario.MaxLength = 20;
            this.edtUsuario.Name = "edtUsuario";
            this.edtUsuario.Size = new System.Drawing.Size(155, 20);
            this.edtUsuario.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuário:";
            // 
            // edtCodigo
            // 
            this.edtCodigo.Location = new System.Drawing.Point(139, 51);
            this.edtCodigo.Mask = "00000";
            this.edtCodigo.Name = "edtCodigo";
            this.edtCodigo.PromptChar = ' ';
            this.edtCodigo.Size = new System.Drawing.Size(50, 20);
            this.edtCodigo.TabIndex = 0;
            this.edtCodigo.Text = "1";
            this.edtCodigo.ValidatingType = typeof(int);
            // 
            // edtNome
            // 
            this.edtNome.Location = new System.Drawing.Point(139, 77);
            this.edtNome.MaxLength = 50;
            this.edtNome.Name = "edtNome";
            this.edtNome.Size = new System.Drawing.Size(355, 20);
            this.edtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(485, 397);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(404, 397);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FormManUsuarios
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(572, 432);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormManUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Usuários";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox edtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox edtCodigo;
        private System.Windows.Forms.CheckBox chkAdministrador;
        private System.Windows.Forms.TextBox edtMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtConfirmar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtUsuario;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox edtSenhaMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edtUsuarioMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox edtPortaMail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox edtServidorMail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkSSL;
    }
}