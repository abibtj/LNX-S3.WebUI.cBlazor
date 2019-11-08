using System.Net.Http;

namespace S3.WebUI.cBlazor.Utility
{
    public class ErrorMessageHelper 
    {
        public static (string, string, bool) GetMessage(HttpRequestException ex)
        {
            string errorTitle;
            string errorMessage;
            bool sessionExpired = false;

            if (ex.Message.Contains("400")) //400 (Bad Request).
            {
                errorTitle = "Bad Request";
                errorMessage = "One of the specified input was not valid.";
            }
            else if (ex.Message.Contains("401")) //401 (Unauthorized).
            {
                errorTitle = "Session Expired";
                errorMessage = "Your session has expired. Please, login again.";
                sessionExpired = true;
            }
            else if (ex.Message.Contains("403")) //403 (Forbidden).
            {
                errorTitle = "Access Denied";
                errorMessage = "You are not authorised to view this resource. Please, contact the administrator.";
            }
            else if (ex.Message.Contains("404")) //404 (Not Found).
            {
                errorTitle = "Not Found";
                errorMessage = "Nothing found for the specified input.";
            }
            else if (ex.Message.Contains("500")) // 500 (Internal Server Error).
            {
                errorTitle = "Service Unvailable";
                errorMessage = "A required service is temporarily unavailable. Please, try again later.";
            }
            else // (Unknown Error).
            {
                errorTitle = "Error";
                errorMessage = "Sorry, we could not load this resource due to an error. Please, try again later.";
            }

            return (errorTitle, errorMessage, sessionExpired);
        }
    }
}
