#pragma checksum "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\Color\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63bd381aa27af6cd9fd496ee284c9520878b9c9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Color_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Color/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63bd381aa27af6cd9fd496ee284c9520878b9c9c", @"/Views/Shared/Components/Color/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca736876ee4d341a357610ac41b98f777ee21d30", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Color_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Color>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\Color\Default.cshtml"
 foreach (Color item in Model)
{
    if (item.ProductColors!=null)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"box\">\r\n    <input type=\"checkbox\"> <span>");
#nullable restore
#line 9 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\Color\Default.cshtml"
                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>(");
#nullable restore
#line 9 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\Color\Default.cshtml"
                                               Write(item.ProductColors.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span></span>\r\n</div>\r\n");
#nullable restore
#line 11 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Shared\Components\Color\Default.cshtml"
    }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Color>> Html { get; private set; }
    }
}
#pragma warning restore 1591
