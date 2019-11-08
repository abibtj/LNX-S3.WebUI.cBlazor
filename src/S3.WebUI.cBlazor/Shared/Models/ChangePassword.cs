using System.ComponentModel.DataAnnotations;

namespace S3.WebUI.cBlazor.Shared.Models
{
    public sealed class ChangePassword
    {
        public string UserId { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
}