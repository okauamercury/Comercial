namespace ComercialTDSDesk
{
    partial class FrmProdutoListar
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dgvProduto = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            picImagem = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
            SuspendLayout();
            // 
            // dgvProduto
            // 
            dgvProduto.AllowUserToAddRows = false;
            dgvProduto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dgvProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProduto.BackgroundColor = SystemColors.ScrollBar;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduto.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodBar, clnDescricao, clnValorUnit });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProduto.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProduto.GridColor = SystemColors.ScrollBar;
            dgvProduto.Location = new Point(57, 51);
            dgvProduto.Name = "dgvProduto";
            dgvProduto.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProduto.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dgvProduto.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduto.Size = new Size(494, 300);
            dgvProduto.TabIndex = 0;
            dgvProduto.CellContentClick += dgvProduto_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Cod Barras";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            clnCodBar.Width = 130;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 200;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Preço";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 60;
            // 
            // picImagem
            // 
            picImagem.BorderStyle = BorderStyle.FixedSingle;
            picImagem.Image = Properties.Resources.sem_imagem;
            picImagem.Location = new Point(583, 51);
            picImagem.Name = "picImagem";
            picImagem.Size = new Size(300, 300);
            picImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagem.TabIndex = 9;
            picImagem.TabStop = false;
            picImagem.Click += picImagem_Click;
            // 
            // FrmProdutoListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 446);
            Controls.Add(picImagem);
            Controls.Add(dgvProduto);
            Name = "FrmProdutoListar";
            Text = "FrmProdutoListar";
            Load += FrmProdutoListar_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)picImagem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProduto;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private PictureBox picImagem;
    }
}