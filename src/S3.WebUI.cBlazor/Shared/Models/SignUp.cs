using System.ComponentModel.DataAnnotations;

namespace S3.WebUI.cBlazor.Shared.Models
{
    public sealed class SignUp
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string[] Roles { get; set; }
        public string SchoolId { get; set; }
    }
}