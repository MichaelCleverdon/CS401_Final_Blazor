#pragma checksum "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cea2efeaf8ef6c8d3ee75f9077a000e96956544f"
// <auto-generated/>
#pragma warning disable 1591
namespace CS401_Final_Blazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\_Imports.razor"
using CS401_Final_Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\_Imports.razor"
using CS401_Final_Blazor.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-gjnse83is7");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-gjnse83is7>CS401_Final_Blazor</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-gjnse83is7");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-gjnse83is7></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-gjnse83is7");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "topnav");
            __builder.AddAttribute(16, "b-gjnse83is7");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "navItem");
            __builder.AddAttribute(19, "b-gjnse83is7");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "href", "");
            __builder.AddAttribute(22, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 28 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\Shared\NavMenu.razor"
                                    NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(24, "Home");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "navItem");
            __builder.AddAttribute(28, "b-gjnse83is7");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "href", "/browse");
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(32, "Browse");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "navItem");
            __builder.AddAttribute(36, "b-gjnse83is7");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(37);
            __builder.AddAttribute(38, "href", "/create");
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(40, "Create");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "navItem");
            __builder.AddAttribute(44, "b-gjnse83is7");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(45);
            __builder.AddAttribute(46, "href", "/about");
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(48, "About this app");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
