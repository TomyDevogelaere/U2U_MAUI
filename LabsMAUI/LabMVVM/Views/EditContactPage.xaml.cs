using LabMVVM.ViewModels;

namespace LabMVVM.Views;

public partial class EditContactPage : ContentPage
{
	public EditContactPage(int contactId)
	{
		BindingContext = new EditContactViewModel() { ContactId = contactId };
		InitializeComponent();
	}
}