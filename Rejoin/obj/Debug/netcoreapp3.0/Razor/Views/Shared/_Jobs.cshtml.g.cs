#pragma checksum "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\Shared\_Jobs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7871a526a1bb62859431576ac8ed84097d69957a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Jobs), @"mvc.1.0.view", @"/Views/Shared/_Jobs.cshtml")]
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
#nullable restore
#line 1 "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\_ViewImports.cshtml"
using Rejoin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\_ViewImports.cshtml"
using Rejoin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\_ViewImports.cshtml"
using Rejoin.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\_ViewImports.cshtml"
using Rejoin.Injections;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7871a526a1bb62859431576ac8ed84097d69957a", @"/Views/Shared/_Jobs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31085bcb7515f4e4d54e7915ea9852b8b55c91de", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Jobs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "company", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "job", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\Shared\_Jobs.cshtml"
 foreach (Job item in ViewBag.Jobs)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card overflow-hidden br-0 overflow-hidden\">\r\n        <div class=\"d-md-flex\">\r\n            <div class=\"p-0 m-0 item-card9-img\">\r\n                <div class=\"item-card9-imgs\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7871a526a1bb62859431576ac8ed84097d69957a5889", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 7 "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\Shared\_Jobs.cshtml"
                                                                       WriteLiteral(item.UserId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7871a526a1bb62859431576ac8ed84097d69957a8246", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 364, "~/images/users/", 364, 15, true);
#nullable restore
#line 8 "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\Shared\_Jobs.cshtml"
AddHtmlAttributeValue("", 379, item.user.Image, 379, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""card overflow-hidden  border-0 box-shadow-0 border-left br-0 mb-0"">
                <div class=""card-body pt-0 pt-md-5"">
                    <div class=""item-card9"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7871a526a1bb62859431576ac8ed84097d69957a10153", async() => {
                WriteLiteral("<h4 class=\"font-weight-semibold mt-1\">");
#nullable restore
#line 14 "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\Shared\_Jobs.cshtml"
                                                                                                                                                                                Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\Shared\_Jobs.cshtml"
                                                                       WriteLiteral(item.JobId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\Shared\_Jobs.cshtml"
                                                                                                    WriteLiteral(item.Title);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["data"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["data"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"mt-2 mb-2\">\r\n                            <a href=\"#\" class=\"mr-4\"><span><i class=\"far fa-building text-muted mr-1\"></i> ");
#nullable restore
#line 16 "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\Shared\_Jobs.cshtml"
                                                                                                      Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n                            <a href=\"#\" class=\"mr-4\"><span><i class=\"fa fa-map-marker text-muted mr-1\"></i> ");
#nullable restore
#line 17 "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\Shared\_Jobs.cshtml"
                                                                                                       Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n                            <a href=\"#\" class=\"mr-4\"><span><i class=\"fas fa-dollar-sign text-muted mr-1\"></i> ");
#nullable restore
#line 18 "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\Shared\_Jobs.cshtml"
                                                                                                         Write(item.Salary.ToString("0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</span></a>\r\n                            <a href=\"#\" class=\"mr-4\"><span><i class=\"fas fa-clock text-muted mr-1\"></i> ");
#nullable restore
#line 19 "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\Shared\_Jobs.cshtml"
                                                                                                   Write(item.Jobtype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n                            <a href=\"#\" class=\"mr-4\"><span><i class=\"fa fa-briefcase text-muted mr-1\"></i> ");
#nullable restore
#line 20 "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\Shared\_Jobs.cshtml"
                                                                                                      Write(item.ExpierenceYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Year Exp</span></a>\r\n                        </div>\r\n                        <p class=\"mb-0 leading-tight\">");
#nullable restore
#line 22 "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\Shared\_Jobs.cshtml"
                                                 Write(item.JobDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
                <div class=""card-footer pt-3 pb-3"">
                    <div class=""item-card9-footer d-flex"">
                        <div class=""d-flex align-items-center mb-3 mb-md-0 mt-auto posted"">
                            <div>
                                <a href=""profile.html"" class=""text-muted fs-12 mb-1"">Posted by </a><span class=""ml-1 fs-13""> ");
#nullable restore
#line 29 "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\Shared\_Jobs.cshtml"
                                                                                                                        Write(item.user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <small class=\"d-block text-default\">");
#nullable restore
#line 30 "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\Shared\_Jobs.cshtml"
                                                               Write(item.CreatedAt.ToString("dd MMM yyyy / HH:MM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                            </div>
                        </div>
                        <div class=""ml-auto"">
                            <a href=""jobs.html"" class=""btn btn-primary mt-3 mt-sm-0""> Apply Now</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 41 "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\Shared\_Jobs.cshtml"
}

#line default
#line hidden
#nullable disable
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