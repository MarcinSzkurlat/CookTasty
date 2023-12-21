using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SharedClassLibrary.Extensions;
using SharedClassLibrary.Persistence;

namespace MAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            var secrets = new ConfigurationBuilder().AddUserSecrets<App>().Build();

            builder.Configuration.AddConfiguration(secrets);
            
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddServices(builder.Configuration);

            var app = builder.Build();

            var scope = app.Services.CreateScope();
            var seeder = scope.ServiceProvider.GetService<Seeder>();
            seeder.SeedAsync();

            return app;
        }
    }
}
