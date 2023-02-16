#pragma checksum "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a86a64fe3e3e3e4ac2e83ebee1517030782eb75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a86a64fe3e3e3e4ac2e83ebee1517030782eb75", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70fb7e08c8d88d9bdc72b27a8b230e7abd41c3dd", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- main -->
<main id=""aboutMain"">

    <div class=""container"">

        <div id=""firstSection"">

            <div class=""row"">
                <div class=""col-lg-6 col-xl-6 col-xxl-6 col-12 col-md-12 col-sm-12 Left"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 313, "\"", 357, 2);
            WriteAttributeValue("", 319, "assets/images/about/", 319, 20, true);
#nullable restore
#line 16 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"
WriteAttributeValue("", 339, Model.About.Image, 339, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 358, "\"", 364, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"col-lg-6 col-xl-6 col-xxl-6 col-12 col-md-12 col-sm-12 Right\">\r\n                    <div class=\"title\">\r\n                        <h3>");
#nullable restore
#line 20 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"
                       Write(Model.About.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    </div>\r\n                    <div class=\"content\">\r\n                        <p>\r\n                            ");
#nullable restore
#line 24 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"
                       Write(Model.About.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n    </div>\r\n    <div class=\"container\">\r\n        <section id=\"second\">\r\n            <div class=\"row secondGeneral\">\r\n");
#nullable restore
#line 38 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"
                 foreach (var item in Model.Posts)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-xl-4 col-xxl-4 col-md-4 col-sm-12 col-12 box\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1167, "\"", 1204, 2);
            WriteAttributeValue("", 1173, "assets/images/about/", 1173, 20, true);
#nullable restore
#line 41 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"
WriteAttributeValue("", 1193, item.Image, 1193, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1205, "\"", 1211, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1241, "\"", 1248, 0);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 42 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <p>\r\n                            ");
#nullable restore
#line 44 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n");
#nullable restore
#line 47 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </section>\r\n        <section id=\"ourTeam\">\r\n            <h3>Meet Our Team</h3>\r\n            <div class=\"mainSliderSectionAbout  row\">\r\n\r\n");
#nullable restore
#line 55 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"
                 foreach (var item in Model.Teams)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"generalForSlider col-lg-3 col-xl-3 col-xxl-3 col-6 col-sm-12 col-md-12\">\r\n                        <div class=\"image\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1842, "\"", 1881, 2);
            WriteAttributeValue("", 1848, "assets/images/ourTeam/", 1848, 22, true);
#nullable restore
#line 59 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"
WriteAttributeValue("", 1870, item.Image, 1870, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1882, "\"", 1888, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"text\">\r\n                            <div class=\"name\">\r\n                                ");
#nullable restore
#line 63 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"
                           Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"text\">\r\n                                ");
#nullable restore
#line 66 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"
                           Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 70 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            </section>\r\n                <section id=\"Testimonial\">\r\n                    <div class=\"testimonialGenera\">\r\n                        <h3>Testimonial</h3>\r\n                        <div class=\"testimonialGeneral1\">\r\n");
#nullable restore
#line 78 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"
                             foreach (var item in Model.Testimonials)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"testimonialGeneral\">\r\n                                <div class=\"image\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 2816, "\"", 2859, 2);
            WriteAttributeValue("", 2822, "assets/images/testimonial/", 2822, 26, true);
#nullable restore
#line 82 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"
WriteAttributeValue("", 2848, item.Image, 2848, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2860, "\"", 2866, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                                </div>\r\n                                <div class=\"name\">\r\n                                    ");
#nullable restore
#line 86 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"ph\">\r\n                                    <p>\r\n                                       ");
#nullable restore
#line 90 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"
                                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n\r\n                            </div>\r\n");
#nullable restore
#line 95 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <section id=\"ourTeam\">\r\n                            <h3>Partners</h3>\r\n                            <div class=\"partners row\">\r\n");
#nullable restore
#line 101 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"
                                 foreach (var item in Model.Partners)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"generalForSlider col-lg-2 col-xl-2 col-xxl-2 col-6 col-sm-12 col-md-12\">\r\n                                    <div class=\"image\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 3863, "\"", 3900, 2);
            WriteAttributeValue("", 3869, "assets/images/brand/", 3869, 20, true);
#nullable restore
#line 105 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"
WriteAttributeValue("", 3889, item.Image, 3889, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3901, "\"", 3907, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 108 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\About\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                             </div>\r\n                        </section>\r\n                    </div>\r\n                </section>\r\n            </div>\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
