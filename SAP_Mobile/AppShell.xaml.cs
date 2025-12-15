namespace SAP_Mobile;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(InitialPage), typeof(InitialPage));
        Routing.RegisterRoute(nameof(PNPage), typeof(PNPage));
    }
}
