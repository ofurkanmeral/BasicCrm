#pragma checksum "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\ListCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c06ecfe2197e5d17414c66e4dec41337d1a9a017"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_ListCategory), @"mvc.1.0.view", @"/Views/Company/ListCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06ecfe2197e5d17414c66e4dec41337d1a9a017", @"/Views/Company/ListCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b12662ff008f5db31089e3143ff4f1b22f68991", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_ListCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\ListCategory.cshtml"
   
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""col-md-9"">
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <td>Firma Adı</td>
                    <td>Address</td>
                    <td>Telefon Number</td>
                    <td>Logo</td>
                    <td></td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 27 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\ListCategory.cshtml"
                 foreach (var iter in Model.Companies)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 793, "\"", 819, 2);
            WriteAttributeValue("", 800, "/Company/", 800, 9, true);
#nullable restore
#line 30 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\ListCategory.cshtml"
WriteAttributeValue("", 809, iter.Name, 809, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\ListCategory.cshtml"
                                                     Write(iter.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\ListCategory.cshtml"
                       Write(iter.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\ListCategory.cshtml"
                       Write(iter.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><img");
            BeginWriteAttribute("src", " src=\"", 968, "\"", 987, 1);
#nullable restore
#line 33 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\ListCategory.cshtml"
WriteAttributeValue("", 974, iter.picture, 974, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"120\" height=\"80\" /></td>\r\n                        <td>\r\n                            <button class=\"btn btn-info listButtonNote\" type=\"button\" data-id=\"");
#nullable restore
#line 35 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\ListCategory.cshtml"
                                                                                          Write(iter.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">NoTes</button>\r\n                            <button class=\"btn btn-success btn-xs listButtonEdit \" type=\"button\" data-id=\"");
#nullable restore
#line 36 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\ListCategory.cshtml"
                                                                                                     Write(iter.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Edit</button>\r\n                            <button class=\"btn btn-danger btn-xs listButtonDelete \" type=\"button\" data-id=\"");
#nullable restore
#line 37 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\ListCategory.cshtml"
                                                                                                      Write(iter.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-company-name=\"");
#nullable restore
#line 37 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\ListCategory.cshtml"
                                                                                                                                   Write(iter.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Delete</button>\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\ListCategory.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyList> Html { get; private set; }
    }
}
#pragma warning restore 1591