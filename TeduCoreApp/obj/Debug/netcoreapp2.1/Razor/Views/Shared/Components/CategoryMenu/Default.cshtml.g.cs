#pragma checksum "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\CategoryMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17d01ce14b82436684ac9554ba69f48ecd1b74ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CategoryMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CategoryMenu_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17d01ce14b82436684ac9554ba69f48ecd1b74ca", @"/Views/Shared/Components/CategoryMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ad63dd39fdc7be8f0a296127d812d582f58e04", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductCategoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(75, 86, true);
            WriteLiteral("<div class=\"navleft-container\">\r\n    <div class=\"mega-menu-title\">\r\n        <h3><span>");
            EndContext();
            BeginContext(162, 26, false);
#line 6 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\CategoryMenu\Default.cshtml"
             Write(Localizer["AllCategories"]);

#line default
#line hidden
            EndContext();
            BeginContext(188, 123, true);
            WriteLiteral("</span></h3>\r\n    </div>\r\n\r\n    <!-- Shop by category -->\r\n    <div class=\"mega-menu-category\">\r\n        <ul class=\"nav\">\r\n");
            EndContext();
#line 12 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\CategoryMenu\Default.cshtml"
             foreach (var item in Model.Where(x => x.ParentId == null))
            {
                if (Model.Any(x => x.ParentId == item.Id))
                {

#line default
#line hidden
            BeginContext(478, 52, true);
            WriteLiteral("                    <li>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 530, "\"", 570, 5);
            WriteAttributeValue("", 537, "/", 537, 1, true);
#line 17 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 538, item.SeoAlias, 538, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 552, "-c.", 552, 3, true);
#line 17 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 555, item.Id, 555, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 565, ".html", 565, 5, true);
            EndWriteAttribute();
            BeginContext(571, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(573, 9, false);
#line 17 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(582, 163, true);
            WriteLiteral("</a>\r\n                        <div class=\"wrap-popup column1\">\r\n                            <div class=\"popup\">\r\n                                <ul class=\"nav\">\r\n");
            EndContext();
#line 21 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                     foreach (var subItem in Model.Where(x => x.ParentId == item.Id))
                                    {

#line default
#line hidden
            BeginContext(887, 46, true);
            WriteLiteral("                                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 933, "\"", 979, 5);
            WriteAttributeValue("", 940, "/", 940, 1, true);
#line 23 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 941, subItem.SeoAlias, 941, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 958, "-c.", 958, 3, true);
#line 23 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 961, subItem.Id, 961, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 974, ".html", 974, 5, true);
            EndWriteAttribute();
            BeginContext(980, 7, true);
            WriteLiteral("><span>");
            EndContext();
            BeginContext(988, 12, false);
#line 23 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                                                                               Write(subItem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1000, 18, true);
            WriteLiteral("</span></a></li>\r\n");
            EndContext();
#line 24 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                    }

#line default
#line hidden
            BeginContext(1057, 134, true);
            WriteLiteral("                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </li>\r\n");
            EndContext();
#line 29 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\CategoryMenu\Default.cshtml"

                }
                else
                {

#line default
#line hidden
            BeginContext(1253, 40, true);
            WriteLiteral("                    <li class=\"nosub\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1293, "\"", 1333, 5);
            WriteAttributeValue("", 1300, "/", 1300, 1, true);
#line 33 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 1301, item.SeoAlias, 1301, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1315, "-c.", 1315, 3, true);
#line 33 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 1318, item.Id, 1318, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1328, ".html", 1328, 5, true);
            EndWriteAttribute();
            BeginContext(1334, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1336, 9, false);
#line 33 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                                                             Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1345, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 34 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Shared\Components\CategoryMenu\Default.cshtml"
                }

            }

#line default
#line hidden
            BeginContext(1392, 33, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
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