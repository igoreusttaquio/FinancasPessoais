using UI.Modal;

namespace UI
{
    public partial class Transacoes : Form
    {
        public Transacoes()
        {
            InitializeComponent();
        }

        private void BtnAdicionarTransacao_Click(object sender, EventArgs e)
        {
            new TransacaoModal().ShowDialog(); ;
        }
    }
}
