using UI.Componentes;

namespace UI.Utils;

public static class TabelaExtencoes
{
    public static void DesabilitarGeracaoAutomaticaColunas(this Tabela tabela)
    {
        tabela.AutoGenerateColumns = false;
    }
}
