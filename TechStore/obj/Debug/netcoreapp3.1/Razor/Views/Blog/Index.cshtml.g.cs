#pragma checksum "C:\Users\irade\source\repos\TechStore\TechStore\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abf0c662628d2de4d9af898ebb618ca64f9c0d01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 2 "C:\Users\irade\source\repos\TechStore\TechStore\Views\_ViewImports.cshtml"
using TechStore.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\irade\source\repos\TechStore\TechStore\Views\_ViewImports.cshtml"
using TechStore.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\irade\source\repos\TechStore\TechStore\Views\_ViewImports.cshtml"
using TechStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\irade\source\repos\TechStore\TechStore\Views\_ViewImports.cshtml"
using TechStore.ViewComponentModels.ProductV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\irade\source\repos\TechStore\TechStore\Views\_ViewImports.cshtml"
using TechStore.ViewComponentModels.ShopV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\irade\source\repos\TechStore\TechStore\Views\_ViewImports.cshtml"
using TechStore.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\irade\source\repos\TechStore\TechStore\Views\_ViewImports.cshtml"
using TechStore.ViewComponentModels.HeaderV;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abf0c662628d2de4d9af898ebb618ca64f9c0d01", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7b96443e1f86743097d935cf29affbd84b19a21", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\irade\source\repos\TechStore\TechStore\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--bread crumb -->
<div class=""breadcrumbGeneral"">
    <div class=""container"">
        <ul>
            <li><a href=""index.html""><span>Home</span> <i class=""fa-solid fa-arrow-right-long""></i></a></li>
            <li><a href=""shop.html""><span>Shop</span> <i class=""fa-solid fa-arrow-right-long""></i></a></li>
            <li><a href=""#""></a><span>Smartphones</span></li>
        </ul>
    </div>
