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
using System.Drawing.Imaging;
using static Mysqlx.Notice.Warning.Types;

namespace ComercialTDSDesk
{
    public partial class FrmProdutoListar : Form
    {
        public FrmProdutoListar()
        {
            InitializeComponent();
        }
        private void FrmProdutoListar_Load(object sender, EventArgs e)
        {
            var lista = Produto.ObterLista();
            int linha = 0;
            dgvProduto.Rows.Clear();
            foreach (var item in lista)
            {
                dgvProduto.Rows.Add();
                dgvProduto.Rows[linha].Cells[0].Value = item.Id;
                dgvProduto.Rows[linha].Cells[1].Value = item.CodBarras;
                dgvProduto.Rows[linha].Cells[2].Value = item.Descricao;
                dgvProduto.Rows[linha].Cells[3].Value = item.ValorUnit;
                //using (MemoryStream ms = new MemoryStream(item.Imagem))
                //{
                //    Image imagem = Image.FromStream(ms);
                //    dataGridView1.Rows[linha].Cells[4].Value = imagem;
                //}
                linha++;

            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var produto = Produto.ObterPorId(Convert.ToInt32(dgvProduto.Rows[dgvProduto.CurrentRow.Index].Cells[0].Value));
            using (MemoryStream ms = new MemoryStream(produto.Imagem))
            {
                picImagem.Image = Image.FromStream(ms);
                picImagem.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Produto produto1 = new();
            var produto = Produto.ObterPorId(Convert.ToInt32(dgvProduto.Rows[dgvProduto.CurrentRow.Index].Cells[0].Value));
            using (MemoryStream ms = new MemoryStream(produto.Imagem))
            {
                picImagem.Image = Image.FromStream(ms);
                picImagem.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }
        private void CarregarGrid()
        {
            var produtos = Produto.ObterLista();
            int linha = 0;
            dgvProduto.Rows.Clear();
            foreach (var produto in produtos)
            {
                dgvProduto.Rows.Add();
                dgvProduto.Rows[linha].Cells[0].Value = produto.Id;
                dgvProduto.Rows[linha].Cells[1].Value = produto.CodBarras;
                dgvProduto.Rows[linha].Cells[2].Value = produto.Descricao;
                dgvProduto.Rows[linha].Cells[3].Value = produto.ValorUnit;
                linha++;
            }
        }
        
        private void FrmProdutoListar_Load_1(object sender, EventArgs e)
        {
            CarregarGrid();
        }

       
        private void dgvNiveis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picImagem_Click(object sender, EventArgs e)
        {

        }

    }


}
