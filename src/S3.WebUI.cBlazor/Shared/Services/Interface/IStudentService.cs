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
    public interface IStudentService : IGenericService<Student, Registration> 
    {
        Task<Student[]> GetAllAsync(string? schoolId = null, string? classId = null, string? parentId = null,
            string? subject = null, string[]? include = null);
    }
}
