#pragma checksum "D:\Fac\Tsp.Net\Proiect\WebApplication1\Pages\proprietati.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab1421fe474058ed8d69f28cc44e41fc686c9adc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication1.Pages.Pages_proprietati), @"mvc.1.0.razor-page", @"/Pages/proprietati.cshtml")]
namespace WebApplication1.Pages
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
#line 1 "D:\Fac\Tsp.Net\Proiect\WebApplication1\Pages\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab1421fe474058ed8d69f28cc44e41fc686c9adc", @"/Pages/proprietati.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd66e6c0b2d0593b97c0d67f6f506054866fe040", @"/Pages/_ViewImports.cshtml")]
    public class Pages_proprietati : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Fac\Tsp.Net\Proiect\WebApplication1\Pages\proprietati.cshtml"
  
    ViewData["Title"] = "Properties";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n<center><h1>Properties</h1></center>\r\n<br />\r\n<br />\r\n\r\n<ol>\r\n");
#nullable restore
#line 13 "D:\Fac\Tsp.Net\Proiect\WebApplication1\Pages\proprietati.cshtml"
     foreach (var item in Model.PGO[0].Prop)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n\r\n            <li>");
#nullable restore
#line 17 "D:\Fac\Tsp.Net\Proiect\WebApplication1\Pages\proprietati.cshtml"
           Write(Html.DisplayFor(modelItem => item));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <br />\r\n\r\n        </div>\r\n");
#nullable restore
#line 21 "D:\Fac\Tsp.Net\Proiect\WebApplication1\Pages\proprietati.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ol>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Pages.proprietatiModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.proprietatiModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.proprietatiModel>)PageContext?.ViewData;
        public WebApplication1.Pages.proprietatiModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591