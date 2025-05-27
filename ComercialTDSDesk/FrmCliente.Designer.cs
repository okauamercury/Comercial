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
            SuspendLayout();
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(438, 235);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.PlaceholderText = "Nome";
            txtNomeCliente.Size = new Size(231, 23);
            txtNomeCliente.TabIndex = 0;
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Location = new Point(438, 265);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.PlaceholderText = "Email";
            txtEmailCliente.Size = new Size(231, 23);
            txtEmailCliente.TabIndex = 1;
            // 
            // btnGravar
            // 
            btnGravar.BackColor = SystemColors.ActiveCaptionText;
            btnGravar.ForeColor = SystemColors.Control;
            btnGravar.Location = new Point(438, 360);
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
            btnCancelar.Location = new Point(579, 360);
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
            label1.Location = new Point(438, 182);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 8;
            label1.Text = "Cadastro de Clientes";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(438, 293);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // maskTel
            // 
            maskTel.Location = new Point(709, 236);
            maskTel.Mask = "(99) 00000-0000";
            maskTel.Name = "maskTel";
            maskTel.Size = new Size(100, 23);
            maskTel.TabIndex = 12;
            maskTel.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // maskCpf
            // 
            maskCpf.Location = new Point(709, 265);
            maskCpf.Mask = "000,000,000-00";
            maskCpf.Name = "maskCpf";
            maskCpf.Size = new Size(100, 23);
            maskCpf.TabIndex = 13;
            maskCpf.MaskInputRejected += maskCpf_MaskInputRejected;
            // 
            // FrmCliente
            // 
            AcceptButton = btnGravar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(1224, 637);
            Controls.Add(maskCpf);
            Controls.Add(maskTel);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtEmailCliente);
            Controls.Add(txtNomeCliente);
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}