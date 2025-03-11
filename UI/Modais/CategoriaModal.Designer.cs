namespace UI.Modais
{
    partial class CategoriaModal
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Orcamento = new Componentes.InputTexto();
            NomeCategoria = new Componentes.InputTexto();
            BotaoAdicionarCategoria = new Componentes.BotaoPrimario();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Orcamento, 0, 1);
            tableLayoutPanel1.Controls.Add(NomeCategoria, 0, 0);
            tableLayoutPanel1.Controls.Add(BotaoAdicionarCategoria, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(14, 17);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35.25305F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.4136124F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(681, 289);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Orcamento
            // 
            Orcamento.Label = "Orçamento(mês)";
            Orcamento.Location = new Point(6, 109);
            Orcamento.Margin = new Padding(6, 8, 6, 8);
            Orcamento.Name = "Orcamento";
            Orcamento.Size = new Size(669, 74);
            Orcamento.TabIndex = 2;
            Orcamento.Texto = "";
            Orcamento.TratarComoSenha = false;
            // 
            // NomeCategoria
            // 
            NomeCategoria.Label = "Nome";
            NomeCategoria.Location = new Point(6, 8);
            NomeCategoria.Margin = new Padding(6, 8, 6, 8);
            NomeCategoria.Name = "NomeCategoria";
            NomeCategoria.Size = new Size(669, 85);
            NomeCategoria.TabIndex = 1;
            NomeCategoria.Texto = "";
            NomeCategoria.TratarComoSenha = false;
            // 
            // BotaoAdicionarCategoria
            // 
            BotaoAdicionarCategoria.Anchor = AnchorStyles.Right;
            BotaoAdicionarCategoria.BackColor = Color.FromArgb(100, 111, 229);
            BotaoAdicionarCategoria.FlatAppearance.BorderSize = 0;
            BotaoAdicionarCategoria.FlatStyle = FlatStyle.Flat;
            BotaoAdicionarCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BotaoAdicionarCategoria.ForeColor = Color.FromArgb(5, 6, 63);
            BotaoAdicionarCategoria.Location = new Point(486, 211);
            BotaoAdicionarCategoria.Margin = new Padding(4, 5, 4, 5);
            BotaoAdicionarCategoria.Name = "BotaoAdicionarCategoria";
            BotaoAdicionarCategoria.Size = new Size(191, 57);
            BotaoAdicionarCategoria.TabIndex = 1;
            BotaoAdicionarCategoria.Text = "Adicionar Categoria";
            BotaoAdicionarCategoria.UseVisualStyleBackColor = false;
            BotaoAdicionarCategoria.Click += botaoPrimario1_Click;
            // 
            // CategoriaModal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 41, 55);
            ClientSize = new Size(709, 323);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CategoriaModal";
            Padding = new Padding(14, 17, 14, 17);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Categoria";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Componentes.InputTexto NomeCategoria;
        private Componentes.BotaoPrimario BotaoAdicionarCategoria;
        private Componentes.InputTexto Orcamento;
    }
}