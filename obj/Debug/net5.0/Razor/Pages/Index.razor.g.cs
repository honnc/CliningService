#pragma checksum "E:\Саша\OneDrive - vyatsu\Универ\Лабы инфа\Labs C#\CleaningServiceWeb\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f16f7118d908d00eadb0bb6cb6add13a2e44a756"
// <auto-generated/>
#pragma warning disable 1591
namespace CleaningServiceWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Саша\OneDrive - vyatsu\Универ\Лабы инфа\Labs C#\CleaningServiceWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Саша\OneDrive - vyatsu\Универ\Лабы инфа\Labs C#\CleaningServiceWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Саша\OneDrive - vyatsu\Универ\Лабы инфа\Labs C#\CleaningServiceWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Саша\OneDrive - vyatsu\Универ\Лабы инфа\Labs C#\CleaningServiceWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Саша\OneDrive - vyatsu\Универ\Лабы инфа\Labs C#\CleaningServiceWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Саша\OneDrive - vyatsu\Универ\Лабы инфа\Labs C#\CleaningServiceWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Саша\OneDrive - vyatsu\Универ\Лабы инфа\Labs C#\CleaningServiceWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Саша\OneDrive - vyatsu\Универ\Лабы инфа\Labs C#\CleaningServiceWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Саша\OneDrive - vyatsu\Универ\Лабы инфа\Labs C#\CleaningServiceWeb\_Imports.razor"
using CleaningServiceWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Саша\OneDrive - vyatsu\Универ\Лабы инфа\Labs C#\CleaningServiceWeb\_Imports.razor"
using CleaningServiceWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Саша\OneDrive - vyatsu\Универ\Лабы инфа\Labs C#\CleaningServiceWeb\_Imports.razor"
using CleaningServiceWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Саша\OneDrive - vyatsu\Универ\Лабы инфа\Labs C#\CleaningServiceWeb\_Imports.razor"
using CleaningServiceWeb.Data.CleaningServiceModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "<p style=\"padding-top: 20px; padding-bottom: 20px\">Пример вывода данных:</p>\r\n        ");
                __builder2.OpenElement(4, "table");
                __builder2.AddAttribute(5, "class", "table");
                __builder2.AddMarkupContent(6, "<thead><tr><th>Имя компании</th>\r\n                    <th>Адрес</th>\r\n                    <th>Контактное лицо</th>\r\n                    <th>Номер телефона</th></tr></thead>\r\n            ");
                __builder2.OpenElement(7, "tbody");
#nullable restore
#line 23 "E:\Саша\OneDrive - vyatsu\Универ\Лабы инфа\Labs C#\CleaningServiceWeb\Pages\Index.razor"
                 foreach (var c in Clients)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(8, "tr");
                __builder2.OpenElement(9, "td");
                __builder2.AddContent(10, 
#nullable restore
#line 26 "E:\Саша\OneDrive - vyatsu\Универ\Лабы инфа\Labs C#\CleaningServiceWeb\Pages\Index.razor"
                             c.NameCompany

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n                        ");
                __builder2.OpenElement(12, "td");
                __builder2.AddContent(13, 
#nullable restore
#line 27 "E:\Саша\OneDrive - vyatsu\Универ\Лабы инфа\Labs C#\CleaningServiceWeb\Pages\Index.razor"
                             c.Address

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n                        ");
                __builder2.OpenElement(15, "td");
                __builder2.AddContent(16, 
#nullable restore
#line 28 "E:\Саша\OneDrive - vyatsu\Универ\Лабы инфа\Labs C#\CleaningServiceWeb\Pages\Index.razor"
                             c.Fioagent

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                        ");
                __builder2.OpenElement(18, "td");
                __builder2.AddContent(19, 
#nullable restore
#line 29 "E:\Саша\OneDrive - vyatsu\Универ\Лабы инфа\Labs C#\CleaningServiceWeb\Pages\Index.razor"
                             c.PhoneNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 31 "E:\Саша\OneDrive - vyatsu\Универ\Лабы инфа\Labs C#\CleaningServiceWeb\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(20, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(21, "<p class=\"alert alert-secondary mt-4\"><b>Чтобы увидеть данные авторизуйтесь!</b></p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "E:\Саша\OneDrive - vyatsu\Универ\Лабы инфа\Labs C#\CleaningServiceWeb\Pages\Index.razor"
      
    List<Client> Clients;
    protected override void OnInitialized()
    {
        Clients = CliServ.GetClients();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientService CliServ { get; set; }
    }
}
#pragma warning restore 1591
