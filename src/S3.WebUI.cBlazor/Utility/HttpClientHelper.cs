using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace S3.WebUI.cBlazor.Utility
{
    public static class HttpClientHelper
    {
        public static Task<T> GetJSONAsync<T>(this System.Net.Http.HttpClient client, string url)
        {
            return client.GetJsonAsync<T>(requestUri: url);
        }
    }
}
