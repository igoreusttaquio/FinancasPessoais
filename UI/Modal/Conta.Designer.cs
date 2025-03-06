namespace UI.Modal
{
    partial class Conta
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
            inputTexto3 = new Componentes.InputTexto();
            inputTexto1 = new Componentes.InputTexto();
            inputCombo1 = new Componentes.InputCombo();
            botaoPrimario1 = new Componentes.BotaoPrimario();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(inputTexto3, 0, 2);
            tableLayoutPanel1.Controls.Add(inputTexto1, 0, 0);
            tableLayoutPanel1.Controls.Add(inputCombo1, 0, 1);
            tableLayoutPanel1.Controls.Add(botaoPrimario1, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(672, 208);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // inputTexto3
            // 
            inputTexto3.Dock = DockStyle.Fill;
            inputTexto3.Location = new Point(3, 107);
            inputTexto3.Name = "inputTexto3";
            inputTexto3.Size = new Size(666, 46);
            inputTexto3.TabIndex = 2;
            // 
            // inputTexto1
            // 
            inputTexto1.Dock = DockStyle.Fill;
            inputTexto1.Location = new Point(3, 3);
            inputTexto1.Name = "inputTexto1";
            inputTexto1.Size = new Size(666, 46);
            inputTexto1.TabIndex = 0;
            // 
            // inputCombo1
            // 
            inputCombo1.Dock = DockStyle.Fill;
            inputCombo1.Location = new Point(3, 55);
            inputCombo1.Name = "inputCombo1";
            inputCombo1.Size = new Size(666, 46);
            inputCombo1.TabIndex = 3;
            // 
            // botaoPrimario1
            // 
            botaoPrimario1.Anchor = AnchorStyles.Right;
            botaoPrimario1.BackColor = Color.FromArgb(100, 111, 229);
            botaoPrimario1.FlatAppearance.BorderSize = 0;
            botaoPrimario1.FlatStyle = FlatStyle.Flat;
            botaoPrimario1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            botaoPrimario1.ForeColor = Color.FromArgb(5, 6, 63);
            botaoPrimario1.Location = new Point(553, 165);
            botaoPrimario1.Name = "botaoPrimario1";
            botaoPrimario1.Size = new Size(116, 34);
            botaoPrimario1.TabIndex = 1;
            botaoPrimario1.Text = "Adicionar Conta";
            botaoPrimario1.UseVisualStyleBackColor = false;
            // 
            // Conta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 41, 55);
            ClientSize = new Size(692, 228);
            Controls.Add(tableLayoutPanel1);
            Name = "Conta";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Conta";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Componentes.InputTexto inputTexto3;
        private Componentes.InputTexto inputTexto1;
        private Componentes.InputCombo inputCombo1;
        private Componentes.BotaoPrimario botaoPrimario1;
    }
}