using Core.Dados;
using Core.Helpers;
using Microsoft.EntityFrameworkCore;
using UI.Services;

namespace UI
{
    public partial class Login : Form
    {
        ILogin _login;
        INavigationService _navigationService;
        BancoDadosContexto _bancoDadosContexto { get; set; }
        public Login(
            ILogin login,
            INavigationService navigationService,
            BancoDadosContexto bancoDadosContexto)
        {
            InitializeComponent();
            _navigationService = navigationService;
            _bancoDadosContexto = bancoDadosContexto;
            _login = login;
        }

        private async void BotaoLogin_Click(object sender, EventArgs e)
        {
            var usuario = await _bancoDadosContexto.Usuarios.FirstOrDefaultAsync(u => u.Login == NomeUsuario.Texto);
            if (usuario == null)
            {
                MessageBox.Show("Usuário não encontrado!");
                return;
            }

            if (PasswordHelper.VerificarSenha(Senha.Texto, usuario.HashSenha, usuario.SaltoSenha) is false)
            {
                MessageBox.Show("A senha fornecida é inválida!");
                return;
            }

            Program.Logado = true;
            _login.PerformarLogin();
        }

        private void LinkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _navigationService.NavigateTo<Registrar>();
        }
    }
}
