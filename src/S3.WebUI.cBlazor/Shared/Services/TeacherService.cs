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
    public class TeacherService : HttpService<Teacher, Registration>, ITeacherService
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;
        private readonly IConfiguration _configuration;

        public TeacherService(IConfiguration configuration, HttpClient httpClient, AppSettings appSettings)
            : base(httpClient, appSettings, configuration)
        => (_httpClient, _appSettings, _configuration) = (httpClient, appSettings, configuration);

        public async Task<Teacher[]> GetAllSignedUpAsync(string? schoolId = null, string[]? include = null)
        {
            var endpoint = Regex.Replace(_configuration.GetSection("endpoints")["getAll"], "variable", $"reg/Teachers");

            return await _httpClient.GetJsonAsync<Teacher[]>($"{_appSettings.ApiUrl}/{endpoint}{IncludeStringHelper.GetString(include)}SchoolId={schoolId}&returnSignedUpTeachers=true");
        }
    }
}
