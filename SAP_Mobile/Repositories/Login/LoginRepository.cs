using Flurl.Http;
using SAP_Mobile.Helpers;
using SAP_Mobile.Models.Request;
using SAP_Mobile.Models.Response;

namespace SAP_Mobile.Repositories.Login
{
    public class LoginRepository : ILoginRepository
    {
        public async Task<LoginResponse> LoginAsync(LoginRequest loginRequest)
        {
            try
            {
                var response = await Sites.loginURL.PostJsonAsync(loginRequest);

                if (response.ResponseMessage.IsSuccessStatusCode)
                {
                    var content = await response.ResponseMessage.Content.ReadAsStringAsync();

                    var loginResponse = JsonSerializer.Deserialize<LoginResponse>(content);

                    return loginResponse;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return new LoginResponse();
        }
    }
}
