using DevExpress.Maui;
using SAP_Mobile.Repositories.Login;
using SAP_Mobile.Repositories.PN;
using UraniumUI;

namespace SAP_Mobile;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseDevExpressControls()
            .UseDevExpressEditors()
            .ConfigureSyncfusionToolkit()
            .UseUraniumUI()
			.UseUraniumUIMaterial() 
            .UseSentry(options =>
			{
				// TODO: Set the Sentry Dsn
				options.Dsn = "https://examplePublicKey@o0.ingest.sentry.io/0";
			})
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<PNPageViewModel>();
        builder.Services.AddSingleton<InitialPageViewModel>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<InitialPage>();
        builder.Services.AddSingleton<PNPage>();

        builder.Services.AddSingleton<ILoginRepository, LoginRepository>();
        builder.Services.AddSingleton<IPNRepository, PNRepository>();



        return builder.Build();
	}
}
