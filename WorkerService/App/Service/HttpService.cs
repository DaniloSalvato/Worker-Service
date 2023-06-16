using System.Net;
using WorkerService.App.Interface;

namespace WorkerService.App.Service
{
    public class HttpService : IHttpService
    {
        public async Task<HttpStatusCode> CheckStatusSite(string url)
        {
            var client = new HttpClient();
            try
            {
                var response = await client.GetAsync(url);
                return response.StatusCode;
            }
            catch (HttpRequestException)
            {

                return HttpStatusCode.NotFound;
            }
            finally
            {
                client.Dispose();
            }
        }
    }
}
