#pragma checksum "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4783eb88db1f612ef6a15bd3944543f9e48c09f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Index), @"mvc.1.0.view", @"/Views/Payment/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Payment/Index.cshtml", typeof(AspNetCore.Views_Payment_Index))]
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
#line 1 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#line 2 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
using GSoft.AbpZeroTemplate.Editions;

#line default
#line hidden
#line 3 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
using GSoft.AbpZeroTemplate.MultiTenancy.Payments;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4783eb88db1f612ef6a15bd3944543f9e48c09f7", @"/Views/Payment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_Index : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<GSoft.AbpZeroTemplate.Web.Models.Payment.PaymentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-src", new global::Microsoft.AspNetCore.Html.HtmlString("/view-resources/Views/Payment/Payment.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-href", new global::Microsoft.AspNetCore.Html.HtmlString("/view-resources/Views/Payment/Payment.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("register-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formPaymentResult"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateScriptSrcTagHelper __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper;
        private global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateLinkHrefTagHelper __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateLinkHrefTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(183, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
  
    Layout = "~/Views/Account/_Layout.cshtml";
    ViewBag.DisableTenantChange = true;

#line default
#line hidden
            BeginContext(276, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(295, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(300, 94, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f59f5af3a7ce405dbf78890abe9f3bc3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper = CreateTagHelper<global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateScriptSrcTagHelper>();
                __tagHelperExecutionContext.Add(__GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 13 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper.AppendVersion = __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion;
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(394, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(397, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(415, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(420, 94, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "79bf8a6ceba94e7cb5256b75ce8eaf72", async() => {
                }
                );
                __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateLinkHrefTagHelper = CreateTagHelper<global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateLinkHrefTagHelper>();
                __tagHelperExecutionContext.Add(__GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateLinkHrefTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(514, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(517, 110, true);
            WriteLiteral("<div class=\"m-login__signin\">\n    <div class=\"m-login__head\">\n        <h3 class=\"m-login__title\">\n            ");
            EndContext();
            BeginContext(628, 16, false);
#line 23 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
       Write(L("PaymentInfo"));

#line default
#line hidden
            EndContext();
            BeginContext(644, 30, true);
            WriteLiteral("\n        </h3>\n    </div>\n    ");
            EndContext();
            BeginContext(674, 3417, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d76027824ceb405dbd3bbe5094d66033", async() => {
                BeginContext(855, 46, true);
                WriteLiteral("\n        <input type=\"hidden\" name=\"EditionId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 901, "\"", 926, 1);
#line 27 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
WriteAttributeValue("", 909, Model.Edition.Id, 909, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(927, 114, true);
                WriteLiteral(" />\n        <input type=\"hidden\" name=\"Gateway\" value=\"\" />\n        <input type=\"hidden\" name=\"EditionPaymentType\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1041, "\"", 1074, 1);
#line 29 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
WriteAttributeValue("", 1049, Model.EditionPaymentType, 1049, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1075, 61, true);
                WriteLiteral(" />\n        <input type=\"hidden\" name=\"SubscriptionStartType\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1136, "\"", 1172, 1);
#line 30 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
WriteAttributeValue("", 1144, Model.SubscriptionStartType, 1144, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1173, 5, true);
                WriteLiteral(" />\n\n");
                EndContext();
#line 32 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
         if (Model.EditionPaymentType == EditionPaymentType.Extend || Model.EditionPaymentType == EditionPaymentType.Upgrade)
        {

#line default
#line hidden
                BeginContext(1314, 49, true);
                WriteLiteral("            <div class=\"hint text-center block\">(");
                EndContext();
                BeginContext(1364, 79, false);
#line 34 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
                                            Write(L(Model.EditionPaymentType + "_Edition_Description", Model.Edition.DisplayName));

#line default
#line hidden
                EndContext();
                BeginContext(1443, 8, true);
                WriteLiteral(")</div>\n");
                EndContext();
#line 35 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
        }
        else
        {

#line default
#line hidden
                BeginContext(1484, 43, true);
                WriteLiteral("            <div class=\"hint text-center\">(");
                EndContext();
                BeginContext(1528, 25, false);
#line 38 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
                                      Write(Model.Edition.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(1553, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1555, 12, false);
#line 38 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
                                                                 Write(L("Edition"));

#line default
#line hidden
                EndContext();
                BeginContext(1567, 8, true);
                WriteLiteral(")</div>\n");
                EndContext();
#line 39 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1585, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 41 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
         if (ViewBag.ErrorMessage != null)
        {

#line default
#line hidden
                BeginContext(1639, 91, true);
                WriteLiteral("            <div class=\"alert alert-danger\">\n                <i class=\"fa fa-warning\"></i> ");
                EndContext();
                BeginContext(1731, 20, false);
#line 44 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
                                         Write(ViewBag.ErrorMessage);

#line default
#line hidden
                EndContext();
                BeginContext(1751, 20, true);
                WriteLiteral("\n            </div>\n");
                EndContext();
#line 46 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1781, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 48 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
         if (Model.IsUpgrading())
        {

#line default
#line hidden
                BeginContext(1826, 182, true);
                WriteLiteral("            <hr class=\"border-green\" />\n            <div class=\"form-actions\">\n                <div class=\"form-group row\">\n                    <label class=\"col-sm-8 control-label\">");
                EndContext();
                BeginContext(2009, 10, false);
#line 53 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
                                                     Write(L("Total"));

#line default
#line hidden
                EndContext();
                BeginContext(2019, 174, true);
                WriteLiteral("</label>\n                    <div class=\"col-sm-4 text-right\">\n                        <p class=\"form-control-static text-bold\" id=\"totalPrice\">\n                            $");
                EndContext();
                BeginContext(2194, 42, false);
#line 56 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
                        Write(Model.AdditionalPrice.Value.ToString("N2"));

#line default
#line hidden
                EndContext();
                BeginContext(2236, 99, true);
                WriteLiteral("\n                        </p>\n                    </div>\n                </div>\n            </div>\n");
                EndContext();
#line 61 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
        }
        else
        {
            if (Model.Edition.MonthlyPrice.HasValue)
            {

#line default
#line hidden
                BeginContext(2435, 254, true);
                WriteLiteral("                <div class=\"form-group\">\n                    <label class=\"m-radio m-radio-outline margin-bottom-0\">\n                        <input class=\"form-control\" type=\"radio\" name=\"PaymentPeriodType\"\n                               data-day-count=\"");
                EndContext();
                BeginContext(2691, 30, false);
#line 69 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
                                           Write((int)PaymentPeriodType.Monthly);

#line default
#line hidden
                EndContext();
                BeginContext(2722, 66, true);
                WriteLiteral("\"\n                               data-payment-period-type-amount=\"");
                EndContext();
                BeginContext(2790, 79, false);
#line 70 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
                                                            Write(Model.Edition.MonthlyPrice.Value.ToString("0.00", CultureInfo.InvariantCulture));

#line default
#line hidden
                EndContext();
                BeginContext(2870, 1, true);
                WriteLiteral("\"");
                EndContext();
                BeginWriteAttribute("value", "\n                               value=\"", 2871, "\"", 2936, 1);
#line 71 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
WriteAttributeValue("", 2910, PaymentPeriodType.Monthly, 2910, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2937, 3, true);
                WriteLiteral(" />");
                EndContext();
                BeginContext(2941, 17, false);
#line 71 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
                                                               Write(L("MonthlyPrice"));

#line default
#line hidden
                EndContext();
                BeginContext(2958, 3, true);
                WriteLiteral(": $");
                EndContext();
                BeginContext(2962, 47, false);
#line 71 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
                                                                                    Write(Model.Edition.MonthlyPrice.Value.ToString("N2"));

#line default
#line hidden
                EndContext();
                BeginContext(3009, 103, true);
                WriteLiteral("\n                            <span></span>\n                        </label>\n                    </div>\n");
                EndContext();
#line 75 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
            }

            if (Model.Edition.AnnualPrice.HasValue)
            {

#line default
#line hidden
                BeginContext(3193, 254, true);
                WriteLiteral("                <div class=\"form-group\">\n                    <label class=\"m-radio m-radio-outline margin-bottom-0\">\n                        <input class=\"form-control\" type=\"radio\" name=\"PaymentPeriodType\"\n                               data-day-count=\"");
                EndContext();
                BeginContext(3449, 29, false);
#line 82 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
                                           Write((int)PaymentPeriodType.Annual);

#line default
#line hidden
                EndContext();
                BeginContext(3479, 66, true);
                WriteLiteral("\"\n                               data-payment-period-type-amount=\"");
                EndContext();
                BeginContext(3547, 78, false);
#line 83 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
                                                            Write(Model.Edition.AnnualPrice.Value.ToString("0.00", CultureInfo.InvariantCulture));

#line default
#line hidden
                EndContext();
                BeginContext(3626, 1, true);
                WriteLiteral("\"");
                EndContext();
                BeginWriteAttribute("value", "\n                               value=\"", 3627, "\"", 3691, 1);
#line 84 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
WriteAttributeValue("", 3666, PaymentPeriodType.Annual, 3666, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3692, 3, true);
                WriteLiteral(" />");
                EndContext();
                BeginContext(3696, 16, false);
#line 84 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
                                                              Write(L("AnnualPrice"));

#line default
#line hidden
                EndContext();
                BeginContext(3712, 3, true);
                WriteLiteral(": $");
                EndContext();
                BeginContext(3716, 46, false);
#line 84 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
                                                                                  Write(Model.Edition.AnnualPrice.Value.ToString("N2"));

#line default
#line hidden
                EndContext();
                BeginContext(3762, 103, true);
                WriteLiteral("\n                            <span></span>\n                        </label>\n                    </div>\n");
                EndContext();
#line 88 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
            }
        }

#line default
#line hidden
                BeginContext(3889, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 91 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
         foreach (var paymentGatewayAdditionalData in Model.Edition.AdditionalData)
        {
            

#line default
#line hidden
                BeginContext(3997, 71, false);
#line 93 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
       Write(Html.Partial("_" + paymentGatewayAdditionalData.Key + ".cshtml", Model));

#line default
#line hidden
                EndContext();
#line 93 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
                                                                                    
        }

#line default
#line hidden
                BeginContext(4079, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
#line 26 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
                                              WriteLiteral(Model.GetFormAction());

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 26 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
                                                                                      WriteLiteral(Model.GetFormPostController());

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 26 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\Index.cshtml"
                                                                                                                                WriteLiteral(Model.GetFormArea());

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-area", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4091, 7, true);
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GSoft.AbpZeroTemplate.Web.Models.Payment.PaymentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591