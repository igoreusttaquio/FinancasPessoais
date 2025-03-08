using System.ComponentModel;

namespace UI.Componentes
{
    public partial class Radios : UserControl
    {
        public Radios()
        {
            InitializeComponent();
        }

        [Browsable(true)]  // Propriedade visível no PropertyGrid
        [Category("Customizados")]
        [Description("Label das opções")]
        public string Titulo
        {
            get => Label.Text;
            set => Label.Text = value;
        }



        [Browsable(true)]
        [Category("Customizados")]
        [Description("Texto primeira Opção")]
        public string TextoPrimeiraOpcao
        {
            get => Radio1.Text;
            set => Radio1.Text = value;
        }

        [Browsable(true)]
        [Category("Customizados")]
        [Description("Valor primeira Opção")]
        public bool PrimeiraOpcaoMarcada
        {
            get => Radio1.Checked;
        }

        [Browsable(true)]
        [Category("Customizados")]
        [Description("Texto segunda Opção")]
        public string TextoSegundaOpcao
        {
            get => Radio2.Text;
            set => Radio2.Text = value;
        }

        [Browsable(true)]
        [Category("Customizados")]
        [Description("Valor segunda Opção")]
        public bool SegundaOpcaoMarcada
        {
            get => Radio2.Checked;
        }


    }
}
