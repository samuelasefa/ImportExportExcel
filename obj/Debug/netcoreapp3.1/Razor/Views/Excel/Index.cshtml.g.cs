#pragma checksum "E:\Project\ImportExportExcel\Views\Excel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a7336c98c10913865b375da80fea1c886b112c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Excel_Index), @"mvc.1.0.view", @"/Views/Excel/Index.cshtml")]
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
#line 1 "E:\Project\ImportExportExcel\Views\_ViewImports.cshtml"
using ImportExportExcel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\ImportExportExcel\Views\_ViewImports.cshtml"
using ImportExportExcel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a7336c98c10913865b375da80fea1c886b112c4", @"/Views/Excel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7429b8f0c0af144e1ec4cbea333adfd8380a38fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Excel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ImportExportExcel.Models.Excel.SalesModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Project\ImportExportExcel\Views\Excel\Index.cshtml"
   
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <table class=""table table-striped table-responsive-md"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th>VoucherId</th>
                            <th>Customer</th>
                            <th>Date</th>
                            <th>Subtotal</th>
                            <th>GrandTotal</th>
                            <th>PreparedBy</th>
                            <th>FsNo</th>
                            <th>Sales Person</th>
                            <th>Source Store</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 25 "E:\Project\ImportExportExcel\Views\Excel\Index.cshtml"
                         foreach (var d in Model) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 27 "E:\Project\ImportExportExcel\Views\Excel\Index.cshtml"
                           Write(d.VoucherId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 28 "E:\Project\ImportExportExcel\Views\Excel\Index.cshtml"
                           Write(d.Customer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 29 "E:\Project\ImportExportExcel\Views\Excel\Index.cshtml"
                           Write(d.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "E:\Project\ImportExportExcel\Views\Excel\Index.cshtml"
                           Write(d.Subtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 31 "E:\Project\ImportExportExcel\Views\Excel\Index.cshtml"
                           Write(d.GrandTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 32 "E:\Project\ImportExportExcel\Views\Excel\Index.cshtml"
                           Write(d.PrepardBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "E:\Project\ImportExportExcel\Views\Excel\Index.cshtml"
                           Write(d.FsNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "E:\Project\ImportExportExcel\Views\Excel\Index.cshtml"
                           Write(d.SalesPerson);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "E:\Project\ImportExportExcel\Views\Excel\Index.cshtml"
                           Write(d.SourceStore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 37 "E:\Project\ImportExportExcel\Views\Excel\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ImportExportExcel.Models.Excel.SalesModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
