#pragma checksum "C:\Users\HP\Desktop\Allup\Allup\Areas\Admin\Views\Shared\_CategorySearchPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6931c1ebecf2164ab2ca9db689258ca49dc6fb14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__CategorySearchPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_CategorySearchPartial.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Allup\Allup\Areas\Admin\Views\_ViewImports.cshtml"
using Allup.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Allup\Allup\Areas\Admin\Views\_ViewImports.cshtml"
using Allup.Areas.Admin.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Allup\Allup\Areas\Admin\Views\_ViewImports.cshtml"
using Allup.Areas.Admin.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6931c1ebecf2164ab2ca9db689258ca49dc6fb14", @"/Areas/Admin/Views/Shared/_CategorySearchPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a224cc1c296cd40dcb89583bfc5a437a071bfc80", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__CategorySearchPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Desktop\Allup\Allup\Areas\Admin\Views\Shared\_CategorySearchPartial.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>Netice tapilmadi</li>\r\n");
#nullable restore
#line 6 "C:\Users\HP\Desktop\Allup\Allup\Areas\Admin\Views\Shared\_CategorySearchPartial.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\Desktop\Allup\Allup\Areas\Admin\Views\Shared\_CategorySearchPartial.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\HP\Desktop\Allup\Allup\Areas\Admin\Views\Shared\_CategorySearchPartial.cshtml"
                                                                                                                         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HP\Desktop\Allup\Allup\Areas\Admin\Views\Shared\_CategorySearchPartial.cshtml"
     
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
