// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace S3.WebUI.cBlazor.Pages
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    public partial class _Imports : System.Object
    {
        #pragma warning disable 1998
        protected void Execute()
        {
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
