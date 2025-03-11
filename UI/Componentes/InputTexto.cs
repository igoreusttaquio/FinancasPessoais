using System.ComponentModel;

namespace UI.Componentes
{
    public partial class InputTexto : UserControl
    {
        public InputTexto()
        {
            InitializeComponent();
        }

        [Browsable(true)]  // Propriedade visível no PropertyGrid
        [Category("Customizados")]
        [Description("Texto que será exibido no input.")]
        public string Texto
        {
            get => Input.Text;
            set
            {
                if (Input.Text != value)
                {
                    Input.Text = value;
                }
            }
        }

        [Browsable(true)]  // Propriedade visível no PropertyGrid
        [Category("Customizados")]
        [Description("Label que será exibido no input.")]
        public string Label
        {
            get => Titulo.Text;
            set => Titulo.Text = value;
        }

        [Browsable(true)]  // Propriedade visível no PropertyGrid
        [Category("Customizados")]
        [Description("Define se o imput sera tratado como senha")]
        public bool TratarComoSenha
        {
            get => Input.PasswordChar != '\0';
            set
            {
                if (value)
                {
                    Input.PasswordChar = '*';
                    TableLayoutPanelCorpo.ColumnStyles[0].SizeType = SizeType.Percent;
                    TableLayoutPanelCorpo.ColumnStyles[1].SizeType = SizeType.Percent;

                    TableLayoutPanelCorpo.ColumnStyles[0].Width = 90f;
                    TableLayoutPanelCorpo.ColumnStyles[1].Width = 10f;
                }
                else
                {
                    TableLayoutPanelCorpo.ColumnStyles[0].SizeType = SizeType.Percent;
                    TableLayoutPanelCorpo.ColumnStyles[1].SizeType = SizeType.Percent;

                    TableLayoutPanelCorpo.ColumnStyles[0].Width = 100f;
                    TableLayoutPanelCorpo.ColumnStyles[1].Width = 0f;
                    Input.PasswordChar = '\0';
                }
            }
        }

        private void BotaoExibirSenha_Click(object sender, EventArgs e)
        {
            Input.PasswordChar = Input.PasswordChar == '\0' ? '*' : '\0';

            BotaoExibirSenha.Image = Input.PasswordChar == '\0' ? Properties.Resources.ocultar : Properties.Resources.exibir;

        }
    }
}
