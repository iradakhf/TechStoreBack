#pragma checksum "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\BestSellerOnSide\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "facc45345212103841b0952f153d0786e896fae3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BestSellerOnSide_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BestSellerOnSide/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"facc45345212103841b0952f153d0786e896fae3", @"/Views/Shared/Components/BestSellerOnSide/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca736876ee4d341a357610ac41b98f777ee21d30", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BestSellerOnSide_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\BestSellerOnSide\Default.cshtml"
 foreach (Product item in Model.Take(3))
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row align-items-center mb-3\">\r\n    <div class=\"col-lg-4 col-xxl-4 col-xl-4 col-sm-4 col-md-4 col-4 imgForBasket\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "facc45345212103841b0952f153d0786e896fae34586", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 222, "~/assets/images/product/", 222, 24, true);
#nullable restore
#line 7 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\BestSellerOnSide\Default.cshtml"
AddHtmlAttributeValue("", 246, item.MainImage, 246, 15, false);

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
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-lg-7 col-xxl-7 col-xl-7 col-sm-7 col-md-7 col-7\">\r\n        <div class=\"name\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 404, "\"", 411, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\BestSellerOnSide\Default.cshtml"
                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
        </div>
        <div class=""stars"">
            <i class=""fa-solid fa-star""></i><i class=""fa-solid fa-star""></i><i class=""fa-solid fa-star""></i><i class=""fa-solid fa-star""></i><i class=""fa-solid fa-star""></i>
        </div>
        <div class=""priceSection d-flex"">
            <div class=""discount pe-5"">
                $");
#nullable restore
#line 18 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\BestSellerOnSide\Default.cshtml"
            Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"sale\">\r\n                <del>\r\n                    $");
#nullable restore
#line 22 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\BestSellerOnSide\Default.cshtml"
                Write(item.DiscountedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </del>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 28 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\BestSellerOnSide\Default.cshtml"
		 
	}

#line default
#line hidden
#nullable disable
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
