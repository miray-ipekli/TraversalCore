#pragma checksum "C:\Users\miray.ipekli\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_PopularDestinationsPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93af9435e55e98d1a6f7d9891912c04e85409cf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__PopularDestinationsPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_PopularDestinationsPartial/Default.cshtml")]
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
#line 1 "C:\Users\miray.ipekli\source\repos\TraversalCore\TraversalCore\Views\_ViewImports.cshtml"
using TraversalCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\miray.ipekli\source\repos\TraversalCore\TraversalCore\Views\_ViewImports.cshtml"
using TraversalCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\miray.ipekli\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_PopularDestinationsPartial\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93af9435e55e98d1a6f7d9891912c04e85409cf5", @"/Views/Shared/Components/_PopularDestinationsPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02afc0eb13c08320087b79bd5a738f20daaee5de", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__PopularDestinationsPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destinational>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""w3l-grids-3 py-5"">
    <div class=""container py-md-5"">
        <div class=""title-content text-left mb-lg-5 mb-4"">
            <h6 class=""sub-title"">Visit</h6>
            <h3 class=""hny-title"">Popüler Rotalar</h3>
        </div>
        <div class=""row bottom-ab-grids"">

");
#nullable restore
#line 11 "C:\Users\miray.ipekli\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_PopularDestinationsPartial\Default.cshtml"
             foreach(var item in Model) { 


#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-lg-6 subject-card mt-lg-0 mt-4"">
                <div class=""subject-card-header p-4"">
                    <a href=""#"" class=""card_title p-lg-4d-block"">
                        <div class=""row align-items-center"">
                            <div class=""col-sm-5 subject-img"">
                                <img");
            BeginWriteAttribute("src", " src=", 745, "", 770, 1);
#nullable restore
#line 18 "C:\Users\miray.ipekli\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_PopularDestinationsPartial\Default.cshtml"
WriteAttributeValue("", 750, item.DestinationImg, 750, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 788, "\"", 794, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"col-sm-7 subject-content mt-sm-0 mt-4\">\r\n                                <h4>");
#nullable restore
#line 21 "C:\Users\miray.ipekli\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_PopularDestinationsPartial\Default.cshtml"
                               Write(item.DestinationCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 22 "C:\Users\miray.ipekli\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_PopularDestinationsPartial\Default.cshtml"
                              Write(item.DestinationDayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <div class=\"dst-btm\">\r\n                                    <h6");
            BeginWriteAttribute("class", " class=\"", 1139, "\"", 1147, 0);
            EndWriteAttribute();
            WriteLiteral("> Başlayan Fiyatlarla </h6>\r\n                                    <span>");
#nullable restore
#line 25 "C:\Users\miray.ipekli\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_PopularDestinationsPartial\Default.cshtml"
                                     Write(item.DestinationPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</span>\r\n                                </div>\r\n                                <p class=\"sub-para\">");
#nullable restore
#line 27 "C:\Users\miray.ipekli\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_PopularDestinationsPartial\Default.cshtml"
                                               Write(item.DestinationDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 33 "C:\Users\miray.ipekli\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_PopularDestinationsPartial\Default.cshtml"
            
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destinational>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
