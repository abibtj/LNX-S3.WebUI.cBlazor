using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using S3.WebUI.cBlazor.Models;
using S3.WebUI.cBlazor.Shared.Models;
using S3.WebUI.cBlazor.Shared.Services;
using S3.WebUI.cBlazor.Shared.Services.Interface;
using S3.WebUI.cBlazor.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace S3.WebUI.cBlazor.Shared.Services
{
    public class ClassService : HttpService<Class, Registration>, IClassService
    {
        public ClassService(IConfiguration configuration, HttpClient httpClient, AppSettings appSettings)
            : base(httpClient, appSettings, configuration) { }
    }
}
