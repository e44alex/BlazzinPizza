#pragma checksum "D:\Source\Repos\BlazzinPizza\BlazingPizza.ComponentsLibrary\Map\Map.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c47a6a384f080010e34952ca0bb2cfefb2defce0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazingPizza.ComponentsLibrary.Map
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Source\Repos\BlazzinPizza\BlazingPizza.ComponentsLibrary\Map\Map.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public partial class Map : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "D:\Source\Repos\BlazzinPizza\BlazingPizza.ComponentsLibrary\Map\Map.razor"
       
    string elementId = $"map-{Guid.NewGuid().ToString("D")}";
    
    [Parameter] public double Zoom { get; set; }
    [Parameter] public List<Marker> Markers { get; set; }

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeVoidAsync(
            "deliveryMap.showOrUpdate",
            elementId,
            Markers);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
