using SAP_Mobile.Models.Request;
using SAP_Mobile.Models.Response;

namespace SAP_Mobile.Repositories.Login
{
    public interface ILoginRepository
    {
        Task<LoginResponse> LoginAsync(LoginRequest loginRequest);
    }
}
