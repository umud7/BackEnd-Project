#pragma checksum "C:\Users\user\source\repos\BackEnd Project\BackEnd Project\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eddbfbbcb112c227e513f90c0d5fcec8ec21de16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Detail), @"mvc.1.0.view", @"/Views/Teacher/Detail.cshtml")]
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
#line 1 "C:\Users\user\source\repos\BackEnd Project\BackEnd Project\Views\_ViewImports.cshtml"
using BackEnd_Project.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\BackEnd Project\BackEnd Project\Views\_ViewImports.cshtml"
using BackEnd_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\BackEnd Project\BackEnd Project\Views\_ViewImports.cshtml"
using BackendProject.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eddbfbbcb112c227e513f90c0d5fcec8ec21de16", @"/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e72e5e6c6b1d3b4f22a5c3844c5aa8ee926014dc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\user\source\repos\BackEnd Project\BackEnd Project\Views\Teacher\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eddbfbbcb112c227e513f90c0d5fcec8ec21de164814", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 918, "~/img/teacher/", 918, 14, true);
#nullable restore
#line 30 "C:\Users\user\source\repos\BackEnd Project\BackEnd Project\Views\Teacher\Detail.cshtml"
AddHtmlAttributeValue("", 932, Model.ImageUrl, 932, 15, false);

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
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-md-7 col-sm-7 col-xs-12"">
                <div class=""teacher-details-content ml-50"">
                    <h2>STUART KELVIN</h2>
                    <h5>Associate Professor</h5>
                    <h4>about me</h4>
                    <p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas </p>
                    <ul>
                        <li><span>degree: </span>");
#nullable restore
#line 40 "C:\Users\user\source\repos\BackEnd Project\BackEnd Project\Views\Teacher\Detail.cshtml"
                                            Write(Model.TeacherDetail.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>experience: </span>");
#nullable restore
#line 41 "C:\Users\user\source\repos\BackEnd Project\BackEnd Project\Views\Teacher\Detail.cshtml"
                                                Write(Model.TeacherDetail.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>hobbies: </span>");
#nullable restore
#line 42 "C:\Users\user\source\repos\BackEnd Project\BackEnd Project\Views\Teacher\Detail.cshtml"
                                             Write(Model.TeacherDetail.Hobby);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>faculty: </span>");
#nullable restore
#line 43 "C:\Users\user\source\repos\BackEnd Project\BackEnd Project\Views\Teacher\Detail.cshtml"
                                             Write(Model.TeacherDetail.Faculty);

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
#line 52 "C:\Users\user\source\repos\BackEnd Project\BackEnd Project\Views\Teacher\Detail.cshtml"
                                         Write(Model.TeacherDetail.MailMe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>make a call : </span>");
#nullable restore
#line 53 "C:\Users\user\source\repos\BackEnd Project\BackEnd Project\Views\Teacher\Detail.cshtml"
                                             Write(Model.TeacherDetail.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>skype : </span>");
#nullable restore
#line 54 "C:\Users\user\source\repos\BackEnd Project\BackEnd Project\Views\Teacher\Detail.cshtml"
                                       Write(Model.TeacherDetail.SkypeLink);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/p>
                    <ul>
                        <li><a href=""https://www.facebook.com/devitems/?ref=bookmarks""><i class=""zmdi zmdi-facebook""></i></a></li>
                        <li><a href=""https://www.pinterest.com/devitemsllc/""><i class=""zmdi zmdi-pinterest""></i></a></li>
                        <li><a href=""#""><i class=""zmdi zmdi-vimeo""></i></a></li>
                        <li><a href=""https://twitter.com/devitemsllc""><i class=""zmdi zmdi-twitter""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-9 col-sm-8"">
                <div class=""skill-area"">
                    <h4>");
#nullable restore
#line 65 "C:\Users\user\source\repos\BackEnd Project\BackEnd Project\Views\Teacher\Detail.cshtml"
                   Write(Model.TeacherDetail.TeacherSkill);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>language</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 85%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
#nullable restore
#line 74 "C:\Users\user\source\repos\BackEnd Project\BackEnd Project\Views\Teacher\Detail.cshtml"
                                                          Write(Model.TeacherDetail.TeacherSkill.Language);

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
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 90%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
#nullable restore
#line 84 "C:\Users\user\source\repos\BackEnd Project\BackEnd Project\Views\Teacher\Detail.cshtml"
                                                          Write(Model.TeacherDetail.TeacherSkill.TeamLeader);

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
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 85%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
#nullable restore
#line 94 "C:\Users\user\source\repos\BackEnd Project\BackEnd Project\Views\Teacher\Detail.cshtml"
                                                          Write(Model.TeacherDetail.TeacherSkill.Development);

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
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 95%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
#nullable restore
#line 104 "C:\Users\user\source\repos\BackEnd Project\BackEnd Project\Views\Teacher\Detail.cshtml"
                                                          Write(Model.TeacherDetail.TeacherSkill.Design);

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
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 85%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
#nullable restore
#line 114 "C:\Users\user\source\repos\BackEnd Project\BackEnd Project\Views\Teacher\Detail.cshtml"
                                                          Write(Model.TeacherDetail.TeacherSkill.Innovation);

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
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 95%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
#nullable restore
#line 124 "C:\Users\user\source\repos\BackEnd Project\BackEnd Project\Views\Teacher\Detail.cshtml"
                                                          Write(Model.TeacherDetail.TeacherSkill.Communication);

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
<!-- Teacher End -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
