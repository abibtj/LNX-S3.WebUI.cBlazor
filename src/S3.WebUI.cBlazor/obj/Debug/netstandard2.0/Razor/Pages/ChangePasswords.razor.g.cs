#pragma checksum "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7adf3dd8a3307ec683889d363af01703eb7f71b7"
// <auto-generated/>
#pragma warning disable 1591
namespace S3.WebUI.cBlazor.Pages
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
#line 12 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Models;

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
#line 15 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Utility;

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
#line 17 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Shared.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/change-password")]
    public partial class ChangePasswords : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
 if (!(changePassword is null))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                     changePassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                     ChangePasswordAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenComponent<PeterLeslieMorris.Blazor.Validation.Validate>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n\r\n        <br>\r\n\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-4 offset-md-4 mat-elevation-z24");
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatH6>(14);
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(16, "Change Password");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n                <br>\r\n                ");
                __builder2.OpenElement(18, "p");
                __builder2.OpenComponent<MatBlazor.MatTextField>(19);
                __builder2.AddAttribute(20, "Label", "Current Password");
                __builder2.AddAttribute(21, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                                                                               showPassword ? "text" : "password"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "IconOnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                                                                                                                                 ToggleShowPassword

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(23, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                                                                                                                                                             showPassword ? "radio_button_unchecked" : "remove_red_eye"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "IconTrailing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                                                                                                                                                                                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "FullWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                                                                                                                                                                                                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                                                                                                                                                                                                                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                              changePassword.CurrentPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => changePassword.CurrentPassword = __value, changePassword.CurrentPassword))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => changePassword.CurrentPassword));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n\r\n                ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "\r\n                    ");
                __builder2.OpenComponent<MatBlazor.MatTextField>(34);
                __builder2.AddAttribute(35, "Label", "New Password");
                __builder2.AddAttribute(36, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                                                                        showPassword ? "text" : "password"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "IconOnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                                                                                                                          ToggleShowPassword

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(38, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                                                                                                                                                      showPassword ? "radio_button_unchecked" : "remove_red_eye"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "IconTrailing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                                                                                                                                                                                                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "FullWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                                                                                                                                                                                                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                                                                                                                                                                                                                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                               changePassword.NewPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => changePassword.NewPassword = __value, changePassword.NewPassword))));
                __builder2.AddAttribute(44, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => changePassword.NewPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __Blazor.S3.WebUI.cBlazor.Pages.ChangePasswords.TypeInference.CreateValidationMessage_0(__builder2, 46, 47, 
#nullable restore
#line 24 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                              () => changePassword.NewPassword

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(48, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n\r\n                ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group");
                __builder2.AddMarkupContent(52, "\r\n                    ");
                __builder2.OpenComponent<MatBlazor.MatTextField>(53);
                __builder2.AddAttribute(54, "Label", "Confirm Password");
                __builder2.AddAttribute(55, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                                                                                showPassword ? "text" : "password"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "IconOnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                                                                                                                                  ToggleShowPassword

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(57, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                                                                                                                                                              showPassword ? "radio_button_unchecked" : "remove_red_eye"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "IconTrailing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                                                                                                                                                                                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "FullWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                                                                                                                                                                                                                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                                                                                                                                                                                                                                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                               changePassword.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => changePassword.ConfirmPassword = __value, changePassword.ConfirmPassword))));
                __builder2.AddAttribute(63, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => changePassword.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n                    ");
                __Blazor.S3.WebUI.cBlazor.Pages.ChangePasswords.TypeInference.CreateValidationMessage_1(__builder2, 65, 66, 
#nullable restore
#line 29 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                              () => changePassword.ConfirmPassword

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(67, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n\r\n\r\n                <br>\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatDialogActions>(69);
                __builder2.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(71, "\r\n                    ");
                    __builder3.OpenComponent<MatBlazor.MatButton>(72);
                    __builder3.AddAttribute(73, "Type", "button");
                    __builder3.AddAttribute(74, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                      GoHome

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(76, "Back");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\r\n                    ");
                    __builder3.OpenComponent<MatBlazor.MatButton>(78);
                    __builder3.AddAttribute(79, "Type", "submit");
                    __builder3.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(81, "span");
                        __builder4.AddAttribute(82, "class", 
#nullable restore
#line 37 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
                                                            busy? "oi oi-loop-circular spinning" : ""

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddContent(83, "Change");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(88, "\r\n");
#nullable restore
#line 43 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Pages\ChangePasswords.razor"
      

    //[Parameter]
    //public string ReturnUrl { get; set; }

    private bool busy;
    private bool showPassword;
    private ChangePassword changePassword;

    private async Task ChangePasswordAsync()
    {
        busy = true;

        try
        {
            await IdentityService.ChangePasswordAsync(changePassword);
            GoHome(); // Changed password successfully.
            Toaster.Add("Your request is being processed.", MatToastType.Info, "Request Processing", "info");
        }
        catch (Exception)
        {
            Toaster.Add("Unable to change your password. Please, enter correct password.", MatToastType.Danger, "Error", "error");
        }

        busy = false;
    }

    private void GoHome()
    {
        // Reset fields to their defaults
        showPassword = false;
        changePassword = null;

        NavigationManager.NavigateTo("");
    }

    protected override async Task OnInitializedAsync()
        => changePassword = new ChangePassword { UserId = AppUser.Id };

    private void ToggleShowPassword()
       => showPassword = !showPassword;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IIdentityService IdentityService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppUser AppUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.S3.WebUI.cBlazor.Pages.ChangePasswords
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
