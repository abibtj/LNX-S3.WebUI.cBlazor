#pragma checksum "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e761ffbb74d44aa6c691370626b8c6a8ce152c2f"
// <auto-generated/>
#pragma warning disable 1591
namespace S3.WebUI.cBlazor.Areas.Student.Pages
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/s/results")]
    public partial class Results : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatH5>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "Scores");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n<br>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
 if (!(scores is null))
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n  \r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-4");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenComponent<MatBlazor.MatSelect>(10);
            __builder.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                           examType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 18 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                                                   ChangeExamTypeAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "Label", "Exam Type");
            __builder.AddAttribute(14, "Enhanced", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                                                                                                    true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenComponent<MatBlazor.MatOption>(17);
                __builder2.AddAttribute(18, "Value", "Continuos Assessment");
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(20, "C.A.");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.OpenComponent<MatBlazor.MatOption>(22);
                __builder2.AddAttribute(23, "Value", "First Exam");
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(25, "First Exam");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.OpenComponent<MatBlazor.MatOption>(27);
                __builder2.AddAttribute(28, "Value", "Second Exam");
                __builder2.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(30, "Second Exam");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.OpenComponent<MatBlazor.MatOption>(32);
                __builder2.AddAttribute(33, "Value", "Class Activities");
                __builder2.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(35, "Class Activities");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.OpenComponent<MatBlazor.MatOption>(37);
                __builder2.AddAttribute(38, "Value", "Homework");
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(40, "Homework");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "col-md-4");
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.OpenComponent<MatBlazor.MatSelect>(47);
            __builder.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                           classId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 27 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                                                  ChangeClassAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(50, "Label", "Class");
            __builder.AddAttribute(51, "Enhanced", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                                                                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(53, "\r\n");
#nullable restore
#line 28 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
             if (!(availableClasses is null))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                 foreach (var _class in availableClasses)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(54, "                    ");
                __builder2.OpenComponent<MatBlazor.MatOption>(55);
                __builder2.AddAttribute(56, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                                       _class.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(58, 
#nullable restore
#line 32 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                                                   _class.Name

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n");
#nullable restore
#line 33 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                 
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(60, "        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "col-md-4");
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.OpenComponent<MatBlazor.MatSelect>(66);
            __builder.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                           subject

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 38 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                                                  ChangeSubjectAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(69, "Label", "Subject");
            __builder.AddAttribute(70, "Enhanced", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(72, "\r\n");
#nullable restore
#line 39 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
             if (!(classSubjects is null))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                 foreach (var subject in classSubjects)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(73, "                    ");
                __builder2.OpenComponent<MatBlazor.MatOption>(74);
                __builder2.AddAttribute(75, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                                       subject

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(77, 
#nullable restore
#line 43 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                                                 subject

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\r\n");
#nullable restore
#line 44 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                 
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(79, "        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(80, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "row");
            __builder.AddMarkupContent(85, "\r\n\r\n    ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "col-md-4");
            __builder.AddMarkupContent(88, "\r\n        ");
            __builder.OpenComponent<MatBlazor.MatSelect>(89);
            __builder.AddAttribute(90, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                           term

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 52 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                                               ChangeTermAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(92, "Label", "Term");
            __builder.AddAttribute(93, "Enhanced", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 52 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                                                                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(95, "\r\n            ");
                __builder2.OpenComponent<MatBlazor.MatOption>(96);
                __builder2.AddAttribute(97, "Value", "1");
                __builder2.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(99, "First Term");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(100, "\r\n            ");
                __builder2.OpenComponent<MatBlazor.MatOption>(101);
                __builder2.AddAttribute(102, "Value", "2");
                __builder2.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(104, "Second Term");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(105, "\r\n            ");
                __builder2.OpenComponent<MatBlazor.MatOption>(106);
                __builder2.AddAttribute(107, "Value", "3");
                __builder2.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(109, "Third Term");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(110, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(111, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n    ");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "class", "col-md-4");
            __builder.AddMarkupContent(115, "\r\n        ");
            __builder.OpenComponent<MatBlazor.MatDatePicker>(116);
            __builder.AddAttribute(117, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#nullable restore
#line 59 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                               session

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, 
#nullable restore
#line 59 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                                                      ChangeSessionAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(119, "Label", "Session");
            __builder.CloseComponent();
            __builder.AddMarkupContent(120, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n");
            __builder.AddContent(123, "    ");
            __builder.OpenElement(124, "img");
            __builder.AddAttribute(125, "class", 
#nullable restore
#line 64 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                  busy? "show-gif": "hide-gif"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(126, "src", "/images/loading.gif");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n");
            __builder.AddContent(128, "    ");
            __Blazor.S3.WebUI.cBlazor.Areas.Student.Pages.Results.TypeInference.CreateMatTable_0(__builder, 129, 130, 
#nullable restore
#line 66 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                      scores

#line default
#line hidden
#nullable disable
            , 131, 
#nullable restore
#line 66 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                                       true

#line default
#line hidden
#nullable disable
            , 132, (__builder2) => {
                __builder2.AddMarkupContent(133, "\r\n            ");
                __builder2.AddMarkupContent(134, "<th>Name</th>\r\n            ");
                __builder2.AddMarkupContent(135, "<th>Score</th>\r\n            ");
                __builder2.AddMarkupContent(136, "<th>Subject</th>\r\n            ");
                __builder2.AddMarkupContent(137, "<th>Class</th>\r\n        ");
            }
            , 138, (context) => (__builder2) => {
                __builder2.AddMarkupContent(139, "\r\n");
#nullable restore
#line 74 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
             if (scores.Length > 0)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(140, "                ");
                __builder2.OpenElement(141, "td");
                __builder2.AddContent(142, 
#nullable restore
#line 76 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                     context.StudentName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n                ");
                __builder2.OpenElement(144, "td");
                __builder2.AddContent(145, 
#nullable restore
#line 77 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                     context.Mark

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(146, "\r\n                ");
                __builder2.OpenElement(147, "td");
                __builder2.AddContent(148, 
#nullable restore
#line 78 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                     context.Subject

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\r\n                ");
                __builder2.OpenElement(150, "td");
                __builder2.AddContent(151, 
#nullable restore
#line 79 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                     context.ClassName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\r\n");
#nullable restore
#line 80 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(153, "                ");
                __builder2.AddMarkupContent(154, "<td colspan=\"4\">No scores found! Please, select appropriate criteria.</td>\r\n");
#nullable restore
#line 84 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(155, "            /**/\r\n        ");
            }
            );
            __builder.AddMarkupContent(156, "\r\n");
#nullable restore
#line 88 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
}
else if (loadFailed)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(157, "    ");
            __builder.OpenElement(158, "p");
            __builder.OpenElement(159, "em");
            __builder.AddContent(160, 
#nullable restore
#line 91 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
            errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n");
#nullable restore
#line 92 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
    Toaster.Add(errorMessage, MatToastType.Danger, errorTitle, "error");
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(162, "    ");
            __builder.OpenComponent<MatBlazor.MatProgressBar>(163);
            __builder.AddAttribute(164, "Indeterminate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 96 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(165, "\r\n");
#nullable restore
#line 97 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "C:\Users\Abeeb\Documents\S3.WebUI.cBlazor\Areas\Student\Pages\Results.razor"
       

    #region variables

    private StudentScore[] scores;
    private Class[] availableClasses;
    private Student student;
    private string[] classSubjects;

    //private Mode mode = Mode.None;
    private bool busy;
    private bool loadFailed;
    private bool sessionExpired;

    string classId;
    string subject;
    private string term; // To be typecast to int
    private string examType;
    private DateTime session = DateTime.UtcNow;
    private string errorTitle = "Error";
    private string errorMessage = "Sorry, we could not load this resource due to an error. Please, try again later.";
    #endregion

    private async Task LoadAsync()
    {
        busy = true;

        try
        {
            if (AppUser.IsStudent)
            {
                scores = await StudentScoreService.GetAllAsync(schoolId: AppUser.SchoolId, classId: classId,
                subject: subject, examType: examType, term: int.Parse(term), session: session.Year);
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

    private async Task ChangeClassAsync(string selectedClassId)
    {
        var selectedClass = availableClasses.ToList().Find(x => x.Id == selectedClassId);

        classId = selectedClassId;
        classSubjects = selectedClass.SubjectsArray;

        await SearchScoresAsync();
    }

    private async Task ChangeExamTypeAsync(string selectedExamType)
    {
        examType = selectedExamType;
        await SearchScoresAsync();
    }

    private async Task ChangeSessionAsync(DateTime? selectedSession)
    {
        if (selectedSession?.Year != session.Year)
        {
            session = selectedSession.Value;
            await SearchScoresAsync();
        }
    }

    private async Task ChangeSubjectAsync(string selectedSubject)
    {
        subject = selectedSubject;
        await SearchScoresAsync();
    }

    private async Task ChangeTermAsync(string selectedTerm)
    {
        term = selectedTerm;
        await SearchScoresAsync();
    }

    protected override async Task OnInitializedAsync()
    {
        await AppUser.InitializeAsync();
        await LoadAsync();
        //StateHasChanged();
    }

    protected async Task SearchScoresAsync()
    {
        busy = true;

        scores = await StudentScoreService.GetAllAsync(schoolId: AppUser.SchoolId, classId: classId,
                subject: subject, examType: examType, term: int.Parse(term), session: session.Year);

        busy = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppUser AppUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Results> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentScoreService StudentScoreService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClassService ClassService { get; set; }
    }
}
namespace __Blazor.S3.WebUI.cBlazor.Areas.Student.Pages.Results
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTable_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTable<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Striped", __arg1);
        __builder.AddAttribute(__seq2, "MatTableHeader", __arg2);
        __builder.AddAttribute(__seq3, "MatTableRow", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
