﻿namespace ComercialTDSDesk
{
    partial class FrmListarUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnBuscar = new Button();
            btnCancelar = new Button();
            txtNome = new TextBox();
            cbmNivel = new ComboBox();
            dgvListar = new DataGridView();
            clnNome = new DataGridViewTextBoxColumn();
            clnNivel = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListar).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Black;
            btnBuscar.ForeColor = SystemColors.ButtonShadow;
            btnBuscar.Location = new Point(279, 355);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Black;
            btnCancelar.ForeColor = SystemColors.ButtonShadow;
            btnCancelar.Location = new Point(413, 355);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(264, 247);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(248, 23);
            txtNome.TabIndex = 3;
            // 
            // cbmNivel
            // 
            cbmNivel.FormattingEnabled = true;
            cbmNivel.Items.AddRange(new object[] { "Master", "Administrador", "Estoquista", "Caixa" });
            cbmNivel.Location = new Point(264, 296);
            cbmNivel.Name = "cbmNivel";
            cbmNivel.Size = new Size(248, 23);
            cbmNivel.TabIndex = 5;
            // 
            // dgvListar
            // 
            dgvListar.AllowUserToAddRows = false;
            dgvListar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvListar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvListar.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListar.Columns.AddRange(new DataGridViewColumn[] { clnNome, clnNivel });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvListar.DefaultCellStyle = dataGridViewCellStyle3;
            dgvListar.Location = new Point(580, 224);
            dgvListar.Name = "dgvListar";
            dgvListar.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvListar.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvListar.RowHeadersVisible = false;
            dgvListar.Size = new Size(272, 185);
            dgvListar.TabIndex = 6;
            dgvListar.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 150;
            // 
            // clnNivel
            // 
            clnNivel.Frozen = true;
            clnNivel.HeaderText = "Nivel";
            clnNivel.Name = "clnNivel";
            clnNivel.ReadOnly = true;
            clnNivel.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Millimeter);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(377, 51);
            label1.TabIndex = 7;
            label1.Text = "Listagem de Usuarios";
            // 
            // FrmListarUsuarios
            // 
            AcceptButton = btnBuscar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(1264, 705);
            Controls.Add(label1);
            Controls.Add(dgvListar);
            Controls.Add(cbmNivel);
            Controls.Add(txtNome);
            Controls.Add(btnCancelar);
            Controls.Add(btnBuscar);
            Name = "FrmListarUsuarios";
            Text = "FrmListar";
            Load += FrmListar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnCancelar;
        private TextBox txtNome;
        private ComboBox cbmNivel;
        private DataGridView dgvListar;
        private Label label1;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnNivel;
    }
}