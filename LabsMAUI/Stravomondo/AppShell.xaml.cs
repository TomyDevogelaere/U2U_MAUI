using Stravomondo.Pages;

namespace Stravomondo
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Routing.RegisterRoute("you/activities/details", typeof(ActivityDetailsPage));
            InitializeComponent();
        }
    }
}