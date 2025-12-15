namespace SAP_Mobile.ViewModels
{
    public partial class InitialPageViewModel : BaseViewModel
    {
        [RelayCommand]
        public async Task GoToPNPage()
       => await Shell.Current.GoToAsync(nameof(PNPage));

    }
}
