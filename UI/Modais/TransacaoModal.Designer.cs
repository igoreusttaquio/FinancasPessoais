namespace UI.Modais;

partial class TransacaoModal
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
        Valor = new Componentes.InputTexto();
        Descricao = new Componentes.InputTexto();
        ComboContas = new Componentes.InputCombo();
        ComboCategorias = new Componentes.InputCombo();
        BotaoSalvar = new Componentes.BotaoPrimario();
        TipoTransacao = new Componentes.Radios();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(Valor, 0, 4);
        tableLayoutPanel1.Controls.Add(Descricao, 0, 3);
        tableLayoutPanel1.Controls.Add(ComboContas, 0, 0);
        tableLayoutPanel1.Controls.Add(ComboCategorias, 0, 1);
        tableLayoutPanel1.Controls.Add(BotaoSalvar, 0, 5);
        tableLayoutPanel1.Controls.Add(TipoTransacao, 0, 2);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(10, 10);
        tableLayoutPanel1.Margin = new Padding(0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.Padding = new Padding(2);
        tableLayoutPanel1.RowCount = 6;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6112957F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.9368763F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.6079731F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.7419357F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.0645161F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9354839F));
        tableLayoutPanel1.Size = new Size(590, 314);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // Valor
        // 
        Valor.Dock = DockStyle.Fill;
        Valor.Label = "Valor";
        Valor.Location = new Point(5, 222);
        Valor.Name = "Valor";
        Valor.Size = new Size(580, 49);
        Valor.TabIndex = 3;
        Valor.Texto = "";
        // 
        // Descricao
        // 
        Descricao.Dock = DockStyle.Fill;
        Descricao.Label = "Descrição";
        Descricao.Location = new Point(5, 168);
        Descricao.Name = "Descricao";
        Descricao.Size = new Size(580, 48);
        Descricao.TabIndex = 2;
        Descricao.Texto = "";
        // 
        // ComboContas
        // 
        ComboContas.Dock = DockStyle.Fill;
        ComboContas.Label = "Conta";
        ComboContas.Location = new Point(5, 5);
        ComboContas.Name = "ComboContas";
        ComboContas.Size = new Size(580, 45);
        ComboContas.TabIndex = 5;
        ComboContas.Valor = null;
        // 
        // ComboCategorias
        // 
        ComboCategorias.Dock = DockStyle.Fill;
        ComboCategorias.Label = "Categoria";
        ComboCategorias.Location = new Point(5, 56);
        ComboCategorias.Name = "ComboCategorias";
        ComboCategorias.Size = new Size(580, 52);
        ComboCategorias.TabIndex = 6;
        ComboCategorias.Valor = null;
        // 
        // BotaoSalvar
        // 
        BotaoSalvar.Anchor = AnchorStyles.Right;
        BotaoSalvar.BackColor = Color.FromArgb(100, 111, 229);
        BotaoSalvar.FlatAppearance.BorderSize = 0;
        BotaoSalvar.FlatStyle = FlatStyle.Flat;
        BotaoSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        BotaoSalvar.ForeColor = Color.FromArgb(5, 6, 63);
        BotaoSalvar.Location = new Point(433, 277);
        BotaoSalvar.Name = "BotaoSalvar";
        BotaoSalvar.Size = new Size(152, 32);
        BotaoSalvar.TabIndex = 1;
        BotaoSalvar.Text = "Adicionar Transação";
        BotaoSalvar.UseVisualStyleBackColor = false;
        BotaoSalvar.Click += BotaoSalvar_Click;
        // 
        // TipoTransacao
        // 
        TipoTransacao.BackColor = Color.FromArgb(31, 41, 55);
        TipoTransacao.Dock = DockStyle.Fill;
        TipoTransacao.Location = new Point(5, 114);
        TipoTransacao.Name = "TipoTransacao";
        TipoTransacao.Size = new Size(580, 48);
        TipoTransacao.TabIndex = 7;
        TipoTransacao.TextoPrimeiraOpcao = "Receita";
        TipoTransacao.TextoSegundaOpcao = "Despesa";
        TipoTransacao.Titulo = "Tipo";
        // 
        // TransacaoModal
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(31, 41, 55);
        ClientSize = new Size(610, 334);
        Controls.Add(tableLayoutPanel1);
        ForeColor = SystemColors.Control;
        Name = "TransacaoModal";
        Padding = new Padding(10);
        StartPosition = FormStartPosition.CenterParent;
        Text = "Transacao";
        tableLayoutPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Componentes.InputTexto Valor;
    private Componentes.InputTexto Descricao;
    private Componentes.BotaoPrimario BotaoSalvar;
    private Componentes.InputCombo ComboContas;
    private Componentes.InputCombo ComboCategorias;
    private Componentes.Radios TipoTransacao;
}