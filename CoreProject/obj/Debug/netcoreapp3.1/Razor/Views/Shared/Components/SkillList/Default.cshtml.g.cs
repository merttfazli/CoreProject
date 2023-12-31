#pragma checksum "C:\CoreProject\CoreProject\CoreProject\Views\Shared\Components\SkillList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83e16e93d9bb86edb6426121cb6ae71465ad6b3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SkillList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SkillList/Default.cshtml")]
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
#line 1 "C:\CoreProject\CoreProject\CoreProject\Views\_ViewImports.cshtml"
using CoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CoreProject\CoreProject\CoreProject\Views\_ViewImports.cshtml"
using CoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\CoreProject\CoreProject\CoreProject\Views\Shared\Components\SkillList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83e16e93d9bb86edb6426121cb6ae71465ad6b3d", @"/Views/Shared/Components/SkillList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eef958cfa2a73942bbe1330b5d72b088dccf54d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SkillList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""section px-3 px-lg-4 pt-5"" id=""skills"">
    <div class=""container-narrow"">
        <div class=""text-center mb-5"">
            <h2 class=""marker marker-center"">Yeteneklerim</h2>
        </div>
        <div class=""text-center"">
            <p class=""mx-auto mb-3"" style=""max-width:600px"">Web Uygulama Geliştirme ve Mobil Uyguluma Geliştirme için gerekli çok sayıda beceriye sahip bir hızlı öğreniciyim. Bu becerileri aşağıda sizinle paylaşıyorum.</p>
        </div>
        <div class=""bg-light p-3"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <!--Çıkan değerleri alfabeye göre sıralar -->
");
#nullable restore
#line 16 "C:\CoreProject\CoreProject\CoreProject\Views\Shared\Components\SkillList\Default.cshtml"
                     foreach (var item in Model.OrderBy(x => x.Title))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"py-1\">\r\n                            <div class=\"d-flex text-small fw-bolder\"><span class=\"me-auto\">");
#nullable restore
#line 19 "C:\CoreProject\CoreProject\CoreProject\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span>");
#nullable restore
#line 19 "C:\CoreProject\CoreProject\CoreProject\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                                              Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span></div>\r\n                            <div class=\"progress my-1\">\r\n                                <div class=\"progress-bar bg-success\" role=\"progressbar\" data-aos=\"zoom-in-right\" data-aos-delay=\"100\" data-aos-anchor=\".skills-section\"");
            BeginWriteAttribute("style", " style=\"", 1215, "\"", 1242, 3);
            WriteAttributeValue("", 1223, "width:", 1223, 6, true);
#nullable restore
#line 21 "C:\CoreProject\CoreProject\CoreProject\Views\Shared\Components\SkillList\Default.cshtml"
WriteAttributeValue(" ", 1229, item.Value, 1230, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1241, "%", 1241, 1, true);
            EndWriteAttribute();
            WriteLiteral(" aria-valuenow=\"90\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 24 "C:\CoreProject\CoreProject\CoreProject\Views\Shared\Components\SkillList\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n          \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; }
    }
}
#pragma warning restore 1591
