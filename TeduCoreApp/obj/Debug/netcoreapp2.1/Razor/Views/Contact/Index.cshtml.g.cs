#pragma checksum "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "585d89c21b9b7a0a48ed587f016cfdfc1d257d38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contact/Index.cshtml", typeof(AspNetCore.Views_Contact_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"585d89c21b9b7a0a48ed587f016cfdfc1d257d38", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ad63dd39fdc7be8f0a296127d812d582f58e04", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactPageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/client-app/controllers/contact/index.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control input-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/contact.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(89, 125, true);
                WriteLiteral("\r\n    <script src=\"https://maps.googleapis.com/maps/api/js?key=AIzaSyBn9gaKzspPwRtaABhpdtgZnmnkoAxy3ek\">\r\n    </script>\r\n    ");
                EndContext();
                BeginContext(214, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec044b61fbc243cdb54ebfbd6c5a1269", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 8 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(305, 116, true);
                WriteLiteral("\r\n    <script>\r\n        var contactObj = new ContactController();\r\n        contactObj.initialize();\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(424, 32, true);
            WriteLiteral("<input type=\"hidden\" id=\"hidLng\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 456, "\"", 482, 1);
#line 14 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Contact\Index.cshtml"
WriteAttributeValue("", 464, Model.Contact.Lng, 464, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(483, 37, true);
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"hidLat\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 520, "\"", 546, 1);
#line 15 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Contact\Index.cshtml"
WriteAttributeValue("", 528, Model.Contact.Lat, 528, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(547, 41, true);
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"hidAddress\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 588, "\"", 618, 1);
#line 16 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Contact\Index.cshtml"
WriteAttributeValue("", 596, Model.Contact.Address, 596, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(619, 38, true);
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"hidName\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 657, "\"", 684, 1);
#line 17 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Contact\Index.cshtml"
WriteAttributeValue("", 665, Model.Contact.Name, 665, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(685, 1968, true);
            WriteLiteral(@" />
<!-- Breadcrumbs -->
<div class=""breadcrumbs"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <ul>
                    <li class=""home""> <a title=""Go to Home Page"" href=""index.html"">Home</a><span>&raquo;</span></li>
                    <li><strong>Contact Us</strong></li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- Breadcrumbs End -->
<!-- Main Container -->
<section class=""main-container col1-layout"">
    <div class=""main container"">
        <div class=""row"">
            <section class=""col-main col-sm-12"">
                <div id=""contact"" class=""page-content page-contact"">
                    <div class=""page-title"">
                        <h2>Contact Us</h2>
                    </div>
                    <div id=""message-box-conact"">We're available for new projects</div>
                    <div class=""row"">
                        <div class=""col-xs-12 col-sm-6"" id=""contact_form_ma");
            WriteLiteral(@"p"">
                            <h3 class=""page-subheading"">Let's get in touch</h3>
                            <p>Lorem ipsum dolor sit amet onsectetuer adipiscing elit. Mauris fermentum dictum magna. Sed laoreet aliquam leo. Ut tellus dolor dapibus eget. Mauris tincidunt aliquam lectus sed vestibulum. Vestibulum bibendum suscipit mattis.</p>
                            <br />
                            <ul>
                                <li><i class=""fa fa-circle""></i> Praesent nec tincidunt turpis.</li>
                                <li><i class=""fa fa-circle""></i> Aliquam et nisi risus.&nbsp;Cras ut varius ante.</li>
                                <li><i class=""fa fa-circle""></i> Ut congue gravida dolor, vitae viverra dolor.</li>
                            </ul>
                            <br />
                            <ul class=""store_info"">
                                <li><i class=""fa fa-home""></i>");
            EndContext();
            BeginContext(2654, 21, false);
#line 54 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Contact\Index.cshtml"
                                                         Write(Model.Contact.Address);

#line default
#line hidden
            EndContext();
            BeginContext(2675, 76, true);
            WriteLiteral("</li>\r\n                                <li><i class=\"fa fa-phone\"></i><span>");
            EndContext();
            BeginContext(2752, 19, false);
#line 55 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Contact\Index.cshtml"
                                                                Write(Model.Contact.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(2771, 95, true);
            WriteLiteral("</span></li>\r\n                                <li><i class=\"fa fa-envelope\"></i>Email: <span><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2866, "\"", 2900, 2);
            WriteAttributeValue("", 2873, "mailto:", 2873, 7, true);
#line 56 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Contact\Index.cshtml"
WriteAttributeValue("", 2880, Model.Contact.Email, 2880, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2901, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2903, 19, false);
#line 56 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Contact\Index.cshtml"
                                                                                                                Write(Model.Contact.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2922, 133, true);
            WriteLiteral("</a></span></li>\r\n                            </ul>\r\n                        </div>\r\n                        <div class=\"col-sm-6\">\r\n");
            EndContext();
#line 60 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Contact\Index.cshtml"
                             if (ViewData["Success"] != null)
                            {

                                if ((bool)ViewData["Success"] == true)
                                {

#line default
#line hidden
            BeginContext(3258, 224, true);
            WriteLiteral("                                    <div class=\"alert alert-success\">\r\n                                        Thank you for your feedback. We are going to reply your order soon.\r\n                                    </div>\r\n");
            EndContext();
#line 68 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Contact\Index.cshtml"

                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3592, 229, true);
            WriteLiteral("                                    <div class=\"alert alert-danger\">\r\n                                        Have an error in send feedback progress. Please contact to administrator.\r\n                                    </div>\r\n");
            EndContext();
#line 75 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Contact\Index.cshtml"

                                }


                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3958, 119, true);
            WriteLiteral("                                <div id=\"map\" style=\"width:100%;height:500px;\"></div>\r\n                                ");
            EndContext();
            BeginContext(4077, 1737, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32ee927da1b947998bbe6161acf6eb32", async() => {
                BeginContext(4120, 124, true);
                WriteLiteral("\r\n                                    <h3 class=\"page-subheading\">Make an enquiry</h3>\r\n                                    ");
                EndContext();
                BeginContext(4244, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a87028863c184707960d2d375f983a88", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 85 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4304, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(4343, 23, false);
#line 86 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Contact\Index.cshtml"
                               Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(4366, 248, true);
                WriteLiteral("\r\n                                    <div class=\"contact-form-box\">\r\n                                        <div class=\"form-selector\">\r\n                                            <label>Name</label>\r\n                                            ");
                EndContext();
                BeginContext(4614, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "da22ee708ab94bed9cf58dad157b3da1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 90 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Feedback.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4689, 229, true);
                WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"form-selector\">\r\n                                            <label>Email</label>\r\n                                            ");
                EndContext();
                BeginContext(4918, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e0ff5b2b2fbc4b1cbe41fb5cf7dc090e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 94 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Feedback.Email);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4994, 231, true);
                WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"form-selector\">\r\n                                            <label>Message</label>\r\n                                            ");
                EndContext();
                BeginContext(5225, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2ac6d66613b469d8f0ad7e6b4533da2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 98 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Feedback.Message);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5313, 494, true);
                WriteLiteral(@"
                                        </div>
                                        <div class=""form-selector"">
                                            <button type=""submit"" class=""button""><i class=""icon-paper-plane icons""></i>&nbsp; <span>Send Message</span></button>
                                            &nbsp; <a href=""#"" class=""button"">Clear</a>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5814, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 106 "E:\Đồ án\teducoreapp\TeduCoreApp\Views\Contact\Index.cshtml"

                            }

#line default
#line hidden
            BeginContext(5849, 177, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </section>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Main Container End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactPageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
