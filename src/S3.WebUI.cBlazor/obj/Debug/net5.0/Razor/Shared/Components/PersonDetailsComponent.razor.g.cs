#pragma checksum "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\PersonDetailsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a27377713a9f7fe70fe8f74c8e54672f0a3dcd0"
// <auto-generated/>
#pragma warning disable 1591
namespace S3.WebUI.cBlazor.Shared.Components
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
#line 20 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Models;

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
#line 23 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Utility;

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
#line 25 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\_Imports.razor"
using S3.WebUI.cBlazor.Shared.Services.Interface;

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
    public partial class PersonDetailsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-group col-md-6");
            __Blazor.S3.WebUI.cBlazor.Shared.Components.PersonDetailsComponent.TypeInference.CreateMatTextField_0(__builder, 5, 6, "First Name", 7, 
#nullable restore
#line 6 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\PersonDetailsComponent.razor"
                                                                                      true

#line default
#line hidden
#nullable disable
            , 8, 
#nullable restore
#line 6 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\PersonDetailsComponent.razor"
                                       Person.FirstName

#line default
#line hidden
#nullable disable
            , 9, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Person.FirstName = __value, Person.FirstName)), 10, () => Person.FirstName);
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "form-group col-md-6");
            __Blazor.S3.WebUI.cBlazor.Shared.Components.PersonDetailsComponent.TypeInference.CreateMatTextField_1(__builder, 14, 15, "Middle Name", 16, 
#nullable restore
#line 9 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\PersonDetailsComponent.razor"
                                       Person.MiddleName

#line default
#line hidden
#nullable disable
            , 17, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Person.MiddleName = __value, Person.MiddleName)), 18, () => Person.MiddleName);
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-group col-md-6");
            __Blazor.S3.WebUI.cBlazor.Shared.Components.PersonDetailsComponent.TypeInference.CreateMatTextField_2(__builder, 24, 25, "Last Name", 26, 
#nullable restore
#line 15 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\PersonDetailsComponent.razor"
                                                                                    true

#line default
#line hidden
#nullable disable
            , 27, 
#nullable restore
#line 15 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\PersonDetailsComponent.razor"
                                       Person.LastName

#line default
#line hidden
#nullable disable
            , 28, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Person.LastName = __value, Person.LastName)), 29, () => Person.LastName);
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group col-md-6");
            __Blazor.S3.WebUI.cBlazor.Shared.Components.PersonDetailsComponent.TypeInference.CreateMatTextField_3(__builder, 33, 34, "Phone Number", 35, 
#nullable restore
#line 18 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\PersonDetailsComponent.razor"
                                       Person.PhoneNumber

#line default
#line hidden
#nullable disable
            , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Person.PhoneNumber = __value, Person.PhoneNumber)), 37, () => Person.PhoneNumber);
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "row");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "form-group col-md-6");
            __Blazor.S3.WebUI.cBlazor.Shared.Components.PersonDetailsComponent.TypeInference.CreateMatDatePicker_4(__builder, 43, 44, "Date Of Birth", 45, 
#nullable restore
#line 24 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\PersonDetailsComponent.razor"
                                                                                            DateOfBirthRequired

#line default
#line hidden
#nullable disable
            , 46, 
#nullable restore
#line 24 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\PersonDetailsComponent.razor"
                                        Person.DateOfBirth

#line default
#line hidden
#nullable disable
            , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Person.DateOfBirth = __value, Person.DateOfBirth)), 48, () => Person.DateOfBirth);
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form-group col-md-6");
            __builder.OpenComponent<MatBlazor.MatSelect<string>>(52);
            __builder.AddAttribute(53, "Label", "Gender*");
            __builder.AddAttribute(54, "Required", "true");
            __builder.AddAttribute(55, "Enhanced", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\PersonDetailsComponent.razor"
                                                                                                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 27 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\PersonDetailsComponent.razor"
                                                    Person.Gender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Person.Gender = __value, Person.Gender))));
            __builder.AddAttribute(58, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => Person.Gender));
            __builder.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatOptionString>(60);
                __builder2.AddAttribute(61, "Value", "Male");
                __builder2.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(63, "Male");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatOptionString>(65);
                __builder2.AddAttribute(66, "Value", "Female");
                __builder2.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(68, "Female");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n    ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "row");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "form-group col-md-6");
            __Blazor.S3.WebUI.cBlazor.Shared.Components.PersonDetailsComponent.TypeInference.CreateMatTextField_5(__builder, 74, 75, "Email", 76, 
#nullable restore
#line 35 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\PersonDetailsComponent.razor"
                                       Person.Email

#line default
#line hidden
#nullable disable
            , 77, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Person.Email = __value, Person.Email)), 78, () => Person.Email);
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\PersonDetailsComponent.razor"
       

    [Parameter] public Person Person { get; set; }
    [Parameter] public bool DateOfBirthRequired { get; set; } = false;


    

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.S3.WebUI.cBlazor.Shared.Components.PersonDetailsComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Required", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Required", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatDatePicker_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Required", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591