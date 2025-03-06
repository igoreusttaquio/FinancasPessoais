using System.ComponentModel;

namespace UI.Componentes;

public partial class InputCombo : UserControl
{
    public InputCombo()
    {
        InitializeComponent();
    }

    [Browsable(true)]  // Propriedade visível no PropertyGrid
    [Category("Customizados")]
    [Description("Valor selecionado no combo")]
    public object? Valor
    {
        get => Combo.SelectedItem;
        set
        {
            if (!Equals(Combo.SelectedItem, value)) // Verifica se o valor realmente mudou
            {
                Combo.SelectedItem = value;  // Atualiza o item selecionado
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

    public void DefinirValores(params object[] valores)
    {
        Combo.Items.Clear();
        Combo.Items.AddRange(valores);
    }
}