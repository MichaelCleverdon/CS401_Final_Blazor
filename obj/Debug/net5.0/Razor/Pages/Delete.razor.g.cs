#pragma checksum "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\Pages\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27eb429e6e09eb687bf1a81e3ae7f56f0631f36a"
// <auto-generated/>
#pragma warning disable 1591
namespace CS401_Final_Blazor.Pages
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
#nullable restore
#line 2 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\Pages\Delete.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/delete")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "The blog post has successfully been deleted. Redirect will happen in: ");
#nullable restore
#line 4 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\Pages\Delete.razor"
__builder.AddContent(2, timeUntilRedir);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\Pages\Delete.razor"
       
    public int timeUntilRedir { get; set; } = 2;
    protected override void OnInitialized() => RedirectAsync();
    private async void RedirectAsync()
    {
        while(timeUntilRedir > 0)
        {
            await Task.Delay(1000);
            timeUntilRedir--;
            StateHasChanged();

        }
        _nav.NavigateTo("/browse");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _nav { get; set; }
    }
}
#pragma warning restore 1591
