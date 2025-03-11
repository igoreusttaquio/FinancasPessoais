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
        tableLayoutPanel1.Location = new Point(14, 17);
        tableLayoutPanel1.Margin = new Padding(0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.Padding = new Padding(3);
        tableLayoutPanel1.RowCount = 6;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6112957F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.9368763F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.6079731F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.7419357F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.0645161F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9354839F));
        tableLayoutPanel1.Size = new Size(843, 523);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // Valor
        // 
        Valor.Dock = DockStyle.Fill;
        Valor.Label = "Valor";
        Valor.Location = new Point(9, 373);
        Valor.Margin = new Padding(6, 8, 6, 8);
        Valor.Name = "Valor";
        Valor.Size = new Size(825, 76);
        Valor.TabIndex = 3;
        Valor.Texto = "";
        Valor.TratarComoSenha = false;
        // 
        // Descricao
        // 
        Descricao.Dock = DockStyle.Fill;
        Descricao.Label = "Descrição";
        Descricao.Location = new Point(9, 283);
        Descricao.Margin = new Padding(6, 8, 6, 8);
        Descricao.Name = "Descricao";
        Descricao.Size = new Size(825, 74);
        Descricao.TabIndex = 2;
        Descricao.Texto = "";
        Descricao.TratarComoSenha = false;
        // 
        // ComboContas
        // 
        ComboContas.Dock = DockStyle.Fill;
        ComboContas.Label = "Conta";
        ComboContas.Location = new Point(9, 11);
        ComboContas.Margin = new Padding(6, 8, 6, 8);
        ComboContas.Name = "ComboContas";
        ComboContas.Size = new Size(825, 69);
        ComboContas.TabIndex = 5;
        ComboContas.Valor = null;
        // 
        // ComboCategorias
        // 
        ComboCategorias.Dock = DockStyle.Fill;
        ComboCategorias.Label = "Categoria";
        ComboCategorias.Location = new Point(9, 96);
        ComboCategorias.Margin = new Padding(6, 8, 6, 8);
        ComboCategorias.Name = "ComboCategorias";
        ComboCategorias.Size = new Size(825, 81);
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
        BotaoSalvar.Location = new Point(619, 462);
        BotaoSalvar.Margin = new Padding(4, 5, 4, 5);
        BotaoSalvar.Name = "BotaoSalvar";
        BotaoSalvar.Size = new Size(217, 53);
        BotaoSalvar.TabIndex = 1;
        BotaoSalvar.Text = "Adicionar Transação";
        BotaoSalvar.UseVisualStyleBackColor = false;
        BotaoSalvar.Click += BotaoSalvar_Click;
        // 
        // TipoTransacao
        // 
        TipoTransacao.BackColor = Color.FromArgb(31, 41, 55);
        TipoTransacao.Dock = DockStyle.Fill;
        TipoTransacao.Location = new Point(9, 193);
        TipoTransacao.Margin = new Padding(6, 8, 6, 8);
        TipoTransacao.Name = "TipoTransacao";
        TipoTransacao.Size = new Size(825, 74);
        TipoTransacao.TabIndex = 7;
        TipoTransacao.TextoPrimeiraOpcao = "Receita";
        TipoTransacao.TextoSegundaOpcao = "Despesa";
        TipoTransacao.Titulo = "Tipo";
        // 
        // TransacaoModal
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(31, 41, 55);
        ClientSize = new Size(871, 557);
        Controls.Add(tableLayoutPanel1);
        ForeColor = SystemColors.Control;
        Margin = new Padding(4, 5, 4, 5);
        Name = "TransacaoModal";
        Padding = new Padding(14, 17, 14, 17);
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