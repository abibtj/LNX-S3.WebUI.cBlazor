// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace S3.WebUI.cBlazor.Areas.SchoolAdmin.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Shared.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\_Imports.razor"
using S3.WebUI.cBlazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\_Imports.razor"
using S3.WebUI.cBlazor.Shared.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\_Imports.razor"
using S3.WebUI.cBlazor.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\_Imports.razor"
using S3.WebUI.cBlazor.Models.Validators;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/schadm/scores")]
    public partial class Scores : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 328 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\SchoolAdmin\Pages\Scores.razor"
       

    #region variables

    private StudentScore[] scores;
    private Class[] availableClasses;
    private Class selectedClass;
    private ClassReport classReport;
    private string[] classSubjects;
    private Mode mode = Mode.None;

    //private Mode mode = Mode.None;
    private bool busy;
    private bool loadFailed;
    private bool sessionExpired;
    //private bool reportDialogIsOpened;
    private bool
        showPrintPreview;

    //string classId;
    string subject;
    private string term = Term.FirstTerm;
    private string examType = ExamType.FirstExam;
    private DateTime session = DateTime.UtcNow;
    private string errorTitle = "Error";
    private string errorMessage = "Sorry, we could not load this resource due to an error. Please, try again later.";
    #endregion


    private async Task ChangeClassAsync(string selectedClassId)
    {
        selectedClass = availableClasses.ToList().First(x => x.Id == selectedClassId);

        //classId = selectedClassId;
        classSubjects = selectedClass.SubjectsArray;

        await SearchScoresAsync();
    }

    private async Task ChangeExamTypeAsync(string selectedExamType)
    {
        examType = selectedExamType;
        await SearchScoresAsync();
    }

    private async Task ChangeSessionAsync(DateTime selectedSession)
    {
        if (selectedSession.Year != session.Year)
        {
            session = selectedSession;
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

    private void CloseDialogs()
    {
        // Reset fields to their defaults
        //reportDialogIsOpened = false;
        showPrintPreview = false;

        classReport = null;
    }

    private void DialogIsOpenedChanged(bool isOpened)
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
            if (AppUser.IsSchoolAdmin || AppUser.IsAssistantSchoolAdmin)
            {

                availableClasses = await ClassService.GetAllAsync(schoolId: AppUser.SchoolId);

                //    scores = await StudentScoreService.GetAllAsync(schoolId: AppUser.SchoolId, classId: classId,
                //    subject: subject, examType: examType, term: int.Parse(term), session: session.Year);
                scores = new StudentScore[] { };
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
        if (!AppUser.IsSignedIn)
        {
            await AppUser.InitializeAsync();
        }

        await LoadAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (classReport is object)
        {
            // Show print dialog
            //JSRuntime.InvokeVoidAsync("printPreviewItem", "all-report-cards");
            //await JSRuntime.InvokeVoidAsync("print");
            //await JSRuntime.InvokeVoidAsync("downloadReportCards");
            //showPrintPreview = false;
            classReport = null;
        }
    }

    private async Task SearchScoresAsync()
    {
        busy = true;

        scores = await StudentScoreService.GetAllAsync(schoolId: AppUser.SchoolId, classId: selectedClass?.Id,
                subject: subject, examType: examType, term: term, session: session.Year);

        busy = false;
    }

    private async Task ShowReportsAsync()
    {
        if (selectedClass is null) // No class has been selected
        {
            Toaster.Add("Please, select the class for which reports are to be generated.", MatToastType.Danger, "No Class Selected", "error");
        }
        else
        {
            busy = true;

            classReport = await ReportService.GetAsync(classId: selectedClass.Id, session: session.Year);

            await PdfGenerator.GenerateAsync(classReport, selectedClass, session.Year, classSubjects);

            //var pdf = new HtmlToPdfDocument()
            //{
            //    GlobalSettings = PdfSettingsHelper.GetGlobalSettings(),
            //    Objects = { PdfSettingsHelper.GetObjectSettings(classReport, selectedClass, session.Year, classSubjects) }
            //};

            //byte[] file = Converter.Convert(pdf);

            //await JSRuntime.InvokeAsync<object>("downloadReportCards", $"{selectedClass.Name} Report Cards.pdf", Convert.ToBase64String(file));



            //reportDialogIsOpened = true;
            //await JSRuntime.InvokeVoidAsync("downloadReportCards");


            //showPrintPreview = true;
            busy = false;

            // Show print dialog
            //JSRuntime.InvokeVoidAsync("PrintPreviewItem", "all-report-cards");
            //JSRuntime.InvokeVoidAsync("print");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppUser AppUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Scores> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentScoreService StudentScoreService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IReportService ReportService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClassService ClassService { get; set; }
    }
}
#pragma warning restore 1591