using Core.Dados;
using Core.Entidades;
using Core.Helpers;
using UI.Services;

namespace UI;

public partial class Registrar : Form
{
    BancoDadosContexto _bancoDadosContexto;
    INavigationService _navigationService;
    public Registrar(
        BancoDadosContexto bancoDadosContexto,
        INavigationService navigationService)
    {
        InitializeComponent();
        _bancoDadosContexto = bancoDadosContexto;
        _navigationService = navigationService;
    }

    private async void BotaoCadastrar_Click(object sender, EventArgs e)
    {
        if (Senha1.Texto != Senha2.Texto)
        {
            _ = MessageBox.Show("As senhas nao combinam!");
            return;
        }

        var usuario = new Usuario
        {
            Id = Guid.NewGuid(),
            Login = NomeUsuario.Texto,
            Nome = Nome.Texto,
            Email = Email.Texto,
            HashSenha = PasswordHelper.GerarHashSenha(Senha1.Texto, out string salto),
            SaltoSenha = salto
        };

        await _bancoDadosContexto.Usuarios.AddAsync(usuario);
        await _bancoDadosContexto.SaveChangesAsync();
        _ = MessageBox.Show("Usuário inserido com sucesso!");
        _navigationService.NavigateTo<Login>();

    }

    private void Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        _navigationService.NavigateTo<Login>();
    }
}
