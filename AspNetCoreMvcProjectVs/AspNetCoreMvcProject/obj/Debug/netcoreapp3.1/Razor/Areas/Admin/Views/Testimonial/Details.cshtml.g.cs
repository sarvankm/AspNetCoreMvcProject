#pragma checksum "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Areas\Admin\Views\Testimonial\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "632b9f7bc533cbd78a78619629ebac9d01080f92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Testimonial_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Testimonial/Details.cshtml")]
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
#line 1 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Areas\Admin\Views\_ViewImports.cshtml"
using AspNetCoreMvcProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"632b9f7bc533cbd78a78619629ebac9d01080f92", @"/Areas/Admin/Views/Testimonial/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75e18b604114ee7349f60d4f6665ac99c9294696", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Testimonial_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Testimonial>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Areas\Admin\Views\Testimonial\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""table-responsive pt-3"">
        <table class=""table table-bordered table-dark"">
            <thead>
                <tr>
                    <th>
                        Image
                    </th>
                    <th>
                        FullName
                    </th>
                    <th>
                        Description
                    </th>
                    <th>
                        Profession
                    </th>
                    <th>
                        IsDeleted
                    </th>
                </tr>
            </thead>
            <tbody>
                    <tr>
                        <td>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "632b9f7bc533cbd78a78619629ebac9d01080f924483", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 823, "~/img/testimonial/", 823, 18, true);
#nullable restore
#line 31 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Areas\Admin\Views\Testimonial\Details.cshtml"
AddHtmlAttributeValue("", 841, Model.Image, 841, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 34 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Areas\Admin\Views\Testimonial\Details.cshtml"
                       Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 37 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Areas\Admin\Views\Testimonial\Details.cshtml"
                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 40 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Areas\Admin\Views\Testimonial\Details.cshtml"
                       Write(Model.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 43 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Areas\Admin\Views\Testimonial\Details.cshtml"
                       Write(Model.IsDeleted);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Testimonial> Html { get; private set; }
    }
}
#pragma warning restore 1591
