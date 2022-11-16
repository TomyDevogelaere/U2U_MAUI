using LabMVVM.ViewModels;

namespace LabMVVM.Views;

public partial class ListContactsPage : ContentPage
{
	private readonly ListContactsViewModel vm;
	public ListContactsPage()
	{
		vm = new ListContactsViewModel();
		BindingContext = vm;
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
		if (vm.Contacts == null || !vm.Contacts.Any())
		{
			vm.LoadContactCommand.Execute(null);
		}
    }
}