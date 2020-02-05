#pragma checksum "D:\Shop\WebAppShopFull\WebApp\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79132e4e4eacd051deaaff603b8b10a210d6b0a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/Index.cshtml", typeof(AspNetCore.Views_Category_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79132e4e4eacd051deaaff603b8b10a210d6b0a9", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75616952ad48f557dea3eb4b5ab9331af75af777", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/category/deleteall"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "D:\Shop\WebAppShopFull\WebApp\Views\Category\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewData["Title"] = "Manage Category";

#line default
#line hidden
            BeginContext(104, 187, true);
            WriteLiteral("\r\n<h2>Manage Categories</h2>\r\n<a href=\"/category/create\">\r\n    <span style=\"font-size: 2.5em; color: black; padding:10px\">\r\n        <i class=\"fas fa-plus-circle\"></i>\r\n    </span>\r\n</a>\r\n");
            EndContext();
            BeginContext(291, 1437, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79132e4e4eacd051deaaff603b8b10a210d6b0a94190", async() => {
                BeginContext(340, 551, true);
                WriteLiteral(@"
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>
                    <input type=""checkbox"" id=""chk"" />
                    <label for=""chk"">Check All</label>
                </th>
            </tr>
            <tr>
                <th><button class=""del"">Delete</button></th>
                <th>Id</th>
                <th>Name</th>
                <th>Description</th>
                <th>Edit</th>
                <th>Delete</th>
            </tr>
        </thead>
        <tbody>
");
                EndContext();
#line 32 "D:\Shop\WebAppShopFull\WebApp\Views\Category\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(948, 105, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        <input type=\"checkbox\" name=\"ids\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1053, "\"", 1069, 1);
#line 36 "D:\Shop\WebAppShopFull\WebApp\Views\Category\Index.cshtml"
WriteAttributeValue("", 1061, item.Id, 1061, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1070, 55, true);
                WriteLiteral("/>\r\n                    </td>\r\n                    <td>");
                EndContext();
                BeginContext(1126, 7, false);
#line 38 "D:\Shop\WebAppShopFull\WebApp\Views\Category\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1133, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1165, 9, false);
#line 39 "D:\Shop\WebAppShopFull\WebApp\Views\Category\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1174, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1206, 16, false);
#line 40 "D:\Shop\WebAppShopFull\WebApp\Views\Category\Index.cshtml"
                   Write(item.Description);

#line default
#line hidden
                EndContext();
                BeginContext(1222, 59, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1281, "\"", 1311, 2);
                WriteAttributeValue("", 1288, "/category/edit/", 1288, 15, true);
#line 42 "D:\Shop\WebAppShopFull\WebApp\Views\Category\Index.cshtml"
WriteAttributeValue("", 1303, item.Id, 1303, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1312, 185, true);
                WriteLiteral(">\r\n                            <img src=\"/images//edit.png\" />\r\n                        </a>\r\n                    </td>\r\n                    <td>\r\n                        <a class=\"del\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1497, "\"", 1529, 2);
                WriteAttributeValue("", 1504, "/category/delete/", 1504, 17, true);
#line 47 "D:\Shop\WebAppShopFull\WebApp\Views\Category\Index.cshtml"
WriteAttributeValue("", 1521, item.Id, 1521, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1530, 144, true);
                WriteLiteral(">\r\n                            <img src=\"/images/trash.png\" />\r\n                        </a>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 52 "D:\Shop\WebAppShopFull\WebApp\Views\Category\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(1689, 32, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1728, 240, true);
            WriteLiteral("\r\n\r\n<script type=\"text/javascript\">\r\n    var b = document.getElementsByClassName(\"del\");\r\n    b.click(confirmDelete);   \r\n    chk.change(function () {\r\n        document.getElementsByName(\"ids\").check(this.checked);\r\n    });\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
