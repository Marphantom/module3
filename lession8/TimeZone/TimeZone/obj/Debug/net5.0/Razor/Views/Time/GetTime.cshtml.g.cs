#pragma checksum "D:\Data CodeGym\SQL\lession8\TimeZone\TimeZone\Views\Time\GetTime.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3c7454497d15f5ad06f8d7b70eda7bdb349a1c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Time_GetTime), @"mvc.1.0.view", @"/Views/Time/GetTime.cshtml")]
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
#line 1 "D:\Data CodeGym\SQL\lession8\TimeZone\TimeZone\Views\_ViewImports.cshtml"
using TimeZone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Data CodeGym\SQL\lession8\TimeZone\TimeZone\Views\_ViewImports.cshtml"
using TimeZone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3c7454497d15f5ad06f8d7b70eda7bdb349a1c4", @"/Views/Time/GetTime.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab1d985ae7925330f179674fe03687c3ced7f2a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Time_GetTime : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DateTime>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Data CodeGym\SQL\lession8\TimeZone\TimeZone\Views\Time\GetTime.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <p><b>Recent Time is: </b> ");
#nullable restore
#line 7 "D:\Data CodeGym\SQL\lession8\TimeZone\TimeZone\Views\Time\GetTime.cshtml"
                          Write(Model.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("; </p>\r\n</div>\r\n}");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DateTime> Html { get; private set; }
    }
}
#pragma warning restore 1591
