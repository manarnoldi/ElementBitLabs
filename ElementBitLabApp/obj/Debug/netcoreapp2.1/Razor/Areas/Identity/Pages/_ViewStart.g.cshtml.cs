#pragma checksum "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Areas\Identity\Pages\_ViewStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfe7af0a5f42142042caf2bdbf24aa270ebe063e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ElementBitLabApp.Areas.Identity.Pages.Areas_Identity_Pages__ViewStart), @"mvc.1.0.view", @"/Areas/Identity/Pages/_ViewStart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Pages/_ViewStart.cshtml", typeof(ElementBitLabApp.Areas.Identity.Pages.Areas_Identity_Pages__ViewStart))]
namespace ElementBitLabApp.Areas.Identity.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Areas\Identity\Pages\_ViewImports.cshtml"
using ElementBitLabApp.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Areas\Identity\Pages\_ViewImports.cshtml"
using ElementBitLabApp.Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe7af0a5f42142042caf2bdbf24aa270ebe063e", @"/Areas/Identity/Pages/_ViewStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da9dfbc1f82a9889e2a20a1cc1067e03505512f", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__ViewStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\amwadwaa\documents\visual studio 2017\Projects\ElementBitLabApp\ElementBitLabApp\Areas\Identity\Pages\_ViewStart.cshtml"
  
    if (SignInManager.IsSignedIn(User))
    {
        Layout = "/Views/Shared/_Layout.cshtml";
    }
    else
    {

    }

#line default
#line hidden
            BeginContext(192, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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
