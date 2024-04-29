namespace ControlDam_YounesSlamani
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Hallo());
        }
    }
}
