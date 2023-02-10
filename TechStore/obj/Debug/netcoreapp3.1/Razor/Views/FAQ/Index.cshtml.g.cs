#pragma checksum "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\FAQ\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c628188c925c08b4ff37e3a4832cd497813ce05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FAQ_Index), @"mvc.1.0.view", @"/Views/FAQ/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c628188c925c08b4ff37e3a4832cd497813ce05", @"/Views/FAQ/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70fb7e08c8d88d9bdc72b27a8b230e7abd41c3dd", @"/Views/_ViewImports.cshtml")]
    public class Views_FAQ_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FAQ>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\FAQ\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- main -->
<main id=""_faqMain"">
    <div class=""breadcrumbGeneral"">
        <div class=""container"">
            <ul>
                <li><a href=""index.html""><span>Home</span> <i class=""fa-solid fa-arrow-right-long""></i></a></li>
                <li><a href=""shop.html""><span>Shop</span> <i class=""fa-solid fa-arrow-right-long""></i></a></li>
                <li><a href=""#""></a><span>Smartphones</span></li>
            </ul>
        </div>
    </div>
    <div class=""container"">
        <div class=""heading"">
            <h3>Answers to Your Questions</h3>
        </div>
        <div class=""accordion"" id=""accordionPanelsStayOpenExample"">
");
#nullable restore
#line 22 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\FAQ\Index.cshtml"
             foreach (var item in Model.Take(1))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""accordion-item"">
                    <h2 class=""accordion-header"" id=""panelsStayOpen-headingOne"">
                        <button class=""accordion-button"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#panelsStayOpen-collapseOne"" aria-expanded=""true"" aria-controls=""panelsStayOpen-collapseOne"">
                            ");
#nullable restore
#line 27 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\FAQ\Index.cshtml"
                       Write(item.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </button>
                    </h2>
                    <div id=""panelsStayOpen-collapseOne"" class=""accordion-collapse collapse show"" aria-labelledby=""panelsStayOpen-headingOne"">
                        <div class=""accordion-body"">
                            ");
#nullable restore
#line 32 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\FAQ\Index.cshtml"
                       Write(item.Answer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 36 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\FAQ\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\FAQ\Index.cshtml"
             foreach (var item in Model.Skip(1).Take(2))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""accordion-item"">
                    <h2 class=""accordion-header"" id=""panelsStayOpen-headingTwo"">
                        <button class=""accordion-button"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#panelsStayOpen-collapseTwo"" aria-expanded=""true"" aria-controls=""panelsStayOpen-collapseOne"">
                            ");
#nullable restore
#line 43 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\FAQ\Index.cshtml"
                       Write(item.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </button>
                    </h2>
                    <div id=""panelsStayOpen-collapseTwo"" class=""accordion-collapse collapse show"" aria-labelledby=""panelsStayOpen-headingTwo"">
                        <div class=""accordion-body"">
                            ");
#nullable restore
#line 48 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\FAQ\Index.cshtml"
                       Write(item.Answer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 52 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\FAQ\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FAQ>> Html { get; private set; }
    }
}
#pragma warning restore 1591