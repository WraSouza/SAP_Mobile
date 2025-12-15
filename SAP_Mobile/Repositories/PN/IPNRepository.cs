using SAP_Mobile.Models.Response;

namespace SAP_Mobile.Repositories.PN
{
    public interface IPNRepository
    {
        Task<PNResponse> GetAllPNAsync();
    }
}
