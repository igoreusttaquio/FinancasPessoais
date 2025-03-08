using System.Globalization;

namespace UI.Utils;

internal static class Formatador
{
    public static string FormatarParaMoeda(this decimal valor, string cultura = "pt-BR")
    {
        return valor.ToString("C2", new CultureInfo(cultura));
    }
}
