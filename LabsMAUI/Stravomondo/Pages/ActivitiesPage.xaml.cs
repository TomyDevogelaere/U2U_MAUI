using Stravomondo.Data;

namespace Stravomondo.Pages;

public partial class ActivitiesPage : ContentPage
{
	public ActivitiesPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        BindingContext = DataSource.Activities;
    }

    private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var activity = e.Item as Activity;
        if (activity == null) return;

        await Shell.Current.GoToAsync($"you/activities/details?id={activity.Id}");
        // deselect item
        ((ListView)sender).SelectedItem = null;
    }
}