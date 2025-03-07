using UI.Componentes;

namespace EmbeddedForms
{
    partial class DashBoard
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
            PainelPrincipal = new Panel();
            layoutPrincipal = new TableLayoutPanel();
            LabelAtividadesRecentes = new Label();
            LabelTitulo = new Label();
            LayoutCards = new TableLayoutPanel();
            CardSaldoTotal = new Card();
            CardTotalTransacoes = new Card();
            CardTotalContas = new Card();
            tableLayoutPanel4 = new TableLayoutPanel();
            BtnTransacoes = new Button();
            BtnGerenciarContas = new Button();
            TabelaAtividadesRecentes = new Tabela();
            Data = new DataGridViewTextBoxColumn();
            Conta = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            PainelPrincipal.SuspendLayout();
            layoutPrincipal.SuspendLayout();
            LayoutCards.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TabelaAtividadesRecentes).BeginInit();
            SuspendLayout();
            // 
            // PainelPrincipal
            // 
            PainelPrincipal.Controls.Add(layoutPrincipal);
            PainelPrincipal.Dock = DockStyle.Fill;
            PainelPrincipal.Location = new Point(0, 0);
            PainelPrincipal.Name = "PainelPrincipal";
            PainelPrincipal.Size = new Size(800, 450);
            PainelPrincipal.TabIndex = 0;
            // 
            // layoutPrincipal
            // 
            layoutPrincipal.BackColor = Color.FromArgb(31, 41, 55);
            layoutPrincipal.ColumnCount = 1;
            layoutPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layoutPrincipal.Controls.Add(LabelAtividadesRecentes, 0, 2);
            layoutPrincipal.Controls.Add(LabelTitulo, 0, 0);
            layoutPrincipal.Controls.Add(LayoutCards, 0, 1);
            layoutPrincipal.Controls.Add(tableLayoutPanel4, 0, 4);
            layoutPrincipal.Controls.Add(TabelaAtividadesRecentes, 0, 3);
            layoutPrincipal.Dock = DockStyle.Fill;
            layoutPrincipal.Location = new Point(0, 0);
            layoutPrincipal.Name = "layoutPrincipal";
            layoutPrincipal.RowCount = 5;
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 38.9312973F));
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 61.0687027F));
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 211F));
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            layoutPrincipal.Size = new Size(800, 450);
            layoutPrincipal.TabIndex = 0;
            // 
            // LabelAtividadesRecentes
            // 
            LabelAtividadesRecentes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LabelAtividadesRecentes.AutoSize = true;
            LabelAtividadesRecentes.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LabelAtividadesRecentes.ForeColor = SystemColors.ButtonHighlight;
            LabelAtividadesRecentes.Location = new Point(3, 156);
            LabelAtividadesRecentes.Name = "LabelAtividadesRecentes";
            LabelAtividadesRecentes.Size = new Size(794, 32);
            LabelAtividadesRecentes.TabIndex = 2;
            LabelAtividadesRecentes.Text = "Atividades recentes";
            LabelAtividadesRecentes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelTitulo
            // 
            LabelTitulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LabelTitulo.AutoSize = true;
            LabelTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            LabelTitulo.ForeColor = SystemColors.ButtonHighlight;
            LabelTitulo.Location = new Point(3, 9);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(794, 41);
            LabelTitulo.TabIndex = 0;
            LabelTitulo.Text = "Dashboard";
            LabelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LayoutCards
            // 
            LayoutCards.ColumnCount = 3;
            LayoutCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            LayoutCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            LayoutCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            LayoutCards.Controls.Add(CardSaldoTotal, 2, 0);
            LayoutCards.Controls.Add(CardTotalTransacoes, 1, 0);
            LayoutCards.Controls.Add(CardTotalContas, 0, 0);
            LayoutCards.Dock = DockStyle.Fill;
            LayoutCards.Location = new Point(3, 62);
            LayoutCards.Name = "LayoutCards";
            LayoutCards.RowCount = 1;
            LayoutCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            LayoutCards.Size = new Size(794, 86);
            LayoutCards.TabIndex = 1;
            // 
            // CardSaldoTotal
            // 
            CardSaldoTotal.DetralheCard = "R$ 1.500,00";
            CardSaldoTotal.Dock = DockStyle.Fill;
            CardSaldoTotal.Location = new Point(531, 3);
            CardSaldoTotal.Name = "CardSaldoTotal";
            CardSaldoTotal.Size = new Size(260, 80);
            CardSaldoTotal.TabIndex = 2;
            CardSaldoTotal.TituloCard = "Total em Despesas";
            // 
            // CardTotalTransacoes
            // 
            CardTotalTransacoes.DetralheCard = "15 Transações";
            CardTotalTransacoes.Dock = DockStyle.Fill;
            CardTotalTransacoes.Location = new Point(267, 3);
            CardTotalTransacoes.Name = "CardTotalTransacoes";
            CardTotalTransacoes.Size = new Size(258, 80);
            CardTotalTransacoes.TabIndex = 3;
            CardTotalTransacoes.TituloCard = "Total de Transações";
            // 
            // CardTotalContas
            // 
            CardTotalContas.DetralheCard = "R$ 4.500,00";
            CardTotalContas.Dock = DockStyle.Fill;
            CardTotalContas.Location = new Point(3, 3);
            CardTotalContas.Name = "CardTotalContas";
            CardTotalContas.Size = new Size(258, 80);
            CardTotalContas.TabIndex = 4;
            CardTotalContas.TituloCard = "Total em contas";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.63476F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.3652391F));
            tableLayoutPanel4.Controls.Add(BtnTransacoes, 1, 0);
            tableLayoutPanel4.Controls.Add(BtnGerenciarContas, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 407);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(794, 40);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // BtnTransacoes
            // 
            BtnTransacoes.Anchor = AnchorStyles.Right;
            BtnTransacoes.BackColor = Color.FromArgb(100, 111, 229);
            BtnTransacoes.Cursor = Cursors.Hand;
            BtnTransacoes.FlatAppearance.BorderSize = 0;
            BtnTransacoes.FlatStyle = FlatStyle.Flat;
            BtnTransacoes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnTransacoes.ForeColor = Color.FromArgb(5, 6, 63);
            BtnTransacoes.Location = new Point(675, 3);
            BtnTransacoes.Name = "BtnTransacoes";
            BtnTransacoes.Size = new Size(116, 34);
            BtnTransacoes.TabIndex = 2;
            BtnTransacoes.Text = "Ver Transações";
            BtnTransacoes.UseVisualStyleBackColor = false;
            // 
            // BtnGerenciarContas
            // 
            BtnGerenciarContas.Anchor = AnchorStyles.Right;
            BtnGerenciarContas.BackColor = Color.FromArgb(100, 111, 229);
            BtnGerenciarContas.Cursor = Cursors.Hand;
            BtnGerenciarContas.FlatAppearance.BorderSize = 0;
            BtnGerenciarContas.FlatStyle = FlatStyle.Flat;
            BtnGerenciarContas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnGerenciarContas.ForeColor = Color.FromArgb(5, 6, 63);
            BtnGerenciarContas.Location = new Point(553, 3);
            BtnGerenciarContas.Name = "BtnGerenciarContas";
            BtnGerenciarContas.Size = new Size(116, 34);
            BtnGerenciarContas.TabIndex = 1;
            BtnGerenciarContas.Text = "Gerenciar Contas";
            BtnGerenciarContas.UseVisualStyleBackColor = false;
            // 
            // TabelaAtividadesRecentes
            // 
            TabelaAtividadesRecentes.AllowUserToAddRows = false;
            TabelaAtividadesRecentes.AllowUserToDeleteRows = false;
            TabelaAtividadesRecentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TabelaAtividadesRecentes.BackgroundColor = Color.FromArgb(31, 41, 55);
            TabelaAtividadesRecentes.BorderStyle = BorderStyle.None;
            TabelaAtividadesRecentes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TabelaAtividadesRecentes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TabelaAtividadesRecentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TabelaAtividadesRecentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelaAtividadesRecentes.Columns.AddRange(new DataGridViewColumn[] { Data, Conta, Categoria, Valor, Descricao });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            TabelaAtividadesRecentes.DefaultCellStyle = dataGridViewCellStyle2;
            TabelaAtividadesRecentes.Dock = DockStyle.Fill;
            TabelaAtividadesRecentes.EnableHeadersVisualStyles = false;
            TabelaAtividadesRecentes.Location = new Point(3, 196);
            TabelaAtividadesRecentes.Name = "TabelaAtividadesRecentes";
            TabelaAtividadesRecentes.ReadOnly = true;
            TabelaAtividadesRecentes.RowHeadersVisible = false;
            TabelaAtividadesRecentes.Size = new Size(794, 205);
            TabelaAtividadesRecentes.TabIndex = 5;
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
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PainelPrincipal);
            Name = "DashBoard";
            Text = "DashBoard";
            PainelPrincipal.ResumeLayout(false);
            layoutPrincipal.ResumeLayout(false);
            layoutPrincipal.PerformLayout();
            LayoutCards.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TabelaAtividadesRecentes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PainelPrincipal;
        private TableLayoutPanel layoutPrincipal;
        private Label LabelTitulo;
        private TableLayoutPanel LayoutCards;
        private Label LabelAtividadesRecentes;
        private TableLayoutPanel tableLayoutPanel4;
        private Button BtnTransacoes;
        private Button BtnGerenciarContas;
        private UI.Componentes.Card CardSaldoTotal;
        private UI.Componentes.Card CardTotalTransacoes;
        private UI.Componentes.Card CardTotalContas;
        private Tabela TabelaAtividadesRecentes;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Conta;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Descricao;
    }
}