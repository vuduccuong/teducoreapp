#pragma checksum "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\MainMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b12bb67513769ba300bb3d1638903cea34b42bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MainMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MainMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MainMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_MainMenu_Default))]
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
#line 1 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\_ViewImports.cshtml"
using TeduCoreApp.Models;

#line default
#line hidden
#line 3 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\_ViewImports.cshtml"
using TeduCoreApp.Models.AccountViewModels;

#line default
#line hidden
#line 4 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\_ViewImports.cshtml"
using TeduCoreApp.Models.ManageViewModels;

#line default
#line hidden
#line 5 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\_ViewImports.cshtml"
using TeduCoreApp.Data.Entities;

#line default
#line hidden
#line 6 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\_ViewImports.cshtml"
using TeduCoreApp.Extensions;

#line default
#line hidden
#line 7 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\_ViewImports.cshtml"
using TeduCoreApp.Application.ViewModels.Product;

#line default
#line hidden
#line 8 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b12bb67513769ba300bb3d1638903cea34b42bc", @"/Views/Shared/Components/MainMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ad63dd39fdc7be8f0a296127d812d582f58e04", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MainMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductCategoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 938, true);
            WriteLiteral(@"<div class=""mtmegamenu"">
    <ul class=""hidden-xs"">
        <li class=""mt-root demo_custom_link_cms"">
            <div class=""mt-root-item"">
                <a href=""/"">
                    <div class=""title title_font""><span class=""title-text"">Home</span></div>
                </a>
            </div>
           
        </li>

        <li class=""mt-root demo_custom_link_cms"">
            <div class=""mt-root-item"">
                <a href=""/page/introduction.html"">
                    <div class=""title title_font""><span class=""title-text"">About</span></div>
                </a>
            </div>

        </li>
        <li class=""mt-root"">
            <div class=""mt-root-item"">
                <a href=""/products.html"">
                    <div class=""title title_font""><span class=""title-text"">Products</span></div>
                </a>
            </div>
            <ul class=""menu-items col-xs-12"">
");
            EndContext();
#line 28 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\MainMenu\Default.cshtml"
                 foreach (var item in Model.Where(c => c.ParentId == null))
                {

#line default
#line hidden
            BeginContext(1073, 122, true);
            WriteLiteral("                    <li class=\"menu-item depth-1 menucol-1-3 \">\r\n                        <div class=\"title title_font\"> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1195, "\"", 1235, 5);
            WriteAttributeValue("", 1202, "/", 1202, 1, true);
#line 31 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\MainMenu\Default.cshtml"
WriteAttributeValue("", 1203, item.SeoAlias, 1203, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1217, "-c.", 1217, 3, true);
#line 31 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\MainMenu\Default.cshtml"
WriteAttributeValue("", 1220, item.Id, 1220, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1230, ".html", 1230, 5, true);
            EndWriteAttribute();
            BeginContext(1236, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1238, 9, false);
#line 31 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\MainMenu\Default.cshtml"
                                                                                              Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1247, 58, true);
            WriteLiteral("</a></div>\r\n                        <ul class=\"submenu\">\r\n");
            EndContext();
#line 33 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\MainMenu\Default.cshtml"
                             foreach (var subItem in Model.Where(x => x.ParentId == item.Id))
                            {

#line default
#line hidden
            BeginContext(1431, 114, true);
            WriteLiteral("                                <li class=\"menu-item\">\r\n                                    <div class=\"title\"> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1545, "\"", 1591, 5);
            WriteAttributeValue("", 1552, "/", 1552, 1, true);
#line 36 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\MainMenu\Default.cshtml"
WriteAttributeValue("", 1553, subItem.SeoAlias, 1553, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 1570, "-c.", 1570, 3, true);
#line 36 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\MainMenu\Default.cshtml"
WriteAttributeValue("", 1573, subItem.Id, 1573, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1586, ".html", 1586, 5, true);
            EndWriteAttribute();
            BeginContext(1592, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1594, 12, false);
#line 36 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\MainMenu\Default.cshtml"
                                                                                                     Write(subItem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1606, 51, true);
            WriteLiteral("</a></div>\r\n                                </li>\r\n");
            EndContext();
#line 38 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\MainMenu\Default.cshtml"
                            }

#line default
#line hidden
            BeginContext(1688, 60, true);
            WriteLiteral("\r\n                        </ul>\r\n                    </li>\r\n");
            EndContext();
#line 42 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\MainMenu\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(1767, 8984, true);
            WriteLiteral(@"               
            </ul>
        </li>
     
        <li class=""mt-root demo_custom_link_cms"">
            <div class=""mt-root-item"">
                <a href=""blog.html"">
                    <div class=""title title_font""><span class=""title-text"">Blog</span></div>
                </a>
            </div>
        </li>
        <li class=""mt-root"">
            <div class=""mt-root-item"">
                <div class=""title title_font""><span class=""title-text"">Best Seller</span></div>
            </div>
            <ul class=""menu-items col-xs-12"">
                <li class=""menu-item depth-1 product menucol-1-3 withimage"">
                    <div class=""product-item"">
                        <div class=""item-inner"">
                            <div class=""product-thumbnail"">
                                <div class=""icon-sale-label sale-left"">Sale</div>
                                <div class=""pr-img-area"">
                                    <a title=""Product title here"" href=""s");
            WriteLiteral(@"ingle_product.html"">
                                        <figure> <img class=""first-img"" src=""/client-side/images/products/product-1.jpg"" alt=""html theme""> <img class=""hover-img"" src=""/client-side/images/products/product-1.jpg"" alt=""html Template""></figure>
                                    </a>
                                </div>
                                <div class=""pr-info-area"">
                                    <div class=""pr-button"">
                                        <div class=""mt-button add_to_wishlist""> <a href=""wishlist.html""> <i class=""fa fa-heart""></i> </a> </div>
                                        <div class=""mt-button add_to_compare""> <a href=""compare.html""> <i class=""fa fa-signal""></i> </a> </div>
                                        <div class=""mt-button quick-view""> <a href=""quick_view.html""> <i class=""fa fa-search""></i> </a> </div>
                                    </div>
                                </div>
                            </div>
  ");
            WriteLiteral(@"                          <div class=""item-info"">
                                <div class=""info-inner"">
                                    <div class=""item-title""> <a title=""Product title here"" href=""single_product.html"">Product title here </a> </div>
                                    <div class=""item-content"">
                                        <div class=""rating""> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> </div>
                                        <div class=""item-price"">
                                            <div class=""price-box""> <span class=""regular-price""> <span class=""price"">$125.00</span> </span> </div>
                                        </div>
                                        <div class=""pro-action"">
                                            <button type=""button"" class=""add-to-cart""><span> Add to Cart</span> </button>
                                    ");
            WriteLiteral(@"    </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </li>
                <li class=""menu-item depth-1 product menucol-1-3 withimage"">
                    <div class=""product-item"">
                        <div class=""item-inner"">
                            <div class=""product-thumbnail"">
                                <div class=""icon-sale-label sale-left"">Sale</div>
                                <div class=""pr-img-area"">
                                    <a title=""Product title here"" href=""single_product.html"">
                                        <figure> <img class=""first-img"" src=""/client-side/images/products/product-1.jpg"" alt=""html Template""> <img class=""hover-img"" src=""/client-side/images/products/product-1.jpg"" alt=""html Template""></figure>
                                    </a>
                                </div>
        ");
            WriteLiteral(@"                        <div class=""pr-info-area"">
                                    <div class=""pr-button"">
                                        <div class=""mt-button add_to_wishlist""> <a href=""wishlist.html""> <i class=""fa fa-heart""></i> </a> </div>
                                        <div class=""mt-button add_to_compare""> <a href=""compare.html""> <i class=""fa fa-signal""></i> </a> </div>
                                        <div class=""mt-button quick-view""> <a href=""quick_view.html""> <i class=""fa fa-search""></i> </a> </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""item-info"">
                                <div class=""info-inner"">
                                    <div class=""item-title""> <a title=""Product title here"" href=""single_product.html"">Product title here </a> </div>
                                    <div class=""item-content"">
                               ");
            WriteLiteral(@"         <div class=""rating""> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> </div>
                                        <div class=""item-price"">
                                            <div class=""price-box""> <span class=""regular-price""> <span class=""price"">$125.00</span> </span> </div>
                                        </div>
                                        <div class=""pro-action"">
                                            <button type=""button"" class=""add-to-cart""><span> Add to Cart</span> </button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </li>
                <li class=""menu-item depth-1 product menucol-1-3 withimage"">
                    <div class=""product-item"">
             ");
            WriteLiteral(@"           <div class=""item-inner"">
                            <div class=""icon-sale-label sale-left"">Sale</div>
                            <div class=""icon-new-label new-right"">New</div>
                            <div class=""product-thumbnail"">
                                <div class=""icon-sale-label sale-left"">Sale</div>
                                <div class=""pr-img-area"">
                                    <a title=""Product title here"" href=""single_product.html"">
                                        <figure> <img class=""first-img"" src=""/client-side/images/products/product-1.jpg"" alt=""html Template""> <img class=""hover-img"" src=""/client-side/images/products/product-1.jpg"" alt=""html Template""></figure>
                                    </a>
                                </div>
                                <div class=""pr-info-area"">
                                    <div class=""pr-button"">
                                        <div class=""mt-button add_to_wishlist""> <a hr");
            WriteLiteral(@"ef=""wishlist.html""> <i class=""fa fa-heart""></i> </a> </div>
                                        <div class=""mt-button add_to_compare""> <a href=""compare.html""> <i class=""fa fa-signal""></i> </a> </div>
                                        <div class=""mt-button quick-view""> <a href=""quick_view.html""> <i class=""fa fa-search""></i> </a> </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""item-info"">
                                <div class=""info-inner"">
                                    <div class=""item-title""> <a title=""Product title here"" href=""single_product.html"">Product title here </a> </div>
                                    <div class=""item-content"">
                                        <div class=""rating""> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> </div>
               ");
            WriteLiteral(@"                         <div class=""item-price"">
                                            <div class=""price-box""> <span class=""regular-price""> <span class=""price"">$125.00</span> </span> </div>
                                        </div>
                                        <div class=""pro-action"">
                                            <button type=""button"" class=""add-to-cart""><span> Add to Cart</span> </button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </li>
            </ul>
        </li>
        <li><a href=""/contact.html"">Contact</a></li>
    </ul>
</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductCategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
