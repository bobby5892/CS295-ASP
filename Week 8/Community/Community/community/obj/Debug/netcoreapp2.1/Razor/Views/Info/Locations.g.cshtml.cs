#pragma checksum "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Info\Locations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afdc073e303424a8abc64713c00eaa63e438d17e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Info_Locations), @"mvc.1.0.view", @"/Views/Info/Locations.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Info/Locations.cshtml", typeof(AspNetCore.Views_Info_Locations))]
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
#line 1 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\_ViewImports.cshtml"
using community;

#line default
#line hidden
#line 2 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\_ViewImports.cshtml"
using community.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afdc073e303424a8abc64713c00eaa63e438d17e", @"/Views/Info/Locations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16075df28e6dd41b65c08800e0925befb2c48920", @"/Views/_ViewImports.cshtml")]
    public class Views_Info_Locations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LocationViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Info\Locations.cshtml"
  
    ViewData["Title"] = "Locations - Via Layout 2";
    Layout = "/views/shared/_Layout2.cshtml";

#line default
#line hidden
            BeginContext(134, 24, true);
            WriteLiteral("\r\n<h2>Locations</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Info\Locations.cshtml"
 foreach (Location Location in Model.Locations)
{

#line default
#line hidden
            BeginContext(210, 12, true);
            WriteLiteral("    <br /><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 222, "\"", 243, 1);
#line 11 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Info\Locations.cshtml"
WriteAttributeValue("", 229, Location.Link, 229, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(244, 14, true);
            WriteLiteral(" target=\"new\">");
            EndContext();
            BeginContext(259, 13, false);
#line 11 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Info\Locations.cshtml"
                                           Write(Location.Name);

#line default
#line hidden
            EndContext();
            BeginContext(272, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 12 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Info\Locations.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LocationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
