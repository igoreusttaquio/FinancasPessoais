namespace UI
{
    partial class Categorias
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
            LabelContas = new Label();
            botaoPrimario1 = new Componentes.BotaoPrimario();
            tabela1 = new Componentes.Tabela();
            Nome = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Acoes = new DataGridViewImageColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabela1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tabela1, 0, 1);
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
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 163F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(LabelContas, 0, 0);
            tableLayoutPanel2.Controls.Add(botaoPrimario1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(794, 52);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // LabelContas
            // 
            LabelContas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LabelContas.AutoSize = true;
            LabelContas.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LabelContas.ForeColor = SystemColors.ButtonHighlight;
            LabelContas.Location = new Point(3, 10);
            LabelContas.Name = "LabelContas";
            LabelContas.Size = new Size(625, 32);
            LabelContas.TabIndex = 5;
            LabelContas.Text = "Minhas Categorias";
            LabelContas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // botaoPrimario1
            // 
            botaoPrimario1.Anchor = AnchorStyles.Right;
            botaoPrimario1.BackColor = Color.FromArgb(100, 111, 229);
            botaoPrimario1.FlatAppearance.BorderSize = 0;
            botaoPrimario1.FlatStyle = FlatStyle.Flat;
            botaoPrimario1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            botaoPrimario1.ForeColor = Color.FromArgb(5, 6, 63);
            botaoPrimario1.Location = new Point(634, 9);
            botaoPrimario1.Name = "botaoPrimario1";
            botaoPrimario1.Size = new Size(157, 34);
            botaoPrimario1.TabIndex = 1;
            botaoPrimario1.Text = "Adicionar Categoria";
            botaoPrimario1.UseVisualStyleBackColor = false;
            botaoPrimario1.Click += botaoPrimario1_Click;
            // 
            // tabela1
            // 
            tabela1.AllowUserToAddRows = false;
            tabela1.AllowUserToDeleteRows = false;
            tabela1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabela1.BackgroundColor = Color.FromArgb(31, 41, 55);
            tabela1.BorderStyle = BorderStyle.None;
            tabela1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tabela1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tabela1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tabela1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabela1.Columns.AddRange(new DataGridViewColumn[] { Nome, Tipo, Acoes });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tabela1.DefaultCellStyle = dataGridViewCellStyle2;
            tabela1.Dock = DockStyle.Fill;
            tabela1.EnableHeadersVisualStyles = false;
            tabela1.Location = new Point(3, 61);
            tabela1.Name = "tabela1";
            tabela1.ReadOnly = true;
            tabela1.RowHeadersVisible = false;
            tabela1.Size = new Size(794, 386);
            tabela1.TabIndex = 1;
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
            // Acoes
            // 
            Acoes.HeaderText = "Ações";
            Acoes.Image = Properties.Resources.lixeira;
            Acoes.Name = "Acoes";
            Acoes.ReadOnly = true;
            Acoes.Resizable = DataGridViewTriState.True;
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 41, 55);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Categorias";
            Text = "Categorias";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabela1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label LabelContas;
        private Componentes.BotaoPrimario botaoPrimario1;
        private Componentes.Tabela tabela1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewImageColumn Acoes;
    }
}