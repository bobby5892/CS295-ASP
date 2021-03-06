#pragma checksum "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf18b77a24762c374441189b4ca9e1ef32f74935"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Messages), @"mvc.1.0.view", @"/Views/Home/Messages.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Messages.cshtml", typeof(AspNetCore.Views_Home_Messages))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf18b77a24762c374441189b4ca9e1ef32f74935", @"/Views/Home/Messages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16075df28e6dd41b65c08800e0925befb2c48920", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Messages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MessageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/messages.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
  

    ViewData["Title"] = "List Messages";
    Layout = "/views/shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(124, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 10 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
   /*
                   This is the main content of the page
                   Message Viewing should be moved into a component to keep DRY
                  */

#line default
#line hidden
            BeginContext(296, 527, true);
            WriteLiteral(@"
<ul class=""nav nav-tabs"">
    <li id=""TabIncoming""><a href=""#"" id=""btnIncoming"">Incoming</a></li>
    <li id=""TabSent""><a href=""#"" id=""btnSent"">Sent</a></li>
    <li id=""TabCompose""><a href=""#"" id=""btnCompose"">Compose</a></li>
</ul>

<div class=""well"" id=""incomingMessages"">
    <h3>Incoming Messages</h3>
    <table>
        <tr>
            <td></td>
            <td class=""header"">From</td>
            <td class=""header"">Timestamp</td>
            <td class=""header"" colspan=""2"">Message</td>
        </tr>
");
            EndContext();
#line 30 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
          int count = 0;

#line default
#line hidden
            BeginContext(850, 16, true);
            WriteLiteral("        &nbsp;\r\n");
            EndContext();
#line 32 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
             foreach (var item in Model.MessagesIncoming)
            {
                // Add Flag for Priority (should be converted to a View Component to keep DRY)
                string priorityCSS = "";
                if (item.IsPriority) { priorityCSS = " priority"; }


#line default
#line hidden
            BeginContext(1149, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1164, "\"", 1196, 2);
            WriteAttributeValue("", 1172, "message-row", 1172, 11, true);
#line 38 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
WriteAttributeValue(" ", 1183, priorityCSS, 1184, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1197, 63, true);
            WriteLiteral(">\r\n                <td><button class=\"reply-button\" data-name=\"");
            EndContext();
            BeginContext(1261, 14, false);
#line 39 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
                                                       Write(item.From.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1275, 13, true);
            WriteLiteral("\" data-from=\"");
            EndContext();
            BeginContext(1289, 5, false);
#line 39 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
                                                                                   Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1294, 16, true);
            WriteLiteral("\" data-subject=\"");
            EndContext();
            BeginContext(1311, 12, false);
#line 39 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
                                                                                                         Write(item.Subject);

#line default
#line hidden
            EndContext();
            BeginContext(1323, 16, true);
            WriteLiteral("\" data-message=\"");
            EndContext();
            BeginContext(1340, 9, false);
#line 39 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
                                                                                                                                      Write(item.Msge);

#line default
#line hidden
            EndContext();
            BeginContext(1349, 119, true);
            WriteLiteral("\" onclick=\"messages.reply(this);\">Reply</button> </td>\r\n                <td class=\"contact-data\">\r\n                    ");
            EndContext();
            BeginContext(1469, 14, false);
#line 41 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
               Write(item.From.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1483, 5, true);
            WriteLiteral(" &lt;");
            EndContext();
            BeginContext(1489, 22, false);
#line 41 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
                                   Write(item.From.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1511, 70, true);
            WriteLiteral("&gt;\r\n                </td>\r\n                <td class=\"contact-data\">");
            EndContext();
            BeginContext(1582, 14, false);
#line 43 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
                                    Write(item.Timestamp);

#line default
#line hidden
            EndContext();
            BeginContext(1596, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1624, 12, false);
#line 44 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
               Write(item.Subject);

#line default
#line hidden
            EndContext();
            BeginContext(1636, 48, true);
            WriteLiteral("</td>\r\n                <td class=\"message-data\">");
            EndContext();
            BeginContext(1685, 9, false);
#line 45 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
                                    Write(item.Msge);

#line default
#line hidden
            EndContext();
            BeginContext(1694, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 47 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
            count++;
        }

#line default
#line hidden
            BeginContext(1753, 272, true);
            WriteLiteral(@"
    </table>
</div>
<div class=""well"" id=""outgoingMessages"">
    <h3>Outgoing Messages</h3>
    <table>
        <tr>
            <td class=""header"">To</td>
            <td class=""header"">Timestamp</td>
            <td class=""header"">Message</td>
        </tr>
");
            EndContext();
#line 60 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
         foreach (var item in Model.MessagesOutgoing)
        {

            string priorityCSS = "";
            if (item.IsPriority) { priorityCSS = " priority"; }


#line default
#line hidden
            BeginContext(2198, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2213, "\"", 2245, 2);
            WriteAttributeValue("", 2221, "message-row", 2221, 11, true);
#line 66 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
WriteAttributeValue(" ", 2232, priorityCSS, 2233, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2246, 44, true);
            WriteLiteral(">\r\n                <td class=\"contact-data\">");
            EndContext();
            BeginContext(2291, 12, false);
#line 67 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
                                    Write(item.To.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2303, 5, true);
            WriteLiteral(" &lt;");
            EndContext();
            BeginContext(2309, 20, false);
#line 67 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
                                                      Write(item.To.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(2329, 52, true);
            WriteLiteral("&gt;</td>\r\n                <td class=\"contact-data\">");
            EndContext();
            BeginContext(2382, 14, false);
#line 68 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
                                    Write(item.Timestamp);

#line default
#line hidden
            EndContext();
            BeginContext(2396, 48, true);
            WriteLiteral("</td>\r\n                <td class=\"message-data\">");
            EndContext();
            BeginContext(2445, 9, false);
#line 69 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
                                    Write(item.Msge);

#line default
#line hidden
            EndContext();
            BeginContext(2454, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 71 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
        }

#line default
#line hidden
            BeginContext(2491, 141, true);
            WriteLiteral("\r\n    </table>\r\n</div>\r\n<div class=\"well\" id=\"composeMessage\">\r\n    <div class=\"container-fluid\">\r\n        <h3>Compose Message</h3>\r\n        ");
            EndContext();
            BeginContext(2632, 1172, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de76990ae45d420e9ec6f5dce7889450", async() => {
                BeginContext(2652, 54, true);
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"emailAddress\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2706, "\"", 2745, 1);
#line 79 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
WriteAttributeValue("", 2714, Model.CurrentUser.EmailAddress, 2714, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2746, 141, true);
                WriteLiteral(" />\r\n            <div class=\"row col-lg-10\">\r\n                <label for=\"to\">To</label>\r\n                <select name=\"to\" id=\"composeTo\">\r\n");
                EndContext();
#line 83 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
                     foreach (User user in Model.Users)
                    {

#line default
#line hidden
                BeginContext(2967, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(2991, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83c49e26c35d48dfab61f6656795d386", async() => {
                    BeginContext(3019, 9, false);
#line 85 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
                                              Write(user.Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(3028, 4, true);
                    WriteLiteral("&lt;");
                    EndContext();
                    BeginContext(3033, 17, false);
#line 85 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
                                                            Write(user.EmailAddress);

#line default
#line hidden
                    EndContext();
                    BeginContext(3050, 5, true);
                    WriteLiteral("&gt; ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 85 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
                           WriteLiteral(user.Name);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3064, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 86 "C:\code\CS295-ASP\Week 3\Community\Community\community\community\Views\Home\Messages.cshtml"
                    }

#line default
#line hidden
                BeginContext(3089, 708, true);
                WriteLiteral(@"                </select>
                Priority<input type=""checkbox"" name=""isPriority"" value=""true"" />
            </div>
            <div class=""row col-lg-10"">
                <label for=""subject"">Subject</label>
                <br /><input type=""text""name=""Subject"" id=""composeSubject""class=""col-lg-10"">

            </div>

            <div class=""row col-lg-10"">
                <label for=""message"">Message</label>
                <br />
                <textarea  name=""message"" class=""col-lg-10"" style=""height:300px;"" ></textarea>
            </div>
            <div class=""row col-lg-10"">
                <input type=""submit"" value=""send message"" />
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3804, 24, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
            EndContext();
            BeginContext(3828, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dd4bb6c25e145fab801c7f68a853324", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MessageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
