#pragma checksum "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "394b4ab137e7349c3167468b8c19a3d18988fdc1"
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
#line 7 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\_Imports.razor"
using one.Shared;

#line default
#line hidden
#line 2 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
using System.Security.Cryptography;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/wellen")]
    public partial class Wellen : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "inputs");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "p");
            __builder.AddContent(4, "Wind in m/s: ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 5 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                                  V

#line default
#line hidden
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => V = __value, V));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, "Wassertiefe [m]: ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 6 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                                      T

#line default
#line hidden
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => T = __value, T));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "p");
            __builder.AddContent(16, "Windlaufstrecke [m]: ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 7 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                                          L

#line default
#line hidden
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => L = __value, L));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "class", "helpcheck");
            __builder.AddAttribute(22, "id", "help");
            __builder.AddAttribute(23, "type", "checkbox");
            __builder.AddAttribute(24, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 7 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                                                                                                         help

#line default
#line hidden
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => help = __value, help));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "<label for=\"help\">?</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#line 8 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
     if (help)
    {

#line default
#line hidden
            __builder.AddMarkupContent(28, "<p>Die Strecke die der Wind übers Wasser weht</p>");
#line 9 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                                                      }

#line default
#line hidden
            __builder.AddContent(29, "    ");
            __builder.OpenElement(30, "p");
            __builder.AddContent(31, "Breitengrad bekannt? ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "checkbox");
            __builder.AddAttribute(34, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 10 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                                                          bgiv

#line default
#line hidden
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => bgiv = __value, bgiv));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#line 11 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
     if (bgiv)
    {

#line default
#line hidden
            __builder.OpenElement(37, "p");
            __builder.AddContent(38, "Breitengrad: ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 12 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                                   b

#line default
#line hidden
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => b = __value, b));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#line 12 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                                            }

#line default
#line hidden
            __builder.AddContent(42, "    ");
            __builder.OpenElement(43, "p");
            __builder.AddMarkupContent(44, "Höhe bekannt? ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "checkbox");
            __builder.AddAttribute(47, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 13 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                                                   hgiv

#line default
#line hidden
            ));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => hgiv = __value, hgiv));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#line 14 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
     if (hgiv)
    {

#line default
#line hidden
            __builder.OpenElement(50, "p");
            __builder.AddMarkupContent(51, "Höhe: ");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 15 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                            H

#line default
#line hidden
            ));
            __builder.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => H = __value, H));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#line 15 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                                     }

#line default
#line hidden
            __builder.AddContent(55, "    ");
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 16 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                      Calc

