using System.ComponentModel.DataAnnotations;

namespace S3.WebUI.cBlazor.Shared.Models
{
    public sealed class ResetPassword
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}