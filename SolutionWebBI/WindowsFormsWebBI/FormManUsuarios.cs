using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsWebBI
{
    public partial class FormManUsuarios : Form
    {
        ClassWebBI.Dados.ClassUsuarios clUsuarios = new ClassWebBI.Dados.ClassUsuarios();

        public string sTipo;
        public int iCodUsuario;

        public FormManUsuarios()
        {
            InitializeComponent();
        }

        public void Inicializa()
        {
            clUsuarios.getUsuario(iCodUsuario);

            lblTipo.Text = sTipo;

            if (sTipo == "Alterar")
            {
                edtCodigo.Text = clUsuarios.fcod_usuario.ToString();
                edtNome.Text = clUsuarios.fnome;
                edtUsuario.Text = clUsuarios.fusuario;
                edtSenha.Text = clUsuarios.fsenha;
                edtConfirmar.Text = clUsuarios.fsenha;
                edtMail.Text = clUsuarios.fendereco_mail;
                chkAdministrador.Checked = clUsuarios.fadministrador;
                edtUsuarioMail.Text = clUsuarios.fusuario_mail;
                edtSenhaMail.Text = clUsuarios.fsenha_mail;
                edtServidorMail.Text = clUsuarios.fservidor_mail;
                edtPortaMail.Text = clUsuarios.fporta_mail.ToString();
                chkSSL.Checked = clUsuarios.fssl;

                edtCodigo.Enabled = false;
                edtUsuario.Enabled = false;
            }

            if (sTipo == "Incluir")
                edtCodigo.Text = Convert.ToString(clUsuarios.getMaxCodUsuario());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidaTela() == false)
                return;

            clUsuarios.fcod_usuario =  Convert.ToInt32(edtCodigo.Text);
            clUsuarios.fnome = edtNome.Text;
            clUsuarios.fusuario = edtUsuario.Text;
            clUsuarios.fsenha = edtSenha.Text;
            clUsuarios.fendereco_mail = edtMail.Text;
            clUsuarios.fadministrador = chkAdministrador.Checked;
            clUsuarios.fssl = chkSSL.Checked;
            clUsuarios.fusuario_mail = edtUsuarioMail.Text;
            clUsuarios.fsenha_mail = edtSenhaMail.Text;
            clUsuarios.fservidor_mail = edtServidorMail.Text;
            clUsuarios.fporta_mail = Convert.ToInt32(edtPortaMail.Text);

            string sAux = clUsuarios.setUsuario(sTipo);

            if (sAux != "")
            {
                MessageBox.Show(sAux, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (sTipo == "Incluir")
                    edtCodigo.Focus();
                else
                    if (sTipo == "Alterar")
                        edtNome.Focus();

                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private bool ValidaTela()
        {
            if (Convert.ToInt32(edtCodigo.Text) <= 0)
            {
                MessageBox.Show("Informe o código do usuário !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (edtNome.Text == "")
            {
                MessageBox.Show("Informe o nome do usuário !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; ;
            }

            if (edtUsuario.Text == "")
            {
                MessageBox.Show("Informe o usuário !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; ;
            }

            if (edtMail.Text == "")
            {
                MessageBox.Show("Informe o endereço de e-mail !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; ;
            }

            if (edtSenha.Text == "")
            {
                MessageBox.Show("Informe a senha do usuário !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; ;
            }

            if (edtPortaMail.Text == "")
            {
                MessageBox.Show("Informe a porta do mail ou zero para nenhuma !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; ;
            }

            if (edtSenha.Text != edtConfirmar.Text)
            {
                MessageBox.Show("A senha informada não confere com a senha de confirmação !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; ;
            }
            
            return true;
        }
    }
}
