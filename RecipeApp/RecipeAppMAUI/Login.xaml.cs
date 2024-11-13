using RecipeSystem;

namespace RecipeAppMAUI;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void LoginBtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            MessageLbl.Text = "";
            DBmanager.SetConnectionString(App.connStringSetting, true, UserNameTxt.Text, PasswordTxt.Text);
            App.LoggedIn = true;
            await Navigation.PopModalAsync();
        }
        catch (Exception ex)
        {
            MessageLbl.Text = ex.Message;
        }
    }

    private void CancelBtn_Clicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }
}