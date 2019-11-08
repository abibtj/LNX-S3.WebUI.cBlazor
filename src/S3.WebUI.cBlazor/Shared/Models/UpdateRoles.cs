using System.ComponentModel.DataAnnotations;

namespace S3.WebUI.cBlazor.Shared.Models
{
    public sealed class UpdateRoles
    {
        public string UserId { get; set; }
        public string[] Roles { get; set; }
    }
}