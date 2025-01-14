using Bileterie.Models;
namespace Bileterie;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (Spectacol)BindingContext;
        slist.DataSpectacol = DateTime.UtcNow;
        await App.Database.SaveSpectacolAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (Spectacol)BindingContext;
        await App.Database.DeleteSpectacolAsync(slist);
        await Navigation.PopAsync();
    }

}