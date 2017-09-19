namespace WindowsFormsWebBI
{
    partial class FormManExcel
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
            this.edtNomeGrupo = new System.Windows.Forms.TextBox();
            this.edtGrupo = new System.Windows.Forms.TextBox();
            this.lblGrupo = new System.Windows.Forms.LinkLabel();
            this.lblArquivo = new System.Windows.Forms.LinkLabel();
            this.edtExcel = new System.Windows.Forms.TextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.edtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.edtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.edtNomeGrupo);
            this.panel1.Controls.Add(this.edtGrupo);
            this.panel1.Controls.Add(this.lblGrupo);
            this.panel1.Controls.Add(this.lblArquivo);
            this.panel1.Controls.Add(this.edtExcel);
            this.panel1.Controls.Add(this.chkAtivo);
            this.panel1.Controls.Add(this.edtCodigo);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.edtNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 353);
            this.panel1.TabIndex = 0;
            // 
            // edtNomeGrupo
            // 
            this.edtNomeGrupo.Enabled = false;
            this.edtNomeGrupo.Location = new System.Drawing.Point(161, 183);
            this.edtNomeGrupo.MaxLength = 50;
            this.edtNomeGrupo.Name = "edtNomeGrupo";
            this.edtNomeGrupo.Size = new System.Drawing.Size(369, 20);
            this.edtNomeGrupo.TabIndex = 8;
            this.edtNomeGrupo.TabStop = false;
            // 
            // edtGrupo
            // 
            this.edtGrupo.Location = new System.Drawing.Point(70, 183);
            this.edtGrupo.MaxLength = 10;
            this.edtGrupo.Name = "edtGrupo";
            this.edtGrupo.Size = new System.Drawing.Size(85, 20);
            this.edtGrupo.TabIndex = 3;
            this.edtGrupo.Leave += new System.EventHandler(this.edtGrupo_Leave);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(30, 186);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(39, 13);
            this.lblGrupo.TabIndex = 2;
            this.lblGrupo.TabStop = true;
            this.lblGrupo.Text = "Grupo:";
            this.lblGrupo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGrupo_LinkClicked);
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Location = new System.Drawing.Point(23, 160);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(46, 13);
            this.lblArquivo.TabIndex = 1;
            this.lblArquivo.TabStop = true;
            this.lblArquivo.Text = "Arquivo:";
            this.lblArquivo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblArquivo_LinkClicked);
            // 
            // edtExcel
            // 
            this.edtExcel.Enabled = false;
            this.edtExcel.Location = new System.Drawing.Point(70, 157);
            this.edtExcel.MaxLength = 100;
            this.edtExcel.Name = "edtExcel";
            this.edtExcel.Size = new System.Drawing.Size(460, 20);
            this.edtExcel.TabIndex = 5;
            this.edtExcel.TabStop = false;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Location = new System.Drawing.Point(70, 209);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 4;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // edtCodigo
            // 
            this.edtCodigo.Location = new System.Drawing.Point(70, 105);
            this.edtCodigo.Mask = "00000";
            this.edtCodigo.Name = "edtCodigo";
            this.edtCodigo.PromptChar = ' ';
            this.edtCodigo.Size = new System.Drawing.Size(50, 20);
            this.edtCodigo.TabIndex = 0;
            this.edtCodigo.Text = "1";
            this.edtCodigo.ValidatingType = typeof(int);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.Blue;
            this.lblTipo.Location = new System.Drawing.Point(7, 7);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            // 
            // edtNome
            // 
            this.edtNome.Enabled = false;
            this.edtNome.Location = new System.Drawing.Point(70, 131);
            this.edtNome.MaxLength = 100;
            this.edtNome.Name = "edtNome";
            this.edtNome.Size = new System.Drawing.Size(460, 20);
            this.edtNome.TabIndex = 1;
            this.edtNome.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(489, 371);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(408, 371);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Arquivos XLSX|*.xlsx|Arquivos XLS|*.xls";
            // 
            // FormManExcel
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(576, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormManExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção do Arquivo Excel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox edtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.MaskedTextBox edtCodigo;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.LinkLabel lblArquivo;
        private System.Windows.Forms.TextBox edtExcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox edtNomeGrupo;
        private System.Windows.Forms.TextBox edtGrupo;
        private System.Windows.Forms.LinkLabel lblGrupo;
    }
}