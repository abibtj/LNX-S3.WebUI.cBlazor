using S3.WebUI.cBlazor.Models;
using S3.WebUI.cBlazor.Utility;
using System.Threading.Tasks;

namespace S3.WebUI.cBlazor.Shared.Services.Interface
{
    public interface ITeacherService : IGenericService<Teacher, Registration> 
    {
        Task<Teacher[]> GetAllSignedUpAsync(string? schoolId = null, string[]? include = null);
    }
}
