#pragma checksum "D:\sehetak\sehetak\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d69645684d82fb2584456c89060577d860f2233"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Details.cshtml", typeof(AspNetCore.Views_Users_Details))]
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
#line 1 "D:\sehetak\sehetak\Views\_ViewImports.cshtml"
using sehetak;

#line default
#line hidden
#line 2 "D:\sehetak\sehetak\Views\_ViewImports.cshtml"
using sehetak.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d69645684d82fb2584456c89060577d860f2233", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9fe64b0e4f21391e0ab1aa40127b0ca25730df6", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sehetak.Models.Users>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(74, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Users</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(194, 48, false);
#line 14 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Userpassword));

#line default
#line hidden
            EndContext();
            BeginContext(242, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(286, 44, false);
#line 17 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.Userpassword));

#line default
#line hidden
            EndContext();
            BeginContext(330, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(374, 44, false);
#line 20 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Usercode));

#line default
#line hidden
            EndContext();
            BeginContext(418, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(462, 40, false);
#line 23 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.Usercode));

#line default
#line hidden
            EndContext();
            BeginContext(502, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(546, 45, false);
#line 26 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Usergroup));

#line default
#line hidden
            EndContext();
            BeginContext(591, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(635, 41, false);
#line 29 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.Usergroup));

#line default
#line hidden
            EndContext();
            BeginContext(676, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(720, 45, false);
#line 32 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Userentry));

#line default
#line hidden
            EndContext();
            BeginContext(765, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(809, 41, false);
#line 35 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.Userentry));

#line default
#line hidden
            EndContext();
            BeginContext(850, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(894, 46, false);
#line 38 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserNomore));

#line default
#line hidden
            EndContext();
            BeginContext(940, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(984, 42, false);
#line 41 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserNomore));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1070, 48, false);
#line 44 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Userlanguage));

#line default
#line hidden
            EndContext();
            BeginContext(1118, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1162, 44, false);
#line 47 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.Userlanguage));

#line default
#line hidden
            EndContext();
            BeginContext(1206, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1250, 51, false);
#line 50 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ModifLastupdate));

#line default
#line hidden
            EndContext();
            BeginContext(1301, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1345, 47, false);
#line 53 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.ModifLastupdate));

#line default
#line hidden
            EndContext();
            BeginContext(1392, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1436, 44, false);
#line 56 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mitemsys));

#line default
#line hidden
            EndContext();
            BeginContext(1480, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1524, 40, false);
#line 59 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mitemsys));

#line default
#line hidden
            EndContext();
            BeginContext(1564, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1608, 46, false);
#line 62 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Branchcode));

#line default
#line hidden
            EndContext();
            BeginContext(1654, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1698, 42, false);
#line 65 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.Branchcode));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1784, 44, false);
#line 68 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Userdate));

#line default
#line hidden
            EndContext();
            BeginContext(1828, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1872, 40, false);
#line 71 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.Userdate));

#line default
#line hidden
            EndContext();
            BeginContext(1912, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1956, 42, false);
#line 74 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Userno));

#line default
#line hidden
            EndContext();
            BeginContext(1998, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2042, 38, false);
#line 77 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.Userno));

#line default
#line hidden
            EndContext();
            BeginContext(2080, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2124, 45, false);
#line 80 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Storecode));

#line default
#line hidden
            EndContext();
            BeginContext(2169, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2213, 41, false);
#line 83 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.Storecode));

#line default
#line hidden
            EndContext();
            BeginContext(2254, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2298, 45, false);
#line 86 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Entryuser));

#line default
#line hidden
            EndContext();
            BeginContext(2343, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2387, 41, false);
#line 89 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.Entryuser));

#line default
#line hidden
            EndContext();
            BeginContext(2428, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2475, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcc5b2fde6b94b4783aaea11643ddd62", async() => {
                BeginContext(2525, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 94 "D:\sehetak\sehetak\Views\Users\Details.cshtml"
                           WriteLiteral(Model.Userid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2533, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2541, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87fbc9377ab64f5797a9390cf05525cc", async() => {
                BeginContext(2563, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2579, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sehetak.Models.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591
