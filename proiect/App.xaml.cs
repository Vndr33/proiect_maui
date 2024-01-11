using proiect.Pages;
using proiect.Pages.Flyout_Page;

namespace proiect
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HomePage();

           // MainPage = new AppShell();
        }
    }
}
