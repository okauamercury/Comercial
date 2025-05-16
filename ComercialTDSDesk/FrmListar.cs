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
    public partial class FrmListar : Form
    {
        public FrmListar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Nivel nivel = new();
            var lista = Nivel.ObterLista();
            int linha = 0;
            dgvListar.Rows.Clear();

            foreach (var nivel1 in lista)
            {
                dgvListar.Rows.Add();
                dgvListar.Rows[linha].Cells[0].Value = nivel.Nome;
                dgvListar.Rows[linha].Cells[1].Value = nivel.Sigla;

                linha++;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var nivel = Nivel.ObterPorId(int.Parse(txtNome.Text));
            txtNome.Text = nivel.Nome;
            cbmNivel.SelectedValue = nivel.Sigla;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmListar_Load(object sender, EventArgs e)
        {
            var niveis = Nivel.ObterLista();
            cbmNivel.DataSource = niveis;
            cbmNivel.DisplayMember = "Nome";
            cbmNivel.ValueMember = "Id";
        }

    }
}
