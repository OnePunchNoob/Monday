using Monday.Pages;

namespace Monday;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Shell shell = new Shell();
        shell.CurrentItem = new FlyoutItem
        {
            FlyoutDisplayOptions = FlyoutDisplayOptions.AsSingleItem,
            Title = "Login",
            Items =
    {
        new ShellContent
        {
            ContentTemplate = new LoginPage()
        }
    }
        };
    }


}
