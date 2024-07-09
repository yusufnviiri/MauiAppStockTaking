using Microsoft.Extensions.Logging;
using IBrowser = IdentityModel.OidcClient.Browser.IBrowser;


namespace MauiAppStockTaking
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton<IBrowser, AuthBrowser>();
            builder.Services.AddSingleton<IAuthService, AuthService>();
            builder.Services.AddTransient<LoginPage>();



#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
