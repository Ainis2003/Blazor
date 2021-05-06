#pragma checksum "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\Pages\Authors.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83a733a9af202f2008ec8a65486d57f16ec4016e"
// <auto-generated/>
#pragma warning disable 1591
namespace BookManagment.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\_Imports.razor"
using BookManagment.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\_Imports.razor"
using BookManagment.Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors")]
    public partial class Authors : AuthorsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Author List</h3>\r\n<br>");
#nullable restore
#line 7 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\Pages\Authors.razor"
 if (Authors == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p>Loading...</p>");
#nullable restore
#line 10 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\Pages\Authors.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-deck");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table table-bordered");
            __builder.AddMarkupContent(6, @"<thead class=""thead-dark""><tr><th scope=""col"">Id</th>
                    <th scope=""col"">Pen Name</th>
                    <th scope=""col"">First Name</th>
                    <th scope=""col"">Last Name</th>
                    <th scope=""col"">Email</th>
                    <th scope=""col"">Average Rating</th></tr></thead>");
#nullable restore
#line 25 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\Pages\Authors.razor"
             foreach (var author in Authors)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tbody");
            __builder.OpenElement(8, "tr");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 29 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\Pages\Authors.razor"
                             author.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                        ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 30 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\Pages\Authors.razor"
                             author.PenName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                        ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 31 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\Pages\Authors.razor"
                             author.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 32 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\Pages\Authors.razor"
                             author.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 33 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\Pages\Authors.razor"
                             author.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 34 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\Pages\Authors.razor"
                             author.Rating

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\Pages\Authors.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\lenovo\source\repos\Blazor\BookManagment.Web\Pages\Authors.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
