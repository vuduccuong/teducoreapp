#pragma checksum "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views1\Role\_AssignPermission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afdc13b356761db6e9f362285e9e80e0f2fa9ca6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views1_Role__AssignPermission), @"mvc.1.0.view", @"/Areas/Admin/Views1/Role/_AssignPermission.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views1/Role/_AssignPermission.cshtml", typeof(AspNetCore.Areas_Admin_Views1_Role__AssignPermission))]
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
#line 1 "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views1\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "E:\Đồ án\teducoreapp\TeduCoreApp\Areas\Admin\Views1\_ViewImports.cshtml"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afdc13b356761db6e9f362285e9e80e0f2fa9ca6", @"/Areas/Admin/Views1/Role/_AssignPermission.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a8eda7989b31aeb5783acba621309a633d04d43", @"/Areas/Admin/Views1/_ViewImports.cshtml")]
    public class Areas_Admin_Views1_Role__AssignPermission : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4743, true);
            WriteLiteral(@"<div id=""modal-grantpermission"" class=""bootbox modal fade modal-darkorange in"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""bootbox-close-button close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
                <h4 class=""modal-title"">Assign permission</h4>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-xs-12 col-md-12"">
                        <input type=""hidden"" id=""hidRoleId"" />
                        <table class=""table table-hover tree"" id=""tblFunction"">
                            <thead class=""bordered-darkorange"">
                                <tr>
                                    <th>Function name</th>
                                    <th>
                                        <label>
           ");
            WriteLiteral(@"                                 <input type=""checkbox"" id=""ckCheckAllView"" value=""{{Id}}"">
                                            <span class=""text"">View</span>
                                        </label>
                                    </th>
                                    <th>
                                        <label>
                                            <input type=""checkbox"" id=""ckCheckAllCreate"" value=""{{Id}}"">
                                            <span class=""text"">Create</span>
                                        </label>
                                    </th>
                                    <th>
                                        <label>
                                            <input type=""checkbox"" id=""ckCheckAllEdit"" value=""{{Id}}"">
                                            <span class=""text"">Update</span>
                                        </label>
                                    </th>
                            ");
            WriteLiteral(@"        <th>
                                        <label>
                                            <input type=""checkbox"" id=""ckCheckAllDelete"" value=""{{Id}}"">
                                            <span class=""text"">Delete</span>
                                        </label>
                                    </th>
                                </tr>
                            </thead>
                            <tbody id=""lst-data-function""></tbody>
                        </table>
                        <script id=""result-data-function"" type=""x-tmpl-mustache"">
                            <tr class=""treegrid-{{Id}} {{treegridparent}}"" data-id=""{{Id}}"">
                                <td>{{Name}}</td>
                                <td>
                                    <label>
                                        <input type=""checkbox"" value=""{{Id}}"" class=""ckView"">
                                        <span class=""text"">Allow</span>
                          ");
            WriteLiteral(@"          </label>
                                </td>
                                <td>
                                    <label>
                                        <input type=""checkbox"" value=""{{Id}}"" class=""ckAdd"">
                                        <span class=""text"">Allow</span>
                                    </label>
                                </td>
                                <td>
                                    <label>
                                        <input type=""checkbox"" value=""{{Id}}"" class=""ckEdit"">
                                        <span class=""text"">Allow</span>
                                    </label>
                                </td>
                                <td>
                                    <label>
                                        <input type=""checkbox"" value=""{{Id}}"" class=""ckDelete"">
                                        <span class=""text"">Allow</span>
                                    </lab");
            WriteLiteral(@"el>
                                </td>
                            </tr>
                        </script>
                    </div>
                </div>


            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-sm-offset-2 col-sm-10"">
                        <button type=""button"" id=""btnSavePermission"" class=""btn btn-success"">Save</button>
                        <button type=""button"" data-dismiss=""modal"" class=""btn btn-default"">Close</button>
                    </div>
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
