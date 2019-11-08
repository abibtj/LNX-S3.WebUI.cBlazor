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
    public class MiscellaneousService : IMiscellaneousService
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;
        private readonly IConfiguration _configuration;

        public MiscellaneousService(IConfiguration configuration, HttpClient httpClient, IAuthService authService, AppSettings appSettings)
            => (_httpClient, _appSettings, _configuration) = (httpClient, appSettings, configuration);

        public async Task<bool> CheckUsernameAvailabilityAsync(string username)
        {
            var endpoint = _configuration.GetSection("endpoints")["checkUsername"];

            return await _httpClient.GetJsonAsync<bool>($"{_appSettings.ApiUrl}/{endpoint}?username={username}");
        }

        public async Task<Address> GetAddressAsync(string addressId)
        {
            var endpoint = Regex.Replace(_configuration.GetSection("endpoints")["get"], "variable", $"reg/Addresses");
            
            return await _httpClient.GetJsonAsync<Address>($"{_appSettings.ApiUrl}/{endpoint}/{addressId}");
        }
    }
}
