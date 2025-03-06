namespace Core.Entidades;

public class Usuario
{
    Guid UsuarioId { get; set; }
    string Login { get; set; }
    string Nome { get; set; }
    byte[] SaltoSenha { get; set; }
    string HashSenha { get; set; }
}
