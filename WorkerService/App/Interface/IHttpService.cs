using System.Net;

namespace WorkerService.App.Interface
{
    public interface IHttpService
    {
        Task<HttpStatusCode> CheckStatusSite(string url);
    }
}
