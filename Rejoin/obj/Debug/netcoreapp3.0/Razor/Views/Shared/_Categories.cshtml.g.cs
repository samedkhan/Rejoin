#pragma checksum "C:\Users\SAMED\source\repos\Rejoin\Rejoin\Views\Shared\_Categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4904038812cc57a53ed999c63e4a33574362b745"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Categories), @"mvc.1.0.view", @"/Views/Shared/_Categories.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4904038812cc57a53ed999c63e4a33574362b745", @"/Views/Shared/_Categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31085bcb7515f4e4d54e7915ea9852b8b55c91de", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "find", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "job", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-xl-3 col-lg-4 col-md-12\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <div class=\"input-group\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4904038812cc57a53ed999c63e4a33574362b7454963", async() => {
                WriteLiteral(@"
                    <input type=""text"" name=""Title"" class=""form-control br-tl-3 br-bl-3"" placeholder=""Search by Title"">
                    <div class=""input-group-append "">
                        <button type=""submit"" class=""btn btn-primary br-tr-3 br-br-3"">
                            Search
                        </button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            <h3 class=\"card-title\">Categories</h3>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4904038812cc57a53ed999c63e4a33574362b7457476", async() => {
                WriteLiteral("\r\n            <div class=\"card-body\">\r\n                <div");
                BeginWriteAttribute("class", " class=\"", 918, "\"", 926, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""container"">
                    <div class=""filter-product-checkboxs"">
                        <div class=""form-group"">
                            <label class=""custom-control custom-checkbox mb-3"">
                                <input type=""radio"" class=""custom-control-input"" name=""Category"" value=""Administrator"">
                                <span class=""custom-control-label"">
                                    <a href=""#"" class=""text-dark"">Administrator</a>
                                </span>
                            </label>
                        </div>
                        <div class=""form-group"">
                            <label class=""custom-control custom-checkbox mb-3"">
                                <input type=""radio"" class=""custom-control-input"" name=""Category"" value=""Chef"">
                                <span class=""custom-control-label"">
                                    <a href=""#"" class=""text-dark"">Chef</a>
                                </span>
");
                WriteLiteral(@"                            </label>
                        </div>
                        <div class=""form-group"">
                            <label class=""custom-control custom-checkbox mb-3"">
                                <input type=""radio"" class=""custom-control-input"" name=""Category"" value=""IT Technologies"">
                                <span class=""custom-control-label"">
                                    <a href=""#"" class=""text-dark"">IT Technologies</a>
                                </span>
                            </label>
                        </div>
                        <div class=""form-group"">
                            <label class=""custom-control custom-checkbox mb-3"">
                                <input type=""radio"" asp-route-data=""Driver"" class=""custom-control-input"" name=""Category"" value=""Driver"">
                                <span class=""custom-control-label"">
                                    <a href=""#"" class=""text-dark"">Driver</a>
                 ");
                WriteLiteral(@"               </span>
                            </label>
                        </div>
                        <div class=""form-group"">
                            <label class=""custom-control custom-checkbox mb-3"">
                                <input type=""radio"" class=""custom-control-input"" name=""Category"" value=""Sales"">
                                <span class=""custom-control-label"">
                                    <a href=""#"" class=""text-dark"">Sales</a>
                                </span>
                            </label>
                        </div>
                        <div class=""form-group"">
                            <label class=""custom-control custom-checkbox mb-3"">
                                <input type=""radio"" class=""custom-control-input"" name=""Category"" value=""Teachers/Lecturers"">
                                <span class=""custom-control-label"">
                                    <a href=""#"" class=""text-dark"">Teachers/Lecturers</a>
             ");
                WriteLiteral(@"                   </span>
                            </label>
                        </div>
                        <div class=""form-group"">
                            <label class=""custom-control custom-checkbox mb-3"">
                                <input type=""radio"" class=""custom-control-input"" name=""Category"" value=""Life Insurance"">
                                <span class=""custom-control-label"">
                                    <a href=""#"" class=""text-dark"">Life Insurance</a>
                                </span>
                            </label>
                        </div>
                    </div>

                </div>
            </div>
            <div class=""card-footer"">
                <button type=""submit"" class=""btn btn-warning btn-block"">Apply Filter</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</div>");
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
