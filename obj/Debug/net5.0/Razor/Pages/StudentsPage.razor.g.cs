#pragma checksum "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\Pages\StudentsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a133f297142600f9b273d02e545a20b24b4300d4"
// <auto-generated/>
#pragma warning disable 1591
namespace UAS.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\_Imports.razor"
using UAS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\_Imports.razor"
using UAS.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pageStudents")]
    public partial class StudentsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Daftar Students</h3>\r\n");
            __builder.AddMarkupContent(1, "<tr><td><a href=\"addStudents\" class=\"btn btn-primary\"> Create New </a></td></tr>\r\n");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-striped");
            __builder.AddMarkupContent(4, "<thead><tr><th>NIM</th>\r\n            <th>Nama Belakang</th>\r\n            <th>Nama Depan</th>\r\n            <th>Tanggal Masuk</th>\r\n            <th>Action</th></tr></thead>\r\n    ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 20 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\Pages\StudentsPage.razor"
         foreach(var Stud in Student)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 23 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\Pages\StudentsPage.razor"
                     Stud.studentID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 24 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\Pages\StudentsPage.razor"
                     Stud.lastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 25 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\Pages\StudentsPage.razor"
                     Stud.firstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 26 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\Pages\StudentsPage.razor"
                     Stud.enrollmentDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", 
#nullable restore
#line 28 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\Pages\StudentsPage.razor"
                           $"detailStudents/{Stud.studentID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "class", "btn btn-success");
            __builder.AddContent(23, "Details");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, " | \r\n                ");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", 
#nullable restore
#line 29 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\Pages\StudentsPage.razor"
                           $"enrollStudents/{Stud.studentID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "class", "btn btn-secondary");
            __builder.AddContent(28, "Enroll");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, " | \r\n                ");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "href", 
#nullable restore
#line 30 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\Pages\StudentsPage.razor"
                           $"editStudents/{Stud.studentID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "class", "btn btn-warning");
            __builder.AddContent(33, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, " |\r\n                ");
            __builder.OpenElement(35, "a");
            __builder.AddAttribute(36, "href", 
#nullable restore
#line 31 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\Pages\StudentsPage.razor"
                           $"deleteStudents/{Stud.studentID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(37, "class", "btn btn-danger");
            __builder.AddContent(38, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\UAS\Pages\StudentsPage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
