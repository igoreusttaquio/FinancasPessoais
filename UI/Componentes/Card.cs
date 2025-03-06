using System.ComponentModel;
namespace UI.Componentes;

public partial class Card : UserControl
{
    [Browsable(true)]
    [Category("Propriedades Customizadas")]
    //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string TituloCard
    {
        get => Titulo.Text; set
        {
            Titulo.Text = value;
        }
    }

    [Browsable(true)]
    [Category("Propriedades Customizadas")]
    //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string DetralheCard
    {
        get => Detalhe.Text; set
        {
            Detalhe.Text = value;
        }
    }
    public Card()
    {
        InitializeComponent();
    }
}
