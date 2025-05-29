namespace ComercialTDSDesk
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNomeCliente = new TextBox();
            txtEmailCliente = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            maskTel = new MaskedTextBox();
            maskCpf = new MaskedTextBox();
            tabControl1 = new TabControl();
            tabClientes = new TabPage();
            tabEnderecos = new TabPage();
            label2 = new Label();
            txtUF = new TextBox();
            txtEstado = new TextBox();
            txtCidade = new TextBox();
            btnBuscar = new Button();
            txtLongradouro = new TextBox();
            txtNumero = new TextBox();
            txtBairro = new TextBox();
            txtCep = new TextBox();
            tabControl1.SuspendLayout();
            tabClientes.SuspendLayout();
            tabEnderecos.SuspendLayout();
            SuspendLayout();
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(244, 157);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.PlaceholderText = "Nome";
            txtNomeCliente.Size = new Size(231, 23);
            txtNomeCliente.TabIndex = 0;
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Location = new Point(244, 187);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.PlaceholderText = "Email";
            txtEmailCliente.Size = new Size(231, 23);
            txtEmailCliente.TabIndex = 1;
            // 
            // btnGravar
            // 
            btnGravar.BackColor = SystemColors.ActiveCaptionText;
            btnGravar.ForeColor = SystemColors.Control;
            btnGravar.Location = new Point(244, 308);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "&Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaptionText;
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(368, 308);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(258, 93);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 8;
            label1.Text = "Cadastro de Clientes";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(244, 215);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // maskTel
            // 
            maskTel.Location = new Point(244, 273);
            maskTel.Mask = "(99) 00000-0000";
            maskTel.Name = "maskTel";
            maskTel.Size = new Size(100, 23);
            maskTel.TabIndex = 12;
            maskTel.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // maskCpf
            // 
            maskCpf.Location = new Point(244, 244);
            maskCpf.Mask = "000,000,000-00";
            maskCpf.Name = "maskCpf";
            maskCpf.Size = new Size(100, 23);
            maskCpf.TabIndex = 13;
         
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabClientes);
            tabControl1.Controls.Add(tabEnderecos);
            tabControl1.Location = new Point(205, 62);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(726, 502);
            tabControl1.TabIndex = 14;
            // 
            // tabClientes
            // 
            tabClientes.BackColor = SystemColors.ScrollBar;
            tabClientes.Controls.Add(btnCancelar);
            tabClientes.Controls.Add(btnGravar);
            tabClientes.Controls.Add(txtEmailCliente);
            tabClientes.Controls.Add(txtNomeCliente);
            tabClientes.Controls.Add(label1);
            tabClientes.Controls.Add(dateTimePicker1);
            tabClientes.Controls.Add(maskCpf);
            tabClientes.Controls.Add(maskTel);
            tabClientes.ForeColor = SystemColors.ControlText;
            tabClientes.Location = new Point(4, 24);
            tabClientes.Name = "tabClientes";
            tabClientes.Padding = new Padding(3);
            tabClientes.Size = new Size(718, 474);
            tabClientes.TabIndex = 0;
            tabClientes.Text = "Clientes";
            // 
            // tabEnderecos
            // 
            tabEnderecos.BackColor = SystemColors.ScrollBar;
            tabEnderecos.Controls.Add(label2);
            tabEnderecos.Controls.Add(txtUF);
            tabEnderecos.Controls.Add(txtEstado);
            tabEnderecos.Controls.Add(txtCidade);
            tabEnderecos.Controls.Add(btnBuscar);
            tabEnderecos.Controls.Add(txtLongradouro);
            tabEnderecos.Controls.Add(txtNumero);
            tabEnderecos.Controls.Add(txtBairro);
            tabEnderecos.Controls.Add(txtCep);
            tabEnderecos.Location = new Point(4, 24);
            tabEnderecos.Name = "tabEnderecos";
            tabEnderecos.Padding = new Padding(3);
            tabEnderecos.Size = new Size(718, 474);
            tabEnderecos.TabIndex = 1;
            tabEnderecos.Text = "Endereços";
            tabEnderecos.Click += tabEnderecos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(203, 82);
            label2.Name = "label2";
            label2.Size = new Size(197, 25);
            label2.TabIndex = 8;
            label2.Text = "Endereços de Clientes";
            // 
            // txtUF
            // 
            txtUF.Location = new Point(378, 262);
            txtUF.Name = "txtUF";
            txtUF.PlaceholderText = "UF";
            txtUF.Size = new Size(55, 23);
            txtUF.TabIndex = 7;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(378, 224);
            txtEstado.Name = "txtEstado";
            txtEstado.PlaceholderText = "Estado";
            txtEstado.Size = new Size(144, 23);
            txtEstado.TabIndex = 6;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(378, 195);
            txtCidade.Name = "txtCidade";
            txtCidade.PlaceholderText = "Cidade";
            txtCidade.Size = new Size(196, 23);
            txtCidade.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar.Location = new Point(142, 339);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(81, 28);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtLongradouro
            // 
            txtLongradouro.Location = new Point(142, 224);
            txtLongradouro.Name = "txtLongradouro";
            txtLongradouro.PlaceholderText = "Longradouro";
            txtLongradouro.Size = new Size(221, 23);
            txtLongradouro.TabIndex = 3;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(142, 253);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Numero";
            txtNumero.Size = new Size(221, 23);
            txtNumero.TabIndex = 2;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(142, 282);
            txtBairro.Name = "txtBairro";
            txtBairro.PlaceholderText = "Bairro";
            txtBairro.Size = new Size(221, 23);
            txtBairro.TabIndex = 1;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(142, 195);
            txtCep.Name = "txtCep";
            txtCep.PlaceholderText = "CEP";
            txtCep.Size = new Size(221, 23);
            txtCep.TabIndex = 0;
            txtCep.TextChanged += txtCep_TextChanged;
            txtCep.Leave += txtCep_Leave;
            // 
            // FrmCliente
            // 
            AcceptButton = btnGravar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(1224, 637);
            Controls.Add(tabControl1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            tabControl1.ResumeLayout(false);
            tabClientes.ResumeLayout(false);
            tabClientes.PerformLayout();
            tabEnderecos.ResumeLayout(false);
            tabEnderecos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNomeCliente;
        private TextBox txtEmailCliente;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskTel;
        private MaskedTextBox maskCpf;
        private TabControl tabControl1;
        private TabPage tabClientes;
        private TabPage tabEnderecos;
        private TextBox txtNumero;
        private TextBox txtBairro;
        private TextBox txtCep;
        private Button btnBuscar;
        private TextBox txtLongradouro;
        private TextBox txtCidade;
        private TextBox txtUF;
        private TextBox txtEstado;
        private Label label2;
    }
}