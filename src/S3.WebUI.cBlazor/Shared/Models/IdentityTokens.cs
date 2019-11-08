using System.Collections.Generic;

namespace S3.WebUI.cBlazor.Shared.Models
{
    public class IdentityTokens
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string[] Roles { get; set; }
        public IDictionary<string, string> Claims { get; set; }
    }
}