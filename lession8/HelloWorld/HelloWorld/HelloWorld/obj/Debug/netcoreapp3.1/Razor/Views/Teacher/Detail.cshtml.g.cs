#pragma checksum "D:\Data CodeGym\SQL\lession8\HelloWorld\HelloWorld\HelloWorld\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ab0da8489dbf0478bab40341f0598d665b67368"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Detail), @"mvc.1.0.view", @"/Views/Teacher/Detail.cshtml")]
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
#line 1 "D:\Data CodeGym\SQL\lession8\HelloWorld\HelloWorld\HelloWorld\Views\_ViewImports.cshtml"
using HelloWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Data CodeGym\SQL\lession8\HelloWorld\HelloWorld\HelloWorld\Views\_ViewImports.cshtml"
using HelloWorld.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ab0da8489dbf0478bab40341f0598d665b67368", @"/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c3a2ae77bb7def8df8d7fca3d0612db813a598", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HelloWorld.Models.Teacher>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h1>ID:");
#nullable restore
#line 3 "D:\Data CodeGym\SQL\lession8\HelloWorld\HelloWorld\HelloWorld\Views\Teacher\Detail.cshtml"
      Write(Model.TeacherId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>Name:");
#nullable restore
#line 4 "D:\Data CodeGym\SQL\lession8\HelloWorld\HelloWorld\HelloWorld\Views\Teacher\Detail.cshtml"
        Write(Model.TeacherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelloWorld.Models.Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
