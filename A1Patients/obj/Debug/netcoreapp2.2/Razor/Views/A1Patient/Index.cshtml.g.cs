#pragma checksum "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9a8f81f5baa1cbd1d9da4cd9dcc4b417ec222eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_A1Patient_Index), @"mvc.1.0.view", @"/Views/A1Patient/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/A1Patient/Index.cshtml", typeof(AspNetCore.Views_A1Patient_Index))]
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
#line 1 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\_ViewImports.cshtml"
using A1Patients;

#line default
#line hidden
#line 2 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\_ViewImports.cshtml"
using A1Patients.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9a8f81f5baa1cbd1d9da4cd9dcc4b417ec222eb", @"/Views/A1Patient/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75dc3a1c43cc13d0d474055c88ae941f17bd9b07", @"/Views/_ViewImports.cshtml")]
    public class Views_A1Patient_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<A1Patients.Models.Patient>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ABPatientDiagnosis", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
  
    ViewData["Title"] = "Patients on File";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(126, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(133, 17, false);
#line 8 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(150, 18, true);
            WriteLiteral("</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(168, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9a8f81f5baa1cbd1d9da4cd9dcc4b417ec222eb5666", async() => {
                BeginContext(191, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(205, 159, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Patient Name\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(365, 43, false);
#line 20 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(408, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(464, 47, false);
#line 23 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(511, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(567, 47, false);
#line 26 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateOfDeath));

#line default
#line hidden
            EndContext();
            BeginContext(614, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(670, 45, false);
#line 29 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(715, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(850, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(910, 246, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9a8f81f5baa1cbd1d9da4cd9dcc4b417ec222eb9473", async() => {
                BeginContext(1062, 43, false);
#line 39 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
                                                                                                                                                                      Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(1105, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(1108, 44, false);
#line 39 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
                                                                                                                                                                                                                    Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-patientId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
                                                                    WriteLiteral(item.PatientId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["patientId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-patientId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["patientId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
                                                                                                          WriteLiteral(item.FirstName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["firstName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-firstName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["firstName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
                                                                                                                                               WriteLiteral(item.LastName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["lastName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-lastName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["lastName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1156, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1224, 42, false);
#line 42 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1266, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 45 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
                      
                        string dateOfBirth = "";
                        if (item.DateOfBirth.HasValue)
                        {
                            dateOfBirth = item.DateOfBirth.Value.ToString("dd MMM yyyy");
                        }
                    

#line default
#line hidden
            BeginContext(1611, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1632, 41, false);
#line 52 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
               Write(Html.DisplayFor(modelItem => dateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(1673, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 55 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
                      
                        string dateOfDeath = "";
                        if (item.DateOfDeath.HasValue)
                        {
                            dateOfDeath = item.DateOfDeath.Value.ToString("dd MMM yyyy");
                        }
                    

#line default
#line hidden
            BeginContext(2018, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2039, 41, false);
#line 62 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
               Write(Html.DisplayFor(modelItem => dateOfDeath));

#line default
#line hidden
            EndContext();
            BeginContext(2080, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2148, 44, false);
#line 65 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(2192, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2259, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9a8f81f5baa1cbd1d9da4cd9dcc4b417ec222eb17587", async() => {
                BeginContext(2311, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
                                           WriteLiteral(item.PatientId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2319, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2343, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9a8f81f5baa1cbd1d9da4cd9dcc4b417ec222eb19988", async() => {
                BeginContext(2398, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
                                              WriteLiteral(item.PatientId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2409, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2433, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9a8f81f5baa1cbd1d9da4cd9dcc4b417ec222eb22395", async() => {
                BeginContext(2487, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
                                             WriteLiteral(item.PatientId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2497, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 73 "C:\Users\marye\Downloads\FatimaFellowship\Final Sponsorship Graphics\A1Patients\A1Patients\Views\A1Patient\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2552, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<A1Patients.Models.Patient>> Html { get; private set; }
    }
}
#pragma warning restore 1591