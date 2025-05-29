namespace ComercialTDSDesk
{
    partial class FrmFornecedor
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
            btnSalvar = new Button();
            btnEditar = new Button();
            txtRazaoSocial = new TextBox();
            txtFantasia = new TextBox();
            dgvFornecedor = new DataGridView();
            txtEmail = new TextBox();
            btnCancelar = new Button();
            maskCnpj = new MaskedTextBox();
            maskTel = new MaskedTextBox();
            txtContato = new TextBox();
            clnID = new DataGridViewTextBoxColumn();
            clnRazaoSocial = new DataGridViewTextBoxColumn();
            clnCnpj = new DataGridViewTextBoxColumn();
            clnContato = new DataGridViewTextBoxColumn();
            clnNomeFantasia = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).BeginInit();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.ActiveCaptionText;
            btnSalvar.ForeColor = SystemColors.Control;
            btnSalvar.Location = new Point(103, 266);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(73, 23);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Gravar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ActiveCaptionText;
            btnEditar.ForeColor = SystemColors.Control;
            btnEditar.Location = new Point(170, 266);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(73, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(103, 94);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.PlaceholderText = "Razão Social";
            txtRazaoSocial.Size = new Size(138, 23);
            txtRazaoSocial.TabIndex = 4;
            // 
            // txtFantasia
            // 
            txtFantasia.Location = new Point(103, 180);
            txtFantasia.Name = "txtFantasia";
            txtFantasia.PlaceholderText = "Nome Fantasia";
            txtFantasia.Size = new Size(138, 23);
            txtFantasia.TabIndex = 5;
            // 
            // dgvFornecedor
            // 
            dgvFornecedor.AllowUserToAddRows = false;
            dgvFornecedor.AllowUserToDeleteRows = false;
            dgvFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedor.Columns.AddRange(new DataGridViewColumn[] { clnID, clnRazaoSocial, clnCnpj, clnContato, clnNomeFantasia, clnTelefone, clnEmail });
            dgvFornecedor.Location = new Point(246, 80);
            dgvFornecedor.Name = "dgvFornecedor";
            dgvFornecedor.ReadOnly = true;
            dgvFornecedor.RowHeadersVisible = false;
            dgvFornecedor.Size = new Size(654, 237);
            dgvFornecedor.TabIndex = 7;
            dgvFornecedor.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(103, 237);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(138, 23);
            txtEmail.TabIndex = 9;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaptionText;
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(103, 294);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(73, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // maskCnpj
            // 
            maskCnpj.Location = new Point(102, 123);
            maskCnpj.Mask = "00,000,000/0000-00";
            maskCnpj.Name = "maskCnpj";
            maskCnpj.Size = new Size(138, 23);
            maskCnpj.TabIndex = 11;
            // 
            // maskTel
            // 
            maskTel.Location = new Point(103, 208);
            maskTel.Mask = "(00) 00000-0000";
            maskTel.Name = "maskTel";
            maskTel.Size = new Size(138, 23);
            maskTel.TabIndex = 12;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(103, 151);
            txtContato.Name = "txtContato";
            txtContato.PlaceholderText = "Contato";
            txtContato.Size = new Size(140, 23);
            txtContato.TabIndex = 13;
            // 
            // clnID
            // 
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            clnID.Width = 50;
            // 
            // clnRazaoSocial
            // 
            clnRazaoSocial.HeaderText = "Razão Social";
            clnRazaoSocial.Name = "clnRazaoSocial";
            clnRazaoSocial.ReadOnly = true;
            // 
            // clnCnpj
            // 
            clnCnpj.HeaderText = "Cnpj";
            clnCnpj.Name = "clnCnpj";
            clnCnpj.ReadOnly = true;
            // 
            // clnContato
            // 
            clnContato.HeaderText = "Contato";
            clnContato.Name = "clnContato";
            clnContato.ReadOnly = true;
            // 
            // clnNomeFantasia
            // 
            clnNomeFantasia.HeaderText = "Nome Fantasia";
            clnNomeFantasia.Name = "clnNomeFantasia";
            clnNomeFantasia.ReadOnly = true;
            // 
            // clnTelefone
            // 
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            // 
            // FrmFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 450);
            Controls.Add(txtContato);
            Controls.Add(maskTel);
            Controls.Add(maskCnpj);
            Controls.Add(btnCancelar);
            Controls.Add(txtEmail);
            Controls.Add(dgvFornecedor);
            Controls.Add(txtFantasia);
            Controls.Add(txtRazaoSocial);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Name = "FrmFornecedor";
            Text = "FrmFornecedor";
            WindowState = FormWindowState.Maximized;
            Load += FrmFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Button btnEditar;
        private TextBox txtRazaoSocial;
        private TextBox txtFantasia;
        private DataGridView dgvFornecedor;
        private TextBox txtEmail;
        private Button btnCancelar;
        private MaskedTextBox maskCnpj;
        private MaskedTextBox maskTel;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnRazaoSocial;
        private DataGridViewTextBoxColumn clnCnpj;
        private DataGridViewTextBoxColumn clnContato;
        private DataGridViewTextBoxColumn clnNomeFantasia;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
        private TextBox txtContato;
    }
}