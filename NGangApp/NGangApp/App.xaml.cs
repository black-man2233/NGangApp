 using Xamarin.Forms;


namespace NGangApp
{
    public partial class App : Application
    {
        public static string Filepath;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new OptionMenu());
        }
        
        public App(string filepath)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new OptionMenu());

            Filepath = filepath;
        }


       


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
