#pragma checksum "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22923fc50cb4cb6fd863a9255e0add3f09494df1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Detail.cshtml", typeof(AspNetCore.Views_Blog_Detail))]
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
#line 1 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/_ViewImports.cshtml"
using QHomeGroup.WebApplication;

#line default
#line hidden
#line 2 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/_ViewImports.cshtml"
using QHomeGroup.WebApplication.Models;

#line default
#line hidden
#line 3 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#line 4 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Http.Features;

#line default
#line hidden
#line 5 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#line 6 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 7 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 8 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 9 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/_ViewImports.cshtml"
using static QHomeGroup.Utilities.Constants.CommonConstants;

#line default
#line hidden
#line 10 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/_ViewImports.cshtml"
using QHomeGroup.Application.Projects.Dtos;

#line default
#line hidden
#line 11 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/_ViewImports.cshtml"
using QHomeGroup.Data.Entities.Projects;

#line default
#line hidden
#line 12 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/_ViewImports.cshtml"
using QHomeGroup.Application.Common.Contacts.Dtos;

#line default
#line hidden
#line 13 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/_ViewImports.cshtml"
using QHomeGroup.Application.Introduce.Dto;

#line default
#line hidden
#line 1 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
using QHomeGroup.Utilities.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22923fc50cb4cb6fd863a9255e0add3f09494df1", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d57de5c8a375405ad25b329fb4ed6a7108ed0edc", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QHomeGroup.Application.Content.Blogs.Dtos.BlogDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
  
    ViewData["Title"] = Model.Name;
    ViewData["Image"] = Model.Thumbnail;
    ViewData["Description"] = Model.Description;

#line default
#line hidden
            BeginContext(224, 199, true);
            WriteLiteral("<div id=\"breacrumb\">\n    <div class=\"container\">\n        <ol class=\"breadcrumb\">\n            <li>\n                <a href=\"/tin-tuc.html\">Tin tức</a>\n            </li>\n            <li class=\"active\">");
            EndContext();
            BeginContext(424, 10, false);
