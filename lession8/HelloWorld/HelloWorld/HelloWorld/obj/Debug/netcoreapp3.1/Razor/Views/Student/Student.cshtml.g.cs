#pragma checksum "D:\Data CodeGym\SQL\lession8\HelloWorld\HelloWorld\HelloWorld\Views\Student\Student.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f817f6529adb72fe4a882f50a93e903b2ce30c8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Student), @"mvc.1.0.view", @"/Views/Student/Student.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
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
#nullable restore
#line 1 "D:\Data CodeGym\SQL\lession8\HelloWorld\HelloWorld\HelloWorld\Views\Student\Student.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f817f6529adb72fe4a882f50a93e903b2ce30c8b", @"/Views/Student/Student.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c3a2ae77bb7def8df8d7fca3d0612db813a598", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Student : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Data CodeGym\SQL\lession8\HelloWorld\HelloWorld\HelloWorld\Views\Student\Student.cshtml"
      
        ViewData["Title"] = "Student Page";
        //Layout = "~/Views/Shared/_Layout2.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\Data CodeGym\SQL\lession8\HelloWorld\HelloWorld\HelloWorld\Views\Student\Student.cshtml"
     foreach(var std in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h1>StudentId: ");
#nullable restore
#line 11 "D:\Data CodeGym\SQL\lession8\HelloWorld\HelloWorld\HelloWorld\Views\Student\Student.cshtml"
              Write(std.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>Fullname: ");
#nullable restore
#line 12 "D:\Data CodeGym\SQL\lession8\HelloWorld\HelloWorld\HelloWorld\Views\Student\Student.cshtml"
             Write(std.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>Gender: ");
#nullable restore
#line 13 "D:\Data CodeGym\SQL\lession8\HelloWorld\HelloWorld\HelloWorld\Views\Student\Student.cshtml"
           Write(std.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>Dob: ");
#nullable restore
#line 14 "D:\Data CodeGym\SQL\lession8\HelloWorld\HelloWorld\HelloWorld\Views\Student\Student.cshtml"
        Write(std.Dob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f817f6529adb72fe4a882f50a93e903b2ce30c8b5852", async() => {
                WriteLiteral("Detail");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-stdId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "D:\Data CodeGym\SQL\lession8\HelloWorld\HelloWorld\HelloWorld\Views\Student\Student.cshtml"
                                                         WriteLiteral(std.StudentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["stdId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-stdId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["stdId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "D:\Data CodeGym\SQL\lession8\HelloWorld\HelloWorld\HelloWorld\Views\Student\Student.cshtml"
                                                                                       WriteLiteral(std.Fullname);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["fn"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-fn", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["fn"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <hr />\r\n</div>\r\n");
#nullable restore
#line 19 "D:\Data CodeGym\SQL\lession8\HelloWorld\HelloWorld\HelloWorld\Views\Student\Student.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
