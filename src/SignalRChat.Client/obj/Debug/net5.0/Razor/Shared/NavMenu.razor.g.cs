#pragma checksum "/Users/alejandroramirezreyesbroxel/Downloads/PA.SignalR-Chat/src/SignalRChat.Client/Shared/NavMenu.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "513a4e7a421eda45d88fd0c94a8e3841a7598b2093b24a3c6d2e5d25fd9b9735"
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
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-dxh37pnn0c");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-dxh37pnn0c>SignalRChat.Client</a>\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "/Users/alejandroramirezreyesbroxel/Downloads/PA.SignalR-Chat/src/SignalRChat.Client/Shared/NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-dxh37pnn0c");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-dxh37pnn0c></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "/Users/alejandroramirezreyesbroxel/Downloads/PA.SignalR-Chat/src/SignalRChat.Client/Shared/NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "/Users/alejandroramirezreyesbroxel/Downloads/PA.SignalR-Chat/src/SignalRChat.Client/Shared/NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-dxh37pnn0c");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-dxh37pnn0c");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-dxh37pnn0c");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", (object)("nav-link"));
            __builder.AddAttribute(22, "href", (object)(""));
            __builder.AddAttribute(23, "Match", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "/Users/alejandroramirezreyesbroxel/Downloads/PA.SignalR-Chat/src/SignalRChat.Client/Shared/NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(24, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-dxh37pnn0c></span> Home\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item px-3");
            __builder.AddAttribute(29, "b-dxh37pnn0c");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", (object)("nav-link"));
            __builder.AddAttribute(32, "href", (object)("chat"));
            __builder.AddAttribute(33, "Match", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 16 "/Users/alejandroramirezreyesbroxel/Downloads/PA.SignalR-Chat/src/SignalRChat.Client/Shared/NavMenu.razor"
                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(34, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(35, "<span class=\"oi oi-chat\" aria-hidden=\"true\" b-dxh37pnn0c></span> Chat\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "/Users/alejandroramirezreyesbroxel/Downloads/PA.SignalR-Chat/src/SignalRChat.Client/Shared/NavMenu.razor"
       
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
