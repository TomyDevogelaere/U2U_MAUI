namespace LabClipboardWithEssentials
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Clipboard.SetTextAsync(inputEntry.Text);
            
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
           lblPaste.Text = await Clipboard.GetTextAsync();
        }
    }
}