namespace UI
{
    partial class Transacoes
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            LabelHistoricoTransacoes = new Label();
            BtnAdicionarTransacao = new Componentes.BotaoPrimario();
            TabelaTransacoes = new Componentes.Tabela();
            Data = new DataGridViewTextBoxColumn();
            Conta = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TabelaTransacoes).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(31, 41, 55);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(TabelaTransacoes, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.8888893F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.1111145F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.3602F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.6398F));
            tableLayoutPanel2.Controls.Add(LabelHistoricoTransacoes, 0, 0);
            tableLayoutPanel2.Controls.Add(BtnAdicionarTransacao, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(794, 52);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // LabelHistoricoTransacoes
            // 
            LabelHistoricoTransacoes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LabelHistoricoTransacoes.AutoSize = true;
            LabelHistoricoTransacoes.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LabelHistoricoTransacoes.ForeColor = SystemColors.ButtonHighlight;
            LabelHistoricoTransacoes.Location = new Point(3, 10);
            LabelHistoricoTransacoes.Name = "LabelHistoricoTransacoes";
            LabelHistoricoTransacoes.Size = new Size(639, 32);
            LabelHistoricoTransacoes.TabIndex = 3;
            LabelHistoricoTransacoes.Text = "Histórico de Transações";
            LabelHistoricoTransacoes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnAdicionarTransacao
            // 
            BtnAdicionarTransacao.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnAdicionarTransacao.BackColor = Color.FromArgb(100, 111, 229);
            BtnAdicionarTransacao.FlatAppearance.BorderSize = 0;
            BtnAdicionarTransacao.FlatStyle = FlatStyle.Flat;
            BtnAdicionarTransacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnAdicionarTransacao.ForeColor = Color.FromArgb(5, 6, 63);
            BtnAdicionarTransacao.Location = new Point(648, 11);
            BtnAdicionarTransacao.Name = "BtnAdicionarTransacao";
            BtnAdicionarTransacao.Size = new Size(143, 30);
            BtnAdicionarTransacao.TabIndex = 1;
            BtnAdicionarTransacao.Text = "Adicionar Transação";
            BtnAdicionarTransacao.UseVisualStyleBackColor = false;
            BtnAdicionarTransacao.Click += BtnAdicionarTransacao_Click;
            // 
            // TabelaTransacoes
            // 
            TabelaTransacoes.AllowUserToAddRows = false;
            TabelaTransacoes.AllowUserToDeleteRows = false;
            TabelaTransacoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TabelaTransacoes.BackgroundColor = Color.FromArgb(31, 41, 55);
            TabelaTransacoes.BorderStyle = BorderStyle.None;
            TabelaTransacoes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            TabelaTransacoes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TabelaTransacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TabelaTransacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelaTransacoes.Columns.AddRange(new DataGridViewColumn[] { Data, Conta, Categoria, Valor, Descricao });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            TabelaTransacoes.DefaultCellStyle = dataGridViewCellStyle2;
            TabelaTransacoes.Dock = DockStyle.Fill;
            TabelaTransacoes.EnableHeadersVisualStyles = false;
            TabelaTransacoes.Location = new Point(3, 61);
            TabelaTransacoes.Name = "TabelaTransacoes";
            TabelaTransacoes.ReadOnly = true;
            TabelaTransacoes.RowHeadersVisible = false;
            TabelaTransacoes.Size = new Size(794, 386);
            TabelaTransacoes.TabIndex = 5;
            // 
            // Data
            // 
            Data.DataPropertyName = "Data";
            Data.HeaderText = "Data";
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // Conta
            // 
            Conta.DataPropertyName = "Conta";
            Conta.HeaderText = "Conta";
            Conta.Name = "Conta";
            Conta.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.DataPropertyName = "Categoria";
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.DataPropertyName = "Valor";
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            // 
            // Transacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Transacoes";
            Text = "Transacoes";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TabelaTransacoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label LabelHistoricoTransacoes;
        private Componentes.BotaoPrimario BtnAdicionarTransacao;
        private Componentes.Tabela TabelaTransacoes;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Conta;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Descricao;
    }
}