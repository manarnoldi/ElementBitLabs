#pragma checksum "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Views\ExcelDatas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3f8041f2c65f83f65b4722525576abaeba99b4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ExcelDatas_Index), @"mvc.1.0.view", @"/Views/ExcelDatas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ExcelDatas/Index.cshtml", typeof(AspNetCore.Views_ExcelDatas_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3f8041f2c65f83f65b4722525576abaeba99b4e", @"/Views/ExcelDatas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2fee70d35305066823981b421c5cb0ae6ee6be6", @"/Views/_ViewImports.cshtml")]
    public class Views_ExcelDatas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ElementBitLabApp.ViewModels.DowloadExcelSelectionViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ExcelDatas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LoadUploadedData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(67, 481, true);
            WriteLiteral(@"<section id=""horizontal"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-title-wrap bar-success"">
                        <h4 class=""card-title"">Upload Excel Data</h4>
                    </div>
                </div>
                <div class=""card-body collapse show"">
                    <div class=""card-block card-dashboard"">
                        ");
            EndContext();
            BeginContext(548, 752, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e4ff51fc3e647c4896f88a47d3e1c75", async() => {
                BeginContext(656, 637, true);
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <fieldset class=""form-group"">
                                        <input type=""file"" class=""form-control-file"" name=""file"" required>
                                    </fieldset>
                                </div>
                                <div class=""col-md-3"">
                                    <input type=""submit"" class=""btn btn-success"" value=""Load and Save Data"" />
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1300, 146, true);
            WriteLiteral("\r\n                        <div>\r\n                            <table class=\"table display nowrap table-striped table-bordered scroll-horizontal\">\r\n");
            EndContext();
#line 27 "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Views\ExcelDatas\Index.cshtml"
                                    if (Model.ExcelDatas.Count <= 0)
                                    {

                                    } else {
                                        int maxRow = Model.ExcelDatas.Max(p => p.Row);
                                        int maxCol = Model.ExcelDatas.Max(p => p.Column);

                                            for (int i = 0; i < Model.ExcelDatas.Count; i++)
                                            {
                                                if (Model.ExcelDatas[i].Row == 0 || Model.ExcelDatas[i].Row == 2) { continue; }
                                                if (Model.ExcelDatas[i].Row == 1)
                                                {
                                                    if (Model.ExcelDatas[i].Column == 0)
                                                    {

#line default
#line hidden
            BeginContext(2333, 56, true);
            WriteLiteral("                                                        ");
            EndContext();
            BeginContext(2391, 15, true);
            WriteLiteral("<thead><tr><th>");
            EndContext();
            BeginContext(2407, 25, false);
#line 41 "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Views\ExcelDatas\Index.cshtml"
                                                                    Write(Model.ExcelDatas[i].Value);

#line default
#line hidden
            EndContext();
            BeginContext(2432, 7, true);
            WriteLiteral("</th>\r\n");
            EndContext();
#line 42 "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Views\ExcelDatas\Index.cshtml"
                                                    }
                                                    else if (Model.ExcelDatas[i].Column == maxCol)
                                                    {

#line default
#line hidden
            BeginContext(2649, 56, true);
            WriteLiteral("                                                        ");
            EndContext();
            BeginContext(2707, 4, true);
            WriteLiteral("<th>");
            EndContext();
            BeginContext(2712, 25, false);
#line 45 "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Views\ExcelDatas\Index.cshtml"
                                                         Write(Model.ExcelDatas[i].Value);

#line default
#line hidden
            EndContext();
            BeginContext(2737, 31, true);
            WriteLiteral("</th></tr></thead><tbody><tr>\r\n");
            EndContext();
#line 46 "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Views\ExcelDatas\Index.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
            BeginContext(2936, 56, true);
            WriteLiteral("                                                        ");
            EndContext();
            BeginContext(2994, 4, true);
            WriteLiteral("<th>");
            EndContext();
            BeginContext(2999, 25, false);
#line 49 "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Views\ExcelDatas\Index.cshtml"
                                                         Write(Model.ExcelDatas[i].Value);

#line default
#line hidden
            EndContext();
            BeginContext(3024, 7, true);
            WriteLiteral("</th>\r\n");
            EndContext();
#line 50 "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Views\ExcelDatas\Index.cshtml"
                                                    }
                                                }
                                                else
                                                {
                                                    if (Model.ExcelDatas[i].Column == maxCol)
                                                    {

#line default
#line hidden
            BeginContext(3392, 60, true);
            WriteLiteral("                                                            ");
            EndContext();
            BeginContext(3454, 4, true);
            WriteLiteral("<td>");
            EndContext();
            BeginContext(3459, 25, false);
#line 56 "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Views\ExcelDatas\Index.cshtml"
                                                             Write(Model.ExcelDatas[i].Value);

#line default
#line hidden
            EndContext();
            BeginContext(3484, 12, true);
            WriteLiteral("</td></tr>\r\n");
            EndContext();
#line 57 "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Views\ExcelDatas\Index.cshtml"
                                                            if (Model.ExcelDatas[i].Row != maxRow)
                                                            {

#line default
#line hidden
            BeginContext(3659, 64, true);
            WriteLiteral("                                                                ");
            EndContext();
            BeginContext(3725, 6, true);
            WriteLiteral("<tr>\r\n");
            EndContext();
#line 60 "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Views\ExcelDatas\Index.cshtml"
                                                            }
                                                    }
                                                    else
                                                    {

#line default
#line hidden
            BeginContext(3962, 60, true);
            WriteLiteral("                                                            ");
            EndContext();
            BeginContext(4024, 4, true);
            WriteLiteral("<td>");
            EndContext();
            BeginContext(4029, 25, false);
#line 64 "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Views\ExcelDatas\Index.cshtml"
                                                             Write(Model.ExcelDatas[i].Value);

#line default
#line hidden
            EndContext();
            BeginContext(4054, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 65 "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Views\ExcelDatas\Index.cshtml"
                                                    }
                                                }
                                            }
                                        }
                                    

#line default
#line hidden
            BeginContext(4296, 226, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ElementBitLabApp.ViewModels.DowloadExcelSelectionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