#line default
#line hidden
            ));
            __builder.AddContent(58, "Berechnen");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "solutions");
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.OpenElement(64, "h4");
            __builder.AddMarkupContent(65, "Durchschnittshöhe: ");
            __builder.AddContent(66, 
#line 19 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                             r(ho)

#line default
#line hidden
            );
            __builder.AddContent(67, " m");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.OpenElement(69, "h4");
            __builder.AddMarkupContent(70, "Signifikante Höhe: ");
            __builder.AddContent(71, 
#line 20 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                             r(hs)

#line default
#line hidden
            );
            __builder.AddContent(72, " m");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n    ");
            __builder.OpenElement(74, "h4");
            __builder.AddMarkupContent(75, "Grösste 10% am Tag: ");
            __builder.AddContent(76, 
#line 21 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                              r(h10)

#line default
#line hidden
            );
            __builder.AddContent(77, " m");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n    ");
            __builder.OpenElement(79, "h4");
            __builder.AddMarkupContent(80, "3 grössten am Tag: ");
            __builder.AddContent(81, 
#line 22 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                             r(hm)

#line default
#line hidden
            );
            __builder.AddContent(82, " m");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.OpenElement(84, "h4");
            __builder.AddContent(85, "Wellenzeitabstand: ");
            __builder.AddContent(86, 
#line 23 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                             r(z)

#line default
#line hidden
            );
            __builder.AddContent(87, " s");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n    ");
            __builder.OpenElement(89, "h4");
            __builder.AddContent(90, "Pro Sekunde: ");
            __builder.AddContent(91, 
#line 24 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                       r(f)

#line default
#line hidden
            );
            __builder.AddContent(92, " Wellen");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n    ");
            __builder.OpenElement(94, "h4");
            __builder.AddContent(95, "Wellengeschwindigkeit: ");
            __builder.AddContent(96, 
#line 25 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                                 r(C)

#line default
#line hidden
            );
            __builder.AddContent(97, " m/s");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n    ");
            __builder.OpenElement(99, "h4");
            __builder.AddContent(100, "Wellenabstand: ");
            __builder.AddContent(101, 
#line 26 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                         r(h)

#line default
#line hidden
            );
            __builder.AddContent(102, " m");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n    ");
            __builder.OpenElement(104, "h4");
            __builder.AddMarkupContent(105, "Tiefster spürbarer Punkt: -");
            __builder.AddContent(106, 
#line 27 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                                     r(i)

#line default
#line hidden
            );
            __builder.AddContent(107, " m");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n    ");
            __builder.OpenElement(109, "h4");
            __builder.AddContent(110, "Durschnittsbrechtiefe: ");
            __builder.AddContent(111, 
#line 28 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                                 r(bws/2)

#line default
#line hidden
            );
            __builder.AddContent(112, " m");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n    ");
            __builder.OpenElement(114, "h4");
            __builder.AddContent(115, "Signifikante Brechtiefe: ");
            __builder.AddContent(116, 
#line 29 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                                   r(bws)

#line default
#line hidden
            );
            __builder.AddContent(117, " m");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n    ");
            __builder.OpenElement(119, "h4");
            __builder.AddContent(120, "Brechtiefe obere 10%: ");
            __builder.AddContent(121, 
#line 30 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                                r(bws*1.3)

#line default
#line hidden
            );
            __builder.AddContent(122, " m");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n    ");
            __builder.OpenElement(124, "h4");
            __builder.AddMarkupContent(125, "Brechtiefe der grössten: ");
            __builder.AddContent(126, 
#line 31 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
                                   r(bws*2)

#line default
#line hidden
            );
            __builder.AddContent(127, " m");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 37 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
 
    double V { get; set; }
    double T { get; set; }
    double L { get; set; }
    double b { get; set; }
    double H { get; set; }
    const double e = Math.E;
    const double pi = Math.PI;
    bool help { get; set; }
    bool bgiv { get; set; }
    bool hgiv { get; set; }
    double C { get; set; }
    double z { get; set; }
    double f { get; set; }
    double hs { get; set; }
    double ho { get; set; }
    double h10 { get; set; }
    double hm { get; set; }
    double v { get; set; }
    double bws { get; set; }
    double h { get; set; }
    double i { get; set; }

    double p(double x,double y)
    {
        return Math.Pow(x, y);
    }

    double ln(double x)
    {
        return Math.Log(x);
    }

    double th(double x)
    {
        return (p(e,x)-p(e,-x))/(p(e,x)+p(e,-x));
    }

    double r(double x)
    {
        return Math.Round(x, 2);
    }


    void Calc()
    {
        if (!bgiv) { b=0; }
        if (!hgiv) { h=0; }
        z = 0.546 * p(V, 1.23) * th(2.54 * p(T, 0.375) / p(V, 0.923)) * th(0.102 * p(L, 1.0 / 3.0) / (p(V, 0.82) * th(2.54 * p(T, 0.375) / p(V, 0.923))));
        f = 1 / z;
        hs = 0.0145 * p(V, 2.46) * th(5.75 * p(T, 0.75) / p(V, 1.845)) * th(0.029 * p(L, 0.5) / (p(V, 1.23) * th(5.75 * p(T, 0.75) / p(V, 1.845))));
        ho = hs / 2;
        h10 = 1.3 * hs;
        hm = 2 * hs;
        double g = 6.67408 * Math.Pow(10, 13) * 5.972 / (Math.Pow((6371000 / (1 + 0.002665 * Math.Cos(2 * Math.PI * b / 180)) + H), 2));
        v = p(g * th(2 * pi * f) / (2 * pi * f * f), 0.5);
        if (v / f < 20 * T) { C = v; }
        else { C=p(g *T,0.5);}
        bws = hs / 1.3;
        h = C * z;
        i = h / 2;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
