#pragma checksum "C:\Users\Admin\source\repos\ASPTest\ASPTest\Views\Shared\AllCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0766f9da18b0987101b182bb5698388d10b82161"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AllCars), @"mvc.1.0.view", @"/Views/Shared/AllCars.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0766f9da18b0987101b182bb5698388d10b82161", @"/Views/Shared/AllCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bda176dbbfb1d7e34329a4ad038ed93acb01078", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AllCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Admin\source\repos\ASPTest\ASPTest\Views\Shared\AllCars.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Car\r\n<div class=\"col-lg-4\">\r\n    <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 66, "\"", 84, 1);
#nullable restore
#line 3 "C:\Users\Admin\source\repos\ASPTest\ASPTest\Views\Shared\AllCars.cshtml"
WriteAttributeValue("", 72, Model.image, 72, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"120\" width=\"260\"");
            BeginWriteAttribute("alt", " alt=\"", 110, "\"", 127, 1);
#nullable restore
#line 3 "C:\Users\Admin\source\repos\ASPTest\ASPTest\Views\Shared\AllCars.cshtml"
WriteAttributeValue("", 116, Model.name, 116, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <h2>Модель: ");
#nullable restore
#line 4 "C:\Users\Admin\source\repos\ASPTest\ASPTest\Views\Shared\AllCars.cshtml"
           Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p>Цена: ");
#nullable restore
#line 5 "C:\Users\Admin\source\repos\ASPTest\ASPTest\Views\Shared\AllCars.cshtml"
        Write(Model.price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Описание: ");
#nullable restore
#line 6 "C:\Users\Admin\source\repos\ASPTest\ASPTest\Views\Shared\AllCars.cshtml"
            Write(Model.fullDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p><a class=\"btn btn-warning\" href=\"/ShopCart/addToCart\">Add to cart</a></p>\r\n</div>");
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
