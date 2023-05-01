namespace Monday.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
        
	}

    
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Get the values of the username and password entries
        //string username = usernameEntry.Text;
        //string password = passwordEntry.Text;

        string username = "admin";
        string password = "password";


        // Validate the user's credentials
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            await DisplayAlert("Error", "Please enter a username and password.", "OK");
        }
        else if (username != "admin" || password != "password")
        {
            await DisplayAlert("Error", "Incorrect username or password.", "OK");
        }
        else
        {
            // Navigate to the main page of the app
            await Navigation.PushAsync(new HomePage());
        }
    }
}