#pragma checksum "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\SchoolAdmin\Pages\Students.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58ce6a98fcc870ea075354b0decf7accc5f2a76c"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/schadm/students")]
    public partial class Students : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 390 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\SchoolAdmin\Pages\Students.razor"
       

    #region variables

    private Student[] students;
    private Student student;
    private Parent[] parents;
    private Parent searchedParent;
    private Class[] classes;
    private Class _class;
    private List<string> availableSubjects;
    private List<string> studentSubjects;
    private List<string> assignableRoles;
    private List<string> studentRoles;
    private SignUp signUp;
    private ResetPassword resetPassword;
    private string selectedSubject;

    private Mode mode = Mode.None;

    private bool addUpdateDialogIsOpened;
    private bool subjectDialogIsOpened;
    private bool deleteDialogIsOpened;
    private bool parentDialogIsOpened;
    private bool rolePanelExpanded;
    private bool signUpDialogIsOpened;
    private bool resetPasswordDialogIsOpened;
    private bool busy;
    private bool busyRemovingSignUp;
    private bool loadFailed;
    private bool sessionExpired;
    private bool showPassword;
    private bool usernameAvailable;
    private bool hasSearchedForParent;

    private string searchParentRegNumber;
    private string add_UpdateTitle;
    private string add_UpdateButtonLabel;
    private string add_RemoveAddressButtonLabel;
    private string usernameAvailabilityText;
    private string errorTitle = "Error";
    private string errorMessage = "Sorry, we could not load this resource due to an error. Please, try again later.";
    #endregion


    private void Add_RemoveAddress()
    {
        if (student.Address is null)
        {
            student.Address = new StudentAddress { StudentId = Guid.Empty.ToString(), Country = "Nigeria" };
            add_RemoveAddressButtonLabel = "Remove";
        }
        else
        {
            student.Address = null;
            student.AddressId = null;
            add_RemoveAddressButtonLabel = "Add";
        }
    }

    private void AddRole(string selectedRole)
    {
        if (!(studentRoles.Contains(selectedRole)) && !string.IsNullOrEmpty(selectedRole))
        {
            studentRoles.Insert(0, selectedRole);
            signUp.Roles = studentRoles.ToArray();
            assignableRoles.Remove(selectedRole);
        }
    }

    private void AddSubject()
    {
        if (!string.IsNullOrEmpty(selectedSubject) &&
            !(studentSubjects.Contains(selectedSubject)) &&
            availableSubjects.Contains(selectedSubject))
        {
            studentSubjects.Insert(0, selectedSubject);
            availableSubjects.Remove(selectedSubject);
            selectedSubject = null; // This enables auto clear of the UI component used for selection
        }
    }

    private async Task Add_UpdateAsync()
    {
        //if (student.SubjectsStatus == "All Class Subjects")
        //{
        //student.OfferingAllClassSubjects = true;
        //    }
        //else if (student.SubjectsStatus == "Selected Subjects")
        //{
        //    student.OfferingAllClassSubjects = false;
        //}

        if (mode == Mode.Add)
        {
            // Populate the subject array of this student before saving
            _class = classes.First(x => x.Id == student.ClassId);
            student.SubjectsArray = _class.SubjectsArray;
            student.OfferingAllClassSubjects = true;


            await StudentService.CreateAsync(student);
        }
        else if (mode == Mode.Update)
        {
            await StudentService.UpdateAsync(student);
        }

        await LoadAsync();
        CloseDialogs();
        Toaster.Add("Your request is being processed. Click Refresh if no change is seen shortly.", MatToastType.Info, "Request Processing", "info");
    }

    private async Task CheckUsernameAvailabilityAsync()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 505 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\SchoolAdmin\Pages\Students.razor"
         if (!string.IsNullOrEmpty(signUp.Username))
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
#line 516 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Areas\SchoolAdmin\Pages\Students.razor"
         
    }

    private void CloseDialogs()
    {
        // Reset fields to their defaults
        addUpdateDialogIsOpened = false;
        subjectDialogIsOpened = false;
        parentDialogIsOpened = false;
        deleteDialogIsOpened = false;
        hasSearchedForParent = false;
        searchParentRegNumber = string.Empty;
        signUpDialogIsOpened = false;
        resetPasswordDialogIsOpened = false;
        rolePanelExpanded = false;
        showPassword = false;
        usernameAvailable = false;
        usernameAvailabilityText = null;

        searchedParent = null;
        student = null;
        _class = null;
        classes = null;
        signUp = null;
        resetPassword = null;
        mode = Mode.None;
    }

    private async Task DeleteAsync(string id)
    {
        await StudentService.DeleteAsync(id);
        await LoadAsync();
        CloseDialogs();
        Toaster.Add("Your request is being processed. Click Refresh if no change is seen shortly.", MatToastType.Info, "Request Processing", "info");
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
                students = await StudentService.GetAllAsync();
            }
            else if (AppUser.IsSchoolAdmin || AppUser.IsAssistantSchoolAdmin)
            {
                students = await StudentService.GetAllAsync(schoolId: AppUser.SchoolId);
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

    private void RemoveRole(string role)
    {
        studentRoles.Remove(role);
        signUp.Roles = new[] { Role.Student }; // The role remains student whether removed or not.
        assignableRoles.Add(role);
        assignableRoles.Sort();
    }

    private async Task RemoveSignUpAsync()
    {
        busyRemovingSignUp = true; // Don't use busy = true; because another control on the same page uses it, else, the two controls will show spinning icon.

        await IdentityService.RemoveSignUpAsync(student.Id);
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

    private void RemoveSearchedParent()
    {
        searchParentRegNumber = string.Empty;
        searchedParent = null;
        hasSearchedForParent = false;
    }

    private void RemoveSubject(string subject)
    {
        studentSubjects.Remove(subject);
        availableSubjects.Add(subject);
        availableSubjects.Sort();
    }

    private async Task SearchForParentAsync()
    {
        try
        {
            searchedParent = await ParentService.GetAsync(searchParentRegNumber);
        }
        catch (HttpRequestException)
        {
            //(errorTitle, errorMessage, sessionExpired) = ErrorMessageHelper.GetMessage(ex);
        }

        hasSearchedForParent = true;
    }

    private async Task ShowAddStudentDialogAsync()
    {
        busy = true;

        classes = await ClassService.GetAllAsync(schoolId: AppUser.SchoolId);

        student = new Student { SchoolId = AppUser.SchoolId, SubjectsStatus = "All Class Subjects" };
        add_UpdateTitle = "Add Student";
        add_UpdateButtonLabel = "Add";
        add_RemoveAddressButtonLabel = "Add";
        mode = Mode.Add;
        addUpdateDialogIsOpened = true;

        busy = false;
    }

    private void ShowDeleteStudentDialog(string id)
    {
        busy = true;

        //student = await StudentService.GetAsync(id);
        student = students.FirstOrDefault(x => x.Id == id);

        mode = Mode.Delete;
        deleteDialogIsOpened = true;

        busy = false;
    }

    private async Task ShowResetPasswordDialog()
    {
        busy = true;
        resetPassword = new ResetPassword { UserId = student.Id };

        mode = Mode.ResetPassword;
        resetPasswordDialogIsOpened = true;

        busy = false;
    }

    private void ShowSignUpDialog(string id)
    {
        busy = true;

        student = students.FirstOrDefault(x => x.Id == id);
        studentRoles = student.RolesArray.ToList();

        if (student.IsSignedUp)
        {
            // This sign up will not be sent to the api, but it's needed for validation sake.
            signUp = new SignUp { UserId = id, SchoolId = AppUser.SchoolId, Username = "Some fake username", Password = "FakePassword@123", ConfirmPassword = "FakePassword@123" };
        }
        else
        {
            signUp = new SignUp { UserId = id, SchoolId = AppUser.SchoolId };
        }

        signUp.Roles = new[] { Role.Student };

        assignableRoles = new List<string> { Role.Student };

        foreach (var role in studentRoles)
        {
            assignableRoles.Remove(role);
        }

        mode = Mode.SignUp;
        signUpDialogIsOpened = true;

        busy = false;
    }

    private async Task ShowUpdateStudentDialogAsync(string id)
    {
        busy = true;

        student = students.FirstOrDefault(x => x.Id == id);
        if (student.OfferingAllClassSubjects)
        {
            student.SubjectsStatus = "All Class Subjects";
        }
        else
        {
            student.SubjectsStatus = "Selected Subjects";
        }

        classes = await ClassService.GetAllAsync(schoolId: AppUser.SchoolId);
        add_UpdateTitle = "Update Student";
        add_UpdateButtonLabel = "Update";
        mode = Mode.Update;
        addUpdateDialogIsOpened = true;

        busy = false;
    }

    private async Task ShowUpdateSubjectsDialogAsync(string id)
    {
        busy = true;

        student = students.FirstOrDefault(x => x.Id == id);
        _class = await ClassService.GetAsync(student.ClassId);

        if (student.OfferingAllClassSubjects)
        {
            studentSubjects = _class.SubjectsArray.ToList();
        }
        else
        {
            studentSubjects = student.SubjectsArray.ToList();
        }

        // Load subjects from json file
        availableSubjects = await HttpClient.GetJsonAsync<List<string>>($"json-data/subjects/{_class.Category}.json");

        foreach (var sub in studentSubjects)
        {
            availableSubjects.Remove(sub);
        }

        mode = Mode.UpdateStudentSubjects;
        subjectDialogIsOpened = true;

        busy = false;
    }

    private async Task ShowUpdateStudentsParentDialogAsync(string id)
    {
        busy = true;

        student = students.FirstOrDefault(x => x.Id == id);
        parents = await ParentService.GetAllAsync(schoolId: AppUser.SchoolId);

        mode = Mode.UpdateStudentParent;
        parentDialogIsOpened = true;

        busy = false;
    }

    private async Task SignUpAsync()
    {
        busy = true;

        if (!student.IsSignedUp)
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

        busy = false;
    }

    private async Task ToggleAddressVisibilityAsync(bool addressVisible)
    {
        if (addressVisible && student.Address is null)
        {
            if (!string.IsNullOrEmpty(student.AddressId)) // This person has an address, load it.
            {
                var address = await MiscellaneousService.GetAddressAsync(student.AddressId.ToString());
                student.Address = new StudentAddress
                {
                    Line1 = address.Line1,
                    Line2 = address.Line2,
                    Town = address.Town,
                    State = address.State,
                    Country = address.Country,
                    StudentId = student.Id
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

    private async Task UpdateStudentsParentAsync()
    {
        busy = true;

        try
        {
            if (!(searchedParent is null))
            {
                student.ParentId = searchedParent.Id;
            }

            await StudentService.UpdateAsync(student);

            CloseDialogs();
            Toaster.Add("Your request is being processed. Click Refresh if no change is seen shortly.", MatToastType.Info, "Request Processing", "info");
        }
        catch (HttpRequestException ex)
        {
            (errorTitle, errorMessage, sessionExpired) = ErrorMessageHelper.GetMessage(ex);
            Toaster.Add(errorMessage, MatToastType.Danger, errorTitle, "error");
            Logger.LogWarning(ex, "Failed to update item.");
        }

        busy = false;
    }

    private async Task UpdateSubjectsAsync()
    {
        busy = true;

        if (studentSubjects.Except(_class.SubjectsArray).Any()
        || _class.SubjectsArray.Except(studentSubjects).Any())
        {
            student.OfferingAllClassSubjects = false;
        }
        else
        {
            student.OfferingAllClassSubjects = true;
        }

        student.SubjectsArray = studentSubjects.ToArray();

        //student.Class = null!; // Student's class's Id is enough, no need sending their class back to the backend api

        try
        {
            await StudentService.UpdateAsync(student);

            subjectDialogIsOpened = false;
            mode = Mode.None;
            Toaster.Add("Your request is being processed. Click Refresh if no change is seen shortly.", MatToastType.Info, "Request Processing", "info");
        }
        catch (HttpRequestException ex)
        {
            (errorTitle, errorMessage, sessionExpired) = ErrorMessageHelper.GetMessage(ex);
            Toaster.Add(errorMessage, MatToastType.Danger, errorTitle, "error");
            Logger.LogWarning(ex, "Failed to update item.");
        }

        busy = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppUser AppUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Student> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IIdentityService IdentityService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMiscellaneousService MiscellaneousService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IParentService ParentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClassService ClassService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService StudentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591