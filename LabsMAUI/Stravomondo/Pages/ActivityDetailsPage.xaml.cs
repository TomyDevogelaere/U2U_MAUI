using Stravomondo.Data;

namespace Stravomondo.Pages;

[QueryProperty(nameof(ActivityId),"id")]
public partial class ActivityDetailsPage : ContentPage
{
	public ActivityDetailsPage()
	{
		InitializeComponent();
	}

    public int ActivityId { get; set; }

    protected override void OnAppearing()
    {
        var activity = DataSource.Activities.SingleOrDefault(a => a.Id == ActivityId);
        BindingContext = activity;
    }
}