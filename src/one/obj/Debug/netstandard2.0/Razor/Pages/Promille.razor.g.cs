#pragma checksum "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Promille.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d778ddae346159fac2edcdfcb8da6c21179b4e9c"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Promille.razor"
using one.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/promille")]
    public partial class Promille : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "inputs");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.AddMarkupContent(3, "<p>Weiblich? <input type=\"checkbox\"></p>\r\n        ");
            __builder.OpenElement(4, "p");
            __builder.AddMarkupContent(5, "<div class=\"entry\">Alter: </div>");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 6 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Promille.razor"
                                                          calculation.Age

#line default
#line hidden
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => calculation.Age = __value, calculation.Age));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "p");
            __builder.AddMarkupContent(11, "<div class=\"entry\">Grösse [cm]: </div>");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 7 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Promille.razor"
                                                                calculation.Height

#line default
#line hidden
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => calculation.Height = __value, calculation.Height));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "p");
            __builder.AddMarkupContent(17, "<div class=\"entry\">Gewicht: </div>");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 8 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Promille.razor"
                                                            calculation.Weight

#line default
#line hidden
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => calculation.Weight = __value, calculation.Weight));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "p");
            __builder.AddMarkupContent(23, "<div class=\"entry\">Deziliter getrunken: </div>");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 9 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Promille.razor"
                                                                        calculation.Deciliter

#line default
#line hidden
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => calculation.Deciliter = __value, calculation.Deciliter));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "p");
            __builder.AddMarkupContent(29, "<div class=\"entry\">Alkohol im Getrunkenen [%]: </div>");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 10 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Promille.razor"
                                                                               calculation.Percent

#line default
#line hidden
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => calculation.Percent = __value, calculation.Percent));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 11 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Promille.razor"
                          OnCalculate

#line default
#line hidden
            ));
            __builder.AddContent(36, "Berechnen");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.AddMarkupContent(39, "<div class=\"solutions\">\r\n    <h3>Promille Alkohol: </h3>\r\n</div>");
        }
        #pragma warning restore 1998
#line 19 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Promille.razor"
 
    AlcoholBloodConcentrationCalculation calculation = new AlcoholBloodConcentrationCalculation(Genders.Male, 0,0,0,0,0);

    public void OnCalculate()
    {
        
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
