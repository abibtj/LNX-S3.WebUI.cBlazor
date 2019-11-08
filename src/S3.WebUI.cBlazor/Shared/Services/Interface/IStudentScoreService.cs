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
    public interface IStudentScoreService//// : IGenericService<StudentScore, Record> 
    {
        Task<StudentScore> GetAsync(string id, string[]? include = null);
        Task<StudentScore[]> GetAllAsync(string? schoolId = null, string? studentId = null, string? classId = null, 
            string? subject = null, string? examType = null, int? term = null, int? session = null, string[]? include = null);
        Task CreateAsync(ClassSubjectScores classSubjectScores);
        Task UpdateAsync(ClassSubjectScores classSubjectScores);
        Task DeleteAsync(string id);
    }
}
