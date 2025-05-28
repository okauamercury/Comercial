namespace ComercialTDSDesk
{
    partial class FrmUsuario
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
            btnGravar = new Button();
            btnCancelar = new Button();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            cmbNivel = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(100, 366);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(136, 32);
            btnGravar.TabIndex = 0;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(278, 366);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(136, 31);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(100, 224);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(218, 23);
            txtNome.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(100, 253);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(218, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(100, 282);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(167, 23);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbNivel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGravar);
            panel1.Location = new Point(330, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 525);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 198);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 7;
            label2.Text = "Nível";
            // 
            // cmbNivel
            // 
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Items.AddRange(new object[] { "", "", "Administrador", "Master", "funcionario", "Caixa", "Estoquista", "Pacote" });
            cmbNivel.Location = new Point(100, 195);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(167, 23);
            cmbNivel.TabIndex = 6;
            cmbNivel.SelectedIndexChanged += cmbNivel_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(9, 16);
            label1.Name = "label1";
            label1.Size = new Size(258, 37);
            label1.TabIndex = 5;
            label1.Text = "Cadastro de Usuario";
            // 
            // FrmUsuario
            // 
            AcceptButton = btnGravar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(1264, 705);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Panel panel1;
        private Label label1;
        private ComboBox cmbNivel;
        private Label label2;
    }
}