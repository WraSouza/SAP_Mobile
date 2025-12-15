namespace SAP_Mobile.Views;

public partial class InitialPage : ContentPage
{
	public InitialPage(InitialPageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
    }
}