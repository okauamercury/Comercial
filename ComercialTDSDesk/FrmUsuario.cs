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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            var niveis = Nivel.ObterLista();
            cmbNivel.DataSource = niveis;
            cmbNivel.DisplayMember = "Nome";
            cmbNivel.ValueMember = "Id";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            Usuario user = new(
                "kaua rocha",
                "kaua@gmail.com",
                "ACdb123#$",
                Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue))
             );
            user.Inserir();
        }
    }
}
