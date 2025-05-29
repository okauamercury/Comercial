using ComercialTDSClass;
using Mysqlx.Crud;
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
            CarregarGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var lista = Fornecedor.ObterLista(100); // Passando um valor para o parâmetro 'limit'
            int linha = 0;

            foreach (var fornecedor in lista)
            {
                dgvFornecedor.Rows.Add();
                dgvFornecedor.Rows[linha].Cells[0].Value = fornecedor.RazaoSocial;
                dgvFornecedor.Rows[linha].Cells[1].Value = fornecedor.Cnpj;
                dgvFornecedor.Rows[linha].Cells[2].Value = fornecedor.Contato;
                dgvFornecedor.Rows[linha].Cells[3].Value = fornecedor.Fantasia;
                dgvFornecedor.Rows[linha].Cells[4].Value = fornecedor.Telefone;
                dgvFornecedor.Rows[linha].Cells[5].Value = fornecedor.Email;

                linha++;
            }
            dgvFornecedor.Rows.Clear();
        }
        private void CarregarGrid()
        {
            var lista = Fornecedor.ObterLista(100); // Passando um valor para o parâmetro 'limit'
            int linha = 0;

            foreach (var fornecedor in lista)
            {
                dgvFornecedor.Rows.Add();
                dgvFornecedor.Rows[linha].Cells[0].Value = fornecedor.RazaoSocial;
                dgvFornecedor.Rows[linha].Cells[1].Value = fornecedor.Cnpj;
                dgvFornecedor.Rows[linha].Cells[2].Value = fornecedor.Contato;
                dgvFornecedor.Rows[linha].Cells[3].Value = fornecedor.Fantasia;
                dgvFornecedor.Rows[linha].Cells[4].Value = fornecedor.Telefone;
                dgvFornecedor.Rows[linha].Cells[5].Value = fornecedor.Email;

                linha++;
            }
            dgvFornecedor.Rows.Clear();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
           
            Fornecedor fornecedor = new(txtRazaoSocial.Text, maskCnpj.Text, txtContato.Text, txtFantasia.Text, maskTel.Text, txtEmail.Text);
            fornecedor.Inserir();
            txtRazaoSocial.Clear();
            maskCnpj.Clear();
            txtContato.Clear();
            txtFantasia.Clear();
            maskTel.Clear();
            txtEmail.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
            
            
            
            
                
               
                
                
                





