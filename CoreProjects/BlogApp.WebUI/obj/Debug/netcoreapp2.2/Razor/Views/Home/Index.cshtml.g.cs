#pragma checksum "D:\ismail\.NetCore_Egitim\CoreProjects\BlogApp.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "363aa5bad36f0d25c53444b302116381f5bc1abf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\ismail\.NetCore_Egitim\CoreProjects\BlogApp.WebUI\Views\_ViewImports.cshtml"
using BlogApp.WebUI.Models;

#line default
#line hidden
#line 2 "D:\ismail\.NetCore_Egitim\CoreProjects\BlogApp.WebUI\Views\_ViewImports.cshtml"
using BlogApp.Entity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"363aa5bad36f0d25c53444b302116381f5bc1abf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96ac41d9fd34d1ba3bd27fcc8aad6cf31e5ca9da", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\ismail\.NetCore_Egitim\CoreProjects\BlogApp.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(71, 1293, true);
            WriteLiteral(@"

<div class=""jumbotron jumbotron-fluid"">
    <div class=""container"">
        <h1 class=""display-3"">Hello, world!</h1>
        <p class=""lead"">This is a simple hero unit, a simple jumbotron-style component for calling extra attention to featured content or information.</p>
        <hr class=""my-4"">
        <p>It uses utility classes for typography and spacing to space content out within the larger container.</p>
        <p class=""lead"">
            <a class=""btn btn-primary btn-lg"" href=""#"" role=""button"">Learn more</a>
        </p>
    </div>
</div>

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-3"">
            <div class=""list-group"">
                <a href=""#"" class=""list-group-item active"">
                    Cras justo odio
                </a>
                <a href=""#"" class=""list-group-item list-group-item-action"">Dapibus ac facilisis in</a>
                <a href=""#"" class=""list-group-item list-group-item-action"">Morbi leo risus</a>
               ");
            WriteLiteral(@" <a href=""#"" class=""list-group-item list-group-item-action"">Porta ac consectetur ac</a>
                <a href=""#"" class=""list-group-item list-group-item-action disabled"">Vestibulum at eros</a>
            </div>
        </div>

        <div class=""col-md-9"">

");
            EndContext();
#line 37 "D:\ismail\.NetCore_Egitim\CoreProjects\BlogApp.WebUI\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1421, 112, true);
            WriteLiteral("                <div class=\"card mt-2\">\r\n                    <div class=\"card-header\">\r\n                        ");
            EndContext();
            BeginContext(1534, 10, false);
#line 41 "D:\ismail\.NetCore_Egitim\CoreProjects\BlogApp.WebUI\Views\Home\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1544, 50, true);
            WriteLiteral("\r\n                    </div>\r\n                    ");
            EndContext();
            BeginContext(1594, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "363aa5bad36f0d25c53444b302116381f5bc1abf6429", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1625, "~/img/", 1625, 6, true);
#line 43 "D:\ismail\.NetCore_Egitim\CoreProjects\BlogApp.WebUI\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1631, item.Image, 1631, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1665, 97, true);
            WriteLiteral("\r\n\r\n                    <div class=\"card-block\">\r\n                        <h4 class=\"card-title\">");
            EndContext();
            BeginContext(1763, 10, false);
#line 46 "D:\ismail\.NetCore_Egitim\CoreProjects\BlogApp.WebUI\Views\Home\Index.cshtml"
                                          Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1773, 52, true);
            WriteLiteral("</h4>\r\n                        <p class=\"card-text\">");
            EndContext();
            BeginContext(1826, 16, false);
#line 47 "D:\ismail\.NetCore_Egitim\CoreProjects\BlogApp.WebUI\Views\Home\Index.cshtml"
                                        Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1842, 136, true);
            WriteLiteral("</p>\r\n                        <a href=\"#\" class=\"btn btn-primary\">Go somewhere</a>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 51 "D:\ismail\.NetCore_Egitim\CoreProjects\BlogApp.WebUI\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1993, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
