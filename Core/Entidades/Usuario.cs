namespace Core.Entidades;

public class Usuario
{
    public Guid Id { get; set; }
    public string Login { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }

    public string SaltoSenha { get; set; }
    public string HashSenha { get; set; }
}
