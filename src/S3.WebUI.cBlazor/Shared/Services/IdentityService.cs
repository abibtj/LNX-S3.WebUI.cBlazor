using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using S3.WebUI.cBlazor.Shared.Models;
using S3.WebUI.cBlazor.Shared.Services.Interface;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace S3.WebUI.cBlazor.Shared.Services
{
    public class IdentityService :  IIdentityService
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;
        private readonly IConfiguration _configuration;

        public IdentityService(HttpClient httpClient, AppSettings appSettings, IConfiguration configuration)
            => (_httpClient, _appSettings, _configuration) = (httpClient, appSettings, configuration);

        public async Task SignUpAsync(SignUp signUp)
            => await _httpClient.PostJsonAsync($"{_appSettings.ApiUrl}/{_configuration.GetSection("endpoints")["signUp"]}", signUp);

        public async Task<IdentityTokens> SignInAsync(SignIn signIn)
           => await _httpClient.PostJsonAsync<IdentityTokens>($"{_appSettings.ApiUrl}/{_configuration.GetSection("endpoints")["signIn"]}", signIn);

        public async Task RemoveSignUpAsync(string userId)
           => await _httpClient.DeleteAsync($"{_appSettings.ApiUrl}/{_configuration.GetSection("endpoints")["removeSignup"]}/{userId}");

        public async Task ChangePasswordAsync(ChangePassword changePassword)
           => await _httpClient.PutJsonAsync($"{_appSettings.ApiUrl}/{_configuration.GetSection("endpoints")["changePassword"]}", changePassword);
       
        public async Task ResetPasswordAsync(ResetPassword resetPassword)
           => await _httpClient.PutJsonAsync($"{_appSettings.ApiUrl}/{_configuration.GetSection("endpoints")["resetPassword"]}", resetPassword);

        public async Task UpdateRolesAsync(UpdateRoles updateRoles)
           => await _httpClient.PutJsonAsync($"{_appSettings.ApiUrl}/{_configuration.GetSection("endpoints")["updateRoles"]}", updateRoles);
    }
}