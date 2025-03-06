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
        Saldo = new UI.Componentes.InputTexto();
        NomeConta = new UI.Componentes.InputTexto();
        ComboTipoConta = new UI.Componentes.InputCombo();
        botaoPrimario1 = new UI.Componentes.BotaoPrimario();
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
        // Saldo
        // 
        Saldo.Dock = DockStyle.Fill;
        Saldo.Label = "Saldo";
        Saldo.Location = new Point(3, 107);
        Saldo.Name = "Saldo";
        Saldo.Size = new Size(666, 46);
        Saldo.TabIndex = 2;
        Saldo.Texto = "";
        // 
        // NomeConta
        // 
        NomeConta.Dock = DockStyle.Fill;
        NomeConta.Label = "Nome";
        NomeConta.Location = new Point(3, 3);
        NomeConta.Name = "NomeConta";
        NomeConta.Size = new Size(666, 46);
        NomeConta.TabIndex = 0;
        NomeConta.Texto = "";
        // 
        // ComboTipoConta
        // 
        ComboTipoConta.Dock = DockStyle.Fill;
        ComboTipoConta.Label = "Tipo";
        ComboTipoConta.Location = new Point(3, 55);
        ComboTipoConta.Name = "ComboTipoConta";
        ComboTipoConta.Size = new Size(666, 46);
        ComboTipoConta.TabIndex = 3;
        ComboTipoConta.Valor = null;
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
        botaoPrimario1.Click += botaoPrimario1_Click;
        // 
        // ContaModal
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(31, 41, 55);
        ClientSize = new Size(692, 228);
        Controls.Add(tableLayoutPanel1);
        Name = "ContaModal";
        Padding = new Padding(10);
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
    private Componentes.BotaoPrimario botaoPrimario1;
}