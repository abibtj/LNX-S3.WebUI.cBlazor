using System.Net.Http;
using System.Text;

namespace S3.WebUI.cBlazor.Utility
{
    public class IncludeStringHelper
    {
        public static string GetString(string[]? include)
        {
            StringBuilder includeString = new StringBuilder("?");

            if (!(include is null) && include.Length > 0)
            {
                foreach (var includeItem in include)
                {
                    includeString.Append($"include={includeItem}&");
                }
            }

            return includeString.ToString();
        }
    }
}
