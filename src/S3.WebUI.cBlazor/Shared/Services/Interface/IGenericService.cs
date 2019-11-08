using Microsoft.AspNetCore.Components;
using S3.WebUI.cBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace S3.WebUI.cBlazor.Shared.Services.Interface
{
    public interface IGenericService<T, N> // T = type, N = External Service Name
    {
        Task<T> GetAsync(string id, string[]? include = null);
        Task<T[]> GetAllAsync(string? schoolId = null, string[]? include = null);
        Task CreateAsync(T t);
        Task UpdateAsync(T t);
        Task DeleteAsync(string id);
    }
}
