using System.Threading.Tasks;
using Blazored.LocalStorage;
using S3.WebUI.cBlazor.Shared.Models;
using S3.WebUI.cBlazor.Shared.Services.Interface;

namespace S3.WebUI.cBlazor.Shared.Services
{
    public class AuthService : IAuthService
    {
        private readonly ILocalStorageService _storage;
        private const string IdentityTokensKey = "identity_token";

        public AuthService(ILocalStorageService storage) => _storage = storage;

        public async Task<IdentityTokens> GetIdentityTokensAsync()
        => await _storage.GetItemAsync<IdentityTokens>(IdentityTokensKey);

        public async Task SetIdentityTokensAsync(IdentityTokens identityTokens)
        => await _storage.SetItemAsync(IdentityTokensKey, identityTokens);

        public async Task RemoveIdentityTokensAsync()
        => await _storage.RemoveItemAsync(IdentityTokensKey);
    }
}
