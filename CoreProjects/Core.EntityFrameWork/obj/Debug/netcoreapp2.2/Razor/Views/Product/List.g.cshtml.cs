#pragma checksum "C:\MyWorks\CoreEgitim\.NetCore_Egitim\CoreProjects\Core.EntityFrameWork\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a08a60f4bba7f18bbc55596fbd019be3ca106111"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/List.cshtml", typeof(AspNetCore.Views_Product_List))]
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
#line 1 "C:\MyWorks\CoreEgitim\.NetCore_Egitim\CoreProjects\Core.EntityFrameWork\Views\_ViewImports.cshtml"
using Core.EntityFrameWork.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a08a60f4bba7f18bbc55596fbd019be3ca106111", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24e2e9bafc05396bcd3892927de46e8c5134e639", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\MyWorks\CoreEgitim\.NetCore_Egitim\CoreProjects\Core.EntityFrameWork\Views\Product\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(69, 28, true);
            WriteLiteral("\r\n<h1>List</h1>\r\n\r\n<br/>\r\n\r\n");
            EndContext();
#line 10 "C:\MyWorks\CoreEgitim\.NetCore_Egitim\CoreProjects\Core.EntityFrameWork\Views\Product\List.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(130, 8, true);
            WriteLiteral("    <h2>");
            EndContext();
            BeginContext(139, 9, false);
#line 12 "C:\MyWorks\CoreEgitim\.NetCore_Egitim\CoreProjects\Core.EntityFrameWork\Views\Product\List.cshtml"
   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(148, 15, true);
            WriteLiteral("</h2>\r\n    <h4>");
            EndContext();
            BeginContext(164, 13, false);
#line 13 "C:\MyWorks\CoreEgitim\.NetCore_Egitim\CoreProjects\Core.EntityFrameWork\Views\Product\List.cshtml"
   Write(item.Category);

#line default
#line hidden
            EndContext();
            BeginContext(177, 15, true);
            WriteLiteral("</h4>\r\n    <h5>");
            EndContext();
            BeginContext(193, 10, false);
#line 14 "C:\MyWorks\CoreEgitim\.NetCore_Egitim\CoreProjects\Core.EntityFrameWork\Views\Product\List.cshtml"
   Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(203, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 15 "C:\MyWorks\CoreEgitim\.NetCore_Egitim\CoreProjects\Core.EntityFrameWork\Views\Product\List.cshtml"
}

#line default
#line hidden
            BeginContext(213, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
