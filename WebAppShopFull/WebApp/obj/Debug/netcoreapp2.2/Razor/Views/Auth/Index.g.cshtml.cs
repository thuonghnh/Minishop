#pragma checksum "D:\Shop\WebAppShopFull\WebApp\Views\Auth\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a93ccd19a939d6bdf0d64d9660bd7a4a132b47c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Index), @"mvc.1.0.view", @"/Views/Auth/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Auth/Index.cshtml", typeof(AspNetCore.Views_Auth_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a93ccd19a939d6bdf0d64d9660bd7a4a132b47c1", @"/Views/Auth/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75616952ad48f557dea3eb4b5ab9331af75af777", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Member>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Shop\WebAppShopFull\WebApp\Views\Auth\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewData["Title"] = "Your Profile";

#line default
#line hidden
            BeginContext(93, 41, true);
            WriteLiteral("\r\n<h1>Your Profile</h1>\r\n<p>Username: <b>");
            EndContext();
            BeginContext(135, 14, false);
#line 8 "D:\Shop\WebAppShopFull\WebApp\Views\Auth\Index.cshtml"
           Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(149, 23, true);
            WriteLiteral("</b></p>\r\n<p>Email: <b>");
            EndContext();
            BeginContext(173, 11, false);
#line 9 "D:\Shop\WebAppShopFull\WebApp\Views\Auth\Index.cshtml"
        Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(184, 52, true);
            WriteLiteral("</b></p>\r\n<a href=\"/auth/change\">Change Password</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Member> Html { get; private set; }
    }
}
#pragma warning restore 1591