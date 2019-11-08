using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using S3.WebUI.cBlazor.Models;
using S3.WebUI.cBlazor.Shared.Models;
using S3.WebUI.cBlazor.Shared.Services;
using S3.WebUI.cBlazor.Shared.Services.Interface;
using S3.WebUI.cBlazor.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace S3.WebUI.cBlazor.Shared.Services
{
    public class ParentService : HttpService<Parent, Registration>, IParentService
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;
        private readonly IConfiguration _configuration;

        public ParentService(IConfiguration configuration, HttpClient httpClient, AppSettings appSettings)
            : base(httpClient, appSettings, configuration)
            => (_httpClient, _appSettings, _configuration) = (httpClient, appSettings, configuration);

        public async Task<Parent> GetAsync(string regNumber)
        {
            var endpoint = Regex.Replace(_configuration.GetSection("endpoints")["get"], "variable", $"reg/Parents");

            return await _httpClient.GetJsonAsync<Parent>($"{_appSettings.ApiUrl}/{endpoint}/{regNumber}");
        }
    }
}
