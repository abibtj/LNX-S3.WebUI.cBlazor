#pragma checksum "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\SchoolAdmin\Pages\Rules.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d08f7c53d01c12148f78f7595d7065ec9c1d6880"
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
#line 1 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Shared.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\_Imports.razor"
using S3.WebUI.cBlazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\_Imports.razor"
using S3.WebUI.cBlazor.Shared.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\_Imports.razor"
using S3.WebUI.cBlazor.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\_Imports.razor"
using S3.WebUI.cBlazor.Models.Validators;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/schadm/rules")]
    public partial class Rules : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 178 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\SchoolAdmin\Pages\Rules.razor"
       

    #region variables

    private Rule[] rules;
    private Rule rule;

    private Mode mode = Mode.None;
    private bool addUpdateDialogIsOpened;
    private bool deleteDialogIsOpened;
    private bool cutoffPanelExpanded;
    private bool busy;
    private bool loadFailed;
    private bool sessionExpired;

    private string add_UpdateTitle;
    private string add_UpdateButtonLabel;
    private string errorTitle = "Error";
    private string errorMessage = "Sorry, we could not load this resource due to an error. Please, try again later.";
    #endregion


    private async Task Add_UpdateAsync()
    {
        busy = true;
 
        if (mode == Mode.Add)
        {
            await RuleService.CreateAsync(rule);
        }
        else if (mode == Mode.Update)
        {
            await RuleService.UpdateAsync(rule);
        }

        await LoadAsync();
        CloseDialogs();
        Toaster.Add("Your request is being processed. Click Refresh if no change is seen shortly.", MatToastType.Info, "Request Processing", "info");

        busy = false;
    }

    private void CloseDialogs()
    {
        // Reset fields to their defaults
        addUpdateDialogIsOpened = false;
        deleteDialogIsOpened = false;
        cutoffPanelExpanded = false;

        rule = null;
        mode = Mode.None;
    }

    private async Task DeleteAsync(string id)
    {
        busy = true;

        await RuleService.DeleteAsync(id);
        await LoadAsync();
        CloseDialogs();
        Toaster.Add("Your request is being processed. Click Refresh if no change is seen shortly.", MatToastType.Info, "Request Processing", "info");

        busy = false;
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
                rules = await RuleService.GetAllAsync(schoolId: AppUser.SchoolId);
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
       if(!AppUser.IsSignedIn)
        {
            await AppUser.InitializeAsync();
        }
        
        await LoadAsync();
    }

    private async Task ShowAddRuleDialogAsync()
    {
        busy = true;

        rule = new Rule { SchoolId = AppUser.SchoolId };

        add_UpdateTitle = "Add Rule";
        add_UpdateButtonLabel = "Add";
        mode = Mode.Add;
        addUpdateDialogIsOpened = true;
        cutoffPanelExpanded = true; // Cutoff marks are required, show the input controls by default

        busy = false;
    }

    private void ShowDeleteRuleDialog(string id)
    {
        busy = true;

        rule = rules.First(x => x.Id == id);

        mode = Mode.Delete;
        deleteDialogIsOpened = true;

        busy = false;
    }

    private async Task ShowUpdateRuleDialogAsync(string id)
    {
        busy = true;

        rule = rules.First(x => x.Id == id);

        add_UpdateTitle = "Update Rule";
        add_UpdateButtonLabel = "Update";

        mode = Mode.Update;
        addUpdateDialogIsOpened = true;

        busy = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppUser AppUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Rules> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IIdentityService IdentityService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMiscellaneousService MiscellaneousService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService StudentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISchoolService SchoolService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRuleService RuleService { get; set; }
    }
}
#pragma warning restore 1591