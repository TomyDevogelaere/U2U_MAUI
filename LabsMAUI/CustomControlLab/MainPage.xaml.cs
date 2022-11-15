namespace CustomControlLab
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            IsBusy = true;
            await Task.Delay(TimeSpan.FromSeconds(2));
            IsBusy = false;
        }
    }
}