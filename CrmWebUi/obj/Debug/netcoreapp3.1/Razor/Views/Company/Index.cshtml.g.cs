#pragma checksum "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddd3836069095f4047ed475e9596cc522b18a8dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Index), @"mvc.1.0.view", @"/Views/Company/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddd3836069095f4047ed475e9596cc522b18a8dd", @"/Views/Company/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b12662ff008f5db31089e3143ff4f1b22f68991", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <button class=""btn btn-success btn-xs"" type=""button"" data-toggle=""modal"" data-target=""#company-add-modal"">Add Company</button>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            <ul class=""list-group"">
");
#nullable restore
#line 15 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\Index.cshtml"
                 foreach (var iter in Model.Categories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item disabled\" aria-disabled=\"true\">");
#nullable restore
#line 17 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\Index.cshtml"
                                                                         Write(iter.tür);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 18 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </ul>
        </div>
        <div class=""col-md-9"">
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
#line 34 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\Index.cshtml"
                     foreach (var iter in Model.Companies)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 37 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\Index.cshtml"
                           Write(iter.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\Index.cshtml"
                           Write(iter.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\Index.cshtml"
                           Write(iter.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><img");
            BeginWriteAttribute("src", " src=\"", 1385, "\"", 1404, 1);
#nullable restore
#line 40 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\Index.cshtml"
WriteAttributeValue("", 1391, iter.picture, 1391, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"120\" height=\"80\" /></td>\r\n                            <td>\r\n                                <button class=\"btn btn-info listButtonNote\" type=\"button\" data-id=\"");
#nullable restore
#line 42 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\Index.cshtml"
                                                                                              Write(iter.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">NoTes</button>\r\n                                <button class=\"btn btn-success btn-xs listButtonEdit \" type=\"button\" data-id=\"");
#nullable restore
#line 43 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\Index.cshtml"
                                                                                                         Write(iter.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Edit</button>\r\n                                <button class=\"btn btn-danger btn-xs listButtonDelete \" type=\"button\" data-id=\"");
#nullable restore
#line 44 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\Index.cshtml"
                                                                                                          Write(iter.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-company-name=\"");
#nullable restore
#line 44 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\Index.cshtml"
                                                                                                                                       Write(iter.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" >Delete</button>\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 48 "C:\Users\Onur Furkan Meral\Desktop\Crm\CrmWebUi\Views\Company\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
    <script>
        $(document).ready(function () {
            $(document).on('click', '.listButtonDelete', () => {
                var btn = $(this);
                var id = btn.data('id');
                var modal = $('#company-delete-modal')
                modal.find('.modal-body').html(""<h3>Silmek İstediğinize Emin misiniz</h3>"")
                modal.modal('show');
            })
        })
    </script>
");
            WriteLiteral(@"    <div class=""modal fade"" id=""company-note-modal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Notlar</h5>
                    <button type=""button"" class=""btn-close"" data-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"" id=""note-body"">

                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Kapat</button>
                </div>
            </div>
        </div>
    </div>
");
            WriteLiteral(@"    <div class=""modal fade"" id=""company-add-modal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Company Add Form</h5>
                    <button type=""button"" class=""btn-close"" data-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"" id=""company-add-body"">

                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-primary"" id=""gonder"">Save changes</button>
                </div>
            </div>
        </div>
    </div>
    <div class=""modal fade"" id=""company-edit-modal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
        ");
            WriteLiteral(@"    <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Company Edit Form</h5>
                    <button type=""button"" class=""btn-close"" data-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">

                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-primary"" id=""modalEditButton"">Save changes</button>
                </div>
            </div>
        </div>
    </div>
    <div class=""modal fade"" id=""company-delete-modal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Company Delete Form</h5>
                    <button t");
            WriteLiteral(@"ype=""button"" class=""btn-close"" data-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">

                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Vazgeç</button>
                    <button type=""button"" class=""btn btn-primary"" id=""modalDeleteButton"">Sil</button>
                </div>
            </div>
        </div>
    </div>
");
            WriteLiteral(@"    <script>
        $(document).ready(function () {
            $(document).on('click', '.listButtonNote', function () {
                var btn = $(this);
                var id = btn.data(""id"");
                var modal=$(""#company-note-modal"");
                modal.find("".modal-body"").load(""/Company/notePartial/"" + id);
                modal.modal(""show"");
            });



            $(document).on('click', '.listButtonEdit', function () {
                var btn = $(this);
                var id = btn.data(""id"");
                var modal = $(""#company-edit-modal"");
                modal.find("".modal-body"").load(""/Company/companyform/"" + id);
                $(""#modalEditButton"").attr(""data-id"", id);
                modal.modal(""show"");

            });
            $(""#modalEditButton"").click(function () {
                var modal = $(""#company-edit-modal"");
                var company_id = $(this).data(""id"");
                var formdata = new FormData();
                f");
            WriteLiteral(@"ormdata.append(""Name"", modal.find(""#Name"").val());
                formdata.append(""Adress"", modal.find(""#Adress"").val());
                formdata.append(""Number"", modal.find(""#Number"").val());
                $.ajax({
                    method: 'POST',
                    url: 'Company/companyEdit/' + company_id,
                    data: formdata,
                    beforeSend: function () {

                    },
                    success: function () {

                    },
                    error: function () {

                    }
                })
            });


            $(document).on('click', '.listButtonDelete', function () {
                var btn = $(this);
                var id = btn.data(""id"");
                var company_name = btn.data(""company-name"");
                var modal = $(""#company-delete-modal"");
                modal.find("".modal-title"").text(company_name);
                modal.find("".modal-body"").html(""<h3>Silmek istediğinizden emin ");
            WriteLiteral(@"misiniz ?</h3>"");
                $(""#modalDeleteButton"").attr(""data-id"", id);
                modal.modal(""show"");
            });
            $(""#modalDeleteButton"").click(function () {
                var company_id = $(this).data(""id"");
                $.ajax({
                    method: 'post',
                    url: '/company/delete/' + company_id,

                }).done(() => {
                    console.log(d);
                })
            });
        });
            /*
        var id = -1;
        var modalbody = $('#note-body');
        $(function () {
            $('#note-modal').on('shown.bs.modal', (e) => {
                console.log(""modal açıldı"");
                var btn = $(e.relatedTarget);
                id = btn.data('company-id');
                console.log(""id = "" + id);
                modalbody.load(""/Company/notePartial/"" + id);
            })
        })

        $(function () {
            var modal = $(""#company-edit-modal"");
            var ");
            WriteLiteral(@"modalbody = modal.find("".modal-body"");
            $('#company-edit-modal').on('shown.bs.modal', (e) => {
                var btn = $(e.relatedTarget);
                id = btn.data('id');
                modalbody.load(""/Company/companyform/"" + id);
                $(""#modalEditButton"").attr(""data-id"", id);
            })

            $(""#modalEditButton"").click(function () {
                $(this).attr(""data-id"");
            });
        })

        $(function () {
            $('#company-add-modal').on('shown.bs.modal', (e) => {
                var btn = $(e.relatedTarget);
                //id = btn.data('company-id');
                $('#company-add-body').load(""/Company/companyform"");
            })
            $('#gonder').click((e) => {
                var name = $('#name').val()
                var adres = $('#Adress').val();
                var number = $('#Number').val();
                $.ajax({
                    method: ""POST"",
                    url: ""/company/create");
            WriteLiteral(@""",
                    data: {d1:name,d2:adres,d3:number}
                }).done((d) => {
                    console.log(""Başarılı"")
                    console.log(d);
                    $('#company-add-modal').hide()
                })
            })
        })
       
        })
        */
        //$(function () {
        //    var modal = $(""#company-delete-modal"");
        //    var modalbody = modal.find("".modal-body"");
        //    $('#company-edit-modal').on('shown.bs.modal', (e) => {
        //        var btn = $(e.relatedTarget);
        //        id = btn.data('id');
        //        modalbody.load(""/Company/companyform/"" + id);
        //        $(""#modalEditButton"").attr(""data-id"", id);
        //    })

        //    $(""#modalEditButton"").click(function () {
        //        $(this).attr(""data-id"");
        //    });
        //})

      
    </script>
");
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
