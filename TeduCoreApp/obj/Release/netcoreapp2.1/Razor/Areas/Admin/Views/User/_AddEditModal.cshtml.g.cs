#pragma checksum "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views\User\_AddEditModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83ed8935cbc704cca84e8760f4bec662ebc66dab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User__AddEditModal), @"mvc.1.0.view", @"/Areas/Admin/Views/User/_AddEditModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/User/_AddEditModal.cshtml", typeof(AspNetCore.Areas_Admin_Views_User__AddEditModal))]
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
#line 1 "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views\_ViewImports.cshtml"
using TeduCoreApp.Models;

#line default
#line hidden
#line 3 "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views\_ViewImports.cshtml"
using TeduCoreApp.Models.AccountViewModels;

#line default
#line hidden
#line 4 "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views\_ViewImports.cshtml"
using TeduCoreApp.Models.ManageViewModels;

#line default
#line hidden
#line 5 "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views\_ViewImports.cshtml"
using TeduCoreApp.Data.Entities;

#line default
#line hidden
#line 6 "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views\_ViewImports.cshtml"
using TeduCoreApp.Application.ViewModels.System;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83ed8935cbc704cca84e8760f4bec662ebc66dab", @"/Areas/Admin/Views/User/_AddEditModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a8eda7989b31aeb5783acba621309a633d04d43", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User__AddEditModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmMaintainance"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 522, true);
            WriteLiteral(@"<div id=""modal-add-edit"" class=""modal fade in"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
                <h4 class=""modal-title"">Add/edit user</h4>
            </div>
            <div class=""modal-body"">
                <div id=""horizontal-form"">
                    ");
            EndContext();
            BeginContext(522, 3749, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3d19f5584af470b99d7c839024d4ef9", async() => {
                BeginContext(585, 3679, true);
                WriteLiteral(@"

                        <div class=""form-group"">
                            <input type=""hidden"" id=""hidId"" value="""" />
                            <label for=""txtFullName"" class=""col-sm-2 control-label"">Full name</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtFullName"" class=""form-control"" id=""txtFullName"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtUserName"" class=""col-sm-2 control-label"">Username</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtUserName"" class=""form-control"" id=""txtUserName"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtPassword"" class=""col-sm-2 control-label"">Password</label>
                          ");
                WriteLiteral(@"  <div class=""col-sm-10"">
                                <input type=""password"" name=""txtPassword"" class=""form-control"" id=""txtPassword"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtConfirmPassword"" class=""col-sm-2 control-label"">Confirm password</label>
                            <div class=""col-sm-10"">
                                <input type=""password"" name=""txtConfirmPassword"" class=""form-control"" id=""txtConfirmPassword"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtEmail"" class=""col-sm-2 control-label "">Email</label>
                            <div class=""col-sm-10"">
                                <input type=""email"" name=""txtEmail"" class=""form-control"" id=""txtEmail"">
                            </div>
                        </div>
                        ");
                WriteLiteral(@"<div class=""form-group"">
                            <label for=""txtPhoneNumber"" class=""col-sm-2 control-label"">Mobile phone</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtPhoneNumber"" class=""form-control"" id=""txtPhoneNumber"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""col-sm-2 control-label"">Roles</label>
                            <div class=""col-sm-10"" id=""list-roles"">

                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-sm-offset-2 col-sm-10"">
                                <div class=""checkbox"">
                                    <label>
                                        <input type=""checkbox"" checked=""checked"" id=""ckStatus"">
                                        <span class=""text"">Active");
                WriteLiteral(@".</span>
                                    </label>
                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-sm-offset-2 col-sm-10"">
                                <button type=""button"" id=""btnSave"" class=""btn btn-success"">Save</button>
                                <button type=""button"" id=""btnCancel"" data-dismiss=""modal"" class=""btn btn-default"">Close</button>
                            </div>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4271, 80, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591