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
            txtCNPJ = new TextBox();
            txtRazaoSocial = new TextBox();
            txtFantasia = new TextBox();
            dgvFornecedor = new DataGridView();
            txtTel = new TextBox();
            txtEmail = new TextBox();
            btnExcluir = new Button();
            clnID = new DataGridViewTextBoxColumn();
            clnRazaoSocial = new DataGridViewTextBoxColumn();
            clnCnpj = new DataGridViewTextBoxColumn();
            clnNomeFantasia = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).BeginInit();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(96, 234);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(73, 23);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Gravar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(163, 234);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(73, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(96, 119);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.PlaceholderText = "CNPJ";
            txtCNPJ.Size = new Size(138, 23);
            txtCNPJ.TabIndex = 3;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(96, 84);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.PlaceholderText = "Razão Social";
            txtRazaoSocial.Size = new Size(138, 23);
            txtRazaoSocial.TabIndex = 4;
            // 
            // txtFantasia
            // 
            txtFantasia.Location = new Point(96, 148);
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
            dgvFornecedor.Columns.AddRange(new DataGridViewColumn[] { clnID, clnRazaoSocial, clnCnpj, clnNomeFantasia, clnTelefone, clnEmail });
            dgvFornecedor.Location = new Point(270, 82);
            dgvFornecedor.Name = "dgvFornecedor";
            dgvFornecedor.ReadOnly = true;
            dgvFornecedor.RowHeadersVisible = false;
            dgvFornecedor.Size = new Size(554, 237);
            dgvFornecedor.TabIndex = 7;
            dgvFornecedor.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(96, 176);
            txtTel.Name = "txtTel";
            txtTel.PlaceholderText = "Telefone";
            txtTel.Size = new Size(138, 23);
            txtTel.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(96, 205);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(138, 23);
            txtEmail.TabIndex = 9;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(96, 262);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(73, 23);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
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
            Controls.Add(btnExcluir);
            Controls.Add(txtEmail);
            Controls.Add(txtTel);
            Controls.Add(dgvFornecedor);
            Controls.Add(txtFantasia);
            Controls.Add(txtRazaoSocial);
            Controls.Add(txtCNPJ);
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
        private TextBox txtCNPJ;
        private TextBox txtRazaoSocial;
        private TextBox txtFantasia;
        private DataGridView dgvFornecedor;
        private TextBox txtTel;
        private TextBox txtEmail;
        private Button btnExcluir;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnRazaoSocial;
        private DataGridViewTextBoxColumn clnCnpj;
        private DataGridViewTextBoxColumn clnNomeFantasia;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
    }
}