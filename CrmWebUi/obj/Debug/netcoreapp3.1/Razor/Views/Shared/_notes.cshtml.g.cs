#pragma checksum "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Shared\_notes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a384b511a5f97bd1305d078985e37e5e11f2e43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__notes), @"mvc.1.0.view", @"/Views/Shared/_notes.cshtml")]
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
#line 2 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\_ViewImports.cshtml"
using CrmEntity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\_ViewImports.cshtml"
using CrmWebUi.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\_ViewImports.cshtml"
using CrmWebUi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a384b511a5f97bd1305d078985e37e5e11f2e43", @"/Views/Shared/_notes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b12662ff008f5db31089e3143ff4f1b22f68991", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__notes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Company>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Shared\_notes.cshtml"
      

        foreach (var item in Model.notes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger\" data-note-id=\"");
#nullable restore
#line 10 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Shared\_notes.cshtml"
                                                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" role=\"alert\">\r\n                ");
#nullable restore
#line 11 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Shared\_notes.cshtml"
           Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 13 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Shared\_notes.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Company> Html { get; private set; }
    }
}
#pragma warning restore 1591
