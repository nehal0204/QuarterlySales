#pragma checksum "C:\Users\Nehal\OneDrive\Desktop\AS5_ND7004\QuarterlySales\Views\Shared\Components\TopQuartersByEmployee\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a09acc6759803f2c033fa91792526465c5b8e68c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopQuartersByEmployee_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopQuartersByEmployee/Default.cshtml")]
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
#line 1 "C:\Users\Nehal\OneDrive\Desktop\AS5_ND7004\QuarterlySales\Views\_ViewImports.cshtml"
using QuarterlySales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nehal\OneDrive\Desktop\AS5_ND7004\QuarterlySales\Views\_ViewImports.cshtml"
using QuarterlySales.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nehal\OneDrive\Desktop\AS5_ND7004\QuarterlySales\Views\_ViewImports.cshtml"
using QuarterlySales.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a09acc6759803f2c033fa91792526465c5b8e68c", @"/Views/Shared/Components/TopQuartersByEmployee/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"720c7c221e4648a4ebd438a1ac1c035ce186c35e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopQuartersByEmployee_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TopQuartersByEmployeeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h6><b>");
#nullable restore
#line 3 "C:\Users\Nehal\OneDrive\Desktop\AS5_ND7004\QuarterlySales\Views\Shared\Components\TopQuartersByEmployee\Default.cshtml"
  Write(Model.NumberOfQuartersToShow.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" Top Quarters By Employee</b></h6>\r\n    <ol>\r\n");
#nullable restore
#line 5 "C:\Users\Nehal\OneDrive\Desktop\AS5_ND7004\QuarterlySales\Views\Shared\Components\TopQuartersByEmployee\Default.cshtml"
         foreach (var year in Model.TopQuarters)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 7 "C:\Users\Nehal\OneDrive\Desktop\AS5_ND7004\QuarterlySales\Views\Shared\Components\TopQuartersByEmployee\Default.cshtml"
           Write(year.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("  Q-");
#nullable restore
#line 7 "C:\Users\Nehal\OneDrive\Desktop\AS5_ND7004\QuarterlySales\Views\Shared\Components\TopQuartersByEmployee\Default.cshtml"
                         Write(year.Quarter);

#line default
#line hidden
#nullable disable
            WriteLiteral(":  <b>");
#nullable restore
#line 7 "C:\Users\Nehal\OneDrive\Desktop\AS5_ND7004\QuarterlySales\Views\Shared\Components\TopQuartersByEmployee\Default.cshtml"
                                            Write(year.Amount?.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> <br>\r\n               <div style=\"border-radius:70px\" class=\"btn btn-primary\"><b>");
#nullable restore
#line 8 "C:\Users\Nehal\OneDrive\Desktop\AS5_ND7004\QuarterlySales\Views\Shared\Components\TopQuartersByEmployee\Default.cshtml"
                                                                     Write(year.Employee.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div> \r\n              \r\n                  </li>\r\n");
#nullable restore
#line 11 "C:\Users\Nehal\OneDrive\Desktop\AS5_ND7004\QuarterlySales\Views\Shared\Components\TopQuartersByEmployee\Default.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </ol>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopQuartersByEmployeeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
