using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using S3.WebUI.cBlazor.Shared.Models;
using S3.WebUI.cBlazor.Shared.Services.Interface;
using S3.WebUI.cBlazor.Utility;

namespace S3.WebUI.cBlazor.Shared.Services
{
    public abstract class HttpService<T, N> : IGenericService<T, N>  // T = type, N = External Service Name
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;
        private readonly IConfiguration _configuration;

        protected HttpService(HttpClient httpClient, AppSettings appSettings, IConfiguration configuration)
            => (_httpClient, _appSettings, _configuration) = (httpClient, appSettings, configuration);


        public async Task<T> GetAsync(string id, string[] include = null) 
            => await _httpClient.GetJsonAsync<T>($"{_appSettings.ApiUrl}/{GetEndPoint("get", typeof(T), typeof(N))}/{id}{IncludeStringHelper.GetString(include)}");

        public async Task<T[]> GetAllAsync(string? schoolId = null, string[]? include = null) 
            => await _httpClient.GetJsonAsync<T[]>($"{_appSettings.ApiUrl}/{GetEndPoint("getAll", typeof(T), typeof(N))}{IncludeStringHelper.GetString(include)}SchoolId={schoolId}");

        public async Task CreateAsync(T t) 
            => await CreateHttpRequestAsync(http => http.PostJsonAsync($"{_appSettings.ApiUrl}/{GetEndPoint("create", typeof(T), typeof(N))}", t));

        public async Task UpdateAsync(T t) 
            => CreateHttpRequestAsync(http => http.PutJsonAsync($"{_appSettings.ApiUrl}/{GetEndPoint("update", typeof(T), typeof(N))}", t));

        public async Task DeleteAsync(string id) 
            => CreateHttpRequestAsync(http => http.DeleteAsync($"{_appSettings.ApiUrl}/{GetEndPoint("delete", typeof(T), typeof(N))}/{id}"));

        private async Task CreateHttpRequestAsync(Func<HttpClient, Task> request, bool authorized = true)
           => await request(_httpClient);

        private string GetEndPoint(string endPointName, Type type, Type serviceName)
        {
            string typeName = type.Name.EndsWith("s") ? $"{type.Name}es" :
                type.Name.EndsWith("y") ?
                $"{type.Name.Substring(0, type.Name.Length - 1)}ies" :
                $"{type.Name}s";
            //string typeName = type.Name.EndsWith('s') ? $"{type.Name}es" :
            //    type.Name.EndsWith('y') ? 
            //    $"{type.Name[0..^1]}ies" :
            //    $"{type.Name}s";

            string servicePrefix = serviceName.Name switch
            {
                "Registration" => "reg",
                "Record" => "rec",
                "Notification" => "notif",
                _ => ""
            };

            return Regex.Replace(_configuration.GetSection("endpoints")[endPointName], "variable", $"{servicePrefix}/{typeName}");
        }
    }
}


//using System;
//using System.IO;
//using System.Linq;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Blazor;
//using Microsoft.AspNetCore.Components;
//using S3.WebUI.cBlazor.Shared.Models;
//using S3.WebUI.cBlazor.Shared.Services.Interface;

//namespace S3.WebUI.cBlazor.Shared.Services
//{
//    public abstract class HttpService
//    {
//        private readonly HttpClient _httpClient;
//        private readonly IAuthService _authService;
//        private readonly AppSettings _settings;

//        protected HttpService(HttpClient httpClient, IAuthService authService, AppSettings settings)
//        {
//            _httpClient = httpClient;
//            _authService = authService;
//            _settings = settings;
//        }

//        protected async Task<TResult> GetAsync<TResult>(string endpoint, bool authorized = true)
//            => await _httpClient.GetJsonAsync<TResult>($"{_settings.ApiUrl}/{endpoint}");

//        protected Task PostAsync(string endpoint, object content, bool authorized = true)
//            => CreateHttpRequestAsync(http => http.PostJsonAsync($"{_settings.ApiUrl}/{endpoint}", content), authorized);

//        protected async Task<TResult> PostAsync<TResult>(string endpoint, object content, bool authorized = true)
//            => await _httpClient.PostJsonAsync<TResult>($"{_settings.ApiUrl}/{endpoint}", content);

//        protected Task PutAsync(string endpoint, object content, bool authorized = true)
//            => CreateHttpRequestAsync(http => http.PutJsonAsync($"{_settings.ApiUrl}/{endpoint}", content), authorized);

//        protected Task DeleteAsync(string endpoint, bool authorized = true)
//            => CreateHttpRequestAsync(http => http.DeleteAsync($"{_settings.ApiUrl}/{endpoint}"), authorized);

//        private async Task CreateHttpRequestAsync(Func<HttpClient, Task> request, bool authorized = true)
//            => await request(_httpClient);
//    }
//}