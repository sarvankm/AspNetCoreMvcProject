#pragma checksum "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "811f865e8a115e4db7cc4d676b47c509cb363897"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_TeacherDetails), @"mvc.1.0.view", @"/Views/Teacher/TeacherDetails.cshtml")]
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
#line 1 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\_ViewImports.cshtml"
using AspNetCoreMvcProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\_ViewImports.cshtml"
using AspNetCoreMvcProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"811f865e8a115e4db7cc4d676b47c509cb363897", @"/Views/Teacher/TeacherDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08d22cfd98cafca0c411884ba5eeaa62faee4c0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_TeacherDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://devitems.us11.list-manage.com/subscribe/post?u=6bbb9b6f5827bd842d9640c82&amp;id=05d85f18ef"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mc-embedded-subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("mc-embedded-subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("validate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
  
    ViewData["Title"] = "TeacherDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>teachers / details</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Teacher Start -->
<div class=""teacher-details-area pt-150 pb-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 col-sm-5 col-xs-12"">
                <div class=""teacher-details-img"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "811f865e8a115e4db7cc4d676b47c509cb3638977146", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 879, "~/img/teacher/", 879, 14, true);
#nullable restore
#line 29 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
AddHtmlAttributeValue("", 893, Model.Image, 893, 12, false);

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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-7 col-sm-7 col-xs-12\">\r\n                <div class=\"teacher-details-content ml-50\">\r\n                    <h2>");
#nullable restore
#line 34 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
                   Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h5>");
