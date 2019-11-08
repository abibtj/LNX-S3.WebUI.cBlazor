using System.Threading.Tasks;
using S3.WebUI.cBlazor.Shared.Models;

namespace S3.WebUI.cBlazor.Shared.Services.Interface
{
    public interface IIdentityService
    {
        //Identity CreateDefaultIdentity();
        Task SignUpAsync(SignUp signUp);
        Task<IdentityTokens> SignInAsync(SignIn signIn);
        Task RemoveSignUpAsync(string userId);
        Task ChangePasswordAsync(ChangePassword changePassword);
        Task ResetPasswordAsync(ResetPassword resetPassword);
        Task UpdateRolesAsync(UpdateRoles updateRoles);
    }
}