</div>
<!-- main -->
<main id=""blogMain"">

    <section id=""post"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-9 col-xxl-9 col-xl-9 col-md-8 col-sm-12 col-12"">
                    <div class=""blog"">
                        <img src=""assets/images/blog/post-01.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 775, "\"", 781, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <h3><a");
            BeginWriteAttribute("href", " href=\"", 815, "\"", 822, 0);
            EndWriteAttribute();
            WriteLiteral(">There are many variations of passages</a></h3>\r\n                        <ul class=\"d-flex\">\r\n                            <li class=\"comment\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1001, "\"", 1008, 0);
            EndWriteAttribute();
            WriteLiteral(">2 Comments</a>\r\n                            </li>\r\n                            <li class=\"date\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1142, "\"", 1149, 0);
            EndWriteAttribute();
            WriteLiteral(@">February 20, 2017</a>
                            </li>
                        </ul>
                        <p>This is a Rebel that surrendered to us. Although he denies it, I believe there may be more of them, and I request permission to conduct a further search of the area. He was armed only with this. Good work, Commander. Leave us. Conduct your search and bring his companions to me. Yes, my Lord.</p>
                        <button>Read More <i class=""fa-solid fa-arrow-right-long""></i></button>
                    </div>
                    <div class=""blog"">
                        <img src=""assets/images/blog/post-01.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1795, "\"", 1801, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <h3><a");
            BeginWriteAttribute("href", " href=\"", 1835, "\"", 1842, 0);
            EndWriteAttribute();
            WriteLiteral(">There are many variations of passages</a></h3>\r\n                        <ul class=\"d-flex\">\r\n                            <li class=\"comment\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2021, "\"", 2028, 0);
            EndWriteAttribute();
            WriteLiteral(">2 Comments</a>\r\n                            </li>\r\n                            <li class=\"date\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2162, "\"", 2169, 0);
            EndWriteAttribute();
            WriteLiteral(@">February 20, 2017</a>
                            </li>
                        </ul>
                        <p>This is a Rebel that surrendered to us. Although he denies it, I believe there may be more of them, and I request permission to conduct a further search of the area. He was armed only with this. Good work, Commander. Leave us. Conduct your search and bring his companions to me. Yes, my Lord.</p>
                        <button>Read More <i class=""fa-solid fa-arrow-right-long""></i></button>
                    </div>
                    <div class=""blog"">
                        <img src=""assets/images/blog/post-01.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2815, "\"", 2821, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <h3><a");
            BeginWriteAttribute("href", " href=\"", 2855, "\"", 2862, 0);
            EndWriteAttribute();
            WriteLiteral(">There are many variations of passages</a></h3>\r\n                        <ul class=\"d-flex\">\r\n                            <li class=\"comment\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3041, "\"", 3048, 0);
            EndWriteAttribute();
            WriteLiteral(">2 Comments</a>\r\n                            </li>\r\n                            <li class=\"date\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3182, "\"", 3189, 0);
            EndWriteAttribute();
            WriteLiteral(@">February 20, 2017</a>
                            </li>
                        </ul>
                        <p>This is a Rebel that surrendered to us. Although he denies it, I believe there may be more of them, and I request permission to conduct a further search of the area. He was armed only with this. Good work, Commander. Leave us. Conduct your search and bring his companions to me. Yes, my Lord.</p>
                        <button>Read More <i class=""fa-solid fa-arrow-right-long""></i></button>
                    </div>
                    <section id=""PrevNext"">
                        <div class=""blog-pagination d-flex justify-content-between"">
                            <ul class=""d-flex"">
                                <li><i class=""fa-solid fa-arrow-left-long""></i> Prev Page</li>
                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4044, "\"", 4051, 0);
            EndWriteAttribute();
            WriteLiteral(">01</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4104, "\"", 4111, 0);
            EndWriteAttribute();
            WriteLiteral(">02</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4164, "\"", 4171, 0);
            EndWriteAttribute();
            WriteLiteral(">03</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4224, "\"", 4231, 0);
            EndWriteAttribute();
            WriteLiteral(@">04</a></li>
                                <li>Next Page <i class=""fa-solid fa-arrow-right-long""></i></li>
                            </ul>
                        </div>
                    </section>
                </div>
                <div class=""col-lg-3 col-xl-3 col-xxl-3 col-md-4 col-sm-12 col-12 right"">
                    <input type=""text"" placeholder=""search"">
                    <div class=""categoryTab"">
                        <div class=""category""><a");
            BeginWriteAttribute("href", " href=\"", 4714, "\"", 4721, 0);
            EndWriteAttribute();
            WriteLiteral(@">Categories</a></div>
                    </div>
                    <ul class=""categoryList"">
                        <li><i class=""fa-solid fa-chevron-right""></i>Accessories <span>(50)</span></li>
                        <li><i class=""fa-solid fa-chevron-right""></i>Cameras <span>(50)</span></li>
                        <li><i class=""fa-solid fa-chevron-right""></i>Computers <span>(50)</span></li>
                        <li><i class=""fa-solid fa-chevron-right""></i>Laptops <span>(50)</span></li>
                        <li><i class=""fa-solid fa-chevron-right""></i>Networking <span>(50)</span></li>
                        <li><i class=""fa-solid fa-chevron-right""></i>Old Products <span>(50)</span></li>
                        <li><i class=""fa-solid fa-chevron-right""></i>Smartphones <span>(50)</span></li>
                    </ul>
                    <section id=""highlights"">
                        <div class=""container"">
                            <div class=""heading"">
                           ");
            WriteLiteral(@"     <h3>Latest Products</h3>
                            </div>
                            <div class=""box"">
                                <div class=""row"">
                                    <div class=""col-lg-4 col-xl-4 col-xxl-4 col-md-4 col-sm-4 col-4"">
                                        <img src=""assets/images/product/10.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6093, "\"", 6099, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                    <div class=\"col-lg-8 col-xl-8 col-xxl-8 col-md-8 col-sm-8 col-8\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 6292, "\"", 6299, 0);
            EndWriteAttribute();
            WriteLiteral(@">Razer RZ02-01071500-R3M1</a>
                                        <div class=""starts"">
                                            <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i>
                                        </div>
                                        <div class=""discount"">
                                            <span>$50.00</span>
                                        </div>
                                        <div class=""sale"">
                                            <span>$2,999.00</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""box"">
                                <div class=""row"">
                                    <div class=""col-lg-4 col-xl-4 col-xxl-4 col-md-4 col-sm-4 col-4"">");
            WriteLiteral("\n                                        <img src=\"assets/images/product/10.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 7404, "\"", 7410, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                    <div class=\"col-lg-8 col-xl-8 col-xxl-8 col-md-8 col-sm-8 col-8\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 7603, "\"", 7610, 0);
            EndWriteAttribute();
            WriteLiteral(@">Razer RZ02-01071500-R3M1</a>
                                        <div class=""starts"">
                                            <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i>
                                        </div>
                                        <div class=""discount"">
                                            <span>$50.00</span>
                                        </div>
                                        <div class=""sale"">
                                            <span>$2,999.00</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""box"">
                                <div class=""row"">
                                    <div class=""col-lg-4 col-xl-4 col-xxl-4 col-md-4 col-sm-4 col-4"">");
            WriteLiteral("\n                                        <img src=\"assets/images/product/10.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 8715, "\"", 8721, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                    <div class=\"col-lg-8 col-xl-8 col-xxl-8 col-md-8 col-sm-8 col-8\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 8914, "\"", 8921, 0);
            EndWriteAttribute();
            WriteLiteral(@">Razer RZ02-01071500-R3M1</a>
                                        <div class=""starts"">
                                            <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i> <i class=""fa-solid fa-star""></i>
                                        </div>
                                        <div class=""discount"">
                                            <span>$50.00</span>
                                        </div>
                                        <div class=""sale"">
                                            <span>$2,999.00</span>
                                        </div>
                                    </div>
                                </div>
                            </div>


                        </div>
                    </section>
                    <div class=""categoryTab"">
                        <div class=""category""><a");
            BeginWriteAttribute("href", " href=\"", 9909, "\"", 9916, 0);
            EndWriteAttribute();
            WriteLiteral(">Popular Tags</a></div>\r\n                    </div>\r\n                    <div class=\"tags\">\r\n                        <ul class=\"d-flex\">\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 10089, "\"", 10096, 0);
            EndWriteAttribute();
            WriteLiteral(">Phone</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 10148, "\"", 10155, 0);
            EndWriteAttribute();
            WriteLiteral(">Computer</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 10210, "\"", 10217, 0);
            EndWriteAttribute();
            WriteLiteral(">Phone</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 10269, "\"", 10276, 0);
            EndWriteAttribute();
            WriteLiteral(">Phone</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 10328, "\"", 10335, 0);
            EndWriteAttribute();
            WriteLiteral(">Phone</a></li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </section>\r\n\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
