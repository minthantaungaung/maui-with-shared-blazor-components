using RazorClassLibrary.Model;

namespace RazorClassLibrary.Data
{
    public interface IHttpRepo
    {
        Task<List<CupSettlementDto>?> CUPReport(string TrnDate);
    }
}
