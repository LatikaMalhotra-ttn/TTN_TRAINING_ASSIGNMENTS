#pragma checksum "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\Pages\AddNav.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad7183371195406ab40225ef13b4afab6b8173a8"
// <auto-generated/>
#pragma warning disable 1591
namespace StudentBlazor.Pages
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
#nullable restore
#line 5 "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\Pages\AddNav.razor"
using StudentApi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\Pages\AddNav.razor"
using StudentBlazor.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddNav")]
    public partial class AddNav : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.AddMarkupContent(1, "\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-10");
            __builder.AddMarkupContent(7, "\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", " form-group");
            __builder.AddMarkupContent(10, "\n                ");
            __builder.AddMarkupContent(11, "<label for=\"Name\" class=\"control-label\">CategoryName</label>\n                ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "form", "Name");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\Pages\AddNav.razor"
                                                                objnavBarInfo.LinkName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objnavBarInfo.LinkName = __value, objnavBarInfo.LinkName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", " form-group");
            __builder.AddMarkupContent(21, "\n                ");
            __builder.AddMarkupContent(22, "<label for=\"Email\" class=\"control-label\">Reference</label>\n                ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "form", "Email");
            __builder.AddAttribute(25, "class", "form-control");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\Pages\AddNav.razor"
                                                                 objnavBarInfo.LinkAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objnavBarInfo.LinkAddress = __value, objnavBarInfo.LinkAddress));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n\n\n\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "row");
            __builder.AddMarkupContent(34, "\n        ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col-md-4");
            __builder.AddMarkupContent(37, "\n            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form-group");
            __builder.AddMarkupContent(40, "\n                ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "button");
            __builder.AddAttribute(43, "class", "btn btn-primary");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\Pages\AddNav.razor"
                                                                        CreateNavBar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "value", "Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                ");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "type", "button");
            __builder.AddAttribute(49, "class", "btn btn-primary");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\Pages\AddNav.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "value", "cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\Latika Malhotra\Desktop\blazor\TTN-BLAZOR\TTN-BLAZOR\BLAZOR\BLAZOR ADVANCE\Q3\StudentBlazor\Pages\AddNav.razor"
       
    NavBarInfo objnavBarInfo = new NavBarInfo();

    protected void CreateNavBar()
    {
        _navbar.AddNavBar(objnavBarInfo);
        _navigate.NavigateTo("/Index");
    }
    void Cancel()
    {
        _navigate.NavigateTo("/Index");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavBarService _navbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigate { get; set; }
    }
}
#pragma warning restore 1591
