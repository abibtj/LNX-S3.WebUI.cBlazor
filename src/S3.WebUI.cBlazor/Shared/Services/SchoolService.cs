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
    public class SchoolService : HttpService<School, Registration>, ISchoolService
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;
        private readonly IConfiguration _configuration;

        public SchoolService(IConfiguration configuration, HttpClient httpClient, AppSettings appSettings)
            : base(httpClient, appSettings, configuration)
        => (_httpClient, _appSettings, _configuration) = (httpClient, appSettings, configuration);

        public async Task<SchoolStatistics[]> GetAllStatsAsync()
        {
            var endpoint = Regex.Replace(_configuration.GetSection("endpoints")["getAll"], "variable", $"reg/Schools");

            return await _httpClient.GetJsonAsync<SchoolStatistics[]>($"{_appSettings.ApiUrl}/{endpoint}?returnSchoolStats=true");
        }
    }
}
