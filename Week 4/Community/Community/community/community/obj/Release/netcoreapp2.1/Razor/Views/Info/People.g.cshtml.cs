#pragma checksum "C:\Users\Rob\Documents\CS295\CS295-ASP\Week 4\Community\Community\community\community\Views\Info\People.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e57cf0df32b28513c4d745635d7925069bb54756"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Info_People), @"mvc.1.0.view", @"/Views/Info/People.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Info/People.cshtml", typeof(AspNetCore.Views_Info_People))]
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
#line 1 "C:\Users\Rob\Documents\CS295\CS295-ASP\Week 4\Community\Community\community\community\Views\_ViewImports.cshtml"
using community;

#line default
#line hidden
#line 2 "C:\Users\Rob\Documents\CS295\CS295-ASP\Week 4\Community\Community\community\community\Views\_ViewImports.cshtml"
using community.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e57cf0df32b28513c4d745635d7925069bb54756", @"/Views/Info/People.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16075df28e6dd41b65c08800e0925befb2c48920", @"/Views/_ViewImports.cshtml")]
    public class Views_Info_People : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Rob\Documents\CS295\CS295-ASP\Week 4\Community\Community\community\community\Views\Info\People.cshtml"
  
    ViewData["Title"] = "People - Via Layout 2";
    Layout = "/views/shared/_Layout2.cshtml";

#line default
#line hidden
            BeginContext(129, 10, true);
            WriteLiteral("People\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Rob\Documents\CS295\CS295-ASP\Week 4\Community\Community\community\community\Views\Info\People.cshtml"
 foreach (Person person in Model.Persons)
{

#line default
#line hidden
            BeginContext(185, 12, true);
            WriteLiteral("    <br /><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 197, "\"", 216, 1);
#line 10 "C:\Users\Rob\Documents\CS295\CS295-ASP\Week 4\Community\Community\community\community\Views\Info\People.cshtml"
WriteAttributeValue("", 204, person.Link, 204, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(217, 14, true);
            WriteLiteral(" target=\"new\">");
            EndContext();
            BeginContext(232, 11, false);
#line 10 "C:\Users\Rob\Documents\CS295\CS295-ASP\Week 4\Community\Community\community\community\Views\Info\People.cshtml"
                                         Write(person.Name);

#line default
#line hidden
            EndContext();
            BeginContext(243, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 11 "C:\Users\Rob\Documents\CS295\CS295-ASP\Week 4\Community\Community\community\community\Views\Info\People.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
