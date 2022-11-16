using LabMVVM.Views;

namespace LabMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new NavigationPage(new EditContactPage(1));
            MainPage = new NavigationPage(new ListContactsPage());
        }
    }
}