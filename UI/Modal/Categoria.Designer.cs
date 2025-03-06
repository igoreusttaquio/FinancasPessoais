namespace UI.Modal
{
    partial class Categoria
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
            TipoCategoria = new Componentes.InputCombo();
            NomeCategoria = new Componentes.InputTexto();
            botaoPrimario1 = new Componentes.BotaoPrimario();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(TipoCategoria, 0, 1);
            tableLayoutPanel1.Controls.Add(NomeCategoria, 0, 0);
            tableLayoutPanel1.Controls.Add(botaoPrimario1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35.25305F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.4136124F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(476, 174);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // TipoCategoria
            // 
            TipoCategoria.Location = new Point(3, 64);
            TipoCategoria.Name = "TipoCategoria";
            TipoCategoria.Size = new Size(470, 48);
            TipoCategoria.TabIndex = 0;
            TipoCategoria.Valor = null;
            // 
            // NomeCategoria
            // 
            NomeCategoria.Location = new Point(3, 3);
            NomeCategoria.Name = "NomeCategoria";
            NomeCategoria.Size = new Size(470, 53);
            NomeCategoria.TabIndex = 1;
            NomeCategoria.Texto = "";
            // 
            // botaoPrimario1
            // 
            botaoPrimario1.Anchor = AnchorStyles.Right;
            botaoPrimario1.BackColor = Color.FromArgb(100, 111, 229);
            botaoPrimario1.FlatAppearance.BorderSize = 0;
            botaoPrimario1.FlatStyle = FlatStyle.Flat;
            botaoPrimario1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            botaoPrimario1.ForeColor = Color.FromArgb(5, 6, 63);
            botaoPrimario1.Location = new Point(339, 127);
            botaoPrimario1.Name = "botaoPrimario1";
            botaoPrimario1.Size = new Size(134, 34);
            botaoPrimario1.TabIndex = 1;
            botaoPrimario1.Text = "Adicionar Categoria";
            botaoPrimario1.UseVisualStyleBackColor = false;
            botaoPrimario1.Click += botaoPrimario1_Click;
            // 
            // Categoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 41, 55);
            ClientSize = new Size(496, 194);
            Controls.Add(tableLayoutPanel1);
            Name = "Categoria";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Categoria";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Componentes.InputCombo TipoCategoria;
        private Componentes.InputTexto NomeCategoria;
        private Componentes.BotaoPrimario botaoPrimario1;
    }
}