#nullable restore
#line 35 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
                   Write(Model.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h4>about me</h4>\r\n                    <p>");
#nullable restore
#line 37 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
                  Write(Model.About);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                    <ul>\r\n                        <li><span>degree: </span>");
#nullable restore
#line 39 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
                                            Write(Model.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>experience: </span>");
#nullable restore
#line 40 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
                                                Write(Model.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>hobbies: </span>");
#nullable restore
#line 41 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
                                             Write(Model.Hobbies);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>faculty: </span>");
#nullable restore
#line 42 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
                                             Write(Model.Faculty);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3 col-sm-4"">
                <div class=""teacher-contact"">
                    <h4>contact information</h4>
                    <p><span>mail me : </span>");
#nullable restore
#line 51 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
                                         Write(Model.ContactInfoMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>make a call : </span>");
#nullable restore
#line 52 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
                                             Write(Model.ContactInfoNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>skype : </span> ");
#nullable restore
#line 53 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
                                        Write(Model.ContactInfoSkype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <ul>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2112, "\"", 2137, 1);
#nullable restore
#line 55 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
WriteAttributeValue("", 2119, Model.OwnFacebook, 2119, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2214, "\"", 2240, 1);
#nullable restore
#line 56 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
WriteAttributeValue("", 2221, Model.OwnPinterest, 2221, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-pinterest\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2318, "\"", 2340, 1);
#nullable restore
#line 57 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
WriteAttributeValue("", 2325, Model.OwnVimeo, 2325, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-vimeo\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2414, "\"", 2438, 1);
#nullable restore
#line 58 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
WriteAttributeValue("", 2421, Model.OwnTwitter, 2421, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""zmdi zmdi-twitter""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-9 col-sm-8"">
                <div class=""skill-area"">
                    <h4>skills</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>language</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 3091, "\"", 3240, 11);
            WriteAttributeValue("", 3099, "width:", 3099, 6, true);
#nullable restore
#line 72 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
WriteAttributeValue(" ", 3105, Model.Skills.LanguageSkillPercent, 3106, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3140, "%;", 3140, 2, true);
            WriteAttributeValue(" ", 3142, "visibility:", 3143, 12, true);
            WriteAttributeValue(" ", 3154, "visible;", 3155, 9, true);
            WriteAttributeValue(" ", 3163, "animation-duration:", 3164, 20, true);
            WriteAttributeValue(" ", 3183, "1.5s;", 3184, 6, true);
            WriteAttributeValue(" ", 3189, "animation-delay:", 3190, 17, true);
            WriteAttributeValue(" ", 3206, "1.2s;", 3207, 6, true);
            WriteAttributeValue(" ", 3212, "animation-name:", 3213, 16, true);
            WriteAttributeValue(" ", 3228, "fadeInLeft;", 3229, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 73 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
                                                          Write(Model.Skills.LanguageSkillPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>team leader</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 3866, "\"", 4017, 11);
            WriteAttributeValue("", 3874, "width:", 3874, 6, true);
#nullable restore
#line 82 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
WriteAttributeValue(" ", 3880, Model.Skills.TeamLeaderSkillPercent, 3881, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3917, "%;", 3917, 2, true);
            WriteAttributeValue(" ", 3919, "visibility:", 3920, 12, true);
            WriteAttributeValue(" ", 3931, "visible;", 3932, 9, true);
            WriteAttributeValue(" ", 3940, "animation-duration:", 3941, 20, true);
            WriteAttributeValue(" ", 3960, "1.5s;", 3961, 6, true);
            WriteAttributeValue(" ", 3966, "animation-delay:", 3967, 17, true);
            WriteAttributeValue(" ", 3983, "1.2s;", 3984, 6, true);
            WriteAttributeValue(" ", 3989, "animation-name:", 3990, 16, true);
            WriteAttributeValue(" ", 4005, "fadeInLeft;", 4006, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 83 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
                                                          Write(Model.Skills.TeamLeaderSkillPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>development</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 4645, "\"", 4797, 11);
            WriteAttributeValue("", 4653, "width:", 4653, 6, true);
#nullable restore
#line 92 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
WriteAttributeValue(" ", 4659, Model.Skills.DevelopmentSkillPercent, 4660, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4697, "%;", 4697, 2, true);
            WriteAttributeValue(" ", 4699, "visibility:", 4700, 12, true);
            WriteAttributeValue(" ", 4711, "visible;", 4712, 9, true);
            WriteAttributeValue(" ", 4720, "animation-duration:", 4721, 20, true);
            WriteAttributeValue(" ", 4740, "1.5s;", 4741, 6, true);
            WriteAttributeValue(" ", 4746, "animation-delay:", 4747, 17, true);
            WriteAttributeValue(" ", 4763, "1.2s;", 4764, 6, true);
            WriteAttributeValue(" ", 4769, "animation-name:", 4770, 16, true);
            WriteAttributeValue(" ", 4785, "fadeInLeft;", 4786, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 93 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
                                                          Write(Model.Skills.DevelopmentSkillPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>design</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 5421, "\"", 5568, 11);
            WriteAttributeValue("", 5429, "width:", 5429, 6, true);
#nullable restore
#line 102 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
WriteAttributeValue(" ", 5435, Model.Skills.DesignSkillPercent, 5436, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5468, "%;", 5468, 2, true);
            WriteAttributeValue(" ", 5470, "visibility:", 5471, 12, true);
            WriteAttributeValue(" ", 5482, "visible;", 5483, 9, true);
            WriteAttributeValue(" ", 5491, "animation-duration:", 5492, 20, true);
            WriteAttributeValue(" ", 5511, "1.5s;", 5512, 6, true);
            WriteAttributeValue(" ", 5517, "animation-delay:", 5518, 17, true);
            WriteAttributeValue(" ", 5534, "1.2s;", 5535, 6, true);
            WriteAttributeValue(" ", 5540, "animation-name:", 5541, 16, true);
            WriteAttributeValue(" ", 5556, "fadeInLeft;", 5557, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 103 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
                                                          Write(Model.Skills.DesignSkillPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>innovation</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 6191, "\"", 6342, 11);
            WriteAttributeValue("", 6199, "width:", 6199, 6, true);
#nullable restore
#line 112 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
WriteAttributeValue(" ", 6205, Model.Skills.InnovationSkillPercent, 6206, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6242, "%;", 6242, 2, true);
            WriteAttributeValue(" ", 6244, "visibility:", 6245, 12, true);
            WriteAttributeValue(" ", 6256, "visible;", 6257, 9, true);
            WriteAttributeValue(" ", 6265, "animation-duration:", 6266, 20, true);
            WriteAttributeValue(" ", 6285, "1.5s;", 6286, 6, true);
            WriteAttributeValue(" ", 6291, "animation-delay:", 6292, 17, true);
            WriteAttributeValue(" ", 6308, "1.2s;", 6309, 6, true);
            WriteAttributeValue(" ", 6314, "animation-name:", 6315, 16, true);
            WriteAttributeValue(" ", 6330, "fadeInLeft;", 6331, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 113 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
                                                          Write(Model.Skills.InnovationSkillPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>communication</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 6972, "\"", 7126, 11);
            WriteAttributeValue("", 6980, "width:", 6980, 6, true);
#nullable restore
#line 122 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
WriteAttributeValue(" ", 6986, Model.Skills.CommunicationSkillPercent, 6987, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7026, "%;", 7026, 2, true);
            WriteAttributeValue(" ", 7028, "visibility:", 7029, 12, true);
            WriteAttributeValue(" ", 7040, "visible;", 7041, 9, true);
            WriteAttributeValue(" ", 7049, "animation-duration:", 7050, 20, true);
            WriteAttributeValue(" ", 7069, "1.5s;", 7070, 6, true);
            WriteAttributeValue(" ", 7075, "animation-delay:", 7076, 17, true);
            WriteAttributeValue(" ", 7092, "1.2s;", 7093, 6, true);
            WriteAttributeValue(" ", 7098, "animation-name:", 7099, 16, true);
            WriteAttributeValue(" ", 7114, "fadeInLeft;", 7115, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 123 "C:\Users\IDEAPAD\Desktop\AspNetCoreMvcProject\AspNetCoreMvcProjectVs\AspNetCoreMvcProject\Views\Teacher\TeacherDetails.cshtml"
                                                          Write(Model.Skills.CommunicationSkillPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Teacher End -->
<!-- Subscribe Start -->
<div class=""subscribe-area pt-60 pb-70"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8 col-md-offset-2"">
                <div class=""subscribe-content section-title text-center"">
                    <h2>subscribe our newsletter</h2>
                    <p>I must explain to you how all this mistaken idea </p>
                </div>
                <div class=""newsletter-form mc_embed_signup"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "811f865e8a115e4db7cc4d676b47c509cb36389728480", async() => {
                WriteLiteral("\r\n                        <div id=\"mc_embed_signup_scroll\" class=\"mc-form\">\r\n                            <input type=\"email\"");
                BeginWriteAttribute("value", " value=\"", 8432, "\"", 8440, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""EMAIL"" class=""email"" id=""mce-EMAIL"" placeholder=""Enter your e-mail address"" required>
                            <!-- real people should not fill this in and expect good things - do not remove this or risk form bot signups-->
                            <div class=""mc-news"" aria-hidden=""true""><input type=""text"" name=""b_6bbb9b6f5827bd842d9640c82_05d85f18ef"" tabindex=""-1""");
                BeginWriteAttribute("value", " value=\"", 8823, "\"", 8831, 0);
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                            <button id=\"mc-embedded-subscribe\" class=\"default-btn\" type=\"submit\" name=\"subscribe\"><span>subscribe</span></button>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <!-- mailchimp-alerts Start -->
                    <div class=""mailchimp-alerts"">
                        <div class=""mailchimp-submitting""></div><!-- mailchimp-submitting end -->
                        <div class=""mailchimp-success""></div><!-- mailchimp-success end -->
                        <div class=""mailchimp-error""></div><!-- mailchimp-error end -->
                    </div>
                    <!-- mailchimp-alerts end -->
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Subscribe End -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
