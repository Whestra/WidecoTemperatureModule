#pragma checksum "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\Components\Dropdown\DropdownListItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a66d3e84831596630faa064d6c8713bef69f5ac3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TemperatureModule.Webpage.Components.Dropdown
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using Temperature_Webmodule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using TemperatureModule.Webpage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using TemperatureModule.Webpage.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
    public partial class DropdownListItem<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\Components\Dropdown\DropdownListItem.razor"
       
    [CascadingParameter(Name = "Dropdown")]
    public Dropdown<TItem> Dropdown { get; set; }

    [Parameter]
    public TItem Item { get; set; }

    [Parameter]
    public RenderFragment<TItem> ChildContent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
