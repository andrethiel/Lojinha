#pragma checksum "G:\Dropbox\Lojinha\Lojinha\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45add18efee46a97760cf81e354810276d712f51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "G:\Dropbox\Lojinha\Lojinha\Views\_ViewImports.cshtml"
using Lojinha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Dropbox\Lojinha\Lojinha\Views\_ViewImports.cshtml"
using Lojinha.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Dropbox\Lojinha\Lojinha\Views\_ViewImports.cshtml"
using Lojinha.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45add18efee46a97760cf81e354810276d712f51", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e084c1608a8dc73f677b45d1370f1a99d184c43", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Dropbox\Lojinha\Lojinha\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_Carousel"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"form-group row\" style=\"margin-top: 5%\">\r\n");
#nullable restore
#line 6 "G:\Dropbox\Lojinha\Lojinha\Views\Home\Index.cshtml"
     foreach(var item in Model.lanchesPreferidos)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Dropbox\Lojinha\Lojinha\Views\Home\Index.cshtml"
   Write(Html.Partial("_LanchesResumo", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Dropbox\Lojinha\Lojinha\Views\Home\Index.cshtml"
                                             ;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
