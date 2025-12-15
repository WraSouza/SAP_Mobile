using CommunityToolkit.Maui.Alerts;
using SAP_Mobile.Helpers;
using SAP_Mobile.Models.Request;
using SAP_Mobile.Repositories.Login;

namespace SAP_Mobile.ViewModels;

public partial class MainViewModel(ILoginRepository loginRepository) : BaseViewModel
{
    [ObservableProperty]
    string? companyDB = "SBO_TIARAJU_PRD";

    [ObservableProperty]
    string? userName;

    [ObservableProperty]
    string? password;

    [RelayCommand]
    public async void Login()
    {
        var loginRequest = new LoginRequest(companyDB, userName, password);

        var result = await loginRepository.LoginAsync(loginRequest);

        if (result is null || string.IsNullOrEmpty(result.sessionId))
        {
            var toast = Toast.Make("Falha ao Realizar o Login", CommunityToolkit.Maui.Core.ToastDuration.Long);
            await toast.Show();

            return;
        }

        SessionHelper.SaveToken(result.sessionId, DateTime.Now.AddMinutes(30));       

        await Shell.Current.GoToAsync($"//{nameof(InitialPage)}");
    }
}
