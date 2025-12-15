namespace SAP_Mobile.Views;

public partial class PNPage : ContentPage
{
    private readonly PNPageViewModel _viewModel;

    public PNPage(PNPageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = _viewModel = viewModel;
     
    }
   
}