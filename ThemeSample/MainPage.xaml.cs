namespace ThemeSample
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.UserAppTheme = AppTheme.Dark;
        }
    }

}
