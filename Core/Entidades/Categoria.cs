﻿namespace Core.Entidades;

public class Categoria
{
    public Guid Id { get; set; }
    //public Guid UsuarioId { get; set; }
    public string NomeCategoria { get; set; } = string.Empty;
    public decimal Orcamento { get; set; }
    public DateTime CriadoEm { get; set; }

    // Relacionamento com o usuário
    // public Usuario? Usuario { get; set; }

    // Relacionamento com as transações
    public ICollection<Transacao>? Transacoes { get; set; }

    public override string ToString()
    {
        return NomeCategoria;
    }
}
