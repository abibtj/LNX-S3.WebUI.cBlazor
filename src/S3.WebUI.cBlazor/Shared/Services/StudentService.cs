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
    public class StudentService : HttpService<Student, Registration>, IStudentService
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;
        private readonly IConfiguration _configuration;

        public StudentService(IConfiguration configuration, HttpClient httpClient, IAuthService authService, AppSettings appSettings)
            : base(httpClient, appSettings, configuration)
            => (_httpClient, _appSettings, _configuration) = (httpClient, appSettings, configuration);

        public async Task<Student[]> GetAllAsync(string? schoolId = null, string? classId = null, string? parentId = null,
            string? subject = null, string[]? include = null)
        {
            var endpoint = Regex.Replace(_configuration.GetSection("endpoints")["getAll"], "variable", $"reg/Students");

            return await _httpClient.GetJsonAsync<Student[]>($"{_appSettings.ApiUrl}/{endpoint}" +
                $"{IncludeStringHelper.GetString(include)}" +
                $"schoolId={schoolId}&classId={classId}&parentId={parentId}&subject={subject}");
        }
    }
}


//using Microsoft.AspNetCore.Components;
//using Microsoft.Extensions.Configuration;
////using Newtonsoft.Json;
////using Newtonsoft.Json.Serialization;
//using S3.WebUI.cBlazor.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text.Json;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;
////using JsonSerializer = Newtonsoft.Json.JsonSerializer;
////using JsonSerializer = System.Text.Json.JsonSerializer;

//namespace S3.WebUI.cBlazor.Areas.SchoolAdmin.Services
//{
//    //public class StudentService : HttpService, IStudentService
//    public class StudentService : IStudentService
//    {
//        private readonly HttpClient _httpClient;
//        private readonly IConfiguration _configuration;

//        public StudentService(HttpClient httpClient, IConfiguration configuration)
//            => (_httpClient, _configuration) = (httpClient, configuration);

//        public async Task<Student> GetAsync(Guid id)
//        {
//            string endpoint = Regex.Replace(_configuration.GetSection("endpoints")["get"], "variable", "students");
//            return await _httpClient.GetJsonAsync<Student>($"{endpoint}/{id}");
//        }

//        public async Task<Student[]> GetAllAsync(Guid? schoolId = null)
//        {
//            string endpoint = Regex.Replace(_configuration.GetSection("endpoints")["getAll"], "variable", "students");
//            return await _httpClient.GetJsonAsync<Student[]>($"{endpoint}?SchoolId={schoolId}");
//        }

//        public async Task CreateAsync(Student student)
//        {
//            string endpoint = Regex.Replace(_configuration.GetSection("endpoints")["create"], "variable", "students");
//            System.Diagnostics.Debug.WriteLine(
//            JsonSerializer.Serialize(student, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }));

//            await _httpClient.SendJsonAsync(HttpMethod.Post, endpoint, student);
//        }

//        public async Task UpdateAsync(Student student)
//        {
//            string endpoint = Regex.Replace(_configuration.GetSection("endpoints")["update"], "variable", "students");
//            await _httpClient.SendJsonAsync(HttpMethod.Put, endpoint, student);
//        }
//        public async Task DeleteAsync(Guid id)
//        {
//            string endpoint = Regex.Replace(_configuration.GetSection("endpoints")["delete"], "variable", "students");
//            await _httpClient.SendJsonAsync(HttpMethod.Delete, $"{endpoint}/{id}", null);
//        }
//    }
//}
