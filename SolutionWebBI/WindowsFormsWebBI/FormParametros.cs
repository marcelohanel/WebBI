using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsWebBI
{
    public partial class FormParametros : Form
    {
        ClassWebBI.Dados.ClassParametros clParametros = new ClassWebBI.Dados.ClassParametros();

        public FormParametros()
        {
            InitializeComponent();
        }

        private void Inicializa()
        {
            clParametros.getParametro();

            edtDtLimiteAtualizacao.Value = clParametros.fdt_limite_atualizacao;
            edtAssunto.Text = clParametros.fmail_assunto;
            edtMensagem.Text = clParametros.fmail_mensagem;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            clParametros.fdt_limite_atualizacao = edtDtLimiteAtualizacao.Value;
            clParametros.fmail_assunto = edtAssunto.Text;
            clParametros.fmail_mensagem = edtMensagem.Text;

            clParametros.setParametro();

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormParametros_Shown(object sender, EventArgs e)
        {
            Inicializa();
        }
    }
}
