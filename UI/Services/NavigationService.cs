using Microsoft.Extensions.DependencyInjection;

namespace UI.Services;

public class NavigationService : INavigationService
{
    public bool CanGoBack => navigationStack.Count > 0;
    private readonly Stack<Form> navigationStack = new();
    private IServiceProvider serviceProvider;
    private Control container;
    private Form currentForm;

    public NavigationService(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }
    public void InitializeContainer(Control container)
    {
        this.container = container;
    }

    public void GoBack()
    {
        if (!CanGoBack) return;
        var previousForm = navigationStack.Pop();
        currentForm.Hide();
        currentForm.Dispose();

        container.Controls.Add(previousForm);
        previousForm.Show();
        currentForm = previousForm;
    }

    public void NavigateTo<T>() where T : Form
    {
        var form = serviceProvider.GetRequiredService<T>();
        form.TopLevel = false;
        form.FormBorderStyle = FormBorderStyle.None;
        form.Dock = DockStyle.Fill;

        if (currentForm != null)
        {
            navigationStack.Push(currentForm);
            currentForm.Hide();
        }

        container.Controls.Add(form);
        form.Show();
        currentForm = form;
    }

    public void Pop()
    {
        while (navigationStack.Count > 0) {
            navigationStack.Pop();
        }
    }
}
