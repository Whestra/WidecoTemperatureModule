#pragma checksum "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\Slides\StartView\StartViewComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aef7feb26d07e35a9c8b44427f8fae54376253e9"
// <auto-generated/>
#pragma warning disable 1591
namespace TemperatureModule.Webpage.Components.Slides.StartView
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\_Imports.razor"
using TemperatureModule.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\_Imports.razor"
using TemperatureModule.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\Slides\StartView\StartViewComponent.razor"
using TemperatureModule.Webpage.Components.Slides.StartView.RecordPlaceholder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\Slides\StartView\StartViewComponent.razor"
using TemperatureModule.Webpage.Components.Slides.StartView.Graph;

#line default
#line hidden
#nullable disable
    public partial class StartViewComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" href=\"css/myown/Carousel.css\">\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "startView");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "order:1; border-radius:5px;");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<TemperatureModule.Webpage.Components.Slides.StartView.RecordPlaceholder.RecordsViewComponent>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "style", "order:3; border-radius:5px; width: 100%");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenComponent<TemperatureModule.Webpage.Components.Slides.StartView.Graph.GraphComponent>(13);
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
