namespace UI.Modais;

partial class ContaModal
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
        Saldo = new Componentes.InputTexto();
        NomeConta = new Componentes.InputTexto();
        ComboTipoConta = new Componentes.InputCombo();
        BotaoSalvar = new Componentes.BotaoPrimario();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(Saldo, 0, 2);
        tableLayoutPanel1.Controls.Add(NomeConta, 0, 0);
        tableLayoutPanel1.Controls.Add(ComboTipoConta, 0, 1);
        tableLayoutPanel1.Controls.Add(BotaoSalvar, 0, 3);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(14, 17);
        tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.Size = new Size(961, 346);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // Saldo
        // 
        Saldo.Dock = DockStyle.Fill;
        Saldo.Label = "Saldo";
        Saldo.Location = new Point(6, 180);
        Saldo.Margin = new Padding(6, 8, 6, 8);
        Saldo.Name = "Saldo";
        Saldo.Size = new Size(949, 70);
        Saldo.TabIndex = 2;
        Saldo.Texto = "";
        Saldo.TratarComoSenha = false;
        // 
        // NomeConta
        // 
        NomeConta.Dock = DockStyle.Fill;
        NomeConta.Label = "Nome";
        NomeConta.Location = new Point(6, 8);
        NomeConta.Margin = new Padding(6, 8, 6, 8);
        NomeConta.Name = "NomeConta";
        NomeConta.Size = new Size(949, 70);
        NomeConta.TabIndex = 0;
        NomeConta.Texto = "";
        NomeConta.TratarComoSenha = false;
        // 
        // ComboTipoConta
        // 
        ComboTipoConta.Dock = DockStyle.Fill;
        ComboTipoConta.Label = "Tipo";
        ComboTipoConta.Location = new Point(6, 94);
        ComboTipoConta.Margin = new Padding(6, 8, 6, 8);
        ComboTipoConta.Name = "ComboTipoConta";
        ComboTipoConta.Size = new Size(949, 70);
        ComboTipoConta.TabIndex = 3;
        ComboTipoConta.Valor = null;
        // 
        // BotaoSalvar
        // 
        BotaoSalvar.Anchor = AnchorStyles.Right;
        BotaoSalvar.BackColor = Color.FromArgb(100, 111, 229);
        BotaoSalvar.FlatAppearance.BorderSize = 0;
        BotaoSalvar.FlatStyle = FlatStyle.Flat;
        BotaoSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        BotaoSalvar.ForeColor = Color.FromArgb(5, 6, 63);
        BotaoSalvar.Location = new Point(791, 273);
        BotaoSalvar.Margin = new Padding(4, 5, 4, 5);
        BotaoSalvar.Name = "BotaoSalvar";
        BotaoSalvar.Size = new Size(166, 57);
        BotaoSalvar.TabIndex = 1;
        BotaoSalvar.Text = "Adicionar Conta";
        BotaoSalvar.UseVisualStyleBackColor = false;
        BotaoSalvar.Click += BotaoSalvar_Click;
        // 
        // ContaModal
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(31, 41, 55);
        ClientSize = new Size(989, 380);
        Controls.Add(tableLayoutPanel1);
        Margin = new Padding(4, 5, 4, 5);
        Name = "ContaModal";
        Padding = new Padding(14, 17, 14, 17);
        StartPosition = FormStartPosition.CenterParent;
        Text = "Conta";
        tableLayoutPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Componentes.InputTexto Saldo;
    private Componentes.InputTexto NomeConta;
    private Componentes.InputCombo ComboTipoConta;
    private Componentes.BotaoPrimario BotaoSalvar;
}