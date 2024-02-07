using RazorClassLibrary.Model;

namespace RazorClassLibrary.Data
{
    public class HttpRepo : IHttpRepo
    {
        private readonly HttpClient _client;
        public HttpRepo(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<CupSettlementDto>?> CUPReport(string TrnDate)
        {
            throw new NotImplementedException();
        }
    }
}
