#pragma checksum "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views\Bill\_DetailModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "378abdd22ba2d70b6142a21b3c8b483adb5cfabb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Bill__DetailModal), @"mvc.1.0.view", @"/Areas/Admin/Views/Bill/_DetailModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Bill/_DetailModal.cshtml", typeof(AspNetCore.Areas_Admin_Views_Bill__DetailModal))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"378abdd22ba2d70b6142a21b3c8b483adb5cfabb", @"/Areas/Admin/Views/Bill/_DetailModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a8eda7989b31aeb5783acba621309a633d04d43", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Bill__DetailModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 529, true);
            WriteLiteral(@"<div id=""modal-detail"" class=""modal fade in"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog  modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
                <h4 class=""modal-title"">Order detail</h4>
            </div>
            <div class=""modal-body"">
                <div id=""horizontal-form"">
                    ");
            EndContext();
            BeginContext(529, 4579, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2e7fab73c0845b3a2caece85b268692", async() => {
                BeginContext(592, 4509, true);
                WriteLiteral(@"
                        <div class=""form-group"">
                            <input type=""hidden"" id=""hidId"" value=""0"" />
                            <label for=""txtCustomerName"" class=""col-sm-2 control-label "">Customer name</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtCustomerName"" class=""form-control"" id=""txtCustomerName"">
                            </div>
                        </div>

                        <div class=""form-group"">
                            <label for=""txtCustomerAddress"" class=""col-sm-2 control-label "">Address</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtCustomerAddress"" class=""form-control"" id=""txtCustomerAddress"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtCustomerMobile"" class=""col-sm-2 control-label ");
                WriteLiteral(@""">Phone</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtCustomerMobile"" class=""form-control"" id=""txtCustomerMobile"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtCustomerMessage"" class=""col-sm-2 control-label "">Customer message</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtCustomerMessage"" class=""form-control"" id=""txtCustomerMessage"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""col-sm-2 control-label "">Payment method</label>
                            <div class=""col-sm-10"">
                                <select id=""ddlPaymentMethod"" class=""form-control""></select>
                            </div>
                       ");
                WriteLiteral(@" </div>
                        <div class=""form-group"">
                            <label f class=""col-sm-2 control-label "">Bill status</label>
                            <div class=""col-sm-10"">
                                <select id=""ddlBillStatus"" class=""form-control""></select>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""col-sm-2 control-label "">Details</label>
                            <div class=""col-sm-10"">
                                <table class=""table table-bordered"">
                                    <thead>
                                        <tr>
                                            <th>Product Name</th>
                                            <th>Color</th>
                                            <th>Size</th>
                                            <th>Quantity</th>
                                            <td></td>
           ");
                WriteLiteral(@"                             </tr>
                                    </thead>
                                    <tbody id=""tbl-bill-details""></tbody>
                                    <tfoot>
                                        <tr>
                                            <td colspan=""5"">
                                                <button class=""btn btn-xs btn-success"" id=""btnAddDetail"" type=""button"">Add</button>
                                            </td>
                                        </tr>
                                    </tfoot>
                                </table>
                                <script type=""x-tmpl-mustache"" id=""template-table-bill-details"">
                                    <tr data-id=""{{Id}}"">
                                        <td>{{{Products}}}</td>
                                        <td>{{{Colors}}}</td>
                                        <td>{{{Sizes}}}</td>
                                        <td><inp");
                WriteLiteral(@"ut type=""number"" class=""txtQuantity form-control"" value=""{{Quantity}}"" /></td>
                                        <td><button class=""btn btn-xs btn-danger btn-delete-detail"" type=""button""><i class=""fa fa-trash""></i></button></td>
                                    </tr>
                                </script>
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
            BeginContext(5108, 823, true);
            WriteLiteral(@"
                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""col-sm-offset-2 col-sm-10"">
                    <button type=""button"" id=""btnSave"" class=""btn btn-success"">Save</button>
                    <button type=""button"" id=""btnConfirm"" class=""btn btn-success"">Confirm payment</button>
                    <button type=""button"" id=""btnPending"" class=""btn btn-warning"">Pending</button>
                    <button type=""button"" id=""btnCancel"" class=""btn btn-primary"">Cancel</button>
                    <button type=""button"" id=""btnExport"" class=""btn btn-default"">Export</button>

                    <button type=""button"" data-dismiss=""modal"" class=""btn btn-danger"">Close</button>
                </div>
            </div>
        </div>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
