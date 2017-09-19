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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            edtDtMovto.Text = DateTime.Today.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (new ClassWebBI.ClassLogin().ValidaLogin(edtUsuario.Text, edtSenha.Text, edtDtMovto.Value) == false)
            {
                MessageBox.Show("Login Inválido !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                edtUsuario.Focus();
            }
            else
            {
                this.Close();
            }
        }
    }
}
