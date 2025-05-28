using ComercialTDSClass;
using NcMaster;
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
            Cliente cliente = new(txtNomeCliente.Text, maskCpf.Text, maskTel.Text, txtEmailCliente.Text, dateTimePicker1.Value);
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

        private void tabEnderecos_Click(object sender, EventArgs e)
        {
            Endereco endereco = new(txtCep.Text, txtLongradouro.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text, txtEstado.Text, txtUF.Text);

            txtCep.Clear();


        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            if (txtCep.Text.Length > 9)
            {
                var endereco = Endereco.ObterPorCep(txtCep.Text);
                if (endereco.Id == 0)
                {
                    endereco = Endereco.ObterPorId(int.Parse(txtCep.Text));
                }
                txtLongradouro.Text = endereco.ToString();
                txtNumero.Text = endereco.Numero;
                txtBairro.Text = endereco.Bairro.ToString();
                txtCidade.Text = endereco.Cidade.ToString();
                txtEstado.Text = endereco.Estado.ToString();
                txtUF.Text = endereco.UF.ToString();

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var endereco = Endereco.ObterPorId(int.Parse(txtCep.Text));
            txtLongradouro.ReadOnly = Enabled;
            txtNumero.Text = endereco.Numero;
            txtBairro.ReadOnly = Enabled;
            txtCidade.ReadOnly = Enabled;
            txtUF.ReadOnly = Enabled;



            txtLongradouro.ReadOnly = true;
            txtNumero.ReadOnly = true;


        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            if (txtCep.Text.Length == 8)
            {
                WebCEP webCEP = new(txtCep.Text);
                txtLongradouro.Text = webCEP.Lagradouro;
                txtBairro.Text = webCEP.Bairro;
                txtCidade.Text = webCEP.Cidade;
                txtUF.Text = webCEP.UF;

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            Endereco endereco = new(txtCep.Text, txtLongradouro.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text, txtEstado.Text, txtUF.Text);
            endereco.Inserir();
            txtCep.Clear();
        }
    }


}



            
   

