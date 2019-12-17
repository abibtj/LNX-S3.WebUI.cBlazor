//using Microsoft.AspNetCore.Components;
//using Microsoft.Extensions.Configuration;
//using S3.WebUI.cBlazor.Models;
//using S3.WebUI.cBlazor.Shared.Models;
//using S3.WebUI.cBlazor.Shared.Services;
//using S3.WebUI.cBlazor.Shared.Services.Interface;
//using S3.WebUI.cBlazor.Utility;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Text.Json;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace S3.WebUI.cBlazor.Shared.Services
//{
//    public class ClassSubjectScoresService : HttpService<ClassSubjectScores, Record>, IClassSubjectScoresService
//    {
//        private readonly HttpClient _httpClient;
//        private readonly AppSettings _appSettings;
//        private readonly IConfiguration _configuration;

//        public ClassSubjectScoresService(IConfiguration configuration, HttpClient httpClient, AppSettings appSettings)
//            : base(httpClient, appSettings, configuration)
//            => (_httpClient, _appSettings, _configuration) = (httpClient, appSettings, configuration);

//        //public async Task<StudentScore> FindAsync(string? schoolId, string? classId, string? subject, string? examType,
//        //    string? term, int? session, string[]? include = null)
//        //{
//        //    var endpoint = Regex.Replace(_configuration.GetSection("endpoints")["getAll"], "variable", $"rec/ClassSubjectScores");

//        //    var classSubjectScores = await _httpClient.GetJsonAsync<StudentScore[]>($"{_appSettings.ApiUrl}/{endpoint}" +
//        //        $"{IncludeStringHelper.GetString(include)}schoolId={schoolId}&classId={classId}&subject={subject}" +
//        //        $"examType={examType}&term={term}&session={session}");

//        //    return classSubjectScores?.FirstOrDefault();
//        //}
//    }
//}
