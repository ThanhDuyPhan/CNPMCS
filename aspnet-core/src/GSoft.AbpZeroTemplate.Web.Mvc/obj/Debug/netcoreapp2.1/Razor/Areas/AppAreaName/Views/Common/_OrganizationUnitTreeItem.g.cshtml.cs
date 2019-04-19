#pragma checksum "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Common\_OrganizationUnitTreeItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52fe3c0368a41a16f8f86f08f4f44c8b870baf08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_Common__OrganizationUnitTreeItem), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/Common/_OrganizationUnitTreeItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/Common/_OrganizationUnitTreeItem.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_Common__OrganizationUnitTreeItem))]
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
#line 1 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Common\_OrganizationUnitTreeItem.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52fe3c0368a41a16f8f86f08f4f44c8b870baf08", @"/Areas/AppAreaName/Views/Common/_OrganizationUnitTreeItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_Common__OrganizationUnitTreeItem : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<OrganizationUnitTreeItemModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Common\_OrganizationUnitTreeItem.cshtml"
  
    var organizationUnits = Model.EditModel.AllOrganizationUnits.Where(p => p.ParentId == Model.ParentId || (!p.ParentId.HasValue && !Model.ParentId.HasValue)).ToList();
    if (organizationUnits.Any())
    {

#line default
#line hidden
            BeginContext(314, 13, true);
            WriteLiteral("        <ul>\n");
            EndContext();
#line 8 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Common\_OrganizationUnitTreeItem.cshtml"
             foreach (var organizationUnit in organizationUnits)
            {
                var selected = Model.EditModel.MemberedOrganizationUnits.Contains(organizationUnit.Code);

#line default
#line hidden
            BeginContext(512, 19, true);
            WriteLiteral("                <li");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 531, "\"", 556, 1);
#line 11 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Common\_OrganizationUnitTreeItem.cshtml"
WriteAttributeValue("", 536, organizationUnit.Id, 536, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(557, 47, true);
            WriteLiteral(" class=\"jstree-open\" data-jstree=\'{\"selected\": ");
            EndContext();
            BeginContext(605, 29, false);
#line 11 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Common\_OrganizationUnitTreeItem.cshtml"
                                                                                       Write(selected.ToString().ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(634, 24, true);
            WriteLiteral("}\'>\n                    ");
            EndContext();
            BeginContext(659, 28, false);
#line 12 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Common\_OrganizationUnitTreeItem.cshtml"
               Write(organizationUnit.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(687, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(709, 154, false);
#line 13 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Common\_OrganizationUnitTreeItem.cshtml"
               Write(Html.Partial("~/Areas/AppAreaName/Views/Common/_OrganizationUnitTreeItem.cshtml", new OrganizationUnitTreeItemModel(Model.EditModel, organizationUnit.Id)));

#line default
#line hidden
            EndContext();
            BeginContext(863, 23, true);
            WriteLiteral("\n                </li>\n");
            EndContext();
#line 15 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Common\_OrganizationUnitTreeItem.cshtml"
            }

#line default
#line hidden
            BeginContext(900, 14, true);
            WriteLiteral("        </ul>\n");
            EndContext();
#line 17 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Common\_OrganizationUnitTreeItem.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrganizationUnitTreeItemModel> Html { get; private set; }
    }
}
#pragma warning restore 1591