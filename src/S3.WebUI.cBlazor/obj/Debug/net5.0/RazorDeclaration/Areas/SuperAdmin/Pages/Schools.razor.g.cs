// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace S3.WebUI.cBlazor.Areas.SuperAdmin.Pages
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
#nullable restore
#line 8 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\SuperAdmin\Pages\Schools.razor"
using Blazor.FlexGrid.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\SuperAdmin\Pages\Schools.razor"
using Blazor.FlexGrid.DataAdapters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\SuperAdmin\Pages\Schools.razor"
using Blazor.FlexGrid.Components.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\SuperAdmin\Pages\Schools.razor"
using Blazor.FlexGrid.DataSet.Options;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/spadm/schools")]
    public partial class Schools : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 169 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\SuperAdmin\Pages\Schools.razor"
       

    #region variables

    //private SchoolStatistics[] schoolStats;
    CollectionTableDataAdapter<SchoolStatistics> schoolStats;
    private School school;

    private Mode mode = Mode.None;
    private bool addUpdateDialogIsOpened;
    private bool deleteDialogIsOpened;
    private bool busy;
    private bool loadFailed;
    private bool sessionExpired;

    private string add_UpdateTitle;
    private string add_UpdateButtonLabel;
    private string add_RemoveAddressButtonLabel;
    private string errorTitle = "Error";
    private string errorMessage = "Sorry, we could not load this resource due to an error. Please, try again later.";
    #endregion

    private void Add_RemoveAddress()
    {
        if (school.Address is null)
        {
            school.Address = new SchoolAddress { SchoolId = Guid.Empty.ToString(), Country = "Nigeria" };
            add_RemoveAddressButtonLabel = "Remove";
        }
        else
        {
            school.Address = null;
            school.AddressId = null;
            add_RemoveAddressButtonLabel = "Add";
        }
    }

    private async Task Add_UpdateAsync()
    {
        busy = true;

        if (mode == Mode.Add)
        {
            await SchoolService.CreateAsync(school);
        }
        else if (mode == Mode.Update)
        {
            await SchoolService.UpdateAsync(school);
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

        add_RemoveAddressButtonLabel = null;
        school = null;
        mode = Mode.None;
    }

    private async Task DeleteAsync(string id)
    {
        busy = true;

        await SchoolService.DeleteAsync(id);
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
            if (AppUser.IsSuperAdmin || AppUser.IsAdmin)
            {
                var data = await SchoolService.GetAllStatsAsync();
                schoolStats = new CollectionTableDataAdapter<SchoolStatistics>(data);

                //schoolStats = await SchoolService.GetAllStatsAsync();
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

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
       
    }

    protected override async Task OnInitializedAsync()
    {
        if(!AppUser.IsSignedIn)
        {
            await AppUser.InitializeAsync();
        }

        await LoadAsync();
    }

    private async Task ShowAddSchoolDialogAsync()
    {
        busy = true;

        school = new School();

        add_UpdateTitle = "Add School";
        add_UpdateButtonLabel = "Add";
        add_RemoveAddressButtonLabel = "Add";
        mode = Mode.Add;
        addUpdateDialogIsOpened = true;

        busy = false;
    }

    private async Task ShowDeleteSchoolDialogAsync(string id)
    {
        busy = true;

        school = await SchoolService.GetAsync(id);

        mode = Mode.Delete;
        deleteDialogIsOpened = true;

        busy = false;
    }

    private async Task ShowUpdateSchoolDialogAsync(string id)
    {
        busy = true;

        school = await SchoolService.GetAsync(id);
        if (!(string.IsNullOrEmpty(school.AddressId)))
        {
            var address = await MiscellaneousService.GetAddressAsync(school.AddressId);
            school.Address = new SchoolAddress
            {
                Line1 = address.Line1,
                Line2 = address.Line2,
                Town = address.Town,
                State = address.State,
                Country = address.Country,
                SchoolId = school.Id
            };

            add_RemoveAddressButtonLabel = "Remove";
        }

        add_UpdateTitle = "Update School";
        add_UpdateButtonLabel = "Update";

        mode = Mode.Update;
        addUpdateDialogIsOpened = true;

        //await InvokeAsync(() =>
        //{
        //    StateHasChanged();
        //});

        busy = false;
    }

    private async Task ToggleAddressVisibilityAsync(bool addressVisible)
    {
        if (addressVisible && school.Address is null)
        {
            if (!string.IsNullOrEmpty(school.AddressId)) // This school has an address, load it.
            {
                var address = await MiscellaneousService.GetAddressAsync(school.AddressId);
                school.Address = new SchoolAddress
                {
                    Line1 = address.Line1,
                    Line2 = address.Line2,
                    Town = address.Town,
                    State = address.State,
                    Country = address.Country,
                    SchoolId = school.Id
                };

                add_RemoveAddressButtonLabel = "Remove";
            }
            else
            {
                add_RemoveAddressButtonLabel = "Add";
            }
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorComponentColumnCollection<SchoolStatistics> Collection { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppUser AppUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Schools> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMiscellaneousService MiscellaneousService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISchoolService SchoolService { get; set; }
    }
}
#pragma warning restore 1591
