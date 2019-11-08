using System.Threading.Tasks;
using S3.WebUI.cBlazor.Shared.Models;

namespace S3.WebUI.cBlazor.Shared.Services.Interface
{
    public interface IAuthService
    {
        Task<IdentityTokens> GetIdentityTokensAsync();
        Task SetIdentityTokensAsync(IdentityTokens identityTokens);
        Task RemoveIdentityTokensAsync();
    }
}

//using System.Threading.Tasks;

//namespace S3.WebUI.cBlazor.Shared.Services.Interface
//{
//    public interface IAuthService
//    {
//        Task<string> GetAccessTokenAsync();
//        Task SetAccessTokenAsync(string accessToken);
//        Task RemoveAccessTokenAsync();
//    }
//}