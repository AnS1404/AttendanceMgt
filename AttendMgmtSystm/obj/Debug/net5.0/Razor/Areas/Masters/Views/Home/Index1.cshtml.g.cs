#pragma checksum "E:\AttendMgmtSystm\AttendMgmtSystm\Areas\Masters\Views\Home\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5901e0b33e72eed4d498aa534fbb6e8684354299"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AttendMgmtSystm.Pages.Masters.Views.Home.Areas_Masters_Views_Home_Index1), @"mvc.1.0.view", @"/Areas/Masters/Views/Home/Index1.cshtml")]
namespace AttendMgmtSystm.Pages.Masters.Views.Home
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
#line 1 "E:\AttendMgmtSystm\AttendMgmtSystm\Areas\_ViewImports.cshtml"
using AttendMgmtSystm;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5901e0b33e72eed4d498aa534fbb6e8684354299", @"/Areas/Masters/Views/Home/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0969d5088492a3c8e31585f154a6e1d0ff110e6", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Masters_Views_Home_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AttendMgmtSystm.Models.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\AttendMgmtSystm\AttendMgmtSystm\Areas\Masters\Views\Home\Index1.cshtml"
   
    ViewData["Title"] = "Dashboard";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2> Dashboard </h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\"> Total Employees  </h5>\r\n                <p class=\" card-text\"> ");
#nullable restore
#line 15 "E:\AttendMgmtSystm\AttendMgmtSystm\Areas\Masters\Views\Home\Index1.cshtml"
                                  Write(Model.EmployeeCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
            </div>
        </div>
    </div>
    <div class=""col-md-8"">
        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title""> Recent Employees </h5>
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Email</th>
                            <th>Phone Number </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 32 "E:\AttendMgmtSystm\AttendMgmtSystm\Areas\Masters\Views\Home\Index1.cshtml"
                         foreach (var employee in Model.RecentEmployees)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 35 "E:\AttendMgmtSystm\AttendMgmtSystm\Areas\Masters\Views\Home\Index1.cshtml"
                               Write(employee.EmpName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 36 "E:\AttendMgmtSystm\AttendMgmtSystm\Areas\Masters\Views\Home\Index1.cshtml"
                               Write(employee.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 37 "E:\AttendMgmtSystm\AttendMgmtSystm\Areas\Masters\Views\Home\Index1.cshtml"
                               Write(employee.PhNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>");
#nullable restore
#line 38 "E:\AttendMgmtSystm\AttendMgmtSystm\Areas\Masters\Views\Home\Index1.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AttendMgmtSystm.Models.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
