#pragma checksum "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Teacher\Pages\ScoresEntry.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1aa4b6d8698c6ce876bb0771ab999a259d558356"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace S3.WebUI.cBlazor.Areas.Teacher.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Shared.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\_Imports.razor"
using S3.WebUI.cBlazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\_Imports.razor"
using S3.WebUI.cBlazor.Shared.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\_Imports.razor"
using S3.WebUI.cBlazor.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\_Imports.razor"
using S3.WebUI.cBlazor.Models.Validators;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/t/scores-entry")]
    public partial class ScoresEntry : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 134 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Teacher\Pages\ScoresEntry.razor"
       

    #region variables

    private ScoresEntryTask[] scoresEntryTasks;
    private ScoresEntryTask task; // The current ScoresEntryTask being worked on
    private ClassSubjectScores classSubjectScores;
    //private List<Student> studentsOfferingSubject;

    private Mode mode = Mode.None;
    private bool scoresEntryDialogIsOpen;
    private bool busy;
    private bool loadFailed;
    private bool scoresExist;
    private bool sessionExpired;

    private string term; // To be typecast to int
    private string examType;
    private DateTime? session = DateTime.UtcNow;
    private string errorTitle = "Error";
    private string errorMessage = "Sorry, we could not load this resource due to an error. Please, try again later.";
    #endregion


    private async Task Add_UpdateAsync()
    {
        busy = true;

        if (mode == Mode.Add)
        {
            await StudentScoreService.CreateAsync(classSubjectScores);
        }
        else if (mode == Mode.Update)
        {
            await StudentScoreService.UpdateAsync(classSubjectScores);
        }

        await LoadAsync();
        CloseDialogs();
        Toaster.Add("Your request is being processed. Click Refresh if no change is seen shortly.", MatToastType.Info, "Request Processing", "info");

        busy = false;
    }

    private void CloseDialogs()
    {
        // Reset fields to their defaults
        scoresEntryDialogIsOpen = false;
        scoresExist = false;
        task = null;

        mode = Mode.None;
    }

    private void DialogIsOpenChanged(bool isOpened)
    {
        if (!isOpened)
        {
            CloseDialogs();
        }
    }

    private async Task LoadAsync()
    {
        busy = true;

        try
        {
            if (AppUser.IsTeacher)
            {
                scoresEntryTasks = await ScoresEntryTaskService.GetAllForTeacherAsync(schoolId: AppUser.SchoolId, teacherId: AppUser.Id);
            }
            else
            {
                loadFailed = true;
                errorMessage = "You are not authorised to view this resource.";
            }
        }
        catch (System.Net.Http.HttpRequestException ex)
        {
            loadFailed = true;
            (errorTitle, errorMessage, sessionExpired) = ErrorMessageHelper.GetMessage(ex);

            if (sessionExpired)
            {
                try //TODO: Remove the following try catch block when globa error handling is implemented
                {
                    await AppUser.SignOutAsync();
                }
                catch (Exception e)
                {
                    Logger.LogWarning(e, "Unable to log user out.");
                }
            }

            Logger.LogWarning(ex, "Failed to load resource.");
        }
        catch (Exception ex)
        {
            loadFailed = true;
            Logger.LogWarning(ex, "Failed to load resource.");
        }

        busy = false;
    }

    protected override async Task OnInitializedAsync()
    {

        await AppUser.InitializeAsync();
        await LoadAsync();
        //StateHasChanged();
    }

    private async Task ShowScoresEnteryDialogAsync(string id)
    {
        if (string.IsNullOrEmpty(term))
        {
            Toaster.Add("Term must be selected", MatToastType.Danger, "Invalid Term", "error");
        }
        else if (string.IsNullOrEmpty(examType))
        {
            Toaster.Add("Exam type must be selected", MatToastType.Danger, "Invalid Exam Type", "error");
        }
        else
        {
            busy = true;

            // TODO: This year or last year is still current session
            bool isCurrentSession = (session?.Date.Year == DateTime.Now.Year);// || (session?.Date.Year == DateTime.Now.Year - 1);

            classSubjectScores = new ClassSubjectScores();
            var studentScores = new List<StudentScore>();
            Student[] studentsOfferingSubject;

            //task = await ScoresEntryTaskService.GetAsync(id);
            task = scoresEntryTasks.FirstOrDefault(x => x.Id == id);

            var existingScores = await StudentScoreService.GetAllAsync(schoolId: task.SchoolId, classId: task.ClassId,
                subject: task.Subject, examType: examType, term: int.Parse(term), session: session?.Date.Year);

            if (!(existingScores is null) && existingScores.Length > 0)
            {
                mode = Mode.Update;
                studentScores = existingScores.ToList();

                // If it is still the current session, check if there's any new students whose scores have not been previously added and add their scores.
                if (isCurrentSession)
                {
                    studentsOfferingSubject = await StudentService.GetAllAsync(schoolId: task.SchoolId, classId: task.ClassId, subject: task.Subject);

                    var studentsOfferingSubject_Ids = new HashSet<string>(studentsOfferingSubject.Select(x => x.Id));
                    var existingScores_StudentIds = new HashSet<string>(existingScores.Select(x => x.StudentId));

                    foreach (var _id in studentsOfferingSubject_Ids)
                    {
                        if (!(existingScores_StudentIds.Contains(_id))) // No score has been added for this student, add it
                        {
                            var student = studentsOfferingSubject.FirstOrDefault(x => x.Id == _id);

                            studentScores.Add(new StudentScore
                            {
                                ClassId = task.ClassId,
                                ClassName = task.ClassName,
                                ExamType = examType,
                                SchoolId = task.SchoolId,
                                Session = session?.Date.Year ?? 2000,
                                StudentId = student.Id,
                                StudentName = student.FullName,
                                Subject = task.Subject,
                                Term = int.Parse(term)
                            });
                        }
                    }
                }
            }
            else if (isCurrentSession)
            {
                mode = Mode.Add;
                studentsOfferingSubject = await StudentService.GetAllAsync(schoolId: task.SchoolId, classId: task.ClassId, subject: task.Subject);

                foreach (var student in studentsOfferingSubject)
                {
                    studentScores.Add(new StudentScore
                    {
                        ClassId = task.ClassId,
                        ClassName = task.ClassName,
                        ExamType = examType,
                        SchoolId = task.SchoolId,
                        Session = session?.Date.Year ?? 2000,
                        StudentId = student.Id,
                        StudentName = student.FullName,
                        Subject = task.Subject,
                        Term = int.Parse(term)
                    });
                }
            }
            else
            {
                mode = Mode.Add;
            }

            if (studentScores.Count > 0) // There are scores to be added or updated
            {
                classSubjectScores.StudentScores = studentScores.OrderBy(x => x.StudentName).ToList();
                scoresExist = true;
            }

            scoresEntryDialogIsOpen = true;

            busy = false;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppUser AppUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<ScoresEntry> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService StudentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentScoreService StudentScoreService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IScoresEntryTaskService ScoresEntryTaskService { get; set; }
    }
}
#pragma warning restore 1591