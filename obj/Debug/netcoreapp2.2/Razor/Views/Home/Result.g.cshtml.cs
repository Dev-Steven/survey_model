#pragma checksum "/Users/stevenchung/Documents/coding_dojo/c#_stack/II_asp_mvc/surveyModel/Views/Home/Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a31492184cd86057cb5261c1fc4f7b7874499d62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Result.cshtml", typeof(AspNetCore.Views_Home_Result))]
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
#line 1 "/Users/stevenchung/Documents/coding_dojo/c#_stack/II_asp_mvc/surveyModel/Views/_ViewImports.cshtml"
using surveyModel;

#line default
#line hidden
#line 2 "/Users/stevenchung/Documents/coding_dojo/c#_stack/II_asp_mvc/surveyModel/Views/_ViewImports.cshtml"
using surveyModel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a31492184cd86057cb5261c1fc4f7b7874499d62", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61cf3db32da73cb4e3ef3aa372ee828c674d8a83", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Survey>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 27, true);
            WriteLiteral("\n<h1>Sumitted Info</h1>\n<p>");
            EndContext();
            BeginContext(42, 5, false);
#line 4 "/Users/stevenchung/Documents/coding_dojo/c#_stack/II_asp_mvc/surveyModel/Views/Home/Result.cshtml"
Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(47, 5, true);
            WriteLiteral("</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591
