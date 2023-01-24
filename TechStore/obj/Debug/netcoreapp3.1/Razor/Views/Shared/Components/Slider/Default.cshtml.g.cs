#pragma checksum "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\Slider\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11dd86c71bd43e85aa10e7a76aa777bc296141af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Slider_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Slider/Default.cshtml")]
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
#line 3 "C:\Users\irade\source\repos\TechStore\TechStore\Views\_ViewImports.cshtml"
using TechStore.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\irade\source\repos\TechStore\TechStore\Views\_ViewImports.cshtml"
using TechStore.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\irade\source\repos\TechStore\TechStore\Views\_ViewImports.cshtml"
using TechStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\irade\source\repos\TechStore\TechStore\Views\_ViewImports.cshtml"
using TechStore.ViewComponentModels.ProductV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\irade\source\repos\TechStore\TechStore\Views\_ViewImports.cshtml"
using TechStore.ViewComponentModels.ShopV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\irade\source\repos\TechStore\TechStore\Views\_ViewImports.cshtml"
using TechStore.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\irade\source\repos\TechStore\TechStore\Views\_ViewImports.cshtml"
using TechStore.ViewComponentModels.HeaderV;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11dd86c71bd43e85aa10e7a76aa777bc296141af", @"/Views/Shared/Components/Slider/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efd64f3e26eeecfbfb59b834d6670ef3e4ea61ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Slider_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Slider>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("backImage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/homeSlider/MainSliderBack.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section id=\"mainSliderSection\">\r\n\r\n    <div class=\"mainSliderSection\">\r\n");
#nullable restore
#line 5 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\Slider\Default.cshtml"
         foreach (Slider item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"generalForSlider\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-6 col-xl-6 col-xxl-6 col-9 col-sm-6 col-md-6 leftForMainSlider\">\r\n                    <p>");
#nullable restore
#line 10 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\Slider\Default.cshtml"
                  Write(Html.Raw(item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <h2>");
#nullable restore
#line 11 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\Slider\Default.cshtml"
                   Write(Html.Raw(item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p>");
#nullable restore
#line 12 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\Slider\Default.cshtml"
                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    <div class=\"buttonSection d-flex align-items-center\">\r\n                        <div class=\"price\">\r\n                            $");
#nullable restore
#line 16 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\Slider\Default.cshtml"
                        Write(item.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"shopNow\">\r\n                            <a ");
#nullable restore
#line 19 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\Slider\Default.cshtml"
                          Write(item.Link);

#line default
#line hidden
#nullable disable
            WriteLiteral(">Show Now</a> <i class=\"fa-solid fa-arrow-right-long\"></i>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"priceDiscount\">\r\n                        <del>$");
#nullable restore
#line 23 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\Slider\Default.cshtml"
                         Write(item.RegularPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</del>
                    </div>
                </div>
                <div class=""col-lg-6 col-xl-6 col-xxl-6 col-3 col-sm-6 col-md-6 d-flex justify-content-end align-content-end mt-5"">
                    <div class=""image"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "11dd86c71bd43e85aa10e7a76aa777bc296141af8134", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1260, "~/assets/images/homeSlider/", 1260, 27, true);
#nullable restore
#line 28 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\Slider\Default.cshtml"
AddHtmlAttributeValue("", 1287, item.Image, 1287, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "11dd86c71bd43e85aa10e7a76aa777bc296141af9837", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 35 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\Slider\Default.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n    </div>\r\n\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Slider>> Html { get; private set; }
    }
}
#pragma warning restore 1591
