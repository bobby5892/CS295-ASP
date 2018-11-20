#pragma checksum "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23d5746cd6046549e7c9d11df79b79588a94a96e"
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
#line 1 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\_ViewImports.cshtml"
using community;

#line default
#line hidden
#line 2 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\_ViewImports.cshtml"
using community.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23d5746cd6046549e7c9d11df79b79588a94a96e", @"/Views/Home/Messages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16075df28e6dd41b65c08800e0925befb2c48920", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Messages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MessageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Messages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/messages.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
  

    ViewData["Title"] = "List Messages";
    Layout = "/views/shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(124, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 10 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
   /*
   This is the main content of the page
   Message Viewing should be moved into a component to keep DRY
  */

#line default
#line hidden
            BeginContext(248, 582, true);
            WriteLiteral(@"
<ul class=""nav nav-tabs"">
    <li id=""TabIncoming""><a href=""#"" id=""btnIncoming"">Incoming</a></li>
    <li id=""TabSent""><a href=""#"" id=""btnSent"">Sent</a></li>
    <li id=""TabCompose""><a href=""#"" id=""btnCompose"">Compose</a></li>
    <li id=""TabCompose""><a href=""/Home/ManageContacts"" id=""btnCompose"">Contacts</a></li>
</ul>

<div class=""well"" id=""incomingMessages"">
    <h3>Incoming Messages</h3>
    <table>
        <tr>
            <td class=""header"">From</td>
            <td class=""header"">Timestamp</td>
            <td class=""header"">Message</td>
        </tr>
");
            EndContext();
#line 30 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
         foreach (var item in Model.MessagesIncoming)
        {
        // Add Flag for Priority (should be converted to a View Component to keep DRY)
        string priorityCSS = "";
        if (item.IsPriority) { priorityCSS = " priority"; }


#line default
#line hidden
            BeginContext(1081, 11, true);
            WriteLiteral("        <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1092, "\"", 1124, 2);
            WriteAttributeValue("", 1100, "message-row", 1100, 11, true);
#line 36 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
WriteAttributeValue(" ", 1111, priorityCSS, 1112, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1125, 59, true);
            WriteLiteral(">\r\n            <td class=\"contact-data \">\r\n                ");
            EndContext();
            BeginContext(1185, 14, false);
#line 38 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
           Write(item.From.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1199, 5, true);
            WriteLiteral(" &lt;");
            EndContext();
            BeginContext(1205, 22, false);
#line 38 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
                               Write(item.From.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1227, 62, true);
            WriteLiteral("&gt;\r\n            </td>\r\n            <td class=\"contact-data\">");
            EndContext();
            BeginContext(1290, 14, false);
#line 40 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
                                Write(item.Timestamp);

#line default
#line hidden
            EndContext();
            BeginContext(1304, 44, true);
            WriteLiteral("</td>\r\n            <td class=\"message-data\">");
            EndContext();
            BeginContext(1349, 9, false);
#line 41 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
                                Write(item.Msge);

#line default
#line hidden
            EndContext();
            BeginContext(1358, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 43 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
        }

#line default
#line hidden
            BeginContext(1391, 272, true);
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
#line 55 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
         foreach (var item in Model.MessagesOutgoing)
        {

        string priorityCSS = "";
        if (item.IsPriority) { priorityCSS = " priority"; }


#line default
#line hidden
            BeginContext(1828, 11, true);
            WriteLiteral("        <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1839, "\"", 1871, 2);
            WriteAttributeValue("", 1847, "message-row", 1847, 11, true);
#line 61 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
WriteAttributeValue(" ", 1858, priorityCSS, 1859, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1872, 40, true);
            WriteLiteral(">\r\n            <td class=\"contact-data\">");
            EndContext();
            BeginContext(1913, 12, false);
#line 62 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
                                Write(item.To.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1925, 5, true);
            WriteLiteral(" &lt;");
            EndContext();
            BeginContext(1931, 20, false);
#line 62 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
                                                  Write(item.To.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1951, 48, true);
            WriteLiteral("&gt;</td>\r\n            <td class=\"contact-data\">");
            EndContext();
            BeginContext(2000, 14, false);
#line 63 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
                                Write(item.Timestamp);

#line default
#line hidden
            EndContext();
            BeginContext(2014, 44, true);
            WriteLiteral("</td>\r\n            <td class=\"message-data\">");
            EndContext();
            BeginContext(2059, 9, false);
#line 64 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
                                Write(item.Msge);

#line default
#line hidden
            EndContext();
            BeginContext(2068, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 66 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
        }

#line default
#line hidden
            BeginContext(2101, 143, true);
            WriteLiteral("\r\n    </table>\r\n</div>\r\n<div class=\"well\" id=\"composeMessage\">\r\n    <div class=\"container-fluid\">\r\n        <h3>Compose Message</h3>\r\n\r\n        ");
            EndContext();
            BeginContext(2244, 1137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89f760807dab42cf83f7dfa758f1ca5b", async() => {
                BeginContext(2308, 54, true);
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"emailAddress\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2362, "\"", 2401, 1);
#line 75 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
WriteAttributeValue("", 2370, Model.CurrentUser.EmailAddress, 2370, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2402, 126, true);
                WriteLiteral(" />\r\n            <div class=\"row col-lg-10\">\r\n                <label for=\"to\">To</label>\r\n                <select name=\"to\">\r\n");
                EndContext();
#line 79 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
                     foreach (User user in Model.Users)
                    {

#line default
#line hidden
                BeginContext(2608, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(2628, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "718ebbc0286b418db39753f20463c1b4", async() => {
                    BeginContext(2656, 9, false);
#line 81 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
                                          Write(user.Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(2665, 4, true);
                    WriteLiteral("&lt;");
                    EndContext();
                    BeginContext(2670, 17, false);
#line 81 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
                                                        Write(user.EmailAddress);

#line default
#line hidden
                    EndContext();
                    BeginContext(2687, 5, true);
                    WriteLiteral("&gt; ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 81 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
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
                BeginContext(2701, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 82 "C:\code\CS295-ASP\Week 8\Community\Community\community\Views\Home\Messages.cshtml"
                    }

#line default
#line hidden
                BeginContext(2726, 648, true);
                WriteLiteral(@"                </select>
                Priority<input type=""checkbox"" name=""isPriority"" value=""true"" />
            </div>
            <div class=""row col-lg-10"">
                <label for=""subject"">Subject</label>
                <br /><input type=""text"" name=""Subject"" class=""col-lg-10"">

            </div>

            <div class=""row col-lg-10"">
                <label for=""message"">Message</label>
                <br /><textarea name=""message"" class=""col-lg-10""></textarea>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3381, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(3391, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f015cdc882db464bad6b3042a7899d2b", async() => {
                BeginContext(3452, 71, true);
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Go Back To Home\" />\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3530, 24, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
            EndContext();
            BeginContext(3554, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43223455261048d4a132735a64687627", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
