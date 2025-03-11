namespace UI
{
    partial class Registrar
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
            LabelHistoricoTransacoes = new Label();
            inputTexto1 = new Componentes.InputTexto();
            inputTexto2 = new Componentes.InputTexto();
            inputTexto3 = new Componentes.InputTexto();
            inputTexto4 = new Componentes.InputTexto();
            botaoPrimario1 = new Componentes.BotaoPrimario();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(31, 41, 55);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(inputTexto4, 0, 4);
            tableLayoutPanel1.Controls.Add(inputTexto3, 0, 3);
            tableLayoutPanel1.Controls.Add(inputTexto2, 0, 2);
            tableLayoutPanel1.Controls.Add(LabelHistoricoTransacoes, 0, 0);
            tableLayoutPanel1.Controls.Add(inputTexto1, 0, 1);
            tableLayoutPanel1.Controls.Add(botaoPrimario1, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // LabelHistoricoTransacoes
            // 
            LabelHistoricoTransacoes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LabelHistoricoTransacoes.AutoSize = true;
            LabelHistoricoTransacoes.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LabelHistoricoTransacoes.ForeColor = SystemColors.ButtonHighlight;
            LabelHistoricoTransacoes.Location = new Point(3, 21);
            LabelHistoricoTransacoes.Name = "LabelHistoricoTransacoes";
            LabelHistoricoTransacoes.Size = new Size(794, 32);
            LabelHistoricoTransacoes.TabIndex = 4;
            LabelHistoricoTransacoes.Text = "Registrar";
            LabelHistoricoTransacoes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputTexto1
            // 
            inputTexto1.Anchor = AnchorStyles.None;
            inputTexto1.Label = "Nome de Usuário";
            inputTexto1.Location = new Point(149, 86);
            inputTexto1.Name = "inputTexto1";
            inputTexto1.Size = new Size(502, 53);
            inputTexto1.TabIndex = 5;
            inputTexto1.Texto = "";
            // 
            // inputTexto2
            // 
            inputTexto2.Anchor = AnchorStyles.None;
            inputTexto2.Label = "E-mail";
            inputTexto2.Location = new Point(149, 161);
            inputTexto2.Name = "inputTexto2";
            inputTexto2.Size = new Size(502, 53);
            inputTexto2.TabIndex = 6;
            inputTexto2.Texto = "";
            // 
            // inputTexto3
            // 
            inputTexto3.Anchor = AnchorStyles.None;
            inputTexto3.Label = "Senha";
            inputTexto3.Location = new Point(149, 236);
            inputTexto3.Name = "inputTexto3";
            inputTexto3.Size = new Size(502, 53);
            inputTexto3.TabIndex = 7;
            inputTexto3.Texto = "";
            // 
            // inputTexto4
            // 
            inputTexto4.Anchor = AnchorStyles.None;
            inputTexto4.Label = "Confirmar Senha";
            inputTexto4.Location = new Point(149, 311);
            inputTexto4.Name = "inputTexto4";
            inputTexto4.Size = new Size(502, 53);
            inputTexto4.TabIndex = 8;
            inputTexto4.Texto = "";
            // 
            // botaoPrimario1
            // 
            botaoPrimario1.Anchor = AnchorStyles.None;
            botaoPrimario1.BackColor = Color.FromArgb(100, 111, 229);
            botaoPrimario1.FlatAppearance.BorderSize = 0;
            botaoPrimario1.FlatStyle = FlatStyle.Flat;
            botaoPrimario1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            botaoPrimario1.ForeColor = Color.FromArgb(5, 6, 63);
            botaoPrimario1.Location = new Point(342, 395);
            botaoPrimario1.Name = "botaoPrimario1";
            botaoPrimario1.Size = new Size(116, 34);
            botaoPrimario1.TabIndex = 1;
            botaoPrimario1.Text = "Cadastrar";
            botaoPrimario1.UseVisualStyleBackColor = false;
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Registrar";
            Text = "Registrar";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Componentes.InputTexto inputTexto4;
        private Componentes.InputTexto inputTexto3;
        private Componentes.InputTexto inputTexto2;
        private Label LabelHistoricoTransacoes;
        private Componentes.InputTexto inputTexto1;
        private Componentes.BotaoPrimario botaoPrimario1;
    }
}