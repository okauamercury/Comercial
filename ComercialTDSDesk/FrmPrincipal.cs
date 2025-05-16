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
            // chamada do panel
        }
        private void AssiociaPanel(Form form)
        {
           
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.MaximizeBox = true;
            form.AutoSize = true;
            form.Size = panelCentral.Size;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(form);
            form.Show();
           
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
            AssiociaPanel(new FrmUsuario());
        }

        private void niveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
             FrmNivel frmNivel = new();
             frmNivel.MdiParent = this;
             frmNivel.Show();
            AssiociaPanel(new FrmNivel());
        }


        private void incluirToolStripMenuItem5_Click(object sender, EventArgs e)
        {
           FrmUsuario frmusuario = new();
           frmusuario.MdiParent = this;
           frmusuario.Show();
            AssiociaPanel(new FrmUsuario());
        }
    }
}
