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
using ZstdSharp.Unsafe;

namespace ComercialTDSDesk
{
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var lista = Fornecedor.ObterPorLista();
            int linha = 0;
            dgvFornecedor.Rows.Clear();
            foreach (var item in lista)
            {
                dgvFornecedor.Rows.Add();
                dgvFornecedor.Rows[linha].Cells[0].Value = item.Id;
                dgvFornecedor.Rows[linha].Cells[1].Value = item.RazaoSocial;
                dgvFornecedor.Rows[linha].Cells[2].Value = item.Cnpj;
                dgvFornecedor.Rows[linha].Cells[3].Value = item.Fantasia;
                dgvFornecedor.Rows[linha].Cells[5].Value = item.Telefone;
                dgvFornecedor.Rows[linha].Cells[6].Value = item.Email;
                



                linha++;

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {


            Fornecedor fornecedor = new(txtRazaoSocial.Text, txtCNPJ.Text, txtFantasia.Text, txtIE.Text, txtTel.Text, txtEmail.Text);
            
            fornecedor.Inserir();
            txtRazaoSocial.Clear();
            txtCNPJ.Clear();
            txtFantasia.Clear();
            txtIE.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            
            

        }

    }
    
}
