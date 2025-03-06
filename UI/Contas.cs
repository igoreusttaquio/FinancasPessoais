using UI.Modais;

namespace UI;

public partial class Contas : Form
{
    public Contas()
    {
        InitializeComponent();
    }

    private void botaoPrimario1_Click(object sender, EventArgs e)
    {
        new ContaModal().ShowDialog();
    }
}
