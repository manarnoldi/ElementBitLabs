#pragma checksum "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Views\ExcelUploads\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a981fffe500725426a3646fcde82b58e04fe3cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ExcelUploads_Details), @"mvc.1.0.view", @"/Views/ExcelUploads/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ExcelUploads/Details.cshtml", typeof(AspNetCore.Views_ExcelUploads_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a981fffe500725426a3646fcde82b58e04fe3cc", @"/Views/ExcelUploads/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2fee70d35305066823981b421c5cb0ae6ee6be6", @"/Views/_ViewImports.cshtml")]
    public class Views_ExcelUploads_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 634, true);
            WriteLiteral(@"<div ng-controller=""UploadExcelCtrl as ctrl"">
    <div class=""col-md-12 margin-bottom-md"">
        <button class=""btn btn-warning"" ng-click=""ctrl.uploadUpdatedData()"">Submit Table Changes</button>
    </div>
    <div class=""col-md-12 margin-bottom-md"">
        <hot-table datarows=""ctrl.viewData"" 
                   settings=""{
                        licenseKey: 'non-commercial-and-evaluation'
                   }"">
            <hot-column ng-repeat=""column in ctrl.viewDataCols"" title=""column.title"" data=""{{column.data}}"" read-only=""column.readOnly"">
            </hot-column>
        </hot-table>
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