#pragma checksum "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Cart\_BillMail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d69f6a9f79d9e7f47548eb48792b634cf79897a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart__BillMail), @"mvc.1.0.view", @"/Views/Cart/_BillMail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/_BillMail.cshtml", typeof(AspNetCore.Views_Cart__BillMail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d69f6a9f79d9e7f47548eb48792b634cf79897a", @"/Views/Cart/_BillMail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ad63dd39fdc7be8f0a296127d812d582f58e04", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart__BillMail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BillViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 93, true);
            WriteLiteral("<h1>Panda Shop new bill</h1>\r\n<table>\r\n    <tr>\r\n        <td>Customer Name</td>\r\n        <td>");
            EndContext();
            BeginContext(116, 18, false);
#line 6 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Cart\_BillMail.cshtml"
       Write(Model.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(134, 66, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Address</td>\r\n        <td>");
            EndContext();
            BeginContext(201, 21, false);
#line 10 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Cart\_BillMail.cshtml"
       Write(Model.CustomerAddress);

#line default
#line hidden
            EndContext();
            BeginContext(222, 64, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Phone</td>\r\n        <td>");
            EndContext();
            BeginContext(287, 20, false);
#line 14 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Cart\_BillMail.cshtml"
       Write(Model.CustomerMobile);

#line default
#line hidden
            EndContext();
            BeginContext(307, 63, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Date</td>\r\n        <td>");
            EndContext();
            BeginContext(371, 46, false);
#line 18 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Cart\_BillMail.cshtml"
       Write(Model.DateCreated.ToString("dd/MM/yyyy hh:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(417, 383, true);
            WriteLiteral(@"</td>
    </tr>
    <tr>
        <td>Details</td>
        <td>
            <table>
                <thead>
                    <tr>
                        <th>Product</th>
                        <th>Quantity</th>
                        <th>Price</th>
                        <th>Total</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 33 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Cart\_BillMail.cshtml"
                     foreach (var item in Model.BillDetails)
                    {

#line default
#line hidden
            BeginContext(885, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(948, 17, false);
#line 36 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Cart\_BillMail.cshtml"
                           Write(item.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(965, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1005, 13, false);
#line 37 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Cart\_BillMail.cshtml"
                           Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1018, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1058, 10, false);
#line 38 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Cart\_BillMail.cshtml"
                           Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1068, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1109, 43, false);
#line 39 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Cart\_BillMail.cshtml"
                            Write((item.Quantity * item.Price).ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 41 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Cart\_BillMail.cshtml"
                    }

#line default
#line hidden
            BeginContext(1214, 154, true);
            WriteLiteral("                </tbody>\r\n                <tfoot>\r\n                    <tr>\r\n                        <td colspan=\"5\">\r\n                            Total: ");
            EndContext();
            BeginContext(1369, 63, false);
#line 46 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Cart\_BillMail.cshtml"
                              Write(Model.BillDetails.Sum(x => x.Quantity * x.Price).ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(1432, 142, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                </tfoot>\r\n            </table>\r\n        </td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BillViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
