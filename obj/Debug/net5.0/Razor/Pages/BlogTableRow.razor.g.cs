#pragma checksum "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\Pages\BlogTableRow.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e3108db3dbd36e3b33394b26f3b6ee2a931bfbb"
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
#line 1 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\Pages\BlogTableRow.razor"
using CS401_Final_Blazor.Data;

#line default
#line hidden
#nullable disable
    public partial class BlogTableRow : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\Pages\BlogTableRow.razor"
 if (string.IsNullOrWhiteSpace(search) || (!string.IsNullOrWhiteSpace(search) && (model.Author.ToLower().Contains(search) || model.Title.ToLower().Contains(search))))
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "tr");
            __builder.AddAttribute(1, "id", 
#nullable restore
#line 4 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\Pages\BlogTableRow.razor"
             model.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "style", "text-align: center;");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\Pages\BlogTableRow.razor"
                                                               () => redirect(model.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(4, "td");
#nullable restore
#line 5 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\Pages\BlogTableRow.razor"
__builder.AddContent(5, model.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "td");
#nullable restore
#line 6 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\Pages\BlogTableRow.razor"
__builder.AddContent(8, model.Author);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "td");
#nullable restore
#line 7 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\Pages\BlogTableRow.razor"
__builder.AddContent(11, model.LastModified);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\Pages\BlogTableRow.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Michael\Desktop\CS401_Final\CS401_Final_Blazor\CS401_Final_Blazor\Pages\BlogTableRow.razor"
       
    [Parameter]
    public BlogModel model { get; set; }
    [Parameter]
    public string search { get; set; }
    [Parameter]
    public Action<Guid> redirect { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
