#pragma checksum "C:\Users\irade\Desktop\TechStoreBack\TechStore\Areas\Manage\Views\PaymentMethod\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a74be46a662546960c22352257d48986d15d50f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_PaymentMethod_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/PaymentMethod/Index.cshtml")]
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
#line 2 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Areas\Manage\Views\_ViewImports.cshtml"
using TechStore.Areas.Manage.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Areas\Manage\Views\_ViewImports.cshtml"
using TechStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Areas\Manage\Views\_ViewImports.cshtml"
using TechStore.ViewModels.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a74be46a662546960c22352257d48986d15d50f9", @"/Areas/Manage/Views/PaymentMethod/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"770bc4a4cc0fb70d4185c173b28f7114490b3337", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_PaymentMethod_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PaymentMethod>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:90%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Areas\Manage\Views\PaymentMethod\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int counter = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-2 h3 mb-4 text-gray-800"">
        <h1>Payment Method</h1>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-12"">

        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Image</th>
                    <th scope=""col"">Description</th>
                    <th>
                        Updated at
                    </th>
                    <th scope=""col"">Setting</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 30 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Areas\Manage\Views\PaymentMethod\Index.cshtml"
                 foreach (PaymentMethod payment in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 34 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Areas\Manage\Views\PaymentMethod\Index.cshtml"
                   Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"align-middle\">");
#nullable restore
#line 36 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Areas\Manage\Views\PaymentMethod\Index.cshtml"
                                        Write(payment.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"align-middle\" style=\"width:10%\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a74be46a662546960c22352257d48986d15d50f97617", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1097, "~/assets/images/payment/", 1097, 24, true);
#nullable restore
#line 37 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Areas\Manage\Views\PaymentMethod\Index.cshtml"
AddHtmlAttributeValue("", 1121, payment?.MainImage, 1121, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <td class=\"align-middle\">");
#nullable restore
#line 38 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Areas\Manage\Views\PaymentMethod\Index.cshtml"
                                        Write(payment.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Areas\Manage\Views\PaymentMethod\Index.cshtml"
                   Write(payment.UpdatedAt?.ToString("dd/mm/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"d-flex p-5\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a74be46a662546960c22352257d48986d15d50f910150", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Areas\Manage\Views\PaymentMethod\Index.cshtml"
                                                                                                   WriteLiteral(payment.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Areas\Manage\Views\PaymentMethod\Index.cshtml"
                    counter++;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PaymentMethod>> Html { get; private set; }
    }
}
#pragma warning restore 1591
