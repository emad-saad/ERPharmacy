#pragma checksum "D:\sehetak\sehetak\Views\Users\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e15ec050833e93014bae4412f39b09309b9bdf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Delete), @"mvc.1.0.view", @"/Views/Users/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Delete.cshtml", typeof(AspNetCore.Views_Users_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e15ec050833e93014bae4412f39b09309b9bdf9", @"/Views/Users/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9fe64b0e4f21391e0ab1aa40127b0ca25730df6", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sehetak.Models.Users>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(73, 166, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Users</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(240, 48, false);
#line 15 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Userpassword));

#line default
#line hidden
            EndContext();
            BeginContext(288, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(332, 44, false);
#line 18 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Userpassword));

#line default
#line hidden
            EndContext();
            BeginContext(376, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(420, 44, false);
#line 21 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Usercode));

#line default
#line hidden
            EndContext();
            BeginContext(464, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(508, 40, false);
#line 24 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Usercode));

#line default
#line hidden
            EndContext();
            BeginContext(548, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(592, 45, false);
#line 27 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Usergroup));

#line default
#line hidden
            EndContext();
            BeginContext(637, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(681, 41, false);
#line 30 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Usergroup));

#line default
#line hidden
            EndContext();
            BeginContext(722, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(766, 45, false);
#line 33 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Userentry));

#line default
#line hidden
            EndContext();
            BeginContext(811, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(855, 41, false);
#line 36 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Userentry));

#line default
#line hidden
            EndContext();
            BeginContext(896, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(940, 46, false);
#line 39 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UserNomore));

#line default
#line hidden
            EndContext();
            BeginContext(986, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1030, 42, false);
#line 42 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UserNomore));

#line default
#line hidden
            EndContext();
            BeginContext(1072, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1116, 48, false);
#line 45 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Userlanguage));

#line default
#line hidden
            EndContext();
            BeginContext(1164, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1208, 44, false);
#line 48 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Userlanguage));

#line default
#line hidden
            EndContext();
            BeginContext(1252, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1296, 51, false);
#line 51 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ModifLastupdate));

#line default
#line hidden
            EndContext();
            BeginContext(1347, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1391, 47, false);
#line 54 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ModifLastupdate));

#line default
#line hidden
            EndContext();
            BeginContext(1438, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1482, 44, false);
#line 57 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mitemsys));

#line default
#line hidden
            EndContext();
            BeginContext(1526, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1570, 40, false);
#line 60 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mitemsys));

#line default
#line hidden
            EndContext();
            BeginContext(1610, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1654, 46, false);
#line 63 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Branchcode));

#line default
#line hidden
            EndContext();
            BeginContext(1700, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1744, 42, false);
#line 66 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Branchcode));

#line default
#line hidden
            EndContext();
            BeginContext(1786, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1830, 44, false);
#line 69 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Userdate));

#line default
#line hidden
            EndContext();
            BeginContext(1874, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1918, 40, false);
#line 72 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Userdate));

#line default
#line hidden
            EndContext();
            BeginContext(1958, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2002, 42, false);
#line 75 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Userno));

#line default
#line hidden
            EndContext();
            BeginContext(2044, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2088, 38, false);
#line 78 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Userno));

#line default
#line hidden
            EndContext();
            BeginContext(2126, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2170, 45, false);
#line 81 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Storecode));

#line default
#line hidden
            EndContext();
            BeginContext(2215, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2259, 41, false);
#line 84 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Storecode));

#line default
#line hidden
            EndContext();
            BeginContext(2300, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2344, 45, false);
#line 87 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Entryuser));

#line default
#line hidden
            EndContext();
            BeginContext(2389, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2433, 41, false);
#line 90 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Entryuser));

#line default
#line hidden
            EndContext();
            BeginContext(2474, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2512, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41c87ee2a0ef4c6f9c59a51ddc7f89df", async() => {
                BeginContext(2538, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2548, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e7754fa90a0e417b90d75506d7d1a9a9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 95 "D:\sehetak\sehetak\Views\Users\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Userid);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2588, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2672, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4738af98efe44220afb642e30f27fdc0", async() => {
                    BeginContext(2694, 12, true);
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
                BeginContext(2710, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            BeginContext(2723, 10, true);
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
