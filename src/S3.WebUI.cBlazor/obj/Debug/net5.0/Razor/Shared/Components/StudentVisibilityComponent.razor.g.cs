#pragma checksum "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8aad13d1039d11fdb1755b7def9dcaa627aa10e8"
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
    public partial class StudentVisibilityComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatAccordion>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatExpansionPanel>(2);
                __builder2.AddAttribute(3, "ExpandedChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 6 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor"
                                        ToggleStudentsVisibilityAsync

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatExpansionPanelSummary>(5);
                    __builder3.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MatBlazor.MatExpansionPanelHeader>(7);
                        __builder4.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(9, "Students*");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\r\n        ");
                    __builder3.OpenComponent<MatBlazor.MatExpansionPanelDetails>(11);
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 11 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor"
             if (IsAdmin) // Non-admin cannot add students to themselves
            {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(13, "div");
                        __builder4.AddAttribute(14, "class", "form-group");
                        __builder4.OpenComponent<MatBlazor.MatAutocompleteList<Student>>(15);
                        __builder4.AddAttribute(16, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Student>>(
#nullable restore
#line 15 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor"
                                                            availableStudents

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(17, "OnOpenedChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 15 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor"
                                                                                                AddStudent

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(18, "CustomStringSelector", new System.Func<Student, System.String>(
#nullable restore
#line 15 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor"
                                                                                                                                                                  x => x.FullName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(19, "Label", "Select Student");
                        __builder4.AddAttribute(20, "ShowClearButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor"
                                                                                                                                                                                                                            true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Student>(
#nullable restore
#line 15 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor"
                                                                                                                         selectedStudent

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Student>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Student>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedStudent = __value, selectedStudent))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(23, "\r\n                ");
                        __builder4.OpenComponent<MatBlazor.MatButton>(24);
                        __builder4.AddAttribute(25, "Type", "button");
                        __builder4.AddAttribute(26, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor"
                                                  AddStudent

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(27, "Icon", "person_add");
                        __builder4.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(29, "Add");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(30, "\r\n                <br>");
#nullable restore
#line 19 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor"
             if (!(ParentStudents is null))
            {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(31, "table");
                        __builder4.AddAttribute(32, "class", "table table-striped");
                        __builder4.OpenElement(33, "tbody");
#nullable restore
#line 26 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor"
                         foreach (var student in ParentStudents)
                        {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(34, "tr");
                        __builder4.OpenElement(35, "td");
                        __builder4.AddContent(36, 
#nullable restore
#line 29 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor"
                                      ParentStudents.IndexOf(student) + 1

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(37, "\r\n                                ");
                        __builder4.OpenElement(38, "td");
                        __builder4.AddContent(39, 
#nullable restore
#line 30 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor"
                                     student.FullName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
#nullable restore
#line 31 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor"
                                 if (IsAdmin) // Non-admin cannot remove students from themselves
                                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(40, "td");
                        __builder4.OpenComponent<MatBlazor.MatIconButton>(41);
                        __builder4.AddAttribute(42, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor"
                                                                  () => RemoveStudent(@student)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(43, "Icon", "delete_forever");
                        __builder4.AddAttribute(44, "Attributes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.Object>>(
#nullable restore
#line 34 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor"
                                                                                                                                      new Dictionary<string, object>() { { "title", "Remove Student" }, { "type", "button" } }

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
#nullable restore
#line 36 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor"
                                }

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
#nullable restore
#line 39 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor"
                        }

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.CloseElement();
#nullable restore
#line 42 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor"
            }

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(45, "<br>\r\n            <br>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\ACER\source\repos\MyProjects\S3_net5.0\LNX-S3.WebUI.cBlazor\src\S3.WebUI.cBlazor\Shared\Components\StudentVisibilityComponent.razor"
       

    private Student selectedStudent;
    private List<Student> availableStudents;

    [Parameter] public Parent Parent { get; set; } // The parent whose students are being displayed / modified.
    [Parameter] public List<Student> ParentStudents  { get; set; } = null; // The parent's students which might have been loaded ealier
    [Parameter] public Mode Mode { get; set; }
    [Parameter] public bool IsAdmin { get; set; } = false;

    private void AddStudent()
    {
        if (!(selectedStudent is null) && !(ParentStudents.Any(x => x.Id == selectedStudent.Id)))
        {
            ParentStudents.Insert(0, selectedStudent);
            availableStudents.Remove(availableStudents.Find(x => x.Id == selectedStudent.Id));
            selectedStudent = null; // This enables auto clear of the UI component used for selection

            Parent.StudentIds = ParentStudents.Select(x => x.Id).ToArray();
        }
    }

    private void RemoveStudent(Student student)
    {
        ParentStudents.Remove(student);
        availableStudents.Add(student);

        Parent.StudentIds = ParentStudents.Select(x => x.Id).ToArray();
    }

    private async Task ToggleStudentsVisibilityAsync(bool studentsVisible)
    {
        if (studentsVisible)
        {
            if (Mode == Mode.Add && ParentStudents is null)
            {
                ParentStudents = new List<Student>();
            }
            else if ((Mode == Mode.Update || Mode == Mode.None) && ParentStudents is null)
            {
                // Get this parent's wards for this school
                var students = await StudentService.GetAllAsync(parentId: Parent.Id.ToString(), schoolId: AppUser.SchoolId);
                ParentStudents = students.ToList();
            }

            if (IsAdmin) // Non-admin does not need to know available students in a school
            {
                if (availableStudents is null)
                {
                    // Get the available students in this school
                    var students = await StudentService.GetAllAsync(schoolId: AppUser.SchoolId);
                    availableStudents = students.ToList();
                }

                // Remove ParentStudents from availableStudents
                foreach (var student in ParentStudents)
                {
                    availableStudents.Remove(availableStudents.Find(x => x.Id == student.Id));
                }
            }
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppUser AppUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService StudentService { get; set; }
    }
}
#pragma warning restore 1591