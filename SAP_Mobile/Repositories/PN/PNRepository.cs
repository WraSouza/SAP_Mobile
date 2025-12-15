using Flurl.Http;
using SAP_Mobile.Helpers;
using SAP_Mobile.Models.Response;

namespace SAP_Mobile.Repositories.PN
{
    public class PNRepository : IPNRepository
    {
        public async Task<PNResponse> GetAllPNAsync()
        {
            try
            {
                var response = await Sites.pNURL
                    .WithOAuthBearerToken(await SessionHelper.GetTokenAsync())
                    .GetAsync();

                if (response.ResponseMessage.IsSuccessStatusCode)
                {
                    var content = await response.ResponseMessage.Content.ReadAsStringAsync();

                    var pnResponse = JsonSerializer.Deserialize<PNResponse>(content);

                    return pnResponse;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return new PNResponse();
        }
    }
}
