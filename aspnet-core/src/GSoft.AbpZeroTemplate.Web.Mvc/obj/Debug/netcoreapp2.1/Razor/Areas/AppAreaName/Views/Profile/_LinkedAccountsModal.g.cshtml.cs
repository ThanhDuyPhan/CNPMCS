#pragma checksum "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_LinkedAccountsModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0691b5eb8d2352e6e613a0ccbb100fd2069b6242"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_Profile__LinkedAccountsModal), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/Profile/_LinkedAccountsModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/Profile/_LinkedAccountsModal.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_Profile__LinkedAccountsModal))]
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
#line 1 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0691b5eb8d2352e6e613a0ccbb100fd2069b6242", @"/Areas/AppAreaName/Views/Profile/_LinkedAccountsModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_Profile__LinkedAccountsModal : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 70, true);
            WriteLiteral("<div class=\"modal-header\">\n    <h4 class=\"modal-title\">\n        <span>");
            EndContext();
            BeginContext(71, 19, false);
#line 3 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_LinkedAccountsModal.cshtml"
         Write(L("LinkedAccounts"));

#line default
#line hidden
            EndContext();
            BeginContext(90, 117, true);
            WriteLiteral("</span>\n    </h4>\n    <button id=\"LinkNewAccountButton\" class=\"btn btn-primary pull-right\"><i class=\"la la-plus\"></i>");
            EndContext();
            BeginContext(208, 19, false);
#line 5 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_LinkedAccountsModal.cshtml"
                                                                                              Write(L("LinkNewAccount"));

#line default
#line hidden
            EndContext();
            BeginContext(227, 208, true);
            WriteLiteral("</button>\n</div>\n<div class=\"modal-body\">\n    <table id=\"LinkedAccountsTable\" class=\"display table table-striped table-bordered table-hover dt-responsive nowrap\">\n        <thead>\n        <tr>\n            <th>");
            EndContext();
            BeginContext(436, 12, false);
#line 11 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_LinkedAccountsModal.cshtml"
           Write(L("Actions"));

#line default
#line hidden
            EndContext();
            BeginContext(448, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(471, 13, false);
#line 12 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_LinkedAccountsModal.cshtml"
           Write(L("UserName"));

#line default
#line hidden
            EndContext();
            BeginContext(484, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(507, 11, false);
#line 13 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_LinkedAccountsModal.cshtml"
           Write(L("Delete"));

#line default
#line hidden
            EndContext();
            BeginContext(518, 162, true);
            WriteLiteral("</th>\n        </tr>\n        </thead>\n    </table>\n</div>\n<div class=\"modal-footer\">\n    <button type=\"button\" class=\"btn default pull-right\" data-dismiss=\"modal\">");
            EndContext();
            BeginContext(681, 10, false);
#line 19 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_LinkedAccountsModal.cshtml"
                                                                         Write(L("Close"));

#line default
#line hidden
            EndContext();
            BeginContext(691, 16, true);
            WriteLiteral("</button>\n</div>");
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
