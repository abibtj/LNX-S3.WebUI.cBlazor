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
    public class ReportService : IReportService
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;
        private readonly IConfiguration _configuration;

        public ReportService(IConfiguration configuration, HttpClient httpClient, IAuthService authService, AppSettings appSettings)
            => (_httpClient, _appSettings, _configuration) = (httpClient, appSettings, configuration);

        public async Task<ClassReport> GetAsync(int session, string? schoolId = null, string? studentId = null, string? classId = null)
            => await _httpClient.GetJsonAsync<ClassReport>($"{_appSettings.ApiUrl}/{GetEndPoint("get")}" +
                $"?schoolId={schoolId}&studentId={studentId}&classId={classId}&session={session}");

        private string GetEndPoint(string endPointName)
            => Regex.Replace(_configuration.GetSection("endpoints")[endPointName], "variable", $"rec/ClassReports");
    }
}
