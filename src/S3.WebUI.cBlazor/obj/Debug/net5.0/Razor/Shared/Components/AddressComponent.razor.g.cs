#pragma checksum "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e24559d3c3431d7d5f7db1462ccfdccfd7996cd"
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
    public partial class AddressComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-group col-md-12");
            __Blazor.S3.WebUI.cBlazor.Shared.Components.AddressComponent.TypeInference.CreateMatTextField_0(__builder, 4, 5, "Address", 6, 
#nullable restore
#line 6 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                                                                                true

#line default
#line hidden
#nullable disable
            , 7, "width:100%;", 8, 
#nullable restore
#line 6 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                                       Address.Line1

#line default
#line hidden
#nullable disable
            , 9, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Address.Line1 = __value, Address.Line1)), 10, () => Address.Line1);
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-group col-md-12");
            __Blazor.S3.WebUI.cBlazor.Shared.Components.AddressComponent.TypeInference.CreateMatTextField_1(__builder, 16, 17, "Address", 18, "width:100%;", 19, 
#nullable restore
#line 11 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                                       Address.Line2

#line default
#line hidden
#nullable disable
            , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Address.Line2 = __value, Address.Line2)), 21, () => Address.Line2);
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-group col-md-12");
            __Blazor.S3.WebUI.cBlazor.Shared.Components.AddressComponent.TypeInference.CreateMatTextField_2(__builder, 27, 28, "Town / City", 29, 
#nullable restore
#line 16 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                                                                                   true

#line default
#line hidden
#nullable disable
            , 30, "width:100%;", 31, 
#nullable restore
#line 16 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                                       Address.Town

#line default
#line hidden
#nullable disable
            , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Address.Town = __value, Address.Town)), 33, () => Address.Town);
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "row");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form-group col-md-6");
            __builder.AddMarkupContent(39, "n\r\n            ");
            __builder.OpenComponent<MatBlazor.MatSelect<string>>(40);
            __builder.AddAttribute(41, "Label", "State*");
            __builder.AddAttribute(42, "Required", "true");
            __builder.AddAttribute(43, "Enhanced", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                                                                                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 21 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                                                    Address.State

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Address.State = __value, Address.State))));
            __builder.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => Address.State));
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 23 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                 if (!(states is null))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                     foreach (var state in states)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MatBlazor.MatOptionString>(48);
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                                                 state

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(51, 
#nullable restore
#line 27 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                                                         state

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 28 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                     
                }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "form-group col-md-6");
            __builder.OpenComponent<MatBlazor.MatSelect<string>>(55);
            __builder.AddAttribute(56, "Label", "Country*");
            __builder.AddAttribute(57, "Required", "true");
            __builder.AddAttribute(58, "Enhanced", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                                                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 33 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                                                    Address.Country

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Address.Country = __value, Address.Country))));
            __builder.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => Address.Country));
            __builder.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 35 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                 if (!(countries is null))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                     foreach (var country in countries)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MatBlazor.MatOptionString>(63);
                __builder2.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                                                 country

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(66, 
#nullable restore
#line 39 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                                                           country

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 40 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
                     
                }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\AddressComponent.razor"
       

    private List<string> states;
    //private string state;
    private List<string> countries;
    //private string country;

    [Parameter] public Address Address { get; set; }

    protected override async Task OnInitializedAsync()
    {
        // Load states and countries from json files
        states = await HttpClient.GetJSONAsync<List<string>>("json-data/states.json");
        countries = await HttpClient.GetJSONAsync<List<string>>("json-data/countries.json");

        //state = Address.State;
        //country = Address.Country;
    }

    //private void ChangeState(string selectedState)
    //{
    //    state = selectedState;
    //    Address.State = selectedState;
    //}

    //private void ChangeCountry(string selectedCountry)
    //{
    //    country = selectedCountry;
    //    Address.Country = selectedCountry;
    //}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
namespace __Blazor.S3.WebUI.cBlazor.Shared.Components.AddressComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Required", __arg1);
        __builder.AddAttribute(__seq2, "Style", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Style", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Required", __arg1);
        __builder.AddAttribute(__seq2, "Style", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591