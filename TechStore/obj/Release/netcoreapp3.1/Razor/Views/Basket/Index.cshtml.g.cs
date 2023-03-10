#pragma checksum "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b36b0e2ceb814af212ea6fee075fe41ffffb080"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36b0e2ceb814af212ea6fee075fe41ffffb080", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d3a12d8e920c0dfb4946b4f868d674c24b01704", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Basket\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- main -->
<main id=""cartMain"">
    <div class=""breadcrumbGeneral"">
        <div class=""container"">
           
        </div>
    </div>
    <div class=""container"">
        <div class=""generalCart"">
            <div class=""row"">
                <div class=""col-lg-8 col-xl-8 col-xxl-8 col-12 col-md-12 col-sm-12"">
                    <div class=""leftCart"">
                        <h3>Shooping Cart</h3>
                        <table>
                            <thead>
                                <tr>
                                    <th>Product</th>
                                    <th>Quantity</th>
                                    <th>Total</th>
                                </tr>
                            </thead>
                            <tbody class=""basketindexcontainer"">
                                ");
#nullable restore
#line 28 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Basket\Index.cshtml"
                           Write(await Html.PartialAsync("_BasketPartial", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </tbody>
                        </table>
                        

                    </div>

                </div>
                <div class=""col-lg-4 col-xl-4 col-xxl-4 col-sm-12 col-md-12 col-12"">
                    <div class=""rightCart"">
                        <h3>Cart Totals</h3>
                        <div class=""subtotal d-flex"">
                            <p>Subtotal</p>
                            <div class=""subtotalPrice""></div>
                        </div>
                        <div class=""shipping d-flex"">
                            <p>Shipping</p>
                            <div class=""rightPartForShipping"">
                                <div class=""flatRate"">
                                    <input type=""checkbox"">
                                    <span>Flat Rate: <span>$3.00</span></span>
                                </div>
                                <div class=""free"">
                                    <input ");
            WriteLiteral(@"type=""checkbox"">
                                    <span>Free Shipping</span>
                                </div>
                                <p class=""calculateShipping"">Calculate Shipping</p>
                            </div>
                        </div>
                        <div class=""total"">
                            <p>Total</p>
                            <div class=""totalPrice"">$");
#nullable restore
#line 59 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Basket\Index.cshtml"
                                                 Write(Model.Sum(b => b.Price * b.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""buttons"">
                            <button id=""firstBtn"">
                                Update Cart
                            </button>
                            <button id=""ProceedToCheckout"">
                                Proceed To Checkout
                            </button>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
   ");
#nullable restore
#line 75 "C:\Users\irade\Desktop\TechStoreBack\TechStore\Views\Basket\Index.cshtml"
Write(await Component.InvokeAsync("Services"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
