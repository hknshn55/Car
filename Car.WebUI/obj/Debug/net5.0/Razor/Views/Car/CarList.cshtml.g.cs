#pragma checksum "C:\Users\Serkan\source\repos\Car\Car.WebUI\Views\Car\CarList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "043c7b8ca0ffe066683863c4657a6bc947dd67e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_CarList), @"mvc.1.0.view", @"/Views/Car/CarList.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Serkan\source\repos\Car\Car.WebUI\Views\_ViewImports.cshtml"
using Car.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Serkan\source\repos\Car\Car.WebUI\Views\_ViewImports.cshtml"
using Car.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Serkan\source\repos\Car\Car.WebUI\Views\_ViewImports.cshtml"
using Car.Entities.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"043c7b8ca0ffe066683863c4657a6bc947dd67e2", @"/Views/Car/CarList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b154525c5f8a007af2cc86425d6f815e408224f", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_CarList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ArabaDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<link href=""//netdna.bootstrapcdn.com/twitter-bootstrap/2.3.2/css/bootstrap-combined.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//netdna.bootstrapcdn.com/twitter-bootstrap/2.3.2/js/bootstrap.min.js""></script>
<script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>

<div class=""container"">
    <div class=""row"">
        <div class=""span5"">
            <table class=""table table-striped table-condensed"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Marka</th>
                        <th>Model</th>
                        <th>Renk</th>
                        <th>Hasar Durumu</th>
                        <th>Yıl</th>
                        <th>Resim</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 29 "C:\Users\Serkan\source\repos\Car\Car.WebUI\Views\Car\CarList.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\Serkan\source\repos\Car\Car.WebUI\Views\Car\CarList.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\Serkan\source\repos\Car\Car.WebUI\Views\Car\CarList.cshtml"
                       Write(item.Marka);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\Serkan\source\repos\Car\Car.WebUI\Views\Car\CarList.cshtml"
                       Write(item.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\Serkan\source\repos\Car\Car.WebUI\Views\Car\CarList.cshtml"
                       Write(item.Renk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\Serkan\source\repos\Car\Car.WebUI\Views\Car\CarList.cshtml"
                       Write(item.HasarDurumu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\Serkan\source\repos\Car\Car.WebUI\Views\Car\CarList.cshtml"
                       Write(item.Yil);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"width:50px;height:50px;\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1471, "\"", 1488, 1);
#nullable restore
#line 39 "C:\Users\Serkan\source\repos\Car\Car.WebUI\Views\Car\CarList.cshtml"
WriteAttributeValue("", 1477, item.Resim, 1477, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </td>\r\n                        <td>\r\n                            <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1608, "\"", 1638, 2);
            WriteAttributeValue("", 1615, "/Car/CarDelete/", 1615, 15, true);
#nullable restore
#line 42 "C:\Users\Serkan\source\repos\Car\Car.WebUI\Views\Car\CarList.cshtml"
WriteAttributeValue("", 1630, item.Id, 1630, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a>\r\n                        </td>\r\n                        <td>\r\n                            <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 1764, "\"", 1795, 2);
            WriteAttributeValue("", 1771, "/Car/CarDetails/", 1771, 16, true);
#nullable restore
#line 45 "C:\Users\Serkan\source\repos\Car\Car.WebUI\Views\Car\CarList.cshtml"
WriteAttributeValue("", 1787, item.Id, 1787, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detaylar</a>\r\n                        </td>\r\n                        <td>\r\n                            <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1923, "\"", 1953, 2);
            WriteAttributeValue("", 1930, "/Car/CarUpdate/", 1930, 15, true);
#nullable restore
#line 48 "C:\Users\Serkan\source\repos\Car\Car.WebUI\Views\Car\CarList.cshtml"
WriteAttributeValue("", 1945, item.Id, 1945, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Güncelle</a>\r\n                        </td>\r\n                        <td>\r\n                            <a class=\"btn btn-dark\"");
            BeginWriteAttribute("href", " href=\"", 2081, "\"", 2109, 2);
            WriteAttributeValue("", 2088, "/Hasar/Index/", 2088, 13, true);
#nullable restore
#line 51 "C:\Users\Serkan\source\repos\Car\Car.WebUI\Views\Car\CarList.cshtml"
WriteAttributeValue("", 2101, item.Id, 2101, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Hataları</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 54 "C:\Users\Serkan\source\repos\Car\Car.WebUI\Views\Car\CarList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ArabaDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
