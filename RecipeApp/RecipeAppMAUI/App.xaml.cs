namespace RecipeAppMAUI
{
    public partial class App : Application
    {
        public static bool LoggedIn = false;
        public static string connStringSetting = "";
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
