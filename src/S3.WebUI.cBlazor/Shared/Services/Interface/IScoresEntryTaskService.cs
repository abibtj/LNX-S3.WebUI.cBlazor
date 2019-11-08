using S3.WebUI.cBlazor.Models;
using S3.WebUI.cBlazor.Utility;
using System.Threading.Tasks;

namespace S3.WebUI.cBlazor.Shared.Services.Interface
{
    public interface IScoresEntryTaskService : IGenericService<ScoresEntryTask, Registration>
    {
        Task<ScoresEntryTask[]> GetAllForTeacherAsync(string teacherId, string? schoolId = null, string[]? include = null);
    }
}
