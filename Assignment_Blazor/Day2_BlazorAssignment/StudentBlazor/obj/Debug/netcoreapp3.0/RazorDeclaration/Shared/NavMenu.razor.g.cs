#pragma checksum "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dee9d2694f9fafa916240e421621d4aeb404dca7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace StudentBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using StudentBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using StudentBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using StudentApi.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using StudentApi.Services;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigate { get; set; }
    }
}
#pragma warning restore 1591
