#pragma checksum "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba88b40dae388bc34a30e96758ba1cd2bdd51990"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\_ViewImports.cshtml"
using community;

#line default
#line hidden
#line 2 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\_ViewImports.cshtml"
using community.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba88b40dae388bc34a30e96758ba1cd2bdd51990", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16075df28e6dd41b65c08800e0925befb2c48920", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 17, true);
            WriteLiteral("<!DOCTYPE html>\r\n");
            EndContext();
            BeginContext(17, 242, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "123d65ce6d1141c497da77576e85743f", async() => {
                BeginContext(23, 46, true);
                WriteLiteral("\r\n    <title>CIT Lab Information</title>\r\n    ");
                EndContext();
                BeginContext(69, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cbf1538391d14c02829193d8cda673f6", async() => {
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
                EndContext();
                BeginContext(115, 137, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/lib/bootstrap/dist/css/bootstrap.css\" />\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n");
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
            BeginContext(259, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(261, 1624, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0619cb615d54e45b6e2a77339b6fc06", async() => {
                BeginContext(267, 207, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <nav class=\"navbar navbar-default\">\r\n            <div class=\"container-fluid\">\r\n                <div class=\"navbar-header\">\r\n                    <a class=\"navbar-brand\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 474, "\"", 508, 1);
#line 13 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 481, Url.Action("Index","Home"), 481, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(509, 208, true);
                WriteLiteral(">CIT Lab Information</a>\r\n                </div>\r\n                <ul class=\"nav navbar-nav\">\r\n                    <div class=\"btn-group mr-2\" role=\"group\" aria-label=\"Links\">\r\n                        <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 717, "\"", 770, 3);
                WriteAttributeValue("", 727, "location.href=\'", 727, 15, true);
#line 17 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 742, Url.Action("Index","Home"), 742, 27, false);

#line default
#line hidden
                WriteAttributeValue("", 769, "\'", 769, 1, true);
                EndWriteAttribute();
                BeginContext(771, 71, true);
                WriteLiteral(" class=\"btn btn-success\">Home</button>\r\n                        <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 842, "\"", 897, 3);
                WriteAttributeValue("", 852, "location.href=\'", 852, 15, true);
#line 18 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 867, Url.Action("History","Home"), 867, 29, false);

#line default
#line hidden
                WriteAttributeValue("", 896, "\'", 896, 1, true);
                EndWriteAttribute();
                BeginContext(898, 74, true);
                WriteLiteral(" class=\"btn btn-success\">History</button>\r\n                        <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 972, "\"", 1027, 3);
                WriteAttributeValue("", 982, "location.href=\'", 982, 15, true);
#line 19 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 997, Url.Action("Contact","Home"), 997, 29, false);

#line default
#line hidden
                WriteAttributeValue("", 1026, "\'", 1026, 1, true);
                EndWriteAttribute();
                BeginContext(1028, 74, true);
                WriteLiteral(" class=\"btn btn-success\">Contact</button>\r\n                        <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1102, "\"", 1155, 3);
                WriteAttributeValue("", 1112, "location.href=\'", 1112, 15, true);
#line 20 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1127, Url.Action("Index","Info"), 1127, 27, false);

#line default
#line hidden
                WriteAttributeValue("", 1154, "\'", 1154, 1, true);
                EndWriteAttribute();
                BeginContext(1156, 71, true);
                WriteLiteral(" class=\"btn btn-success\">Info</button>\r\n                        <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1227, "\"", 1284, 3);
                WriteAttributeValue("", 1237, "location.href=\'", 1237, 15, true);
#line 21 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1252, Url.Action("Locations","Info"), 1252, 31, false);

#line default
#line hidden
                WriteAttributeValue("", 1283, "\'", 1283, 1, true);
                EndWriteAttribute();
                BeginContext(1285, 76, true);
                WriteLiteral(" class=\"btn btn-success\">Locations</button>\r\n                        <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1361, "\"", 1415, 3);
                WriteAttributeValue("", 1371, "location.href=\'", 1371, 15, true);
#line 22 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1386, Url.Action("People","Info"), 1386, 28, false);

#line default
#line hidden
                WriteAttributeValue("", 1414, "\'", 1414, 1, true);
                EndWriteAttribute();
                BeginContext(1416, 183, true);
                WriteLiteral(" class=\"btn btn-success\">People</button>\r\n                    </div>\r\n                    <div class=\"btn-group mr-2\" role=\"group\" aria-label=\"Tools\">\r\n                        <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1599, "\"", 1655, 3);
                WriteAttributeValue("", 1609, "location.href=\'", 1609, 15, true);
#line 25 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1624, Url.Action("Messages","Home"), 1624, 30, false);

#line default
#line hidden
                WriteAttributeValue("", 1654, "\'", 1654, 1, true);
                EndWriteAttribute();
                BeginContext(1656, 178, true);
                WriteLiteral(" class=\"btn btn-primary\">Messages</button>\r\n                    </div>\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n\r\n        <div class=\"jumbotron\">\r\n            ");
                EndContext();
                BeginContext(1835, 12, false);
#line 32 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1847, 31, true);
                WriteLiteral("\r\n         </div>\r\n    </div>\r\n");
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
            BeginContext(1885, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
