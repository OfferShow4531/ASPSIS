#pragma checksum "C:\Users\user\Desktop\SISCLONE\ProjectForSIS\SIS Upload\Views\CommentariesModels\Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f32891e08dd60e17d5d43c4685a702ce1051827"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CommentariesModels_Comments), @"mvc.1.0.view", @"/Views/CommentariesModels/Comments.cshtml")]
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
#line 1 "C:\Users\user\Desktop\SISCLONE\ProjectForSIS\SIS Upload\Views\_ViewImports.cshtml"
using SIS_Upload;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\SISCLONE\ProjectForSIS\SIS Upload\Views\_ViewImports.cshtml"
using SIS_Upload.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f32891e08dd60e17d5d43c4685a702ce1051827", @"/Views/CommentariesModels/Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baae3af3ea3058479717d59de2ebcb1d1ee6fbe2", @"/Views/_ViewImports.cshtml")]
    public class Views_CommentariesModels_Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SIS_Upload.Models.CommentariesModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\Desktop\SISCLONE\ProjectForSIS\SIS Upload\Views\CommentariesModels\Comments.cshtml"
  
    ViewData["Title"] = "Comments";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>СТРАНИЦА ПОЛЬЗОВАТЕЛЕЙ</h1>
<style>
    body {
        background-color: yellow;
        box-shadow: 2px 2px 5px rgb(255, 106, 0);
        font-family:'Times New Roman';
        font-size: 40px;
    }
    p{
        font-size: 70px;
    }
    
</style>
<p>
   Комментариии других пользователей\Включая Ваши комментарии
</p>

<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 28 "C:\Users\user\Desktop\SISCLONE\ProjectForSIS\SIS Upload\Views\CommentariesModels\Comments.cshtml"
           Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\user\Desktop\SISCLONE\ProjectForSIS\SIS Upload\Views\CommentariesModels\Comments.cshtml"
           Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\user\Desktop\SISCLONE\ProjectForSIS\SIS Upload\Views\CommentariesModels\Comments.cshtml"
           Write(Html.DisplayNameFor(model => model.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\user\Desktop\SISCLONE\ProjectForSIS\SIS Upload\Views\CommentariesModels\Comments.cshtml"
           Write(Html.DisplayNameFor(model => model.Reputation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\user\Desktop\SISCLONE\ProjectForSIS\SIS Upload\Views\CommentariesModels\Comments.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\user\Desktop\SISCLONE\ProjectForSIS\SIS Upload\Views\CommentariesModels\Comments.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\user\Desktop\SISCLONE\ProjectForSIS\SIS Upload\Views\CommentariesModels\Comments.cshtml"
               Write(Html.DisplayFor(modelItem => item.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\user\Desktop\SISCLONE\ProjectForSIS\SIS Upload\Views\CommentariesModels\Comments.cshtml"
               Write(Html.DisplayFor(modelItem => item.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\user\Desktop\SISCLONE\ProjectForSIS\SIS Upload\Views\CommentariesModels\Comments.cshtml"
               Write(Html.DisplayFor(modelItem => item.Reputation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 59 "C:\Users\user\Desktop\SISCLONE\ProjectForSIS\SIS Upload\Views\CommentariesModels\Comments.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SIS_Upload.Models.CommentariesModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591