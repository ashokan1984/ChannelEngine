#pragma checksum "C:\Users\U1213107\OneDrive - MMC\Desktop\ChannelEngineAssignment\ChannelEngineAssignment\ChannelEngineWeb\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd070870daabdfff2ed9deb6375cc1c08d805331"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\U1213107\OneDrive - MMC\Desktop\ChannelEngineAssignment\ChannelEngineAssignment\ChannelEngineWeb\Views\_ViewImports.cshtml"
using ChannelEngineWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\U1213107\OneDrive - MMC\Desktop\ChannelEngineAssignment\ChannelEngineAssignment\ChannelEngineWeb\Views\_ViewImports.cshtml"
using ChannelEngineWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd070870daabdfff2ed9deb6375cc1c08d805331", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73758d071213735f6b45f3064e7ab3995aa2ead6", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ChannelEngine.Models.ProductResponse>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateStock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\U1213107\OneDrive - MMC\Desktop\ChannelEngineAssignment\ChannelEngineAssignment\ChannelEngineWeb\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Products</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd070870daabdfff2ed9deb6375cc1c08d8053314598", async() => {
                WriteLiteral(@"
    <table id=""tblCEData"" class=""table"">
        <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Name</th>
                <th scope=""col"">GTIN</th>
                <th scope=""col"">TotalQuantity</th>
                <th scope=""col"">Merchant Product Number</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "C:\Users\U1213107\OneDrive - MMC\Desktop\ChannelEngineAssignment\ChannelEngineAssignment\ChannelEngineWeb\Views\Order\Index.cshtml"
                 for (int i = 0; i < Model.Count; i++)
                {


#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 25 "C:\Users\U1213107\OneDrive - MMC\Desktop\ChannelEngineAssignment\ChannelEngineAssignment\ChannelEngineWeb\Views\Order\Index.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <td");
                BeginWriteAttribute("id", " id=\"", 770, "\"", 810, 2);
                WriteAttributeValue("", 775, "td_Name_", 775, 8, true);
#nullable restore
#line 26 "C:\Users\U1213107\OneDrive - MMC\Desktop\ChannelEngineAssignment\ChannelEngineAssignment\ChannelEngineWeb\Views\Order\Index.cshtml"
WriteAttributeValue("", 783, Model[i].MerchantProductNo, 783, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 26 "C:\Users\U1213107\OneDrive - MMC\Desktop\ChannelEngineAssignment\ChannelEngineAssignment\ChannelEngineWeb\Views\Order\Index.cshtml"
                                                                Write(Html.DisplayFor(modelitem => Model[i].Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td");
                BeginWriteAttribute("id", " id=\"", 890, "\"", 917, 2);
                WriteAttributeValue("", 895, "td_GTIN_", 895, 8, true);
#nullable restore
#line 27 "C:\Users\U1213107\OneDrive - MMC\Desktop\ChannelEngineAssignment\ChannelEngineAssignment\ChannelEngineWeb\Views\Order\Index.cshtml"
WriteAttributeValue("", 903, Model[i].GTIN, 903, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 27 "C:\Users\U1213107\OneDrive - MMC\Desktop\ChannelEngineAssignment\ChannelEngineAssignment\ChannelEngineWeb\Views\Order\Index.cshtml"
                                                   Write(Html.DisplayFor(modelitem => Model[i].GTIN));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td");
                BeginWriteAttribute("id", " id=\"", 997, "\"", 1042, 2);
                WriteAttributeValue("", 1002, "td_TotalQuantity_", 1002, 17, true);
#nullable restore
#line 28 "C:\Users\U1213107\OneDrive - MMC\Desktop\ChannelEngineAssignment\ChannelEngineAssignment\ChannelEngineWeb\Views\Order\Index.cshtml"
WriteAttributeValue("", 1019, Model[i].TotalQuantity, 1019, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\U1213107\OneDrive - MMC\Desktop\ChannelEngineAssignment\ChannelEngineAssignment\ChannelEngineWeb\Views\Order\Index.cshtml"
                                                                     Write(Html.DisplayFor(modelitem => Model[i].TotalQuantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td");
                BeginWriteAttribute("id", " id=\"", 1131, "\"", 1184, 2);
                WriteAttributeValue("", 1136, "td_MerchantProductNo_", 1136, 21, true);
#nullable restore
#line 29 "C:\Users\U1213107\OneDrive - MMC\Desktop\ChannelEngineAssignment\ChannelEngineAssignment\ChannelEngineWeb\Views\Order\Index.cshtml"
WriteAttributeValue("", 1157, Model[i].MerchantProductNo, 1157, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 29 "C:\Users\U1213107\OneDrive - MMC\Desktop\ChannelEngineAssignment\ChannelEngineAssignment\ChannelEngineWeb\Views\Order\Index.cshtml"
                                                                             Write(Html.DisplayFor(modelitem => Model[i].MerchantProductNo));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                        <td>\r\n                            <input type=\"number\"");
                BeginWriteAttribute("id", " id=\"", 1330, "\"", 1378, 2);
                WriteAttributeValue("", 1335, "td_ProductCount_", 1335, 16, true);
#nullable restore
#line 32 "C:\Users\U1213107\OneDrive - MMC\Desktop\ChannelEngineAssignment\ChannelEngineAssignment\ChannelEngineWeb\Views\Order\Index.cshtml"
WriteAttributeValue("", 1351, Model[i].MerchantProductNo, 1351, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1379, "\"", 1438, 1);
#nullable restore
#line 32 "C:\Users\U1213107\OneDrive - MMC\Desktop\ChannelEngineAssignment\ChannelEngineAssignment\ChannelEngineWeb\Views\Order\Index.cshtml"
WriteAttributeValue("", 1386, Html.DisplayFor(modelitem => Model[i].ProductCount), 1386, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1439, "\"", 1469, 1);
#nullable restore
#line 32 "C:\Users\U1213107\OneDrive - MMC\Desktop\ChannelEngineAssignment\ChannelEngineAssignment\ChannelEngineWeb\Views\Order\Index.cshtml"
WriteAttributeValue("", 1447, Model[i].ProductCount, 1447, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" id=\"stockCount\" placeholder=\"Enter Stock Count\" />\r\n                        </td>\r\n                        <td>\r\n                            <button type=\"button\"");
                BeginWriteAttribute("id", " id=\"", 1654, "\"", 1702, 2);
                WriteAttributeValue("", 1659, "btn_UpdateStock_", 1659, 16, true);
#nullable restore
#line 35 "C:\Users\U1213107\OneDrive - MMC\Desktop\ChannelEngineAssignment\ChannelEngineAssignment\ChannelEngineWeb\Views\Order\Index.cshtml"
WriteAttributeValue("", 1675, Model[i].MerchantProductNo, 1675, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onclick=\"tableToObj(this)\" class=\"btn btn-primary\">Update Stock</button>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 38 "C:\Users\U1213107\OneDrive - MMC\Desktop\ChannelEngineAssignment\ChannelEngineAssignment\ChannelEngineWeb\Views\Order\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script type=""text/javascript"">

    $(""#btnSubmit"").click(function() {
        $(""#tblCEData tr"").each(function() {
            var table = $(this);
            var result = tableToObj(table);
        });
    });

    var tableToObj = function( button ) {
        var btnId = button.id;
        var merchantProductNumber = btnId.split('_')[2];
        var stockCount = document.getElementById('td_ProductCount_' + merchantProductNumber).value;

       $.post(""Order/UpdateStock"",
           {""Name"":"""",""GTIN"":"""",""TotalQuantity"":0, ""MerchantProductNo"": merchantProductNumber, ""ProductCount"": stockCount },
           function(res) {
               alert(""Stock Updated for "" + merchantProductNumber);
           });
    };

</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ChannelEngine.Models.ProductResponse>> Html { get; private set; }
    }
}
#pragma warning restore 1591
