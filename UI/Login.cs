using UI.Services;

namespace UI
{
    public partial class Login : Form
    {
        ILogin _login;
        public Login(ILogin login)
        {
            InitializeComponent();
            _login = login;
        }

        private void BotaoLogin_Click(object sender, EventArgs e)
        {
            Program.Logado = true;
            _login.PerformarLogin();
        }
    }
}
