#pragma checksum "/Users/alejandroramirezreyesbroxel/Downloads/PA.SignalR-Chat/src/SignalRChat.Client/Shared/MainLayout.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3a7b689cd7bddb5c5b0df28ed694c404583264fbb0f8fe76c82073aa483a9cf0"
// <auto-generated/>
#pragma warning disable 1591
namespace SignalRChat.Client.Shared
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/alejandroramirezreyesbroxel/Downloads/PA.SignalR-Chat/src/SignalRChat.Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/alejandroramirezreyesbroxel/Downloads/PA.SignalR-Chat/src/SignalRChat.Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/alejandroramirezreyesbroxel/Downloads/PA.SignalR-Chat/src/SignalRChat.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/alejandroramirezreyesbroxel/Downloads/PA.SignalR-Chat/src/SignalRChat.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/alejandroramirezreyesbroxel/Downloads/PA.SignalR-Chat/src/SignalRChat.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/alejandroramirezreyesbroxel/Downloads/PA.SignalR-Chat/src/SignalRChat.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/alejandroramirezreyesbroxel/Downloads/PA.SignalR-Chat/src/SignalRChat.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/alejandroramirezreyesbroxel/Downloads/PA.SignalR-Chat/src/SignalRChat.Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/alejandroramirezreyesbroxel/Downloads/PA.SignalR-Chat/src/SignalRChat.Client/_Imports.razor"
using SignalRChat.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/alejandroramirezreyesbroxel/Downloads/PA.SignalR-Chat/src/SignalRChat.Client/_Imports.razor"
using SignalRChat.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-czoi667jno");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-czoi667jno");
            __builder.OpenComponent<global::SignalRChat.Client.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-czoi667jno");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-czoi667jno><a href=\"https://www.netmentor.es/\" target=\"_blank\" class=\"ml-md-auto\" b-czoi667jno>netmentor</a></div>\n\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-czoi667jno");
#nullable restore
#line 14 "/Users/alejandroramirezreyesbroxel/Downloads/PA.SignalR-Chat/src/SignalRChat.Client/Shared/MainLayout.razor"
__builder.AddContent(15, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
