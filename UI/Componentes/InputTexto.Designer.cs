namespace UI.Componentes
{
    partial class InputTexto
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
            Input = new TextBox();
            Label = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(31, 41, 55);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Input, 0, 1);
            tableLayoutPanel1.Controls.Add(Label, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.0655746F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 63.9344254F));
            tableLayoutPanel1.Size = new Size(583, 53);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Input
            // 
            Input.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Input.BackColor = Color.FromArgb(55, 65, 81);
            Input.BorderStyle = BorderStyle.None;
            Input.Font = new Font("Segoe UI", 10F);
            Input.ForeColor = Color.WhiteSmoke;
            Input.Location = new Point(3, 23);
            Input.Multiline = true;
            Input.Name = "Input";
            Input.Size = new Size(577, 25);
            Input.TabIndex = 0;
            // 
            // Label
            // 
            Label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Label.AutoSize = true;
            Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Label.ForeColor = SystemColors.Control;
            Label.Location = new Point(3, 2);
            Label.Name = "Label";
            Label.Size = new Size(577, 15);
            Label.TabIndex = 1;
            Label.Text = "Label";
            // 
            // InputTexto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "InputTexto";
            Size = new Size(583, 53);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox Input;
        private Label Label;
    }
}
