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
    public class StudentScoreService : IStudentScoreService
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;
        private readonly IConfiguration _configuration;

        public StudentScoreService(IConfiguration configuration, HttpClient httpClient, IAuthService authService, AppSettings appSettings)
            => (_httpClient, _appSettings, _configuration) = (httpClient, appSettings, configuration);

        public async Task CreateAsync(ClassSubjectScores classSubjectScores)
            => await _httpClient.PostJsonAsync($"{_appSettings.ApiUrl}/{GetEndPoint("create")}", classSubjectScores);

        public async Task DeleteAsync(string id)
            => await _httpClient.DeleteAsync($"{_appSettings.ApiUrl}/{GetEndPoint("delete")}/{id}");

        public async Task<StudentScore[]> GetAllAsync(string? schoolId = null, string? studentId = null, string? classId = null,
            string? subject = null, string? examType = null, int? term = null, int? session = null, string[]? include = null)
            => await _httpClient.GetJsonAsync<StudentScore[]>($"{_appSettings.ApiUrl}/{GetEndPoint("getAll")}" +
                $"{IncludeStringHelper.GetString(include)}schoolId={schoolId}&studentId={studentId}&classId={classId}&subject={subject}" +
                $"&examType={examType}&term={term}&session={session}");


        public async Task<StudentScore> GetAsync(string id, string[]? include = null)
            => await _httpClient.GetJsonAsync<StudentScore>($"{_appSettings.ApiUrl}/{GetEndPoint("get")}/{id}{IncludeStringHelper.GetString(include)}");

        public async Task UpdateAsync(ClassSubjectScores classSubjectScores)
            => await _httpClient.PutJsonAsync($"{_appSettings.ApiUrl}/{GetEndPoint("update")}", classSubjectScores);

        private string GetEndPoint(string endPointName)
            => Regex.Replace(_configuration.GetSection("endpoints")[endPointName], "variable", $"rec/StudentScores");

        //public async Task<Student[]> GetAllAsync(string parentId, string? schoolId = null, string[]? include = null)
        //{
        //    var endpoint = Regex.Replace(_configuration.GetSection("endpoints")["getAll"], "variable", $"reg/Students");

        //    return await _httpClient.GetJsonAsync<Student[]>($"{_appSettings.ApiUrl}/{endpoint}{IncludeStringHelper.GetString(include)}SchoolId={schoolId}&ParentId={parentId}");
        //}
    }
}
