#pragma checksum "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Promille.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c65ffce50623f1cb7d7da2abf1048f249533511"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace one.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\_Imports.razor"
using one;

#line default
#line hidden
#line 7 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\_Imports.razor"
using one.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/promille")]
    public partial class Promille : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 18 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Promille.razor"
 
    double J { get; set; }
    double H { get; set; }
    double G { get; set; }
    double D { get; set; }
    double P { get; set; }
    double p { get; set; }


    void Calc()
    {
        double c = 2.447 - 0.09516 * J + 0.1074 * H + 0.3362 * G;
        double g = 0.7893 * P * D;
        p = 0.76 * g / c;
        p = Math.Round(p, 2);
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
