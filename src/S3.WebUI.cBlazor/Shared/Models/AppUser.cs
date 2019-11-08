using Blazored.LocalStorage;
using S3.WebUI.cBlazor.Models;
using S3.WebUI.cBlazor.Shared.Services;
using S3.WebUI.cBlazor.Shared.Services.Interface;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace S3.WebUI.cBlazor.Shared.Models
{
    public class AppUser
    {
        private readonly IAuthService _authService;
        private readonly IIdentityService _identityService;
        private readonly HttpClient _httpClient;

        public string Id { get; private set; }
        public string Username { get; private set; }
        public string SchoolId { get; private set; }
        public bool IsSignedIn { get; private set; }
        public bool IsSuperAdmin { get; private set; }
        public bool IsAdmin { get; private set; }
        public bool IsSchoolAdmin { get; private set; }
        public bool IsAssistantSchoolAdmin { get; private set; }
        public bool IsTeacher { get; private set; }
        public bool IsParent { get; private set; }
        public bool IsStudent { get; private set; }

        public AppUser(IAuthService authService, IIdentityService identityService, HttpClient httpClient)
            => (_authService, _httpClient, _identityService) = (authService, httpClient, identityService);

        public async Task InitializeAsync()
        {
            var identityTokens = await _authService.GetIdentityTokensAsync();
            if (!(identityTokens is null))
            {
                SetAuthorizationHeader(isSignedIn: true, identityTokens.AccessToken);

                SetUserPermissions(isSignedIn: true, identityTokens: identityTokens);
                SetUserRoles(identityTokens.Roles);
            }
            else
            {
                SetAuthorizationHeader(isSignedIn: false);
                SetUserPermissions(isSignedIn: false);
            }
        }

        public async Task SingInAsycn(SignIn signIn)
        {
            var identityTokens = await _identityService.SignInAsync(signIn);
            if (!(identityTokens is null))
            {
                await SaveIdentityTokensAsync(identityTokens);
                SetAuthorizationHeader(isSignedIn: true, identityTokens.AccessToken);

                SetUserPermissions(isSignedIn: true, identityTokens: identityTokens);
                SetUserRoles(identityTokens.Roles);
            }
        }

        public async Task SignOutAsync()
        {
            await RemoveIdentityTokensAsync();
            SetAuthorizationHeader(isSignedIn: false);
            SetUserPermissions(isSignedIn: false);
        }

        private async Task SaveIdentityTokensAsync(IdentityTokens identityTokens)
            => await _authService.SetIdentityTokensAsync(identityTokens);

        private void SetAuthorizationHeader(bool isSignedIn, string accessToken = "")
        {
            if (isSignedIn && !_httpClient.DefaultRequestHeaders.Contains("Authorization"))
            { 
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            }
            else if(!isSignedIn)
            { 
                _httpClient.DefaultRequestHeaders.Authorization = null;
            }
        }

        private async Task RemoveIdentityTokensAsync()
            => await _authService.RemoveIdentityTokensAsync();

        private void SetUserPermissions(bool isSignedIn, IdentityTokens identityTokens = null)
        {
            if (isSignedIn)
            {
                IsSignedIn = true;
                Id = identityTokens.Claims["id"];
                Username = identityTokens.Claims["username"];
                SchoolId = identityTokens.Claims["schoolId"];
            }
            else
            {
                Id = string.Empty;
                Username = string.Empty;
                SchoolId = string.Empty;
                IsSignedIn = false;
                IsSuperAdmin = false;
                IsAdmin = false;
                IsSchoolAdmin = false;
                IsAssistantSchoolAdmin = false;
                IsTeacher = false;
                IsParent = false;
                IsStudent = false;
            }

        }

        private void SetUserRoles(string[] roles)
        {
            foreach (var role in roles)
            {
                // Use pattern matching
                _ = role switch
                {
                    Role.SuperAdmin => IsSuperAdmin = true,
                    Role.Admin => IsAdmin = true,
                    Role.SchoolAdmin => IsSchoolAdmin = true,
                    Role.AssistantSchoolAdmin => IsAssistantSchoolAdmin = true,
                    Role.Teacher => IsTeacher = true,
                    Role.Parent => IsParent = true,
                    Role.Student => IsStudent = true,
                    _ => IsSignedIn = false // Invalid role found, log the user out
                };
            }
        }
    }
}


//using Blazored.LocalStorage;
//using S3.WebUI.cBlazor.Shared.Services;
//using S3.WebUI.cBlazor.Shared.Services.Interface;
//using System;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Threading.Tasks;

//namespace S3.WebUI.cBlazor.Shared.Models
//{
//    public class User
//    {
//        private readonly IAuthService _authService;
//        private readonly IIdentityService _identityService;
//        private readonly HttpClient _httpClient;

//        public bool IsLoggedIn { get; private set; }

//        public User(IAuthService authService, IIdentityService identityService, HttpClient httpClient)
//            => (_authService, _httpClient, _identityService) = (authService, httpClient, identityService);

//        public async Task InitializeAsync()
//        {
//            var accessToken = await _authService.GetAccessTokenAsync();
//            if (!string.IsNullOrEmpty(accessToken))
//            {
//                SetAuthorizationHeader(accessToken);

//                IsLoggedIn = true;
//            }
//        }

//        public async Task SingInAsycn(Identity identity)
//        {
//            var tokens = await _identityService.SignInAsync(identity);
//            if (!(tokens is null))
//            {
//                await SaveAccessTokenAsync(tokens.AccessToken);
//                SetAuthorizationHeader(tokens.AccessToken);

//                IsLoggedIn = true;
//            }
//        }

//        public async Task SignOutAsync()
//        {
//            await RemoveAccessTokenAsync();
//            _httpClient.DefaultRequestHeaders.Authorization = null;

//            IsLoggedIn = false;
//        }

//        private async Task SaveAccessTokenAsync(string accessToken)
//            => await _authService.SetAccessTokenAsync(accessToken);

//        private void SetAuthorizationHeader(string accessToken)
//        {
//            if (!_httpClient.DefaultRequestHeaders.Contains("Authorization"))
//                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
//        }

//        private async Task RemoveAccessTokenAsync()
//            => await _authService.RemoveAccessTokenAsync();
//    }
//}