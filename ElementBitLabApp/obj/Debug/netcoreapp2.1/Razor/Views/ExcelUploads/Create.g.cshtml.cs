#pragma checksum "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Views\ExcelUploads\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc6d8afb4457a7d8ad64b8cc301eaa3be44700b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ExcelUploads_Create), @"mvc.1.0.view", @"/Views/ExcelUploads/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ExcelUploads/Create.cshtml", typeof(AspNetCore.Views_ExcelUploads_Create))]
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
#line 1 "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Views\_ViewImports.cshtml"
using ElementBitLabApp;

#line default
#line hidden
#line 2 "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Views\_ViewImports.cshtml"
using ElementBitLabApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc6d8afb4457a7d8ad64b8cc301eaa3be44700b2", @"/Views/ExcelUploads/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2fee70d35305066823981b421c5cb0ae6ee6be6", @"/Views/_ViewImports.cshtml")]
    public class Views_ExcelUploads_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("frm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 308, true);
            WriteLiteral(@"<div ng-controller=""UploadExcelCtrl as ctrl"">
    <section id=""horizontal-form-layouts"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""px-3"">
                            ");
            EndContext();
            BeginContext(308, 4225, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe33210e718d45599f3dbc817ddc2019", async() => {
                BeginContext(350, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(384, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "730e4125ac5e40c18ef120b309fa2a6c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 9 "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Views\ExcelUploads\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(444, 4082, true);
                WriteLiteral(@"
                                <div class=""form-body"">
                                    <h4 class=""form-section"">
                                        <i class=""icon-direction""></i>Select Excel Details
                                    </h4>
                                    <div class=""row"">
                                        <div class=""col-md-6"">
                                            <div class=""form-group"">
                                                <label class=""label-control"">Client Name</label>
                                                <select class=""form-control"" ng-change=""ctrl.loadProjects()"" ng-model=""ctrl.client"" ng-options=""x.clientName for x in ctrl.clients""></select>
                                            </div>
                                        </div>
                                        <div class=""col-md-6"">
                                            <div class=""form-group"">
                                                <label ");
                WriteLiteral(@"class=""label-control"">Project Name</label>
                                                <select class=""form-control"" ng-change=""ctrl.loadBuildings()"" ng-model=""ctrl.project"" ng-options=""x.projectName for x in ctrl.projects""></select>
                                            </div>
                                        </div>
                                    </div>

                                    <div class=""row"">
                                        <div class=""col-md-6"">
                                            <div class=""form-group"">
                                                <label class=""label-control"">Building Name</label>
                                                <select class=""form-control"" ng-model=""ctrl.building"" ng-options=""x.buildingName for x in ctrl.buildings""></select>
                                            </div>
                                        </div>
                                        <div class=""col-md-6"">
                     ");
                WriteLiteral(@"                       <div class=""form-group"">
                                                <label class=""label-control"">Discipline</label>
                                                <select class=""form-control"" ng-model=""ctrl.discipline"" ng-options=""x.disciplineName for x in ctrl.disciplines""></select>
                                            </div>
                                        </div>
                                    </div>

                                    <div class=""row"">
                                        <div class=""col-md-6"">
                                            <div class=""form-group"">
                                                <label>Select File To Upload</label>
                                                <input type=""file"" ngf-select=""ctrl.SelectFile($file)"" multiple=""false"" class=""form-control-file"">
                                            </div>
                                        </div>
                                      ");
                WriteLiteral(@"  <div class=""col-md-6"">
                                            <div class=""form-group"">
                                                <label class=""label-control"">Excel Name</label>
                                                <input class=""form-control"" ng-model=""ctrl.ExcelName"" placeholder=""Input Excel Name"" />
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div class=""form-actions right"">
                                    <button type=""submit"" ng-disabled=""(!ctrl.ExcelName || !ctrl.building || !ctrl.discipline)"" class=""btn btn-success""
                                            ng-click=""ctrl.submitFile()"">
                                        <i class=""icon-note""></i> Upload Excel File
                                    </button>
                                </div>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4533, 144, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>");
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
