#pragma checksum "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\45. 14-12-2021\Sifte\Sifte\Views\Student\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad0a425b11013e5c9435bf0eaf4a39106beb8a01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Detail), @"mvc.1.0.view", @"/Views/Student/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad0a425b11013e5c9435bf0eaf4a39106beb8a01", @"/Views/Student/Detail.cshtml")]
    public class Views_Student_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\45. 14-12-2021\Sifte\Sifte\Views\Student\Detail.cshtml"
   Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<main>\r\n");
#nullable restore
#line 4 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\45. 14-12-2021\Sifte\Sifte\Views\Student\Detail.cshtml"
     if (ViewBag.Student == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Data yoxdur!</h1>\r\n");
#nullable restore
#line 7 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\45. 14-12-2021\Sifte\Sifte\Views\Student\Detail.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul>\r\n            <li>Id: ");
#nullable restore
#line 11 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\45. 14-12-2021\Sifte\Sifte\Views\Student\Detail.cshtml"
               Write(ViewBag.Student.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>FullName: ");
#nullable restore
#line 12 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\45. 14-12-2021\Sifte\Sifte\Views\Student\Detail.cshtml"
                     Write(ViewBag.Student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\45. 14-12-2021\Sifte\Sifte\Views\Student\Detail.cshtml"
                                           Write(ViewBag.Student.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>GroupNo: ");
#nullable restore
#line 13 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\45. 14-12-2021\Sifte\Sifte\Views\Student\Detail.cshtml"
                    Write(ViewBag.Student.GroupNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ul>\r\n");
#nullable restore
#line 15 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\45. 14-12-2021\Sifte\Sifte\Views\Student\Detail.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</main>\r\n\r\n\r\n");
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
