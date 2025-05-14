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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin frmlogin = new();
            Hide();
            frmlogin.ShowDialog();
            if (Program.UsuarioLogado.Id > 0)
            {
                tsslUsuarioLogado.Text = Program.UsuarioLogado.Nome + " - " + Program.UsuarioLogado.Nivel.Nome;
            }
            Show();
        }

        private void statusStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void trocarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmlogin = new();
            frmlogin.btnCancelar.Text = "&Voltar";
            frmlogin.ShowDialog();
            tsslUsuarioLogado.Text = Program.UsuarioLogado.Nome + " - " + Program.UsuarioLogado.Nivel.Nome;

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
