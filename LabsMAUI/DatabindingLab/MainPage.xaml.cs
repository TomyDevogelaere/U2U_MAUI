using Sandwiches.ViewModels;

namespace Sandwiches;

public partial class MainPage : ContentPage
{
    private readonly SandwichListViewModel viewModel = new SandwichListViewModel();

    public MainPage()
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    private void AddNewSandwich(object _, EventArgs __) => viewModel.AddNewSandwich();

    private void AddSandwich(object _, EventArgs __) => viewModel.AddSandwich();

    private void ShowList(object sender, EventArgs e) => viewModel.ShowSandwichList();
}

