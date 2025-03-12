namespace UI
{
    partial class Login
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
            NomeUsuario = new Componentes.InputTexto();
            Senha = new Componentes.InputTexto();
            BotaoLogin = new Componentes.BotaoPrimario();
            LinkCadastro = new LinkLabel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(31, 41, 55);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(LabelHistoricoTransacoes, 0, 0);
            tableLayoutPanel1.Controls.Add(NomeUsuario, 0, 1);
            tableLayoutPanel1.Controls.Add(Senha, 0, 2);
            tableLayoutPanel1.Controls.Add(BotaoLogin, 0, 3);
            tableLayoutPanel1.Controls.Add(LinkCadastro, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // LabelHistoricoTransacoes
            // 
            LabelHistoricoTransacoes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LabelHistoricoTransacoes.AutoSize = true;
            LabelHistoricoTransacoes.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LabelHistoricoTransacoes.ForeColor = SystemColors.ButtonHighlight;
            LabelHistoricoTransacoes.Location = new Point(3, 36);
            LabelHistoricoTransacoes.Name = "LabelHistoricoTransacoes";
            LabelHistoricoTransacoes.Size = new Size(794, 32);
            LabelHistoricoTransacoes.TabIndex = 4;
            LabelHistoricoTransacoes.Text = "Login";
            LabelHistoricoTransacoes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NomeUsuario
            // 
            NomeUsuario.Anchor = AnchorStyles.None;
            NomeUsuario.Label = "Nome de Usuário";
            NomeUsuario.Location = new Point(149, 131);
            NomeUsuario.Margin = new Padding(4, 5, 4, 5);
            NomeUsuario.Name = "NomeUsuario";
            NomeUsuario.Size = new Size(502, 53);
            NomeUsuario.TabIndex = 5;
            NomeUsuario.Texto = "";
            NomeUsuario.TratarComoSenha = false;
            // 
            // Senha
            // 
            Senha.Anchor = AnchorStyles.None;
            Senha.Label = "Senha";
            Senha.Location = new Point(149, 236);
            Senha.Margin = new Padding(4, 5, 4, 5);
            Senha.Name = "Senha";
            Senha.Size = new Size(502, 53);
            Senha.TabIndex = 7;
            Senha.Texto = "";
            Senha.TratarComoSenha = true;
            // 
            // BotaoLogin
            // 
            BotaoLogin.Anchor = AnchorStyles.None;
            BotaoLogin.BackColor = Color.FromArgb(100, 111, 229);
            BotaoLogin.FlatAppearance.BorderSize = 0;
            BotaoLogin.FlatStyle = FlatStyle.Flat;
            BotaoLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BotaoLogin.ForeColor = Color.FromArgb(5, 6, 63);
            BotaoLogin.Location = new Point(342, 350);
            BotaoLogin.Name = "BotaoLogin";
            BotaoLogin.Size = new Size(116, 34);
            BotaoLogin.TabIndex = 1;
            BotaoLogin.Text = "Logar";
            BotaoLogin.UseVisualStyleBackColor = false;
            BotaoLogin.Click += BotaoLogin_Click;
            // 
            // LinkCadastro
            // 
            LinkCadastro.Anchor = AnchorStyles.None;
            LinkCadastro.AutoSize = true;
            LinkCadastro.Location = new Point(343, 427);
            LinkCadastro.Name = "LinkCadastro";
            LinkCadastro.Size = new Size(113, 15);
            LinkCadastro.TabIndex = 8;
            LinkCadastro.TabStop = true;
            LinkCadastro.Text = "Não possui usuário?";
            LinkCadastro.LinkClicked += LinkCadastro_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Login";
            Text = "Login";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Componentes.InputTexto Senha;
        private Label LabelHistoricoTransacoes;
        private Componentes.InputTexto NomeUsuario;
        private Componentes.BotaoPrimario BotaoLogin;
        private LinkLabel LinkCadastro;
    }
}