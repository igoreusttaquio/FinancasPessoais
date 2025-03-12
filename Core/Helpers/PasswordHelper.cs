
using System.Security.Cryptography;
using System.Text;

namespace Core.Helpers;

public static class PasswordHelper
{

    // Método para gerar hash de senha com um salt
    public static string GerarHashSenha(string senha, out string salt)
    {
        // Gerar um salt aleatório
        using (var rng = RandomNumberGenerator.Create())
        {
            var saltBytes = new byte[16]; // 16 bytes para o salt
            rng.GetBytes(saltBytes);
            salt = Convert.ToBase64String(saltBytes);

            // Combinar senha com o salt
            var senhaComSalt = senha + salt;

            // Gerar hash da senha com o salt usando SHA-256
            using (var sha256 = SHA256.Create())
            {
                var senhaHashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senhaComSalt));
                return Convert.ToBase64String(senhaHashBytes);
            }
        }
    }

    // Método para verificar se a senha fornecida corresponde ao hash armazenado
    public static bool VerificarSenha(string senha, string hashArmazenado, string salt)
    {
        // Recalcular o hash usando o salt
        var senhaComSalt = senha + salt;
        using (var sha256 = SHA256.Create())
        {
            var senhaHashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senhaComSalt));
            var hashCalculado = Convert.ToBase64String(senhaHashBytes);

            // Comparar os hashes
            return hashCalculado == hashArmazenado;
        }
    }
}
