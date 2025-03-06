namespace Core.Modelos;

public record TipoConta
{
    public string Codigo { get; init; }
    public string Descricao { get; init; }

    public TipoConta(string codigo, string descricao)
    {
        Codigo = codigo;
        Descricao = descricao;
    }

    public override string ToString()
    {
        return Descricao;
    }
}
