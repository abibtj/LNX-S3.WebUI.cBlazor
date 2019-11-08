using Microsoft.AspNetCore.Components;
using S3.WebUI.cBlazor.Models;
using S3.WebUI.cBlazor.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace S3.WebUI.cBlazor.Shared.Services.Interface
{
    public interface IClassService : IGenericService<Class, Registration> { }
}
