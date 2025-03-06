namespace UI.Componentes;

public partial class Tabela : DataGridView
{
    public Tabela()
    {
        InitializeComponent();
    }

    private void TabelaBase_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex % 2 == 0)
        {
            Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(25, 30, 36);
        }
    }
}
