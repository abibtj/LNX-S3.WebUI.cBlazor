#pragma checksum "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "672aa1a9956bf174e1ac1f83fc0f823c578ec0dc"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace S3.WebUI.cBlazor.Areas.Student.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/s/results")]
    public partial class Results : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
       

    #region variables

    private StudentScore[] scores;
    private Class[] availableClasses;
    private Student student;
    private string[] classSubjects;

    //private Mode mode = Mode.None;
    private bool busy;
    private bool loadFailed;
    private bool sessionExpired;

    string classId;
    string subject;
    private string term; // To be typecast to int
    private string examType;
    private DateTime session = DateTime.UtcNow;
    private string errorTitle = "Error";
    private string errorMessage = "Sorry, we could not load this resource due to an error. Please, try again later.";
    #endregion

    private async Task LoadAsync()
    {
        busy = true;

        try
        {
            if (AppUser.IsStudent)
            {
                scores = await StudentScoreService.GetAllAsync(studenId: AppUser.Id,
                subject: subject, examType: examType, term: int.Parse(term), session: session.Year);
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

    private async Task ChangeClassAsync(string selectedClassId)
    {
        var selectedClass = availableClasses.ToList().Find(x => x.Id == selectedClassId);

        classId = selectedClassId;
        classSubjects = selectedClass.SubjectsArray;

        await SearchScoresAsync();
    }

    private async Task ChangeExamTypeAsync(string selectedExamType)
    {
        examType = selectedExamType;
        await SearchScoresAsync();
    }

    private async Task ChangeSessionAsync(DateTime? selectedSession)
    {
        if (selectedSession?.Year != session.Year)
        {
            session = selectedSession.Value;
            await SearchScoresAsync();
        }
    }

    private async Task ChangeSubjectAsync(string selectedSubject)
    {
        subject = selectedSubject;
        await SearchScoresAsync();
    }

    private async Task ChangeTermAsync(string selectedTerm)
    {
        term = selectedTerm;
        await SearchScoresAsync();
    }

    protected override async Task OnInitializedAsync()
    {
        await AppUser.InitializeAsync();
        await LoadAsync();
        //StateHasChanged();
    }

    protected async Task SearchScoresAsync()
    {
        busy = true;

        scores = await StudentScoreService.GetAllAsync(schoolId: AppUser.SchoolId, classId: classId,
                subject: subject, examType: examType, term: int.Parse(term), session: session.Year);

        busy = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppUser AppUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Results> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentScoreService StudentScoreService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClassService ClassService { get; set; }
    }
}
#pragma warning restore 1591