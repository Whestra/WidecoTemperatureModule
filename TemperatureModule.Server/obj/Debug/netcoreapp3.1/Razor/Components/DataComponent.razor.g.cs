#pragma checksum "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a6d4bf77e856de6696f6c007bbf8e84cde32e80"
// <auto-generated/>
#pragma warning disable 1591
namespace TemperatureModule.Server.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 2 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataComponent.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataComponent.razor"
using TemperatureModule.Webpage.Datasource;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataComponent.razor"
using TemperatureModule.Webpage.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataComponent.razor"
using BlazorDateRangePicker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataComponent.razor"
using TemperatureModule.Webpage.Components.DataControllPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataComponent.razor"
using TemperatureModule.Webpage.Components.Slides;

#line default
#line hidden
#nullable disable
    public partial class DataComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" href=\"css/myown/Data.css\">\r\n");
#nullable restore
#line 14 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataComponent.razor"
 if(UnitData != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "data");
            __builder.AddAttribute(4, "style", "display:flex; flex-direction:column;");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenComponent<TemperatureModule.Webpage.Components.DataControllPanel.ControllPanelComponent>(6);
            __builder.AddAttribute(7, "DateUpdated", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorDateRangePicker.DateRange>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorDateRangePicker.DateRange>(this, 
#nullable restore
#line 17 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataComponent.razor"
                                             DateUpdated

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenComponent<TemperatureModule.Webpage.Components.Slides.CarouselComponent>(9);
            __builder.AddAttribute(10, "UnitData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TemperatureModule.Webpage.Models.UnitData[]>(
#nullable restore
#line 18 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataComponent.razor"
                                     UnitData

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 20 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataComponent.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "    ");
            __builder.AddMarkupContent(14, "<div style=\"padding-top: 12px;padding-left: 20px;padding-bottom: 12px;font-size: 30px;border: 1px solid rgba(0,0,0,.125);\">\r\n        <strong>Loading...</strong>\r\n    </div>\r\n");
#nullable restore
#line 26 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataComponent.razor"
       
    public UnitData[] UnitData { get; set; }

    private Datasource _datasource;

    public async Task DateUpdated(DateRange dateRange)
    {
        UnitData = (await _datasource.GetDaysAsync(dateRange.Start.DateTime, dateRange.End.DateTime)).ToArray();
    }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            _datasource = new Datasource(client);
            UnitData = (await _datasource.GetDayAsync(DateTime.Now)).ToArray();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
