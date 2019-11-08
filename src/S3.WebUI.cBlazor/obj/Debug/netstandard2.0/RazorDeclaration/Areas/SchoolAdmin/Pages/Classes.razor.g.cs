#pragma checksum "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\SchoolAdmin\Pages\Classes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5663471c005dc2cdb4ef93b670c407e6194984a2"
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
#nullable restore
#line 9 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\SchoolAdmin\Pages\Classes.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/schadm/classes")]
    public partial class Classes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 179 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\SchoolAdmin\Pages\Classes.razor"
       

    #region variables

    private Class[] classes;
    private Class _class;
    private List<string> availableSubjects;
    private List<string> classSubjects;
    private string selectedSubject;
    private string classCategory;

    private Mode mode = Mode.None;
    private bool addUpdateDialogIsOpen;
    private bool cloneDialogIsOpen;
    private bool deleteDialogIsOpen;
    private bool subjectPanelExpanded;
    private bool busy;
    private bool loadFailed;
    private bool sessionExpired;

    private string add_UpdateTitle;
    private string clonedClassName;
    private string add_UpdateButtonLabel;
    private string errorTitle = "Error";
    private string errorMessage = "Sorry, we could not load this resource due to an error. Please, try again later.";
    #endregion

    private void AddSubject()
    {
        if (!string.IsNullOrEmpty(selectedSubject) &&
            !(classSubjects.Contains(selectedSubject)) &&
            availableSubjects.Contains(selectedSubject))
        {
            classSubjects.Insert(0, selectedSubject);
            availableSubjects.Remove(selectedSubject);
            selectedSubject = null; // This enables auto clear of the UI component used for selection
        }

        _class.SubjectsArray = classSubjects.ToArray();

    }

    private async Task Add_UpdateAsync()
    {
        busy = true;

        if (mode == Mode.Add || mode == Mode.Update)
        {
            if (mode == Mode.Add)
            {
                await ClassService.CreateAsync(_class);
            }
            else
            {
                await ClassService.UpdateAsync(_class);
            }
            await LoadAsync();
            CloseDialogs();
            Toaster.Add("Your request is being processed. Click Refresh if no change is seen shortly.", MatToastType.Info, "Request Processing", "info");

        }
        else if (mode == Mode.Clone)
        {
            if (clonedClassName.ToLowerInvariant() == Regex.Replace(_class.Name.Trim(), " {2,}", " ").ToLowerInvariant())
            {
                Toaster.Add("A different class name must be specified.", MatToastType.Danger, "Invalid Input", "error");
            }
            else
            {
                await ClassService.CreateAsync(_class);
                await LoadAsync();
                CloseDialogs();
                Toaster.Add("Your request is being processed. Click Refresh if no change is seen shortly.", MatToastType.Info, "Request Processing", "info");
            }
        }

        busy = false;
    }

    private void CloseDialogs()
    {
        // Reset fields to their defaults
        addUpdateDialogIsOpen = false;
        deleteDialogIsOpen = false;
        cloneDialogIsOpen = false;
        subjectPanelExpanded = false;

        _class = null;

        availableSubjects = null;
        classSubjects = null;
        classCategory = null;

        mode = Mode.None;
    }

    private async Task DeleteAsync(string id)
    {
        busy = true;

        await ClassService.DeleteAsync(id);
        await LoadAsync();
        CloseDialogs();
        Toaster.Add("Your request is being processed. Click Refresh if no change is seen shortly.", MatToastType.Info, "Request Processing", "info");

        busy = false;
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
            if (AppUser.IsSchoolAdmin || AppUser.IsAssistantSchoolAdmin)
            {
                classes = await ClassService.GetAllAsync(schoolId: AppUser.SchoolId);
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

    private async Task LoadSubjectsAsync(string category)
    {
        _class.Category = category;
        classCategory = category;

        // Load subjects from json file
        availableSubjects = await HttpClient.GetJsonAsync<List<string>>($"json-data/subjects/{category}.json");

        classSubjects = new List<string>();
    }

    protected override async Task OnInitializedAsync()
    {
        await AppUser.InitializeAsync();
        await LoadAsync();
        //StateHasChanged();
    }

    private void RemoveSubject(string subject)
    {
        classSubjects.Remove(subject);
        availableSubjects.Add(subject);
        availableSubjects.Sort();

        _class.SubjectsArray = classSubjects.ToArray();
    }

    private async Task ShowAddClassDialogAsync()
    {
        busy = true;

        _class = new Class { SchoolId = AppUser.SchoolId };
        classSubjects = new List<string>();

        add_UpdateTitle = "Add Class";
        add_UpdateButtonLabel = "Add";

        mode = Mode.Add;
        addUpdateDialogIsOpen = true;

        busy = false;
    }

    private void ShowCloneClassDialog(string id)
    {
        busy = true;

        //_class = await ClassService.GetAsync(id);
        _class = classes.FirstOrDefault(x => x.Id == id);
        clonedClassName = _class.Name;

        mode = Mode.Clone;
        cloneDialogIsOpen = true;

        busy = false;
    }

    private void ShowDeleteClassDialog(string id)
    {
        busy = true;

        //_class = await ClassService.GetAsync(id);
        _class = classes.FirstOrDefault(x => x.Id == id);

        mode = Mode.Delete;
        deleteDialogIsOpen = true;

        busy = false;
    }

    private async Task ShowUpdateClassDialogAsync(string id)
    {
        busy = true;

        //_class = await ClassService.GetAsync(id);
        _class = classes.FirstOrDefault(x => x.Id == id);
        classCategory = _class.Category;

        await LoadSubjectsAsync(_class.Category); //Loads available subject for this category from json file

        classSubjects = _class.SubjectsArray.ToList();

        foreach (var subject in classSubjects)
        {
            availableSubjects.Remove(subject);
        }

        add_UpdateTitle = "Update Class";
        add_UpdateButtonLabel = "Update";

        mode = Mode.Update;
        addUpdateDialogIsOpen = true;

        busy = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppUser AppUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Classes> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMiscellaneousService MiscellaneousService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClassService ClassService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591