namespace UI.Services;

public interface INavigationService
{
    void NavigateTo<T>() where T : Form;
    void GoBack();
    bool CanGoBack { get; }
    void InitializeContainer(Control container);
    void Pop();
}

