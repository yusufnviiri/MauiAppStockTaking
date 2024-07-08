
using MauiAppStockTaking.Models;


namespace MauiAppStockTaking.Pages;

public partial class InputPage : ContentPage
{
	public InputPage()
	{
		InitializeComponent();
       

    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        var product = new Product
        {
            Name = "This is a product sorting and counter",
            ManufacturerName = "Old Devol of Marietta!!"
        };
        var pageParams = new Dictionary<string, object>{{ "Product", product }};
        await Shell.Current.GoToAsync("productdetails", pageParams);
    }
}