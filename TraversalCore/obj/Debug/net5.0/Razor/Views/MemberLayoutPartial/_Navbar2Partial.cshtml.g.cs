#pragma checksum "C:\Users\miray.ipekli\source\repos\TraversalCore\TraversalCore\Views\MemberLayoutPartial\_Navbar2Partial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f5f7b45b8909833b9e13e1b8f43612cde3f54af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MemberLayoutPartial__Navbar2Partial), @"mvc.1.0.view", @"/Views/MemberLayoutPartial/_Navbar2Partial.cshtml")]
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
#line 3 "C:\Users\miray.ipekli\source\repos\TraversalCore\TraversalCore\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f5f7b45b8909833b9e13e1b8f43612cde3f54af", @"/Views/MemberLayoutPartial/_Navbar2Partial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02afc0eb13c08320087b79bd5a738f20daaee5de", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MemberLayoutPartial__Navbar2Partial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/soft-ui-dashboard/assets/img/team-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar avatar-sm  me-3 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/soft-ui-dashboard/assets/img/small-logos/logo-spotify.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar avatar-sm bg-gradient-dark  me-3 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<nav class=""navbar navbar-main navbar-expand-lg px-0 mx-4 shadow-none border-radius-xl"" id=""navbarBlur"" navbar-scroll=""true"">
    <div class=""container-fluid py-1 px-3"">    
        <div class=""collapse navbar-collapse mt-sm-0 mt-2 me-md-0 me-sm-4"" id=""navbar"">
            <div class=""ms-md-auto pe-md-3 d-flex align-items-center"">
                <div class=""input-group"">
                    <span class=""input-group-text text-body""><i class=""fas fa-search"" aria-hidden=""true""></i></span>
                    <input type=""text"" class=""form-control"" placeholder=""Type here..."">
                </div>
            </div>
            <ul class=""navbar-nav  justify-content-end"">
                <li class=""nav-item d-flex align-items-center"">
                    <a href=""javascript:;"" class=""nav-link text-body font-weight-bold px-0"">
                        <i class=""fa fa-user me-sm-1""></i>
                        <span class=""d-sm-inline d-none"">Sign In</span>
                    </a>
               ");
            WriteLiteral(@" </li>
                <li class=""nav-item d-xl-none ps-3 d-flex align-items-center"">
                    <a href=""javascript:;"" class=""nav-link text-body p-0"" id=""iconNavbarSidenav"">
                        <div class=""sidenav-toggler-inner"">
                            <i class=""sidenav-toggler-line""></i>
                            <i class=""sidenav-toggler-line""></i>
                            <i class=""sidenav-toggler-line""></i>
                        </div>
                    </a>
                </li>
                <li class=""nav-item px-3 d-flex align-items-center"">
                    <a href=""javascript:;"" class=""nav-link text-body p-0"">
                        <i class=""fa fa-cog fixed-plugin-button-nav cursor-pointer""></i>
                    </a>
                </li>
                <li class=""nav-item dropdown pe-2 d-flex align-items-center"">
                    <a href=""javascript:;"" class=""nav-link text-body p-0"" id=""dropdownMenuButton"" data-bs-toggle=""dropdown"" aria-expa");
            WriteLiteral(@"nded=""false"">
                        <i class=""fa fa-bell cursor-pointer""></i>
                    </a>
                    <ul class=""dropdown-menu  dropdown-menu-end  px-2 py-3 me-sm-n4"" aria-labelledby=""dropdownMenuButton"">
                        <li class=""mb-2"">
                            <a class=""dropdown-item border-radius-md"" href=""javascript:;"">
                                <div class=""d-flex py-1"">
                                    <div class=""my-auto"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0f5f7b45b8909833b9e13e1b8f43612cde3f54af7734", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                    <div class=""d-flex flex-column justify-content-center"">
                                        <h6 class=""text-sm font-weight-normal mb-1"">
                                            <span class=""font-weight-bold"">New message</span> from Laur
                                        </h6>
                                        <p class=""text-xs text-secondary mb-0"">
                                            <i class=""fa fa-clock me-1""></i>
                                            13 minutes ago
                                        </p>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class=""mb-2"">
                            <a class=""dropdown-item border-radius-md"" href=""javascript:;"">
                                <div class=""d-flex py-1"">
                                    <di");
            WriteLiteral("v class=\"my-auto\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0f5f7b45b8909833b9e13e1b8f43612cde3f54af9982", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                    <div class=""d-flex flex-column justify-content-center"">
                                        <h6 class=""text-sm font-weight-normal mb-1"">
                                            <span class=""font-weight-bold"">New album</span> by Travis Scott
                                        </h6>
                                        <p class=""text-xs text-secondary mb-0"">
                                            <i class=""fa fa-clock me-1""></i>
                                            1 day
                                        </p>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li>
                            <a class=""dropdown-item border-radius-md"" href=""javascript:;"">
                                <div class=""d-flex py-1"">
                                    <div class=""avatar av");
            WriteLiteral(@"atar-sm bg-gradient-secondary  me-3  my-auto"">
                                        <svg width=""12px"" height=""12px"" viewBox=""0 0 43 36"" version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"">
                                            <title>credit-card</title>
                                            <g stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"">
                                                <g transform=""translate(-2169.000000, -745.000000)"" fill=""#FFFFFF"" fill-rule=""nonzero"">
                                                    <g transform=""translate(1716.000000, 291.000000)"">
                                                        <g transform=""translate(453.000000, 454.000000)"">
                                                            <path class=""color-background"" d=""M43,10.7482083 L43,3.58333333 C43,1.60354167 41.3964583,0 39.4166667,0 L3.58333333,0 C1.60354167,0 0,1.60354167 0,3.58333333 L0,10.7482083 L43,10.7482083 Z"" opacity");
            WriteLiteral(@"=""0.593633743""></path>
                                                            <path class=""color-background"" d=""M0,16.125 L0,32.25 C0,34.2297917 1.60354167,35.8333333 3.58333333,35.8333333 L39.4166667,35.8333333 C41.3964583,35.8333333 43,34.2297917 43,32.25 L43,16.125 L0,16.125 Z M19.7083333,26.875 L7.16666667,26.875 L7.16666667,23.2916667 L19.7083333,23.2916667 L19.7083333,26.875 Z M35.8333333,26.875 L28.6666667,26.875 L28.6666667,23.2916667 L35.8333333,23.2916667 L35.8333333,26.875 Z""></path>
                                                        </g>
                                                    </g>
                                                </g>
                                            </g>
                                        </svg>
                                    </div>
                                    <div class=""d-flex flex-column justify-content-center"">
                                        <h6 class=""text-sm font-weight-normal mb-1"">
                      ");
            WriteLiteral(@"                      Payment successfully completed
                                        </h6>
                                        <p class=""text-xs text-secondary mb-0"">
                                            <i class=""fa fa-clock me-1""></i>
                                            2 days
                                        </p>
                                    </div>
                                </div>
                            </a>
                        </li>
                    </ul>
                </li>
            </ul>
        </div>
    </div>
</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
