namespace UI.Componentes
{
    partial class Radios
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Label = new Label();
            Radio1 = new RadioButton();
            Radio2 = new RadioButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Label, 0, 0);
            tableLayoutPanel1.Controls.Add(Radio1, 0, 1);
            tableLayoutPanel1.Controls.Add(Radio2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.Size = new Size(524, 45);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Label
            // 
            Label.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(Label, 2);
            Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Label.ForeColor = SystemColors.HighlightText;
            Label.Location = new Point(3, 0);
            Label.Name = "Label";
            Label.Size = new Size(36, 15);
            Label.TabIndex = 0;
            Label.Text = "Label";
            // 
            // Radio1
            // 
            Radio1.AutoSize = true;
            Radio1.Cursor = Cursors.Hand;
            Radio1.ForeColor = SystemColors.HighlightText;
            Radio1.Location = new Point(3, 19);
            Radio1.Name = "Radio1";
            Radio1.Size = new Size(69, 19);
            Radio1.TabIndex = 1;
            Radio1.TabStop = true;
            Radio1.Text = "Opção 1";
            Radio1.UseVisualStyleBackColor = true;
            // 
            // Radio2
            // 
            Radio2.AutoSize = true;
            Radio2.Cursor = Cursors.Hand;
            Radio2.ForeColor = SystemColors.HighlightText;
            Radio2.Location = new Point(265, 19);
            Radio2.Name = "Radio2";
            Radio2.Size = new Size(69, 19);
            Radio2.TabIndex = 2;
            Radio2.TabStop = true;
            Radio2.Text = "Opção 2";
            Radio2.UseVisualStyleBackColor = true;
            // 
            // Radios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 41, 55);
            Controls.Add(tableLayoutPanel1);
            Name = "Radios";
            Size = new Size(524, 45);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Label;
        private RadioButton Radio1;
        private RadioButton Radio2;
    }
}
