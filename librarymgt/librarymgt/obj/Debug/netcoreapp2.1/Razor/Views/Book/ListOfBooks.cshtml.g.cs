#pragma checksum "C:\Users\harki\source\repos\librarymgt (1)\librarymgt\librarymgt\Views\Book\ListOfBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3febad3636ea9915342b06b9e57fbc35697b2fc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_ListOfBooks), @"mvc.1.0.view", @"/Views/Book/ListOfBooks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/ListOfBooks.cshtml", typeof(AspNetCore.Views_Book_ListOfBooks))]
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
#line 1 "C:\Users\harki\source\repos\librarymgt (1)\librarymgt\librarymgt\Views\_ViewImports.cshtml"
using librarymgt;

#line default
#line hidden
#line 2 "C:\Users\harki\source\repos\librarymgt (1)\librarymgt\librarymgt\Views\_ViewImports.cshtml"
using librarymgt.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3febad3636ea9915342b06b9e57fbc35697b2fc4", @"/Views/Book/ListOfBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86167976fda8422c3ab164fb27eb3705ab9a7f33", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_ListOfBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<librarymgt.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\harki\source\repos\librarymgt (1)\librarymgt\librarymgt\Views\Book\ListOfBooks.cshtml"
  
    ViewData["Title"] = "ListOfBooks";

#line default
#line hidden
            BeginContext(93, 131, true);
            WriteLiteral("\r\n<h2>Availabel Books</h2>\r\n\r\n<p>\r\n    \r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(225, 42, false);
#line 16 "C:\Users\harki\source\repos\librarymgt (1)\librarymgt\librarymgt\Views\Book\ListOfBooks.cshtml"
           Write(Html.DisplayNameFor(model => model.BookId));

#line default
#line hidden
            EndContext();
            BeginContext(267, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(323, 44, false);
#line 19 "C:\Users\harki\source\repos\librarymgt (1)\librarymgt\librarymgt\Views\Book\ListOfBooks.cshtml"
           Write(Html.DisplayNameFor(model => model.BookName));

#line default
#line hidden
            EndContext();
            BeginContext(367, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(423, 46, false);
#line 22 "C:\Users\harki\source\repos\librarymgt (1)\librarymgt\librarymgt\Views\Book\ListOfBooks.cshtml"
           Write(Html.DisplayNameFor(model => model.AuthorName));

#line default
#line hidden
            EndContext();
            BeginContext(469, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(525, 40, false);
#line 25 "C:\Users\harki\source\repos\librarymgt (1)\librarymgt\librarymgt\Views\Book\ListOfBooks.cshtml"
           Write(Html.DisplayNameFor(model => model.ISBN));

#line default
#line hidden
            EndContext();
            BeginContext(565, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\harki\source\repos\librarymgt (1)\librarymgt\librarymgt\Views\Book\ListOfBooks.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(683, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(732, 41, false);
#line 34 "C:\Users\harki\source\repos\librarymgt (1)\librarymgt\librarymgt\Views\Book\ListOfBooks.cshtml"
           Write(Html.DisplayFor(modelItem => item.BookId));

#line default
#line hidden
            EndContext();
            BeginContext(773, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(829, 43, false);
#line 37 "C:\Users\harki\source\repos\librarymgt (1)\librarymgt\librarymgt\Views\Book\ListOfBooks.cshtml"
           Write(Html.DisplayFor(modelItem => item.BookName));

#line default
#line hidden
            EndContext();
            BeginContext(872, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(928, 45, false);
#line 40 "C:\Users\harki\source\repos\librarymgt (1)\librarymgt\librarymgt\Views\Book\ListOfBooks.cshtml"
           Write(Html.DisplayFor(modelItem => item.AuthorName));

#line default
#line hidden
            EndContext();
            BeginContext(973, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1029, 39, false);
#line 43 "C:\Users\harki\source\repos\librarymgt (1)\librarymgt\librarymgt\Views\Book\ListOfBooks.cshtml"
           Write(Html.DisplayFor(modelItem => item.ISBN));

#line default
#line hidden
            EndContext();
            BeginContext(1068, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1124, 51, false);
#line 46 "C:\Users\harki\source\repos\librarymgt (1)\librarymgt\librarymgt\Views\Book\ListOfBooks.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {item.BookId }));

#line default
#line hidden
            EndContext();
            BeginContext(1175, 73, true);
            WriteLiteral(" |\r\n               \r\n                \r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "C:\Users\harki\source\repos\librarymgt (1)\librarymgt\librarymgt\Views\Book\ListOfBooks.cshtml"
}

#line default
#line hidden
            BeginContext(1251, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<librarymgt.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
