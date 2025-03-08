namespace UI
{
    partial class Contas
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            LabelContas = new Label();
            BotaoAdicionarConta = new Componentes.BotaoPrimario();
            TabelaContas = new Componentes.Tabela();
            Nome = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Saldo = new DataGridViewTextBoxColumn();
            Acao = new DataGridViewImageColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TabelaContas).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(31, 41, 55);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(TabelaContas, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.33753F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.662468F));
            tableLayoutPanel2.Controls.Add(LabelContas, 0, 0);
            tableLayoutPanel2.Controls.Add(BotaoAdicionarConta, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(794, 48);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // LabelContas
            // 
            LabelContas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LabelContas.AutoSize = true;
            LabelContas.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LabelContas.ForeColor = SystemColors.ButtonHighlight;
            LabelContas.Location = new Point(3, 8);
            LabelContas.Name = "LabelContas";
            LabelContas.Size = new Size(616, 32);
            LabelContas.TabIndex = 4;
            LabelContas.Text = "Minhas Contas";
            LabelContas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BotaoAdicionarConta
            // 
            BotaoAdicionarConta.Anchor = AnchorStyles.Right;
            BotaoAdicionarConta.BackColor = Color.FromArgb(100, 111, 229);
            BotaoAdicionarConta.FlatAppearance.BorderSize = 0;
            BotaoAdicionarConta.FlatStyle = FlatStyle.Flat;
            BotaoAdicionarConta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BotaoAdicionarConta.ForeColor = Color.FromArgb(5, 6, 63);
            BotaoAdicionarConta.Location = new Point(629, 7);
            BotaoAdicionarConta.Name = "BotaoAdicionarConta";
            BotaoAdicionarConta.Size = new Size(162, 34);
            BotaoAdicionarConta.TabIndex = 1;
            BotaoAdicionarConta.Text = "Adicionar nova conta";
            BotaoAdicionarConta.UseVisualStyleBackColor = false;
            BotaoAdicionarConta.Click += BotaoAdicionarConta_Click;
            // 
            // TabelaContas
            // 
            TabelaContas.AllowUserToAddRows = false;
            TabelaContas.AllowUserToDeleteRows = false;
            TabelaContas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TabelaContas.BackgroundColor = Color.FromArgb(31, 41, 55);
            TabelaContas.BorderStyle = BorderStyle.None;
            TabelaContas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            TabelaContas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.Control;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            TabelaContas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            TabelaContas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelaContas.Columns.AddRange(new DataGridViewColumn[] { Nome, Tipo, Saldo, Acao });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            TabelaContas.DefaultCellStyle = dataGridViewCellStyle4;
            TabelaContas.Dock = DockStyle.Fill;
            TabelaContas.EnableHeadersVisualStyles = false;
            TabelaContas.Location = new Point(3, 57);
            TabelaContas.Name = "TabelaContas";
            TabelaContas.ReadOnly = true;
            TabelaContas.RowHeadersVisible = false;
            TabelaContas.Size = new Size(794, 390);
            TabelaContas.TabIndex = 1;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.DataPropertyName = "Tipo";
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // Saldo
            // 
            Saldo.DataPropertyName = "Saldo";
            Saldo.HeaderText = "Saldo";
            Saldo.Name = "Saldo";
            Saldo.ReadOnly = true;
            // 
            // Acao
            // 
            Acao.HeaderText = "Ação";
            Acao.Image = Properties.Resources.lixeira;
            Acao.Name = "Acao";
            Acao.ReadOnly = true;
            Acao.Resizable = DataGridViewTriState.True;
            Acao.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Contas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Contas";
            Text = "Contas";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TabelaContas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Componentes.Tabela TabelaContas;
        private Label LabelContas;
        private Componentes.BotaoPrimario BotaoAdicionarConta;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Saldo;
        private DataGridViewImageColumn Acao;
    }
}