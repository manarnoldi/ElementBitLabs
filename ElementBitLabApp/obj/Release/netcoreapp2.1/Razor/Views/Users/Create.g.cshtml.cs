#pragma checksum "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Views\Users\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c267b89cac047b384b764495bcb2b61307a76608"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Create), @"mvc.1.0.view", @"/Views/Users/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Create.cshtml", typeof(AspNetCore.Views_Users_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c267b89cac047b384b764495bcb2b61307a76608", @"/Views/Users/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2fee70d35305066823981b421c5cb0ae6ee6be6", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 306, true);
            WriteLiteral(@"<div ng-controller=""UserRolesCtrl as ctrl"">
    <section id=""horizontal-form-layouts"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""px-3"">
                            ");
            EndContext();
            BeginContext(306, 6990, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "304aaf905dab4a38a6ee7b1739a4f3a7", async() => {
                BeginContext(348, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(382, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0c198e6e9ff4bddb8f11ee29f9b8bde", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 9 "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Views\Users\Create.cshtml"
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
                BeginContext(442, 6847, true);
                WriteLiteral(@"
                                <div class=""form-body"">
                                    <h4 class=""form-section"">
                                        <i class=""icon-direction""></i>Enter User Details
                                    </h4>
                                    <div class=""row"">
                                        <div class=""col-md-6"">
                                            <div class=""form-group"">
                                                <label class=""label-control"">First Name</label>
                                                <input type=""text"" ng-model=""ctrl.firstName"" class=""form-control"" placeholder=""Enter First Name"" />
                                            </div>
                                        </div>
                                        <div class=""col-md-6"">
                                            <div class=""form-group"">
                                                <label class=""label-control"">Last Name</label>
    ");
                WriteLiteral(@"                                            <input type=""text"" ng-model=""ctrl.lastName"" class=""form-control"" placeholder=""Enter Last Name"" />
                                            </div>
                                        </div>
                                    </div>

                                    <div class=""row"">
                                        <div class=""col-md-6"">
                                            <div class=""form-group"">
                                                <label class=""label-control"">Company Name</label>
                                                <input type=""text"" ng-model=""ctrl.company"" class=""form-control"" placeholder=""Enter Company Name"" />
                                            </div>
                                        </div>
                                        <div class=""col-md-6"">
                                            <div class=""form-group"">
                                                <label class=""la");
                WriteLiteral(@"bel-control"">Country Name</label>
                                                <input type=""text"" ng-model=""ctrl.country"" class=""form-control"" placeholder=""Enter Country Name"" />
                                            </div>
                                        </div>
                                    </div>

                                    <div class=""row"">
                                        <div class=""col-md-6"">
                                            <div class=""form-group"">
                                                <label class=""label-control"">Postal Address</label>
                                                <input type=""text"" ng-model=""ctrl.address"" class=""form-control"" placeholder=""Enter Postal Address"" />
                                            </div>
                                        </div>
                                        <div class=""col-md-6"">
                                            <div class=""form-group"">
                   ");
                WriteLiteral(@"                             <label class=""label-control"">Phone Number</label>
                                                <input type=""text"" ng-model=""ctrl.phoneNumber"" class=""form-control"" placeholder=""Enter Phone Number"" />                                                
                                            </div>
                                        </div>
                                    </div>

                                    <div class=""row"">
                                        <div class=""col-md-12"">
                                            <div class=""form-group"">
                                                <label class=""label-control"">Other Details</label>
                                                <textarea type=""password"" ng-model=""ctrl.description"" class=""form-control"" rows=""2""></textarea>
                                            </div>
                                        </div>
                                    </div>

                ");
                WriteLiteral(@"                    <div class=""row"">
                                        <div class=""col-md-6"">
                                            <div class=""form-group"">
                                                <label class=""label-control"">Email Address</label>
                                                <input type=""email"" ng-model=""ctrl.email"" class=""form-control"" placeholder=""Enter Email Address"" />
                                            </div>
                                        </div>
                                        <div class=""col-md-6"">
                                            <div class=""form-group"">
                                                <label class=""label-control"">Role Name</label>
                                                <select ng-model=""ctrl.roleName"" ng-options=""x.name for x in ctrl.userRoles"" class=""form-control""></select>
                                            </div>
                                        </div>

             ");
                WriteLiteral(@"                       </div>

                                    <div class=""row"">
                                        <div class=""col-md-6"">
                                            <div class=""form-group"">
                                                <label class=""label-control"">Password</label>
                                                <input type=""password"" ng-model=""ctrl.password"" class=""form-control"" />
                                            </div>
                                        </div>
                                        <div class=""col-md-6"">
                                            <div class=""form-group"">
                                                <label class=""label-control"">Confirm Password</label>
                                                <input type=""password"" ng-model=""ctrl.confirmPassword"" class=""form-control"" />
                                            </div>
                                        </div>
                     ");
                WriteLiteral(@"               </div>
                                </div>

                                <div class=""form-actions right"">
                                    <button type=""submit"" ng-disabled=""(!ctrl.firstName || !ctrl.lastName || !ctrl.email || !ctrl.userName || ctrl.password
                                            || !(ctrl.password == ctrl.confirmPassword) || !ctrl.roleName)"" class=""btn btn-success""
                                            ng-click=""ctrl.submitUserDetails()"">
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
            BeginContext(7296, 144, true);
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