using MauiAppStockTaking.Pages;

namespace MauiAppStockTaking
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("login", typeof(LoginPage));
            Routing.RegisterRoute("productdetails", typeof(ProductPage));


        }
       
    }
}
