#pragma checksum "D:\Shop\WebAppShopFull\WebApp\Views\Member\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f15cc6e8f087b31de8ad644e386eb406fe2685c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_Index), @"mvc.1.0.view", @"/Views/Member/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Member/Index.cshtml", typeof(AspNetCore.Views_Member_Index))]
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
#line 1 "D:\Shop\WebAppShopFull\WebApp\Views\_ViewImports.cshtml"
using DTO;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f15cc6e8f087b31de8ad644e386eb406fe2685c1", @"/Views/Member/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75616952ad48f557dea3eb4b5ab9331af75af777", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Member>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Shop\WebAppShopFull\WebApp\Views\Member\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewData["Title"] = "Manager Member";

#line default
#line hidden
            BeginContext(101, 229, true);
            WriteLiteral("\r\n<h2>Manager Members</h2>\r\n<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th>Username</th>\r\n            <th>Email</th>\r\n            <th>Manage Roles</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 17 "D:\Shop\WebAppShopFull\WebApp\Views\Member\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(379, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(418, 13, false);
#line 20 "D:\Shop\WebAppShopFull\WebApp\Views\Member\Index.cshtml"
               Write(item.Username);

#line default
#line hidden
            EndContext();
            BeginContext(431, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(459, 10, false);
#line 21 "D:\Shop\WebAppShopFull\WebApp\Views\Member\Index.cshtml"
               Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(469, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 520, "\"", 548, 2);
            WriteAttributeValue("", 527, "/member/role/", 527, 13, true);
#line 23 "D:\Shop\WebAppShopFull\WebApp\Views\Member\Index.cshtml"
WriteAttributeValue("", 540, item.Id, 540, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(549, 61, true);
            WriteLiteral(">Change Roles</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 26 "D:\Shop\WebAppShopFull\WebApp\Views\Member\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(621, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Member>> Html { get; private set; }
    }
}
#pragma warning restore 1591
