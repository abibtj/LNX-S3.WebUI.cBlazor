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
    [Microsoft.AspNetCore.Components.RouteAttribute("/schadm/teachers")]
    public partial class Teachers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 289 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\SchoolAdmin\Pages\Teachers.razor"
       

    #region variables

    private Teacher[] teachers;
    private Teacher teacher;
    private SignUp signUp;
    private ResetPassword resetPassword;
    private School[] schools;
    private List<string> assignableRoles;
    private List<string> teacherRoles;

    private Mode mode = Mode.None;
    private bool addUpdateDialogIsOpened;
    private bool deleteDialogIsOpened;
    private bool rolePanelExpanded;
    private bool signUpDialogIsOpened;
    private bool resetPasswordDialogIsOpened;
    private bool busy;
    private bool busyRemovingSignUp;
    private bool loadFailed;
    private bool sessionExpired;
    private bool showPassword;
    private bool usernameAvailable;

    decimal? step;
    decimal? gradeLevel;

    private string add_UpdateTitle;
    private string add_UpdateButtonLabel;
    private string add_RemoveAddressButtonLabel;
    private string usernameAvailabilityText;
    private string errorTitle = "Error";
    private string errorMessage = "Sorry, we could not load this resource due to an error. Please, try again later.";
    #endregion


    private void Add_RemoveAddress()
    {
        if (teacher.Address is null)
        {
            teacher.Address = new TeacherAddress { TeacherId = Guid.Empty.ToString(), Country = "Nigeria" };
            add_RemoveAddressButtonLabel = "Remove";
        }
        else
        {
            teacher.Address = null;
            teacher.AddressId = null;
            add_RemoveAddressButtonLabel = "Add";
        }
    }

    private void AddRole(string selectedRole)
    {
        if (!string.IsNullOrEmpty(selectedRole) &&
            !(teacherRoles.Contains(selectedRole)))
        {
            teacherRoles.Insert(0, selectedRole);
            signUp.Roles = teacherRoles.ToArray();
            assignableRoles.Remove(selectedRole);
        }
    }

    private async Task Add_UpdateAsync()
    {
        busy = true;

        if (gradeLevel.HasValue && gradeLevel.Value > 0)
        {
            teacher.GradeLevel = (int)gradeLevel;

            if (step.HasValue && step.Value > 0)
            {
                teacher.Step = (int)step;
            }
        }

        if (mode == Mode.Add)
        {
            await TeacherService.CreateAsync(teacher);
        }
        else if (mode == Mode.Update)
        {
            await TeacherService.UpdateAsync(teacher);
        }

        await LoadAsync();
        CloseDialogs();
        Toaster.Add("Your request is being processed. Click Refresh if no change is seen shortly.", MatToastType.Info, "Request Processing", "info");

        busy = false;
    }

    private async Task CheckUsernameAvailabilityAsync()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 384 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\SchoolAdmin\Pages\Teachers.razor"
         if(!string.IsNullOrEmpty(signUp.Username))
        { 
            usernameAvailable = await MiscellaneousService.CheckUsernameAvailabilityAsync(signUp.Username);
            if (usernameAvailable)
            {
                usernameAvailabilityText = "This username is available.";
            }
            else
            {
                usernameAvailabilityText = "This username is not available.";
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 395 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\SchoolAdmin\Pages\Teachers.razor"
         
    }

    private void CloseDialogs()
    {
        // Reset fields to their defaults
        addUpdateDialogIsOpened = false;
        deleteDialogIsOpened = false;
        signUpDialogIsOpened = false;
        resetPasswordDialogIsOpened = false;
        rolePanelExpanded = false;
        showPassword = false;
        usernameAvailable = false;

        usernameAvailabilityText = null;
        teacher = null;
        signUp = null;
        resetPassword = null;
        mode = Mode.None;
    }

    private async Task DeleteAsync(string id)
    {
        busy = true;

        await TeacherService.DeleteAsync(id);
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
            if (AppUser.IsSuperAdmin)
            {
                teachers = await TeacherService.GetAllAsync();
            }
            else if (AppUser.IsSchoolAdmin || AppUser.IsAssistantSchoolAdmin)
            {
                teachers = await TeacherService.GetAllAsync(schoolId: AppUser.SchoolId);
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

    private async Task LoadSchoolsAsync()
    {
        // TODO: Limit the number of schools loaded, it might be too large
        // Load schools
        schools = await SchoolService.GetAllAsync();
    }

    protected override async Task OnInitializedAsync()
    {
       if(!AppUser.IsSignedIn)
        {
            await AppUser.InitializeAsync();
        }
        
        await LoadAsync();
    }

    private void RemoveRole(string role)
    {
        teacherRoles.Remove(role);
        signUp.Roles = teacherRoles.ToArray();
        assignableRoles.Add(role);
        assignableRoles.Sort();
    }

    private async Task RemoveSignUpAsync()
    {
        busyRemovingSignUp = true; // Don't use busy = true; because another control on the same page uses it, else, the two controls will show spinning icon.

        await IdentityService.RemoveSignUpAsync(teacher.Id);
        CloseDialogs();
        Toaster.Add("Your request is being processed. Click Refresh if no change is seen shortly.", MatToastType.Info, "Request Processing", "info");

        busyRemovingSignUp = false;
    }

    private async Task ResetPasswordAsync()
    {
        busy = true;

        await IdentityService.ResetPasswordAsync(resetPassword);
        CloseDialogs();
        Toaster.Add("Your request is being processed. Click Refresh if no change is seen shortly.", MatToastType.Info, "Request Processing", "info");

        busy = false;
    }

    private async Task ShowAddTeacherDialogAsync()
    {
        busy = true;

        if (AppUser.IsSuperAdmin)
        {
            await LoadSchoolsAsync();
            teacher = new Teacher();
        }
        else if (AppUser.IsSchoolAdmin || AppUser.IsAssistantSchoolAdmin)
        {
            teacher = new Teacher { SchoolId = AppUser.SchoolId };
        }

        add_UpdateTitle = "Add Teacher";
        add_UpdateButtonLabel = "Add";
        add_RemoveAddressButtonLabel = "Add";
        mode = Mode.Add;
        addUpdateDialogIsOpened = true;

        busy = false;
    }

    private async Task ShowDeleteTeacherDialogAsync(string id)
    {
        busy = true;

        //teacher = await TeacherService.GetAsync(id);
        teacher = teachers.FirstOrDefault(x => x.Id == id);

        mode = Mode.Delete;
        deleteDialogIsOpened = true;

        busy = false;
    }

    private async Task ShowResetPasswordDialog()
    {
        busy = true;
        resetPassword = new ResetPassword { UserId = teacher.Id };

        mode = Mode.ResetPassword;
        resetPasswordDialogIsOpened = true;

        busy = false;
    }

    private async Task ShowSignUpDialogAsync(string id)
    {
        busy = true;

        //teacher = await TeacherService.GetAsync(id);
        teacher = teachers.FirstOrDefault(x => x.Id == id);
        teacherRoles = teacher.RolesArray.ToList();

        if (teacher.IsSignedUp)
        {
            // This sign up will not be sent to the api, but it's needed for validation sake.
            signUp = new SignUp { UserId = id, SchoolId = teacher.SchoolId, Username = "Some fake username", Password = "FakePassword@123", ConfirmPassword = "FakePassword@123" };
        }
        else
        {
            signUp = new SignUp { UserId = id, SchoolId = teacher.SchoolId };
        }

        signUp.Roles = teacher.RolesArray;

        //Role roles = new Role();

        if (AppUser.IsSchoolAdmin)
        {
            assignableRoles = await HttpClient.GetJSONAsync<List<string>>("json-data/roles/school-admin.json");
        }
        else if (AppUser.IsAssistantSchoolAdmin)
        {
            assignableRoles = await HttpClient.GetJSONAsync<List<string>>("json-data/roles/assistant-school-admin.json");
        }
        else if (AppUser.IsSuperAdmin)
        {
            assignableRoles = await HttpClient.GetJSONAsync<List<string>>("json-data/roles/super-admin.json");
        }

        assignableRoles.Remove(Role.Student); // A teacher cannot be a student.

        foreach (var role in teacherRoles)
        {
            assignableRoles.Remove(role);
        }

        assignableRoles.Sort();

        mode = Mode.SignUp;
        signUpDialogIsOpened = true;

        busy = false;
    }

    private async Task ShowUpdateTeacherDialogAsync(string id)
    {
        busy = true;

        //teacher = await TeacherService.GetAsync(id);
        teacher = teachers.FirstOrDefault(x => x.Id == id);
        gradeLevel = (decimal?)teacher.GradeLevel;
        step = teacher.Step;

         if (AppUser.IsSuperAdmin)
        {
            await LoadSchoolsAsync();
        }

        add_UpdateTitle = "Update Teacher";
        add_UpdateButtonLabel = "Update";

        mode = Mode.Update;
        addUpdateDialogIsOpened = true;

        busy = false;
    }

    private async Task SignUpAsync()
    {
        busy = true;

        if (!teacher.IsSignedUp)
        {
            if (usernameAvailable)
            {
                await IdentityService.SignUpAsync(signUp);
                CloseDialogs();
                Toaster.Add("Your request is being processed. Click Refresh if no change is seen shortly.", MatToastType.Info, "Request Processing", "info");
            }
            else
            {
                Toaster.Add("The specified username is already taken. Please, choose another one.", MatToastType.Danger, "Unavailable Username", "error");
            }
        }
        else // This teacher is already signed up, update their roles (if there's any changes)
        {
            if (teacher.RolesArray.Except(teacherRoles).Any() || teacherRoles.Except(teacher.RolesArray).Any()) // There's a change in roles
            {
                await IdentityService.UpdateRolesAsync(new UpdateRoles { UserId = teacher.Id, Roles = teacherRoles.ToArray() });
                Toaster.Add("Your request is being processed. Click Refresh if no change is seen shortly.", MatToastType.Info, "Request Processing", "info");
            }

            CloseDialogs();
        }

        busy = false;
    }

    private async Task ToggleAddressVisibilityAsync(bool addressVisible)
    {
        if (addressVisible && teacher.Address is null)
        {
            if (!string.IsNullOrEmpty(teacher.AddressId)) // This person has an address, load it.
            {
                var address = await MiscellaneousService.GetAddressAsync(teacher.AddressId.ToString());
                teacher.Address = new TeacherAddress
                {
                    Line1 = address.Line1,
                    Line2 = address.Line2,
                    Town = address.Town,
                    State = address.State,
                    Country = address.Country,
                    TeacherId = teacher.Id
                };

                add_RemoveAddressButtonLabel = "Remove";
            }
            else
            {
                add_RemoveAddressButtonLabel = "Add";
            }
        }
    }

    private void ToggleShowPassword()
        => showPassword = !showPassword;


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppUser AppUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Teachers> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IIdentityService IdentityService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMiscellaneousService MiscellaneousService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISchoolService SchoolService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITeacherService TeacherService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591