#pragma checksum "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad82abef35679c53c8db01044fd0e550f2022063"
// <auto-generated/>
#pragma warning disable 1591
namespace S3.WebUI.cBlazor.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatNavMenu>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatNavItem>(3);
                __builder2.AddAttribute(4, "Href", "/");
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatIcon>(6);
                    __builder3.AddAttribute(7, "Icon", "home");
                    __builder3.CloseComponent();
                    __builder3.AddContent(8, "  Home");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatDivider>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatNavItem>(12);
                __builder2.AddAttribute(13, "Href", "/");
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatIcon>(15);
                    __builder3.AddAttribute(16, "Icon", "dashboard");
                    __builder3.CloseComponent();
                    __builder3.AddContent(17, "  Dashboard");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatDivider>(19);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\NavMenu.razor"
         if (AppUser.IsSuperAdmin)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(21, "            ");
                __builder2.OpenComponent<S3.WebUI.cBlazor.Shared.NavItemsSuperAdmin>(22);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n");
#nullable restore
#line 17 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(24, "\r\n");
#nullable restore
#line 19 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\NavMenu.razor"
         if (AppUser.IsAdmin)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(25, "            ");
                __builder2.OpenComponent<S3.WebUI.cBlazor.Shared.NavItemsSuperAdmin>(26);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n");
#nullable restore
#line 22 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(28, "\r\n");
#nullable restore
#line 24 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\NavMenu.razor"
         if (AppUser.IsSchoolAdmin)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(29, "            ");
                __builder2.OpenComponent<S3.WebUI.cBlazor.Shared.NavItemsSchoolAdmin>(30);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n");
#nullable restore
#line 27 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(32, "\r\n");
#nullable restore
#line 29 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\NavMenu.razor"
         if (AppUser.IsAssistantSchoolAdmin)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\NavMenu.razor"
                                       
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(33, "\r\n");
#nullable restore
#line 34 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\NavMenu.razor"
         if (AppUser.IsTeacher)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(34, "            ");
                __builder2.OpenComponent<S3.WebUI.cBlazor.Shared.NavItemsTeacher>(35);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n");
#nullable restore
#line 37 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(37, "\r\n");
#nullable restore
#line 39 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\NavMenu.razor"
         if (AppUser.IsParent)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\NavMenu.razor"
                                       
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(38, "\r\n");
#nullable restore
#line 44 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\NavMenu.razor"
         if (AppUser.IsStudent)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(39, "            ");
                __builder2.OpenComponent<S3.WebUI.cBlazor.Shared.NavItemsStudent>(40);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n");
#nullable restore
#line 47 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(42, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatNavSubMenu>(43);
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(45, "\r\n        ");
                    __builder3.OpenComponent<MatBlazor.MatNavSubMenuHeader>(46);
                    __builder3.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(48, "\r\n            ");
                        __builder4.OpenComponent<MatBlazor.MatNavItem>(49);
                        __builder4.AddAttribute(50, "AllowSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "C:\Users\Abeeb\Documents\Visual Studio 2019\Projects\S3\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\NavMenu.razor"
                                        false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MatBlazor.MatIcon>(52);
                            __builder5.AddAttribute(53, "Icon", "settings");
                            __builder5.CloseComponent();
                            __builder5.AddContent(54, "  Settings");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(55, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\r\n        ");
                    __builder3.OpenComponent<MatBlazor.MatDivider>(57);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\r\n\r\n        ");
                    __builder3.OpenComponent<MatBlazor.MatNavSubMenuList>(59);
                    __builder3.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(61, "\r\n            ");
                        __builder4.OpenComponent<MatBlazor.MatNavItem>(62);
                        __builder4.AddAttribute(63, "Href", "profile");
                        __builder4.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(65, "Profile");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(66, "\r\n            ");
                        __builder4.OpenComponent<MatBlazor.MatNavItem>(67);
                        __builder4.AddAttribute(68, "Href", "change-password");
                        __builder4.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(70, "Change Password");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(71, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppUser AppUser { get; set; }
    }
}
#pragma warning restore 1591
