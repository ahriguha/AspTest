#pragma checksum "C:\Users\Admin\source\repos\ASPTest\ASPTest\Views\ShopCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f0c4f94f559b74d5cdc870c1a10685c8f5c4ddf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShopCart_Index), @"mvc.1.0.view", @"/Views/ShopCart/Index.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\ASPTest\ASPTest\Views\_ViewImports.cshtml"
using ASPTest.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\ASPTest\ASPTest\Views\_ViewImports.cshtml"
using ASPTest.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f0c4f94f559b74d5cdc870c1a10685c8f5c4ddf", @"/Views/ShopCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bda176dbbfb1d7e34329a4ad038ed93acb01078", @"/Views/_ViewImports.cshtml")]
    public class Views_ShopCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Admin\source\repos\ASPTest\ASPTest\Views\ShopCart\Index.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ShopCartViewModel\r\n<div class=\"container\">\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\ASPTest\ASPTest\Views\ShopCart\Index.cshtml"
     foreach (var el in Model.shopCart.shopItemsList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning mt-3\">\r\n            <b>Car: </b>");
#nullable restore
#line 6 "C:\Users\Admin\source\repos\ASPTest\ASPTest\Views\ShopCart\Index.cshtml"
                   Write(el.car.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n            <b>Price: </b>");
#nullable restore
#line 7 "C:\Users\Admin\source\repos\ASPTest\ASPTest\Views\ShopCart\Index.cshtml"
                     Write(el.car.price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 9 "C:\Users\Admin\source\repos\ASPTest\ASPTest\Views\ShopCart\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n    <div class=\"btn btn-danger\" asp-controller=\"Order\">Buy</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
