#pragma checksum "C:\Users\Rob\Documents\CIS295\CS295-ASP\Week 2\Community\community\community\Views\Home\MessageSent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d535b6aa28708b56d28acc7ff8950de5f8fac56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MessageSent), @"mvc.1.0.view", @"/Views/Home/MessageSent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MessageSent.cshtml", typeof(AspNetCore.Views_Home_MessageSent))]
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
#line 1 "C:\Users\Rob\Documents\CIS295\CS295-ASP\Week 2\Community\community\community\Views\_ViewImports.cshtml"
using community;

#line default
#line hidden
#line 2 "C:\Users\Rob\Documents\CIS295\CS295-ASP\Week 2\Community\community\community\Views\_ViewImports.cshtml"
using community.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d535b6aa28708b56d28acc7ff8950de5f8fac56", @"/Views/Home/MessageSent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16075df28e6dd41b65c08800e0925befb2c48920", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MessageSent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MessageModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Rob\Documents\CIS295\CS295-ASP\Week 2\Community\community\community\Views\Home\MessageSent.cshtml"
  
    ViewData["Title"] = "Sent Message";
    Layout = "/views/shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(116, 36, true);
            WriteLiteral("\r\nYour message has not been sent to ");
            EndContext();
            BeginContext(153, 13, false);
#line 7 "C:\Users\Rob\Documents\CIS295\CS295-ASP\Week 2\Community\community\community\Views\Home\MessageSent.cshtml"
                             Write(Model.to.name);

#line default
#line hidden
            EndContext();
            BeginContext(166, 5, true);
            WriteLiteral(" &lt;");
            EndContext();
            BeginContext(172, 21, false);
#line 7 "C:\Users\Rob\Documents\CIS295\CS295-ASP\Week 2\Community\community\community\Views\Home\MessageSent.cshtml"
                                                Write(Model.to.emailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(193, 58, true);
            WriteLiteral("&gt;\r\n<br /><label>Message Contents</label>\r\n<br /><pre>\r\n");
            EndContext();
            BeginContext(252, 13, false);
#line 10 "C:\Users\Rob\Documents\CIS295\CS295-ASP\Week 2\Community\community\community\Views\Home\MessageSent.cshtml"
Write(Model.message);

#line default
#line hidden
            EndContext();
            BeginContext(265, 8, true);
            WriteLiteral("\r\n</pre>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MessageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
