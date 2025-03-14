﻿namespace EmbeddedForms
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Layout = new SplitContainer();
            NavBar = new TableLayoutPanel();
            BtnLogout = new Button();
            BrnCategoria = new Button();
            BtnTransacoes = new Button();
            BtnContas = new Button();
            BtnDashboard = new Button();
            BtnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)Layout).BeginInit();
            Layout.Panel1.SuspendLayout();
            Layout.SuspendLayout();
            NavBar.SuspendLayout();
            SuspendLayout();
            // 
            // Layout
            // 
            Layout.BackColor = Color.FromArgb(17, 24, 39);
            Layout.Dock = DockStyle.Fill;
            Layout.Location = new Point(10, 10);
            Layout.Name = "Layout";
            Layout.Orientation = Orientation.Horizontal;
            // 
            // Layout.Panel1
            // 
            Layout.Panel1.Controls.Add(NavBar);
            // 
            // Layout.Panel2
            // 
            Layout.Panel2.BackColor = Color.FromArgb(31, 41, 55);
            Layout.Panel2.Padding = new Padding(6);
            Layout.Size = new Size(780, 482);
            Layout.SplitterDistance = 44;
            Layout.TabIndex = 0;
            // 
            // NavBar
            // 
            NavBar.BackColor = Color.FromArgb(17, 24, 39);
            NavBar.ColumnCount = 6;
            NavBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            NavBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            NavBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            NavBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            NavBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            NavBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            NavBar.Controls.Add(BtnLogout, 5, 0);
            NavBar.Controls.Add(BrnCategoria, 4, 0);
            NavBar.Controls.Add(BtnTransacoes, 3, 0);
            NavBar.Controls.Add(BtnContas, 2, 0);
            NavBar.Controls.Add(BtnDashboard, 1, 0);
            NavBar.Controls.Add(BtnVoltar, 0, 0);
            NavBar.Dock = DockStyle.Fill;
            NavBar.Location = new Point(0, 0);
            NavBar.Name = "NavBar";
            NavBar.RowCount = 1;
            NavBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            NavBar.Size = new Size(780, 44);
            NavBar.TabIndex = 0;
            // 
            // BtnLogout
            // 
            BtnLogout.Dock = DockStyle.Fill;
            BtnLogout.FlatAppearance.BorderSize = 0;
            BtnLogout.FlatStyle = FlatStyle.Flat;
            BtnLogout.ForeColor = SystemColors.HighlightText;
            BtnLogout.Image = (Image)resources.GetObject("BtnLogout.Image");
            BtnLogout.Location = new Point(705, 3);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.Size = new Size(72, 38);
            BtnLogout.TabIndex = 5;
            BtnLogout.UseVisualStyleBackColor = true;
            // 
            // BrnCategoria
            // 
            BrnCategoria.BackColor = Color.FromArgb(17, 24, 39);
            BrnCategoria.Dock = DockStyle.Fill;
            BrnCategoria.FlatAppearance.BorderSize = 0;
            BrnCategoria.FlatStyle = FlatStyle.Flat;
            BrnCategoria.ForeColor = SystemColors.HighlightText;
            BrnCategoria.Location = new Point(549, 3);
            BrnCategoria.Name = "BrnCategoria";
            BrnCategoria.Size = new Size(150, 38);
            BrnCategoria.TabIndex = 4;
            BrnCategoria.Text = "Categorias";
            BrnCategoria.UseVisualStyleBackColor = false;
            BrnCategoria.Click += BrnCategoria_Click;
            // 
            // BtnTransacoes
            // 
            BtnTransacoes.BackColor = Color.FromArgb(17, 24, 39);
            BtnTransacoes.Dock = DockStyle.Fill;
            BtnTransacoes.FlatAppearance.BorderSize = 0;
            BtnTransacoes.FlatStyle = FlatStyle.Flat;
            BtnTransacoes.ForeColor = SystemColors.HighlightText;
            BtnTransacoes.Location = new Point(393, 3);
            BtnTransacoes.Name = "BtnTransacoes";
            BtnTransacoes.Size = new Size(150, 38);
            BtnTransacoes.TabIndex = 2;
            BtnTransacoes.Text = "Transações";
            BtnTransacoes.UseVisualStyleBackColor = false;
            BtnTransacoes.Click += BtnTransacoes_Click;
            // 
            // BtnContas
            // 
            BtnContas.BackColor = Color.FromArgb(17, 24, 39);
            BtnContas.Dock = DockStyle.Fill;
            BtnContas.FlatAppearance.BorderSize = 0;
            BtnContas.FlatStyle = FlatStyle.Flat;
            BtnContas.ForeColor = SystemColors.HighlightText;
            BtnContas.Location = new Point(237, 3);
            BtnContas.Name = "BtnContas";
            BtnContas.Size = new Size(150, 38);
            BtnContas.TabIndex = 1;
            BtnContas.Text = "Contas";
            BtnContas.UseVisualStyleBackColor = false;
            BtnContas.Click += BtnContas_Click;
            // 
            // BtnDashboard
            // 
            BtnDashboard.BackColor = Color.FromArgb(17, 24, 39);
            BtnDashboard.Dock = DockStyle.Fill;
            BtnDashboard.FlatAppearance.BorderSize = 0;
            BtnDashboard.FlatStyle = FlatStyle.Flat;
            BtnDashboard.ForeColor = SystemColors.HighlightText;
            BtnDashboard.Location = new Point(81, 3);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Size = new Size(150, 38);
            BtnDashboard.TabIndex = 0;
            BtnDashboard.Text = "Dashboard";
            BtnDashboard.UseVisualStyleBackColor = false;
            BtnDashboard.Click += BtnDashboard_Click;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Dock = DockStyle.Fill;
            BtnVoltar.FlatAppearance.BorderSize = 0;
            BtnVoltar.FlatStyle = FlatStyle.Flat;
            BtnVoltar.ForeColor = SystemColors.HighlightText;
            BtnVoltar.Image = UI.Properties.Resources.seta_voltar;
            BtnVoltar.Location = new Point(3, 3);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(72, 38);
            BtnVoltar.TabIndex = 3;
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 24, 39);
            ClientSize = new Size(800, 502);
            Controls.Add(Layout);
            Name = "Main";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Layout.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Layout).EndInit();
            Layout.ResumeLayout(false);
            NavBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer Layout;
        private TableLayoutPanel NavBar;
        private Button BtnTransacoes;
        private Button BtnContas;
        private Button BtnDashboard;
        private Button BtnVoltar;
        private Button BrnCategoria;
        private Button BtnLogout;
    }
}
