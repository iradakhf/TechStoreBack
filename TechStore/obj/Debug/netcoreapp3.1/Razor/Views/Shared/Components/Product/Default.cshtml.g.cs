#pragma checksum "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\Product\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebc87bf51807836baea4c0fe13edda2f6b985e37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Product_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Product/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebc87bf51807836baea4c0fe13edda2f6b985e37", @"/Views/Shared/Components/Product/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e841af6b24296653c416178d5abbcb7f0f04f586", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Product_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section id=""productBoxesNewArrivalFeaturedTopSelling"">
    <div class=""productBoxesNewArrivalFeaturedTopSellingGeneral"">
        <div class=""container"">
            <div class=""productTab"">
                <ul class=""d-flex"">
                    <li><a id=""productBoxNewArrival""");
            BeginWriteAttribute("href", " href=\"", 304, "\"", 311, 0);
            EndWriteAttribute();
            WriteLiteral(">New Arrivals</a></li>\r\n                    <li><a id=\"productBoxFeatured\"");
            BeginWriteAttribute("href", " href=\"", 386, "\"", 393, 0);
            EndWriteAttribute();
            WriteLiteral(">Featured</a></li>\r\n                    <li><a id=\"productBoxTopSelling\"");
            BeginWriteAttribute("href", " href=\"", 466, "\"", 473, 0);
            EndWriteAttribute();
            WriteLiteral(">Top Selling</a></li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"productBox productBoxNewArrival\">\r\n                <div class=\"row justify-content-between\">\r\n                    ");
#nullable restore
#line 15 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\Product\Default.cshtml"
               Write(Html.Partial("_ProductOnHomePartialView", Model.NewArrivals));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"productBox productBoxFeatured\">\r\n                <div class=\"row justify-content-between\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\Product\Default.cshtml"
               Write(Html.Partial("_ProductOnHomePartialView", Model.BestSellers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"productBox productBoxTopSelling\">\r\n                <div class=\"row justify-content-between\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\Product\Default.cshtml"
               Write(Html.Partial("_ProductOnHomePartialView", Model.Featured));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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