#line 14 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
                          Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(434, 417, true);
            WriteLiteral(@"</li>
        </ol>
    </div>
</div>
<div id=""carousel-id"" class=""carousel slide mg-top-40"" data-ride=""carousel"">
    <ol class=""carousel-indicators"">
        <li data-target=""#carousel-id"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#carousel-id"" data-slide-to=""1"" class=""""></li>
        <li data-target=""#carousel-id"" data-slide-to=""2"" class=""""></li>
    </ol>
    <div class=""carousel-inner"">
");
            EndContext();
#line 25 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
         if (Model.SlideImages.Count > 0)
        {
            

#line default
#line hidden
#line 27 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
             for (var i = 0; i < Model.SlideImages.Count; i++)
            {

                if (i == 0)
                {

#line default
#line hidden
            BeginContext(1027, 176, true);
            WriteLiteral("                    <div class=\"item active\">\n                        <div  style=\"\"></div>\n                        <img alt=\"First slide\" style=\"width: 1920px; height: 650px;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1203, "\"", 1230, 1);
#line 34 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
WriteAttributeValue("", 1209, Model.SlideImages[i], 1209, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1231, 30, true);
            WriteLiteral(">\n\n                    </div>\n");
            EndContext();
#line 37 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1318, 169, true);
            WriteLiteral("                    <div class=\"item\">\n                        <div  style=\"\"></div>\n                        <img alt=\"First slide\" style=\"width: 1920px; height: 650px;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1487, "\"", 1514, 1);
#line 42 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
WriteAttributeValue("", 1493, Model.SlideImages[i], 1493, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1515, 29, true);
            WriteLiteral(">\n                    </div>\n");
            EndContext();
#line 44 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
                }
            }

#line default
#line hidden
#line 45 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1586, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 47 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
         if (Model.SlideVideos.Count > 0)
        {
            

#line default
#line hidden
#line 49 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
             for (var i = 0; i < Model.SlideVideos.Count; i++)
            {

                if (i == 0)
                {

#line default
#line hidden
            BeginContext(1762, 177, true);
            WriteLiteral("                    <div class=\"item active\">\n                        <div class=\"js-player\" style=\"width: 100%; height: 550px\" data-plyr-provider=\"youtube\" data-plyr-embed-id=\"");
            EndContext();
            BeginContext(1940, 57, false);
#line 55 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
                                                                                                                              Write(ClipboardFusionHelper.GetEmbededId(@Model.SlideVideos[i]));

#line default
#line hidden
            EndContext();
            BeginContext(1997, 36, true);
            WriteLiteral("\"></div>\n                    </div>\n");
            EndContext();
#line 57 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2090, 170, true);
            WriteLiteral("                    <div class=\"item\">\n                        <div class=\"js-player\" style=\"width: 100%; height: 550px\" data-plyr-provider=\"youtube\" data-plyr-embed-id=\"");
            EndContext();
            BeginContext(2261, 57, false);
#line 61 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
                                                                                                                              Write(ClipboardFusionHelper.GetEmbededId(@Model.SlideVideos[i]));

#line default
#line hidden
            EndContext();
            BeginContext(2318, 36, true);
            WriteLiteral("\"></div>\n                    </div>\n");
            EndContext();
#line 63 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
                }

            }

#line default
#line hidden
#line 65 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
             
        }

#line default
#line hidden
            BeginContext(2397, 374, true);
            WriteLiteral(@"    </div>
    <a class=""left carousel-control"" href=""#carousel-id"" data-slide=""prev""><span class=""icon-left-control icon-controls""></span></a>
    <a class=""right carousel-control"" href=""#carousel-id"" data-slide=""next""><span class=""icon-right-control icon-controls""></span></a>
</div>
<!-- END -->
<div id=""project-page-detail"" class=""wow fadeInUp"" data-wow-duration=""1s"">
");
            EndContext();
#line 73 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
     foreach (var item in Model.Block)
    {
        if (item.BlockType == BlockType.Text)
        {

#line default
#line hidden
            BeginContext(2872, 105, true);
            WriteLiteral("            <div class=\"container\">\n                <div class=\"sv-intro mg-top-50\">\n                    ");
            EndContext();
            BeginContext(2978, 19, false);
#line 79 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
               Write(Html.Raw(item.Text));

#line default
#line hidden
            EndContext();
            BeginContext(2997, 43, true);
            WriteLiteral("\n                </div>\n            </div>\n");
            EndContext();
#line 82 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
        }
        else if (item.BlockType == BlockType.Image)
        {

#line default
#line hidden
            BeginContext(3112, 68, true);
            WriteLiteral("            <div class=\"img-service mg-top-50\">\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3180, "\"", 3197, 1);
#line 86 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
WriteAttributeValue("", 3186, item.Image, 3186, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3198, 88, true);
            WriteLiteral(" class=\"img-responsive\" alt=\"\" style=\"width: 1920px;height: 655px;\">\n            </div>\n");
            EndContext();
#line 88 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(3319, 142, true);
            WriteLiteral("            <div class=\"container\">\n                <div class=\"row\">\n                    <div class=\"col-xs-12\">\n                        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3461, "\"", 3563, 3);
            WriteAttributeValue("", 3469, "service-item", 3469, 12, true);
            WriteAttributeValue(" ", 3481, "mg-top-50", 3482, 10, true);
#line 94 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
WriteAttributeValue(" ", 3491, item.ImagePosition == ImagePosition.Right ? "service-right-img" : "", 3492, 71, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3564, 211, true);
            WriteLiteral(">\n                            <div class=\"sv-image\">\n                                <div class=\"wrap-img\">\n                                    <div class=\"main-img\">\n                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3775, "\"", 3792, 1);
#line 98 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
WriteAttributeValue("", 3781, item.Image, 3781, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3793, 394, true);
            WriteLiteral(@" class=""img-responsive"" alt="""" style=""width: 570px;height: 400px;"">
                                    </div>
                                </div>
                            </div>
                            <div class=""sv-text"">
                                <div class=""wrap-content"">
                                    <h3 class=""title-head"">
                                        ");
            EndContext();
            BeginContext(4188, 10, false);
#line 105 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
                                   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(4198, 144, true);
            WriteLiteral("\n                                    </h3>\n                                    <div class=\"sv-content\">\n                                        ");
            EndContext();
            BeginContext(4343, 19, false);
#line 108 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
                                   Write(Html.Raw(item.Text));

#line default
#line hidden
            EndContext();
            BeginContext(4362, 219, true);
            WriteLiteral("\n                                    </div>\n                                </div>\n                            </div>\n                        </div>\n\n                    </div>\n                </div>\n            </div>\n");
            EndContext();
#line 117 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(4597, 270, true);
            WriteLiteral(@"</div>
<!-- END -->
<div id=""blog"" class=""wow fadeInUp"" data-wow-duration=""1s"">
    <div class=""container"">
        <div class=""blog-content"">
            <h3 class=""blog-heading"">
                Có thể bạn quan tâm
            </h3>
            <ul class=""list-blog"">
");
            EndContext();
#line 128 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
                 foreach (var item in Model.BlogInterest.Take(6))
                {

#line default
#line hidden
            BeginContext(4951, 51, true);
            WriteLiteral("                    <li>\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5002, "\"", 5025, 1);
#line 131 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
WriteAttributeValue("", 5009, item.LinkDetail, 5009, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5026, 41, true);
            WriteLiteral(" title=\"\"><i class=\"icon-right-open\"></i>");
            EndContext();
            BeginContext(5068, 9, false);
#line 131 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
                                                                                      Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5077, 31, true);
            WriteLiteral("</a>\n                    </li>\n");
            EndContext();
#line 133 "/home/lebatuananh/Documents/Template/TemplateMVC/QHomeGroup/QHomeGroup.WebApplication/Views/Blog/Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(5126, 78, true);
            WriteLiteral("\n            </ul>\n        </div>\n    </div>\n</div>\n<!-- END -->\n<!-- END -->\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5222, 213, true);
                WriteLiteral("\n    <script>\n        const players = Array.from(document.querySelectorAll(\'.js-player\')).map(p => new Plyr(p, {\n            controls: [\'play-large\', \'play\', \'progress\', \'current-time\']\n        }));\n    </script>\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QHomeGroup.Application.Content.Blogs.Dtos.BlogDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
