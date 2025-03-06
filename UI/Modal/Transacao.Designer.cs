﻿namespace UI.Modal
{
    partial class Transacao
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
            inputTexto5 = new Componentes.InputTexto();
            inputTexto4 = new Componentes.InputTexto();
            inputTexto3 = new Componentes.InputTexto();
            botaoPrimario1 = new Componentes.BotaoPrimario();
            inputCombo1 = new Componentes.InputCombo();
            inputCombo2 = new Componentes.InputCombo();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(inputTexto5, 0, 4);
            tableLayoutPanel1.Controls.Add(inputTexto4, 0, 3);
            tableLayoutPanel1.Controls.Add(inputTexto3, 0, 2);
            tableLayoutPanel1.Controls.Add(botaoPrimario1, 0, 5);
            tableLayoutPanel1.Controls.Add(inputCombo1, 0, 0);
            tableLayoutPanel1.Controls.Add(inputCombo2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(2);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.28395F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.04938F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.Size = new Size(590, 345);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // inputTexto5
            // 
            inputTexto5.Dock = DockStyle.Fill;
            inputTexto5.Location = new Point(5, 229);
            inputTexto5.Name = "inputTexto5";
            inputTexto5.Size = new Size(580, 50);
            inputTexto5.TabIndex = 4;
            // 
            // inputTexto4
            // 
            inputTexto4.Dock = DockStyle.Fill;
            inputTexto4.Location = new Point(5, 173);
            inputTexto4.Name = "inputTexto4";
            inputTexto4.Size = new Size(580, 50);
            inputTexto4.TabIndex = 3;
            // 
            // inputTexto3
            // 
            inputTexto3.Dock = DockStyle.Fill;
            inputTexto3.Location = new Point(5, 117);
            inputTexto3.Name = "inputTexto3";
            inputTexto3.Size = new Size(580, 50);
            inputTexto3.TabIndex = 2;
            // 
            // botaoPrimario1
            // 
            botaoPrimario1.Anchor = AnchorStyles.Right;
            botaoPrimario1.BackColor = Color.FromArgb(100, 111, 229);
            botaoPrimario1.FlatAppearance.BorderSize = 0;
            botaoPrimario1.FlatStyle = FlatStyle.Flat;
            botaoPrimario1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            botaoPrimario1.ForeColor = Color.FromArgb(5, 6, 63);
            botaoPrimario1.Location = new Point(433, 295);
            botaoPrimario1.Name = "botaoPrimario1";
            botaoPrimario1.Size = new Size(152, 34);
            botaoPrimario1.TabIndex = 1;
            botaoPrimario1.Text = "Adicionar Transação";
            botaoPrimario1.UseVisualStyleBackColor = false;
            // 
            // inputCombo1
            // 
            inputCombo1.Location = new Point(5, 5);
            inputCombo1.Name = "inputCombo1";
            inputCombo1.Size = new Size(580, 44);
            inputCombo1.TabIndex = 5;
            // 
            // inputCombo2
            // 
            inputCombo2.Location = new Point(5, 63);
            inputCombo2.Name = "inputCombo2";
            inputCombo2.Size = new Size(580, 41);
            inputCombo2.TabIndex = 6;
            // 
            // Transacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 41, 55);
            ClientSize = new Size(610, 365);
            Controls.Add(tableLayoutPanel1);
            ForeColor = SystemColors.Control;
            Name = "Transacao";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Transacao";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Componentes.InputTexto inputTexto5;
        private Componentes.InputTexto inputTexto4;
        private Componentes.InputTexto inputTexto3;
        private Componentes.BotaoPrimario botaoPrimario1;
        private Componentes.InputCombo inputCombo1;
        private Componentes.InputCombo inputCombo2;
    }
}