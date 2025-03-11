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
            Titulo = new Label();
            TableLayoutPanelCorpo = new TableLayoutPanel();
            Input = new TextBox();
            BotaoExibirSenha = new Button();
            tableLayoutPanel1.SuspendLayout();
            TableLayoutPanelCorpo.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(31, 41, 55);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Titulo, 0, 0);
            tableLayoutPanel1.Controls.Add(TableLayoutPanelCorpo, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.0655746F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 63.9344254F));
            tableLayoutPanel1.Size = new Size(833, 88);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Titulo.ForeColor = SystemColors.Control;
            Titulo.Location = new Point(4, 3);
            Titulo.Margin = new Padding(4, 0, 4, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(825, 25);
            Titulo.TabIndex = 1;
            Titulo.Text = "Label";
            // 
            // TableLayoutPanelCorpo
            // 
            TableLayoutPanelCorpo.ColumnCount = 2;
            TableLayoutPanelCorpo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.62394F));
            TableLayoutPanelCorpo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.376058F));
            TableLayoutPanelCorpo.Controls.Add(Input, 0, 0);
            TableLayoutPanelCorpo.Controls.Add(BotaoExibirSenha, 1, 0);
            TableLayoutPanelCorpo.Dock = DockStyle.Fill;
            TableLayoutPanelCorpo.Location = new Point(3, 34);
            TableLayoutPanelCorpo.Name = "TableLayoutPanelCorpo";
            TableLayoutPanelCorpo.RowCount = 1;
            TableLayoutPanelCorpo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanelCorpo.Size = new Size(827, 51);
            TableLayoutPanelCorpo.TabIndex = 2;
            // 
            // Input
            // 
            Input.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Input.BackColor = Color.FromArgb(55, 65, 81);
            Input.BorderStyle = BorderStyle.None;
            Input.Font = new Font("Segoe UI", 10F);
            Input.ForeColor = Color.WhiteSmoke;
            Input.Location = new Point(4, 5);
            Input.Margin = new Padding(4, 5, 4, 5);
            Input.Multiline = true;
            Input.Name = "Input";
            Input.Size = new Size(758, 41);
            Input.TabIndex = 0;
            // 
            // BotaoExibirSenha
            // 
            BotaoExibirSenha.Cursor = Cursors.Hand;
            BotaoExibirSenha.Dock = DockStyle.Fill;
            BotaoExibirSenha.FlatAppearance.BorderSize = 0;
            BotaoExibirSenha.FlatStyle = FlatStyle.Flat;
            BotaoExibirSenha.ForeColor = SystemColors.Control;
            BotaoExibirSenha.Image = Properties.Resources.exibir;
            BotaoExibirSenha.Location = new Point(769, 3);
            BotaoExibirSenha.Name = "BotaoExibirSenha";
            BotaoExibirSenha.Size = new Size(55, 45);
            BotaoExibirSenha.TabIndex = 1;
            BotaoExibirSenha.UseVisualStyleBackColor = true;
            BotaoExibirSenha.Click += BotaoExibirSenha_Click;
            // 
            // InputTexto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "InputTexto";
            Size = new Size(833, 88);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            TableLayoutPanelCorpo.ResumeLayout(false);
            TableLayoutPanelCorpo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox Input;
        private Label Titulo;
        private TableLayoutPanel TableLayoutPanelCorpo;
        private Button BotaoExibirSenha;
    }
}
