#pragma checksum "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\SignUpComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7106fb53c41b4545793e28d8412e63d4e4b0bd3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace S3.WebUI.cBlazor.Shared.Components
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
#line 18 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Models;

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
#line 21 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Utility;

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
#line 23 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Shared.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    public partial class SignUpComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 101 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\SignUpComponent.razor"
       

    private ResetPassword resetPassword;
    //private Mode mode = Mode.None;

    private bool busy;
    //private bool busyRemovingSignUp;
    private bool rolePanelExpanded;
    private bool SignUpDialogIsOpened;
    //private bool resetPasswordDialogIsOpened;
    private bool usernameAvailable;
    private bool showPassword;

    //private string usernameAvailabilityText;


    [Parameter] public List<string> AssignableRoles { get; set; }
    [Parameter] public List<string> PersonRoles { get; set; }

    [Parameter] public Person Person { get; set; }
    [Parameter] public SignUp SignUp { get; set; }

    private void AddRole(string selectedRole)
    {
        if (!(PersonRoles.Contains(selectedRole)) && !string.IsNullOrEmpty(selectedRole))
        {
            PersonRoles.Insert(0, selectedRole);
            SignUp.Roles = PersonRoles.ToArray();
            AssignableRoles.Remove(selectedRole);
        }
    }

    private async Task CheckUsernameAvailabilityAsync()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\SignUpComponent.razor"
           
    }

    private void CloseDialogs()
    {
        // Reset fields to their defaults
        SignUpDialogIsOpened = false;
        rolePanelExpanded = false;
        showPassword = false;

        //usernameAvailabilityText = null;
        SignUp = null;
    }

    private void DialogIsOpenedChanged(bool isOpened)
    {
        if (!isOpened)
        {
            CloseDialogs();
        }
    }

    //protected override async Task OnInitializedAsync()
    //{

    //}

    private void RemoveRole(string role)
    {
        PersonRoles.Remove(role);

        if (Person is Parent && !PersonRoles.Contains(Role.Parent))
        {
            PersonRoles.Add(Role.Parent); // The role remains Parent whether removed or not.
        }
        else if (Person is Student && !PersonRoles.Contains(Role.Student))
        {
            PersonRoles.Add(Role.Student); // The role remains Student whether removed or not.
        }

        SignUp.Roles = PersonRoles.ToArray();
        AssignableRoles.Add(role);
        AssignableRoles.Sort();
    }

    private async Task RemoveSignUpAsync()
    {
        //busyRemovingSignUp = true; // Don't use busy = true; because another control on the same page uses it, else, the two controls will show spinning icon.

        //await IdentityService.RemoveSignUpAsync(Person.Id);
        //CloseDialogs();
        //Toaster.Add("Your request is being processed. Click Refresh if no change is seen shortly.", MatToastType.Info, "Request Processing", "info");

        //busyRemovingSignUp = false;
    }

    private void ShowResetPasswordDialog()
    {
        resetPassword = new ResetPassword { UserId = Person.Id };

        //mode = Mode.ResetPassword;
        //resetPasswordDialogIsOpened = true;
    }

    private async Task SignUpAsync()
    {
        busy = true;

        if (!Person.IsSignedUp)
        {
            if (usernameAvailable)
            {
                await IdentityService.SignUpAsync(SignUp);
                CloseDialogs();
                Toaster.Add("Your request is being processed. Click Refresh if no change is seen shortly.", MatToastType.Info, "Request Processing", "info");
            }
            else
            {
                Toaster.Add("The specified username is already taken. Please, choose another one.", MatToastType.Danger, "Unavailable Username", "error");
            }
        }

        busy = false;
    }

    private void ToggleShowPassword()
       => showPassword = !showPassword;


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMiscellaneousService MiscellaneousService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IIdentityService IdentityService { get; set; }
    }
}
#pragma warning restore 1591
