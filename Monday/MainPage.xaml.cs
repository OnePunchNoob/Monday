using Monday.Pages;

namespace Monday;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        Navigation.PushAsync(new LoginPage());
    }

   

}