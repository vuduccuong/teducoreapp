#pragma checksum "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views1\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3df2fb418f8888ef34cba87c6a6c42091567577f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views1_Shared__LoginPartial), @"mvc.1.0.view", @"/Areas/Admin/Views1/Shared/_LoginPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views1/Shared/_LoginPartial.cshtml", typeof(AspNetCore.Areas_Admin_Views1_Shared__LoginPartial))]
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
#line 1 "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views1\Shared\_LoginPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views1\Shared\_LoginPartial.cshtml"
using TeduCoreApp.Models;

#line default
#line hidden
#line 3 "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views1\_ViewImports.cshtml"
using TeduCoreApp.Models.AccountViewModels;

#line default
#line hidden
#line 4 "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views1\_ViewImports.cshtml"
using TeduCoreApp.Models.ManageViewModels;

#line default
#line hidden
#line 5 "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views1\_ViewImports.cshtml"
using TeduCoreApp.Data.Entities;

#line default
#line hidden
#line 6 "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views1\_ViewImports.cshtml"
using TeduCoreApp.Application.ViewModels.System;

#line default
#line hidden
#line 3 "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views1\Shared\_LoginPartial.cshtml"
using TeduCoreApp.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3df2fb418f8888ef34cba87c6a6c42091567577f", @"/Areas/Admin/Views1/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a8eda7989b31aeb5783acba621309a633d04d43", @"/Areas/Admin/Views1/_ViewImports.cshtml")]
    public class Areas_Admin_Views1_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/Account/Logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logoutForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(96, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(186, 117, true);
            WriteLiteral("\r\n<a href=\"javascript:;\" class=\"user-profile dropdown-toggle\" data-toggle=\"dropdown\" aria-expanded=\"false\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 303, "\"", 341, 1);
#line 9 "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views1\Shared\_LoginPartial.cshtml"
WriteAttributeValue("", 309, User.GetSpecificClaim("Avatar"), 309, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(342, 8, true);
            WriteLiteral(" alt=\"\">");
            EndContext();
            BeginContext(351, 33, false);
#line 9 "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views1\Shared\_LoginPartial.cshtml"
                                                  Write(User.GetSpecificClaim("FullName"));

#line default
#line hidden
            EndContext();
            BeginContext(384, 389, true);
            WriteLiteral(@"
    <span class="" fa fa-angle-down""></span>
</a>
<ul class=""dropdown-menu dropdown-usermenu pull-right"">
    <li><a href=""javascript:;""> Profile</a></li>
    <li>
        <a href=""javascript:;"">
            <span class=""badge bg-red pull-right"">50%</span>
            <span>Settings</span>
        </a>
    </li>
    <li><a href=""javascript:;"">Help</a></li>
    <li>
        ");
            EndContext();
            BeginContext(773, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7584d22e5e4745e29449648f1ae1c03f", async() => {
                BeginContext(861, 106, true);
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-link navbar-btn navbar-link\">Log out</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(974, 22, true);
            WriteLiteral("\r\n    </li>\r\n</ul>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> SignInManager { get; private set; }
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
