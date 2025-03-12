using UI;
using UI.Services;

namespace EmbeddedForms;

public partial class Main : Form
{
    private readonly INavigationService navigationService;
    ILogin _login;
    public Main(INavigationService navigationService, ILogin login)
    {
        this.navigationService = navigationService;
        InitializeComponent();
        AjustarAparenciaBotoes();
        _login = login;

        navigationService.InitializeContainer(Layout.Panel2);
        if (Program.Logado is false)
        {
            Layout.Panel1.Hide();
            navigationService.NavigateTo<Login>();
            AtribuirEventoLogin();
        }

    }

    private void BtnDashboard_Click(object sender, EventArgs e)
    {
        navigationService.NavigateTo<DashBoard>();
    }

    private void BtnContas_Click(object sender, EventArgs e)
    {
        navigationService.NavigateTo<Contas>();
    }

    private void BtnTransacoes_Click(object sender, EventArgs e)
    {
        navigationService.NavigateTo<Transacoes>();
    }

    private void AjustarAparenciaBotoes()
    {
        foreach (var botao in NavBar.Controls.OfType<Button>())
        {
            botao.Cursor = Cursors.Hand;
        }
    }

    private void BtnVoltar_Click(object sender, EventArgs e)
    {
        navigationService.GoBack();
    }

    private void BrnCategoria_Click(object sender, EventArgs e)
    {
        navigationService.NavigateTo<Categorias>();
    }

    void AtribuirEventoLogin()
    {
        _login.PerformarLogin += delegate ()
        {
            Layout.Panel1.Show();
            navigationService.NavigateTo<DashBoard>();
        };
    }
}
