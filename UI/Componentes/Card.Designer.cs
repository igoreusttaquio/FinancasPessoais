namespace UI.Componentes
{
    partial class Card
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel3 = new TableLayoutPanel();
            Detalhe = new Label();
            Titulo = new Label();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(55, 65, 81);
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(Detalhe, 0, 1);
            tableLayoutPanel3.Controls.Add(Titulo, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(229, 97);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // Detalhe
            // 
            Detalhe.Anchor = AnchorStyles.Left;
            Detalhe.AutoSize = true;
            Detalhe.Font = new Font("Segoe UI", 14F);
            Detalhe.ForeColor = SystemColors.ButtonHighlight;
            Detalhe.Location = new Point(3, 60);
            Detalhe.Name = "Detalhe";
            Detalhe.Size = new Size(77, 25);
            Detalhe.TabIndex = 1;
            Detalhe.Text = "Detalhe";
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.Left;
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Titulo.ForeColor = SystemColors.ButtonHighlight;
            Titulo.Location = new Point(3, 11);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(64, 25);
            Titulo.TabIndex = 0;
            Titulo.Text = "Titulo";
            // 
            // Card
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel3);
            Name = "Card";
            Size = new Size(229, 97);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private Label Detalhe;
        private Label Titulo;
    }
}
