#pragma checksum "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\_ProductOnHomePartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9e6b71ec22b9e7476907e627548740fc0013826"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductOnHomePartialView), @"mvc.1.0.view", @"/Views/Shared/_ProductOnHomePartialView.cshtml")]
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
#line 2 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\_ViewImports.cshtml"
using TechStore.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\_ViewImports.cshtml"
using TechStore.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\_ViewImports.cshtml"
using TechStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\_ViewImports.cshtml"
using TechStore.ViewComponentModels.ProductV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\_ViewImports.cshtml"
using TechStore.ViewComponentModels.ShopV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\_ViewImports.cshtml"
using TechStore.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\_ViewImports.cshtml"
using TechStore.ViewComponentModels.HeaderV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\_ViewImports.cshtml"
using TechStore.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\_ViewImports.cshtml"
using TechStore.ViewModels.AboutV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\_ViewImports.cshtml"
using TechStore.ViewModels.ContactV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\_ViewImports.cshtml"
using TechStore.ViewModels.SingleV;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9e6b71ec22b9e7476907e627548740fc0013826", @"/Views/Shared/_ProductOnHomePartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70fb7e08c8d88d9bdc72b27a8b230e7abd41c3dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductOnHomePartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/cart.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("addtobasket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addtobasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\_ProductOnHomePartialView.cshtml"
 foreach (Product item in Model.Take(8))
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div id=""product1"" class=""col-lg-3 col-xxl-3 col-xl-3 col-md-6 col-sm-6 col-12"">

        <div class=""imageAndTextBox"">
            <div class=""productBoxesSectionSliderForSingleProduct1"">
                <div class=""box"">
                    <img width=""100%""");
            BeginWriteAttribute("src", " src=\"", 347, "\"", 390, 2);
            WriteAttributeValue("", 353, "assets/images/product/", 353, 22, true);
#nullable restore
#line 11 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\_ProductOnHomePartialView.cshtml"
WriteAttributeValue("", 375, item.MainImage, 375, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 391, "\"", 397, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div class=\"textPart\">\r\n                <div class=\"title d-flex justify-content-center\">\r\n                    <span>-</span>\r\n                    <div class=\"text\">\r\n                        ");
#nullable restore
#line 18 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\_ProductOnHomePartialView.cshtml"
                   Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"productDescription\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9e6b71ec22b9e7476907e627548740fc00138269081", async() => {
#nullable restore
#line 22 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\_ProductOnHomePartialView.cshtml"
                                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\_ProductOnHomePartialView.cshtml"
                                                                   WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                </div>\r\n                <div class=\"priceSection d-flex\">\r\n                    <div class=\"discount\">\r\n                        $");
#nullable restore
#line 26 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\_ProductOnHomePartialView.cshtml"
                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"sale\">\r\n                        <del>\r\n                            $");
#nullable restore
#line 30 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\_ProductOnHomePartialView.cshtml"
                        Write(item.DiscountedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </del>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"onHoverBasketCompareWishList\">\r\n                <div class=\"top\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9e6b71ec22b9e7476907e627548740fc001382612746", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a9e6b71ec22b9e7476907e627548740fc001382612963", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" <span>Add to Cart</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\_ProductOnHomePartialView.cshtml"
                                                                                              WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                </div>\r\n                <div class=\"bottom\">\r\n                    <div class=\"left\">\r\n                        <a href=\"compare.html\"><img src=\"assets/images/compare.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1754, "\"", 1760, 0);
            EndWriteAttribute();
            WriteLiteral("> Compare</a>\r\n                    </div>\r\n                    <div class=\"right\">\r\n                        <a href=\"wishlist.html\"><img src=\"assets/images/wishlist.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1930, "\"", 1936, 0);
            EndWriteAttribute();
            WriteLiteral("> Wishlist</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 50 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\_ProductOnHomePartialView.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
