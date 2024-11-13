namespace RecipeAppMAUI;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
        this.Loaded += Home_Loaded;
	}

    private void Home_Loaded(object? sender, EventArgs e)
    {
        if(App.LoggedIn == false)
        {
            Navigation.PushModalAsync(new Login());
        }
    }
}