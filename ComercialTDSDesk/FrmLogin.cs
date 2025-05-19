using ComercialTDSClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialTDSDesk
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnCancelar.Text == "&Voltar")
                Close();
            else
                Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Program.UsuarioLogado = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);

            if (Program.UsuarioLogado.Id > 0)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Email e/ou Senha invalidos ou \n " +
                    "usuario não cadastrado!");
                txtEmail.Focus();
                txtEmail.SelectAll();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
