#pragma checksum "D:\sehetak\sehetak\Views\Home\ItemCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d3415c16c21037122cf948f70c06dbf28ce2e87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ItemCard), @"mvc.1.0.view", @"/Views/Home/ItemCard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ItemCard.cshtml", typeof(AspNetCore.Views_Home_ItemCard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d3415c16c21037122cf948f70c06dbf28ce2e87", @"/Views/Home/ItemCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9fe64b0e4f21391e0ab1aa40127b0ca25730df6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ItemCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sehetak.Models.CustomClasses.mainModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InsertItemCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\sehetak\sehetak\Views\Home\ItemCard.cshtml"
  
    ViewData["Title"] = "ItemCard";
    Layout = "~/Views/Shared/BodyContent.cshtml";

#line default
#line hidden
            BeginContext(142, 263, true);
            WriteLiteral(@"<style>
    .table td, .table th {
        border-top:none;
       text-align:right;
    }
   
   
</style>

    <h4 style=""text-align:center ;background-color:gray;font-size:18px;color:white;border-style:ridge;border-radius:5px;"">إضافة صنف جديد</h4>

");
            EndContext();
            BeginContext(405, 6887, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e0353bc593a40ed90e0ca4340dcc7fd", async() => {
                BeginContext(461, 711, true);
                WriteLiteral(@"
    
        <table class=""table table-responsive table-dark""  dir=""rtl"">

            <tbody>
                <tr>

                    <td>كود 1<input type=""text"" required name=""Code1"" class=""form-control""/></td>
                    <td>كود 2 <input type=""text"" name=""code2"" class=""form-control""/></td>
                
                </tr>
                <tr>

                    <td>اسم الصنف عربى<input type=""text"" required name=""itemarabicname"" class=""form-control""/></td>
                    <td> اسم الصنف بالانجليزية<input type=""text"" required name=""itemenglishname"" class=""form-control""/></td>

                </tr>
                <tr>

                    <td>الشركة المنتجة ");
                EndContext();
                BeginContext(1173, 158, false);
#line 36 "D:\sehetak\sehetak\Views\Home\ItemCard.cshtml"
                                  Write(Html.DropDownListFor(m => m.Itemproducername, (IEnumerable<SelectListItem>)ViewBag.items, "--من فضلك اختر الشركة المنتجة --", new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1331, 1015, true);
                WriteLiteral(@"</td>
                    <td>الكود ف الشركة<input type=""text""  class=""form-control""/></td>
                    <td>صنف معتاد <input type=""checkbox""  class=""chBox"" name=""ItemOriginal""  /></td>
                </tr>
                <tr>
                    <td>دواء <input type=""checkbox""  class=""chBox"" name=""medicine"" /></td>
                    <td>له تاريخ صلاحية <input type=""checkbox""  class=""chBox"" name=""hasValidDate"" /></td>
                    <td>صنف ثلاجة <input type=""checkbox""  class=""chBox"" name=""FridgeItem"" /></td>
                
                </tr>
                <tr>
                    <td>صنف خدمة <input type=""checkbox""  class=""chBox"" name=""ItemService"" /></td>
                    <td>طباعة باركود <input type=""checkbox""  class=""chBox"" name=""printBarcode"" /></td>
                    <td>طباعة اسم الصنف <input type=""checkbox""  class=""chBox"" name=""printItemName"" /></td>
                 
                </tr>
                <tr>

                    <td>طبيعة الصنف ");
                EndContext();
                BeginContext(2347, 162, false);
#line 54 "D:\sehetak\sehetak\Views\Home\ItemCard.cshtml"
                               Write(Html.DropDownListFor(m => m.itemsclassifname, (IEnumerable<SelectListItem>)ViewBag.itemsclassif, "--من فضلك اختر طبيعة الصنف --", new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(2509, 296, true);
                WriteLiteral(@"</td>
                    <td>مكان الصنف <input type=""text"" name=""itemPlace"" class=""form-control""/></td>
                    <td> لا يرتجع شراء <input type=""checkbox""  class=""chBox"" name=""noReturnable"" /></td>
                </tr>
                <tr>

                    <td>منشأ الصنف  ");
                EndContext();
                BeginContext(2806, 157, false);
#line 60 "D:\sehetak\sehetak\Views\Home\ItemCard.cshtml"
                               Write(Html.DropDownListFor(m => m.itemsoriginname, (IEnumerable<SelectListItem>)ViewBag.itemsorig, "--من فضلك اختر منشأ الصنف --", new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(2963, 389, true);
                WriteLiteral(@"</td>
                    <td>فترة حساب متوسط البيع باالايام <input type=""text"" name=""itemPeriod"" class=""form-control""/></td>
                </tr>
                <tr>


                    <td>ملاحظات <input type=""text"" name=""notes"" class=""form-control""/></td>
                </tr>
                <tr>

                    <td>المجموعة العلمية <select name=""ScientificGroup"">");
                EndContext();
                BeginContext(3352, 17, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b7b42bd5b174a74bc7465e7484bb8e0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3369, 493, true);
                WriteLiteral(@"</select></td>
                    <td>الاسم العلمى <input type=""text"" class=""form-control""/></td>
                </tr>
                <tr>

                    <td> المادة الفعالة الاساسية<input type=""text"" name=""MaddaFaala"" class=""form-control""/></td>
                    <td>نسبة المادة الفعالة <input type=""text"" name=""madaaFaalaPercent""  class=""form-control""/></td>

                </tr>
                <tr>

                    <td>طريقة الاستخدام <select name=""UsageWay"">");
                EndContext();
                BeginContext(3862, 17, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "891aa45a11094152a23a12c97c743541", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3879, 1117, true);
                WriteLiteral(@"</select></td>


                </tr>
                <tr>
                    <td>وقف التعامل مع الصنف <input type=""checkbox""  class=""chBox"" name=""stopItemDeal"" /></td>
                    <td>ايقاف بيع الصنف <input type=""checkbox""  class=""chBox"" name=""stopItemSales"" /></td>
                    <td>ايقاف شراء الصنف <input type=""checkbox""  class=""chBox"" name=""stopItemBuy"" /></td>

                </tr>
                <tr>
                    <td>السماح بإجراء خصم <input type=""checkbox""  class=""chBox"" name=""permissionToDiscount"" /></td>
                    <td>اقصى خصم قيمة <input type=""text"" name=""MaxDiscountValue"" /></td>
                    <td>اقصى خصم نسبة <input type=""text"" name=""MaxDiscountPercent"" /> %</td>

                </tr>
                <tr>

                    <td>خصم لكل العملاء عند البيع <input type=""text"" name=""DiscountForAllCustomersValue"" class=""form-control""/> %</td>
                    <td>دواعى الاستخدام <input type=""text"" name=""UsageNeed"" class=""form-control""/><");
                WriteLiteral("/td>\r\n\r\n                </tr>\r\n                <tr>\r\n\r\n                    <td>الوحدة الكبرى ");
                EndContext();
                BeginContext(4997, 157, false);
#line 105 "D:\sehetak\sehetak\Views\Home\ItemCard.cshtml"
                                 Write(Html.DropDownListFor(m => m.itemsunitsname, (IEnumerable<SelectListItem>)ViewBag.itemsunits, "--من فضلك اختر وحدة الصنف --", new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(5154, 70, true);
                WriteLiteral("</td>\r\n                    <td>الوحدة الصغرى <select name=\"smallUnit\">");
                EndContext();
                BeginContext(5224, 17, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d5728287db74f41a4f86cfc1062fe53", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5241, 697, true);
                WriteLiteral(@"</select></td>
                    <td>عدد الوحدات <input type=""text"" name=""UnitsCount"" class=""form-control""/></td>

                </tr>
                <tr>
                    <td> الحدالاقصى<input type=""text"" name=""MaxLimit"" class=""form-control""/></td>
                    <td>الحد الادنى  <input type=""text"" name=""minLimit"" class=""form-control"" /></td>
                    <td>  حد الطلب  <input type=""text"" name=""LimitRequest"" class=""form-control""/></td>
                </tr>
                <tr>
                    <td>الكمية الافتراضية عند الشراء<input type=""text"" name=""virtualQtyOnBuy"" class=""form-control""/></td>
                    <td>وحدة الشراء <select name=""BuyUnit"">");
                EndContext();
                BeginContext(5938, 17, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16319c87c7ce4e21ad9f71384f2de952", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5955, 75, true);
                WriteLiteral("</select></td>\r\n                    <td>وحدة البيع <select name=\"SaleUnit\">");
                EndContext();
                BeginContext(6030, 17, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7734144ccf71497fb2475aa65fed5293", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6047, 1238, true);
                WriteLiteral(@"</select></td>
                </tr>
                <tr>
                    <td>صنف نواقص <input type=""checkbox""  class=""chBox"" name=""IsMinusItem"" /></td>
                    <td>صنف بيع كسور <input type=""checkbox""  class=""chBox"" name=""IsFractionItem"" /></td>


                </tr>
                <tr>
                    <td>سعر البيع <input type=""text"" name=""SalesPrice"" class=""form-control""/></td>
                    <td>الضريبة <input type=""text"" name=""Tax"" class=""form-control""/></td>
                    <td>نسبة الخصم <input type=""text"" name=""DiscountPercent"" class=""form-control""/></td>
                   
                </tr>
                <tr>
                    <td>فرق سعر بيع الوحدة المتوسطة <input type=""text"" name=""DiffPriceAvgSales"" class=""form-control""/></td>
                    <td>فرق سعر بيع الوحدة الصغرى <input type=""text"" name=""DiffPricesmSales"" class=""form-control""/></td>
                    <td> سعر الشراء <input type=""text"" name=""PurchasePrice"" class=""form-control""/>");
                WriteLiteral("</td>\r\n\r\n                </tr>\r\n                <tr>\r\n                    <td><button type=\"submit\" class=\"btn btn-primary\">حفظ</button></td>\r\n\r\n\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sehetak.Models.CustomClasses.mainModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
