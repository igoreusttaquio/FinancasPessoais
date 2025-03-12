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
            Nome = new Componentes.InputTexto();
            LabelHistoricoTransacoes = new Label();
            Login = new LinkLabel();
            BotaoCadastrar = new Componentes.BotaoPrimario();
            Senha2 = new Componentes.InputTexto();
            Senha1 = new Componentes.InputTexto();
            Email = new Componentes.InputTexto();
            NomeUsuario = new Componentes.InputTexto();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(31, 41, 55);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Nome, 0, 1);
            tableLayoutPanel1.Controls.Add(LabelHistoricoTransacoes, 0, 0);
            tableLayoutPanel1.Controls.Add(Login, 0, 7);
            tableLayoutPanel1.Controls.Add(BotaoCadastrar, 0, 6);
            tableLayoutPanel1.Controls.Add(Senha2, 0, 5);
            tableLayoutPanel1.Controls.Add(Senha1, 0, 4);
            tableLayoutPanel1.Controls.Add(Email, 0, 3);
            tableLayoutPanel1.Controls.Add(NomeUsuario, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.6931705F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7094889F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7094889F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7094889F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7094889F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7094889F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.10726452F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.65211535F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Nome
            // 
            Nome.Anchor = AnchorStyles.None;
            Nome.Label = "Seu nome";
            Nome.Location = new Point(149, 62);
            Nome.Margin = new Padding(4, 5, 4, 5);
            Nome.Name = "Nome";
            Nome.Size = new Size(502, 46);
            Nome.TabIndex = 10;
            Nome.Texto = "";
            Nome.TratarComoSenha = false;
            // 
            // LabelHistoricoTransacoes
            // 
            LabelHistoricoTransacoes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LabelHistoricoTransacoes.AutoSize = true;
            LabelHistoricoTransacoes.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LabelHistoricoTransacoes.ForeColor = SystemColors.ButtonHighlight;
            LabelHistoricoTransacoes.Location = new Point(3, 10);
            LabelHistoricoTransacoes.Name = "LabelHistoricoTransacoes";
            LabelHistoricoTransacoes.Size = new Size(794, 32);
            LabelHistoricoTransacoes.TabIndex = 4;
            LabelHistoricoTransacoes.Text = "Registrar";
            LabelHistoricoTransacoes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            Login.Anchor = AnchorStyles.None;
            Login.AutoSize = true;
            Login.Location = new Point(381, 426);
            Login.Name = "Login";
            Login.Size = new Size(37, 15);
            Login.TabIndex = 9;
            Login.TabStop = true;
            Login.Text = "Login";
            Login.LinkClicked += Login_LinkClicked;
            // 
            // BotaoCadastrar
            // 
            BotaoCadastrar.Anchor = AnchorStyles.None;
            BotaoCadastrar.BackColor = Color.FromArgb(100, 111, 229);
            BotaoCadastrar.FlatAppearance.BorderSize = 0;
            BotaoCadastrar.FlatStyle = FlatStyle.Flat;
            BotaoCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BotaoCadastrar.ForeColor = Color.FromArgb(5, 6, 63);
            BotaoCadastrar.Location = new Point(342, 385);
            BotaoCadastrar.Name = "BotaoCadastrar";
            BotaoCadastrar.Size = new Size(116, 30);
            BotaoCadastrar.TabIndex = 1;
            BotaoCadastrar.Text = "Cadastrar";
            BotaoCadastrar.UseVisualStyleBackColor = false;
            BotaoCadastrar.Click += BotaoCadastrar_Click;
            // 
            // Senha2
            // 
            Senha2.Anchor = AnchorStyles.None;
            Senha2.Label = "Confirmar senha";
            Senha2.Location = new Point(149, 326);
            Senha2.Margin = new Padding(4, 5, 4, 5);
            Senha2.Name = "Senha2";
            Senha2.Size = new Size(502, 46);
            Senha2.TabIndex = 8;
            Senha2.Texto = "";
            Senha2.TratarComoSenha = true;
            // 
            // Senha1
            // 
            Senha1.Anchor = AnchorStyles.None;
            Senha1.Label = "Senha";
            Senha1.Location = new Point(149, 260);
            Senha1.Margin = new Padding(4, 5, 4, 5);
            Senha1.Name = "Senha1";
            Senha1.Size = new Size(502, 46);
            Senha1.TabIndex = 7;
            Senha1.Texto = "";
            Senha1.TratarComoSenha = true;
            // 
            // Email
            // 
            Email.Anchor = AnchorStyles.None;
            Email.Label = "E-mail";
            Email.Location = new Point(149, 194);
            Email.Margin = new Padding(4, 5, 4, 5);
            Email.Name = "Email";
            Email.Size = new Size(502, 46);
            Email.TabIndex = 6;
            Email.Texto = "";
            Email.TratarComoSenha = false;
            // 
            // NomeUsuario
            // 
            NomeUsuario.Anchor = AnchorStyles.None;
            NomeUsuario.Label = "Nome de Usuário";
            NomeUsuario.Location = new Point(149, 128);
            NomeUsuario.Margin = new Padding(4, 5, 4, 5);
            NomeUsuario.Name = "NomeUsuario";
            NomeUsuario.Size = new Size(502, 46);
            NomeUsuario.TabIndex = 5;
            NomeUsuario.Texto = "";
            NomeUsuario.TratarComoSenha = false;
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
        private Componentes.InputTexto Senha2;
        private Componentes.InputTexto Senha1;
        private Componentes.InputTexto Email;
        private Label LabelHistoricoTransacoes;
        private Componentes.InputTexto NomeUsuario;
        private Componentes.BotaoPrimario BotaoCadastrar;
        private LinkLabel Login;
        private Componentes.InputTexto Nome;
    }
}