#pragma checksum "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\Components\Highlight\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "658bbbba2ad1d573bd34799b085c0619a3c7db5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Highlight_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Highlight/Default.cshtml")]
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
#nullable restore
#line 13 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\_ViewImports.cshtml"
using TechStore.ViewModels.WishlistV;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"658bbbba2ad1d573bd34799b085c0619a3c7db5f", @"/Views/Shared/Components/Highlight/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d3a12d8e920c0dfb4946b4f868d674c24b01704", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Highlight_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<section id=""highlights"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-xl-4 col-xxl-4 col-md-4 col-sm-12 col-12"">
                <div class=""heading"">
                    <h3>Bestsellers</h3>
                </div>
");
#nullable restore
#line 10 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\Components\Highlight\Default.cshtml"
                 foreach (Product item in Model.BestSellers.Take(3))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"box mb-4\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-lg-4 col-xl-4 col-xxl-4 col-md-4 col-sm-4 col-4\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "658bbbba2ad1d573bd34799b085c0619a3c7db5f6988", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 586, "~/assets/images/product/", 586, 24, true);
#nullable restore
#line 15 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\Components\Highlight\Default.cshtml"
AddHtmlAttributeValue("", 610, item.MainImage, 610, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-lg-8 col-xl-8 col-xxl-8 col-md-8 col-sm-8 col-8\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "658bbbba2ad1d573bd34799b085c0619a3c7db5f8740", async() => {
#nullable restore
#line 18 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\Components\Highlight\Default.cshtml"
                                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\Components\Highlight\Default.cshtml"
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
            WriteLiteral(@"
                            <div class=""starts"">
                                <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i>
                            </div>
                            <div class=""discount"">
                                <span>$");
#nullable restore
#line 23 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\Components\Highlight\Default.cshtml"
                                  Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"sale\">\r\n                                <span>$");
#nullable restore
#line 26 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\Components\Highlight\Default.cshtml"
                                  Write(item.DiscountedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 31 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\Components\Highlight\Default.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-lg-4 col-xl-4 col-xxl-4 col-md-4 col-sm-12 col-12\">\r\n                <div class=\"heading\">\r\n                    <h3>Featured</h3>\r\n                </div>\r\n");
#nullable restore
#line 38 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\Components\Highlight\Default.cshtml"
                 foreach (Product item in Model.Featured.Take(3))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"box mb-4\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-lg-4 col-xl-4 col-xxl-4 col-md-4 col-sm-4 col-4\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "658bbbba2ad1d573bd34799b085c0619a3c7db5f13561", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2074, "~/assets/images/product/", 2074, 24, true);
#nullable restore
#line 43 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\Components\Highlight\Default.cshtml"
AddHtmlAttributeValue("", 2098, item.MainImage, 2098, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-lg-8 col-xl-8 col-xxl-8 col-md-8 col-sm-8 col-8\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "658bbbba2ad1d573bd34799b085c0619a3c7db5f15330", async() => {
#nullable restore
#line 46 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\Components\Highlight\Default.cshtml"
                                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                <div class=""starts"">
                                    <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i>
                                </div>
                                <div class=""discount"">
                                    <span>$");
#nullable restore
#line 51 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\Components\Highlight\Default.cshtml"
                                      Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <div class=\"sale\">\r\n                                    <span>$");
#nullable restore
#line 54 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\Components\Highlight\Default.cshtml"
                                      Write(item.DiscountedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 59 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\Components\Highlight\Default.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-lg-4 col-xl-4 col-xxl-4 col-md-4 col-sm-12 col-12\">\r\n                <div class=\"heading\">\r\n                    <h3>Hot Sale</h3>\r\n                </div>\r\n");
#nullable restore
#line 66 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\Components\Highlight\Default.cshtml"
                 foreach (Product item in Model.NewArrivals.Take(3))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"box mb-4\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-lg-4 col-xl-4 col-xxl-4 col-md-4 col-sm-4 col-4\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "658bbbba2ad1d573bd34799b085c0619a3c7db5f19145", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3601, "~/assets/images/product/", 3601, 24, true);
#nullable restore
#line 71 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\Components\Highlight\Default.cshtml"
AddHtmlAttributeValue("", 3625, item.MainImage, 3625, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-lg-8 col-xl-8 col-xxl-8 col-md-8 col-sm-8 col-8\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "658bbbba2ad1d573bd34799b085c0619a3c7db5f20914", async() => {
#nullable restore
#line 74 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\Components\Highlight\Default.cshtml"
                                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                <div class=""starts"">
                                    <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i>
                                </div>
                                <div class=""discount"">
                                    <span>$");
#nullable restore
#line 79 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\Components\Highlight\Default.cshtml"
                                      Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <div class=\"sale\">\r\n                                    <span>$");
#nullable restore
#line 82 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\Components\Highlight\Default.cshtml"
                                      Write(item.DiscountedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 87 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Shared\Components\Highlight\Default.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
