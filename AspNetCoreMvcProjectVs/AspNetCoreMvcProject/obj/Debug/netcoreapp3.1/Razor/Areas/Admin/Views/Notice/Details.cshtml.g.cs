#pragma checksum "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Areas\Admin\Views\Notice\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "211e4d513b8975ae62fa0ac0ead3bb00cdfa4ec0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Notice_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Notice/Details.cshtml")]
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
#nullable restore
#line 2 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Areas\Admin\Views\_ViewImports.cshtml"
using AspNetCoreMvcProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"211e4d513b8975ae62fa0ac0ead3bb00cdfa4ec0", @"/Areas/Admin/Views/Notice/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08d22cfd98cafca0c411884ba5eeaa62faee4c0b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Notice_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Notice>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Areas\Admin\Views\Notice\Details.cshtml"
  
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
                        VideoLink
                    </th>
                    <th>
                        NoticeDate
                    </th>
                    <th>
                        NoticeText
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
#nullable restore
#line 28 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Areas\Admin\Views\Notice\Details.cshtml"
                       Write(Model.VideoLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 31 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Areas\Admin\Views\Notice\Details.cshtml"
                       Write(Model.NoticeDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 34 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Areas\Admin\Views\Notice\Details.cshtml"
                       Write(Model.NoticeText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 37 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Areas\Admin\Views\Notice\Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Notice> Html { get; private set; }
    }
}
#pragma warning restore 1591
