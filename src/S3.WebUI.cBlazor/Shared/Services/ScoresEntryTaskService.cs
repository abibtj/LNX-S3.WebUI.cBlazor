using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using S3.WebUI.cBlazor.Models;
using S3.WebUI.cBlazor.Shared.Models;
using S3.WebUI.cBlazor.Shared.Services.Interface;
using S3.WebUI.cBlazor.Utility;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace S3.WebUI.cBlazor.Shared.Services
{
    public class ScoresEntryTaskService : HttpService<ScoresEntryTask, Registration>, IScoresEntryTaskService
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;
        private readonly IConfiguration _configuration;

        public ScoresEntryTaskService(IConfiguration configuration, HttpClient httpClient, AppSettings appSettings)
            : base(httpClient, appSettings, configuration)
        => (_httpClient, _appSettings, _configuration) = (httpClient, appSettings, configuration);


        public async Task<ScoresEntryTask[]> GetAllForTeacherAsync(string teacherId, string? schoolId = null, string[]? include = null)
        {
            var endpoint = Regex.Replace(_configuration.GetSection("endpoints")["getAll"], "variable", $"reg/ScoresEntryTasks");

            return await _httpClient.GetJsonAsync<ScoresEntryTask[]>($"{_appSettings.ApiUrl}/{endpoint}{IncludeStringHelper.GetString(include)}SchoolId={schoolId}&TeacherId={teacherId}");
        }
    }
}
