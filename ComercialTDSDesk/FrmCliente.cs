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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            maskTel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Cliente cliente = new(txtNomeCliente.Text, maskCpf.Text,  maskTel.Text, txtEmailCliente.Text, dateTimePicker1.Value);
            cliente.Insert();
            txtNomeCliente.Clear();
            txtEmailCliente.Clear();
            maskTel.Clear();
            maskCpf.Clear();


            MessageBox.Show("cliente cadastrado com sucesso!");


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            var niveis = Nivel.ObterLista();

            txtNomeCliente.Clear();
            txtEmailCliente.Clear();
            maskCpf.Clear();
            maskTel.Clear();


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }


}
   

