#pragma checksum "C:\Users\Rob\Documents\CIS295\CS295-ASP\Week 1\Part 2\community\community\Views\Info\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db5ec376b99edb214760a0f9b812e499bb55bfe0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Info_Index), @"mvc.1.0.view", @"/Views/Info/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Info/Index.cshtml", typeof(AspNetCore.Views_Info_Index))]
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
#line 1 "C:\Users\Rob\Documents\CIS295\CS295-ASP\Week 1\Part 2\community\community\Views\_ViewImports.cshtml"
using community;

#line default
#line hidden
#line 2 "C:\Users\Rob\Documents\CIS295\CS295-ASP\Week 1\Part 2\community\community\Views\_ViewImports.cshtml"
using community.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db5ec376b99edb214760a0f9b812e499bb55bfe0", @"/Views/Info/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16075df28e6dd41b65c08800e0925befb2c48920", @"/Views/_ViewImports.cshtml")]
    public class Views_Info_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Rob\Documents\CIS295\CS295-ASP\Week 1\Part 2\community\community\Views\Info\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#line 4 "C:\Users\Rob\Documents\CIS295\CS295-ASP\Week 1\Part 2\community\community\Views\Info\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(72, 17, true);
            WriteLiteral("<!DOCTYPE html>\r\n");
            EndContext();
            BeginContext(89, 190, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63aabdb72a4d4bbaa12513bfc44da3de", async() => {
                BeginContext(95, 177, true);
                WriteLiteral("\r\n    <title>CIT Lab Information</title>\r\n    <link rel=\"stylesheet\" href=\"/lib/bootstrap/dist/css/bootstrap.css\" />\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(279, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(281, 974, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bc72a8432e54f93bf343d6ba2774bc7", async() => {
                BeginContext(287, 207, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <nav class=\"navbar navbar-default\">\r\n            <div class=\"container-fluid\">\r\n                <div class=\"navbar-header\">\r\n                    <a class=\"navbar-brand\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 494, "\"", 525, 1);
#line 18 "C:\Users\Rob\Documents\CIS295\CS295-ASP\Week 1\Part 2\community\community\Views\Info\Index.cshtml"
WriteAttributeValue("", 501, Url.Action("Index","/"), 501, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(526, 121, true);
                WriteLiteral(">CIT Lab Information</a>\r\n                </div>\r\n                <ul class=\"nav navbar-nav\">\r\n                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 647, "\"", 678, 1);
#line 21 "C:\Users\Rob\Documents\CIS295\CS295-ASP\Week 1\Part 2\community\community\Views\Info\Index.cshtml"
WriteAttributeValue("", 654, Url.Action("Index","/"), 654, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(679, 42, true);
                WriteLiteral(">Home</a></li>\r\n                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 721, "\"", 758, 1);
#line 22 "C:\Users\Rob\Documents\CIS295\CS295-ASP\Week 1\Part 2\community\community\Views\Info\Index.cshtml"
WriteAttributeValue("", 728, Url.Action("Index","History"), 728, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(759, 45, true);
                WriteLiteral(">History</a></li>\r\n                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 804, "\"", 841, 1);
#line 23 "C:\Users\Rob\Documents\CIS295\CS295-ASP\Week 1\Part 2\community\community\Views\Info\Index.cshtml"
WriteAttributeValue("", 811, Url.Action("Index","Contact"), 811, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(842, 60, true);
                WriteLiteral(">Contact</a></li>\r\n                    <li class=\"active\"><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 902, "\"", 936, 1);
#line 24 "C:\Users\Rob\Documents\CIS295\CS295-ASP\Week 1\Part 2\community\community\Views\Info\Index.cshtml"
WriteAttributeValue("", 909, Url.Action("Index","Info"), 909, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(937, 311, true);
                WriteLiteral(@">Info</a></li>
                </ul>
            </div>
        </nav>

        <div class=""jumbotron"">
            <h1>CIT Lab Information</h1>
            <p>
                A common information portal for the CIT Lab.
            </p>
        </div>
        <p></p>
        <p></p>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1255, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
