using EmbeddedForms;
using UI.Services;

namespace UI
{
    public partial class Login : Form
    {
        INavigationService _navigationService;
        public Login(INavigationService navigationService)
        {
            InitializeComponent();
            _navigationService = navigationService;
        }

        private void BotaoLogin_Click(object sender, EventArgs e)
        {
            _navigationService.Pop();
            Program.Logado = true;
            _navigationService.NavigateTo<Main>();
        }
    }
}
